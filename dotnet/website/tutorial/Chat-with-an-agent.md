This tutorial shows how to generate response using an @DevGpt.Core.IAgent by taking @DevGpt.OpenAI.OpenAIChatAgent as an example.

> [!NOTE]
> DevGpt.Net provides the following agents to connect to different LLM platforms. Generating responses using these agents is similar to the example shown below.
> - @DevGpt.OpenAI.OpenAIChatAgent
> - @DevGpt.SemanticKernel.SemanticKernelAgent
> - @DevGpt.LMStudio.LMStudioAgent
> - @DevGpt.Mistral.MistralClientAgent
> - @DevGpt.Anthropic.AnthropicClientAgent
> - @DevGpt.Ollama.OllamaAgent
> - @DevGpt.Gemini.GeminiChatAgent

> [!NOTE]
> The complete code example can be found in [Chat_With_Agent.cs](https://github.com/khulnasoft/devgpt/blob/main/dotnet/sample/DevGpt.BasicSamples/GettingStart/Chat_With_Agent.cs)

## Step 1: Install DevGpt

First, install the DevGpt package using the following command:

```bash
dotnet add package DevGpt
```

## Step 2: add Using Statements

[!code-csharp[Using Statements](../../sample/DevGpt.BasicSamples/GettingStart/Chat_With_Agent.cs?name=Using)]

## Step 3: Create an @DevGpt.OpenAI.OpenAIChatAgent

> [!NOTE]
> The @DevGpt.OpenAI.Extension.OpenAIAgentExtension.RegisterMessageConnector* method registers an @DevGpt.OpenAI.OpenAIChatRequestMessageConnector middleware which converts OpenAI message types to DevGpt message types. This step is necessary when you want to use DevGpt built-in message types like @DevGpt.Core.TextMessage, @DevGpt.Core.ImageMessage, etc.
> For more information, see [Built-in-messages](../articles/Built-in-messages.md)

[!code-csharp[Create an OpenAIChatAgent](../../sample/DevGpt.BasicSamples/GettingStart/Chat_With_Agent.cs?name=Create_Agent)]

## Step 4: Generate Response
To generate response, you can use one of the overloaded method of @DevGpt.Core.AgentExtension.SendAsync* method. The following code shows how to generate response with text message:

[!code-csharp[Generate Response](../../sample/DevGpt.BasicSamples/GettingStart/Chat_With_Agent.cs?name=Chat_With_Agent)]

To generate response with chat history, you can pass the chat history to the @DevGpt.Core.AgentExtension.SendAsync* method:

[!code-csharp[Generate Response with Chat History](../../sample/DevGpt.BasicSamples/GettingStart/Chat_With_Agent.cs?name=Chat_With_History)]

To streamingly generate response, use @DevGpt.Core.IStreamingAgent.GenerateStreamingReplyAsync*

[!code-csharp[Generate Streaming Response](../../sample/DevGpt.BasicSamples/GettingStart/Chat_With_Agent.cs?name=Streaming_Chat)]

## Further Reading
- [Chat with google gemini](../articles/DevGpt.Gemini/Chat-with-google-gemini.md)
- [Chat with vertex gemini](../articles/DevGpt.Gemini/Chat-with-vertex-gemini.md)
- [Chat with Ollama](../articles/DevGpt.Ollama/Chat-with-llama.md)
- [Chat with Semantic Kernel Agent](../articles/DevGpt.SemanticKernel/SemanticKernelAgent-simple-chat.md)