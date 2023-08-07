using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using dotenv.net;

using rest_simple.Models;

namespace rest_simple;
class Program
{
    async static Task Main(string[] args)
    {
        // Load the environment variables
        DotEnv.Load();
        var uri = Environment.GetEnvironmentVariable("GPT_OPENAI_FULL_ENDPOINT");
        var apiKey = Environment.GetEnvironmentVariable("GPT_OPENAI_KEY");

        if (uri is null || apiKey is null || uri == "" || apiKey == "")
        {
            Console.WriteLine("Please set the GPT_OPENAI_FULL_ENDPOINT and GPT_OPENAI_KEY environment variables.");
            return;
        }
        Console.WriteLine($"Using deployment at: {uri} with key {apiKey?.Substring(0, 5)}...");

        // Get an HTTP client
        var client = new HttpClient();

        // Prepare the prompt
        string prompt = "What is the speed of light?";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"Prompt:\n\n{prompt}\n\n");

        // Prepare the request payload
        var messages = new Message[] { new Message("user", "What is the speed of light?") };
        var payload = new { messages = messages, max_tokens = 100, temperature = 0.3 };
        var json = JsonSerializer.Serialize(payload);

        // Prepare the request
        var request = new HttpRequestMessage(HttpMethod.Post, uri);
        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        request.Headers.TryAddWithoutValidation("api-key", apiKey);
        request.Content = new StringContent(json, Encoding.UTF8, "application/json");

        // Send the request
        var response = await client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            var raw = await response.Content.ReadAsStringAsync();
            var responseJson = JsonDocument.Parse(raw);
            // Print the response
            Console.WriteLine(JsonSerializer.Serialize(responseJson, new JsonSerializerOptions { WriteIndented = true }));
        }
        else
        {
            // If there was an error, print the status code
            Console.WriteLine(response.StatusCode);
        }
    }
}
