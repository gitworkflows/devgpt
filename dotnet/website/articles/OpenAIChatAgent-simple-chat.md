The following example shows how to create an @DevGpt.OpenAI.OpenAIChatAgent and chat with it.

Firsly, import the required namespaces:
[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/OpenAICodeSnippet.cs?name=using_statement)]

Then, create an @DevGpt.OpenAI.OpenAIChatAgent and chat with it:
[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/OpenAICodeSnippet.cs?name=create_openai_chat_agent)]

@DevGpt.OpenAI.OpenAIChatAgent also supports streaming chat via @DevGpt.Core.IAgent.GenerateStreamingReplyAsync*.

[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/OpenAICodeSnippet.cs?name=create_openai_chat_agent_streaming)]