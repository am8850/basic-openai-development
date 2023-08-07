# Intro to Development with OpenAI APIs

## Running the demos

### `.env` file (secrets)

- The demos load the endpoint and API keys via an the a `.env` file or by setting environment variables
- The actual `.env` file is not stored on this repo
- There's a `.env-sample` file in the repo
- Rename the `.env-sample` file to `.env`
- And add the endpoints and keys to the `.env` file
- Alternatively, you can set environment variables:
  - `export GPT_OPENAI_KEY=123`

### Notebooks

Requirements:

- VS Code
- Polyglot vs-code extension

Notebooks:

* `notebooks/simplest.ipynb`
  * Davinci call using Azure OpenAI SDK
* `notebooks/res-simple.ipynb`
  * GPT call using models and HttpClient
* `notebooks/sk-simple.ipynb`
  * GPT call using semantic kernel
* `notebooks/res-augmented.ipynb`
  * GPT call using models and HttpClient

### Csharp projects

Requirement:

- VS Code or Visual Studio
- .NET 6 or 7

Projects:

- `csharp/simplest`
  - Uses Azure.OpenAI SDK
- `csharp/rest-simple`
  - Uses straight REST with models and HttpClient

## Some OpenAI principles

### My opinion on using OpenAI APIs

The power is not in what they know (the training data), is it what it learned to do. It learnt to:

- Analyze
- Summarize
- Translate
- Generate content
- Etc.

Updated data can be passed as context to answer a prompt.

### Tokens - The OpenAI currency

- Each call will be charged prompt and completion tokens. Managing this is key to managing costs.

### OpenAI - Application Architecture

- OpenAI application are services that can call the OpenAI APIs. They can be implemented as CLIs, Containers, apps running on physical and virtual servers.
- Software architecture techniques matters, a good architecture may create an injectable service library that can be used any implementation, for example.

### Prompt Engineering

- Refer to best practices for prompt engineering below.

## Notebooks included in this repo to call the APIs

### No code

- Using VS Code REST Client to make calls to the APIs without any development.

### C# SDK

- Calling the GPT API with Azure SDK.

### C# REST

- Calling the GPT API with REST.

### C# Semantic Kernel

- Calling the GPT API with Microsoft Semantic Kernel (a more advanced SDK).

### C# REST Augmented

- Calling the GPT API using REST simulating a RAG pattern.

## Reference

- https://learn.microsoft.com/en-us/azure/ai-services/openai/reference
- https://platform.openai.com/tokenizer
- https://help.openai.com/en/articles/6654000-best-practices-for-prompt-engineering-with-openai-api
