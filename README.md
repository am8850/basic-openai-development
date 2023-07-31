# Intro to Development with OpenAI APIs

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

## Basic ways of calling the APIs

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
