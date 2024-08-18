## DevGpt.Mistral overview

DevGpt.Mistral provides the following agent(s) to connect to [Mistral.AI](https://mistral.ai/) platform.
- @DevGpt.Mistral.MistralClientAgent: A slim wrapper agent over @DevGpt.Mistral.MistralClient.

### Get started with DevGpt.Mistral

To get started with DevGpt.Mistral, follow the [installation guide](Installation.md) to make sure you add the DevGpt feed correctly. Then add the `DevGpt.Mistral` package to your project file.

```bash
dotnet add package DevGpt.Mistral
```

>[!NOTE]
> You need to provide an api-key to use Mistral models which will bring additional cost while using. you can get the api key from [Mistral.AI](https://mistral.ai/).

### Example

Import the required namespace
[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/MistralAICodeSnippet.cs?name=using_statement)]

Create a @DevGpt.Mistral.MistralClientAgent and start chatting!
[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/MistralAICodeSnippet.cs?name=create_mistral_agent)]

Use @DevGpt.Core.IStreamingAgent.GenerateStreamingReplyAsync* to stream the chat completion.
[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/MistralAICodeSnippet.cs?name=streaming_chat)]