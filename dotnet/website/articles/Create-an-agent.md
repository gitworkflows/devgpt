## AssistantAgent

[`AssistantAgent`](../api/DevGpt.AssistantAgent.yml) is a built-in agent in `DevGpt` that acts as an AI assistant. It uses LLM to generate response to user input. It also supports function call if the underlying LLM model supports it (e.g. `gpt-3.5-turbo-0613`).

## Create an `AssistantAgent` using OpenAI model.

[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/CreateAnAgent.cs?name=code_snippet_1)]

## Create an `AssistantAgent` using Azure OpenAI model.

[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/CreateAnAgent.cs?name=code_snippet_2)]
