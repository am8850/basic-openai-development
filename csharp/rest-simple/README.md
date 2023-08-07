# Simplest

## Running

- Rename the `.env-sample` file to `.env`
- Add the OpenAI endpoint uri and the api key
> **Note:** The endpoint is the the full URL including the model name and API version
- Type: `dotnet run .`

## Expected output

```text
What is the speed of light?

{
  "id": "chatcmpl-7l1P51PeC2YoFu9Io0bZDZ18ZoqfR",
  "object": "chat.completion",
  "created": 1691441167,
  "model": "gpt-35-turbo",
  "choices": [
    {
      "index": 0,
      "finish_reason": "stop",
      "message": {
        "role": "assistant",
        "content": "The speed of light is approximately 299,792,458 meters per second (or about 670,616,629 miles per hour)."
      }
    }
  ],
  "usage": {
    "completion_tokens": 28,
    "prompt_tokens": 15,
    "total_tokens": 43
  }
}
```