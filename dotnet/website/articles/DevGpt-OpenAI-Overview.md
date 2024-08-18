## DevGpt.OpenAI Overview

DevGpt.OpenAI provides the following agents over openai models:
- @DevGpt.OpenAI.OpenAIChatAgent: A slim wrapper agent over `OpenAIClient`. This agent only support `IMessage<ChatRequestMessage>` message type. To support more message types like @DevGpt.Core.TextMessage, register the agent with @DevGpt.OpenAI.OpenAIChatRequestMessageConnector.
- @DevGpt.OpenAI.GPTAgent: An agent that build on top of @DevGpt.OpenAI.OpenAIChatAgent with more message types support like @DevGpt.Core.TextMessage, @DevGpt.Core.ImageMessage, @DevGpt.Core.MultiModalMessage and function call support. Essentially, it is equivalent to @DevGpt.OpenAI.OpenAIChatAgent with @DevGpt.Core.FunctionCallMiddleware and @DevGpt.OpenAI.OpenAIChatRequestMessageConnector registered.

### Get start with DevGpt.OpenAI

To get start with DevGpt.OpenAI, firstly, follow the [installation guide](Installation.md) to make sure you add the DevGpt feed correctly. Then add `DevGpt.OpenAI` package to your project file.

```xml
<ItemGroup>
    <PackageReference Include="DevGpt.OpenAI" Version="DEVGPT_VERSION" />
</ItemGroup>
```


