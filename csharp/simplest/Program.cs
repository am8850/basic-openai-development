// See https://aka.ms/new-console-template for more information
// dotnet add package Azure.AI.OpenAI --prerelease
// dotnet add package dotenv.net
// rename .env-example to .env and add your endpoint and key

using Azure;
using Azure.AI.OpenAI;
using dotenv.net;

// Load the full endpoint and key from the .env file
DotEnv.Load();
var endpoint = Environment.GetEnvironmentVariable("DAVINCI_OPENAI_ENDPOINT");
var modelName = Environment.GetEnvironmentVariable("DAVINCI_OPENAI_DEPLOYMENT_NAME");
var apiKey = Environment.GetEnvironmentVariable("DAVINCI_OPENAI_KEY");

if (endpoint is null || apiKey is null || endpoint == "" || apiKey == "" || modelName is null || modelName == "")
{
    Console.WriteLine("Please add your model name, endpoint and key to the .env file");
    return;
}

Console.WriteLine($"Using deployment at: {endpoint} with key {apiKey.Substring(0, 5)}...");

// Create an SDK client
OpenAIClient client = new(new Uri(endpoint), new AzureKeyCredential(apiKey));

// Prepare the prompt
string prompt = "When was Microsoft founded?";
Console.Write($"Prompt:\n\n{prompt}\n\n");

// Get a completion
Response<Completions> completionsResponse = await client.GetCompletionsAsync(modelName, prompt);
string completion = completionsResponse.Value.Choices[0].Text;
Console.WriteLine($"Completion Text: {completion}");