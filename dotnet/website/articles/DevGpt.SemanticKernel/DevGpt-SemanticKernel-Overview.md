## DevGpt.SemanticKernel Overview

DevGpt.SemanticKernel is a package that provides seamless integration with Semantic Kernel. It provides the following agents:
- @DevGpt.SemanticKernel.SemanticKernelAgent: A slim wrapper agent over `Kernel` that only support original `ChatMessageContent` type via `IMessage<ChatMessageContent>`. To support more DevGpt built-in message type, register the agent with @DevGpt.SemanticKernel.SemanticKernelChatMessageContentConnector.
- @DevGpt.SemanticKernel.SemanticKernelChatCompletionAgent: A slim wrapper agent over `Khulnasoft.SemanticKernel.Agents.ChatCompletionAgent`.

DevGpt.SemanticKernel also provides the following middleware:
- @DevGpt.SemanticKernel.SemanticKernelChatMessageContentConnector: A connector that convert the message from DevGpt built-in message types to `ChatMessageContent` and vice versa. At the current stage, it only supports conversation between @DevGpt.Core.TextMessage, @DevGpt.Core.ImageMessage and @DevGpt.Core.MultiModalMessage. Function call message type like @DevGpt.Core.ToolCallMessage and @DevGpt.Core.ToolCallResultMessage are not supported yet.
- @DevGpt.SemanticKernel.KernelPluginMiddleware: A middleware that allows you to use semantic kernel plugins in other DevGpt agents like @DevGpt.OpenAI.OpenAIChatAgent.

### Get start with DevGpt.SemanticKernel

To get start with DevGpt.SemanticKernel, firstly, follow the [installation guide](../Installation.md) to make sure you add the DevGpt feed correctly. Then add `DevGpt.SemanticKernel` package to your project file.

```xml
<ItemGroup>
    <PackageReference Include="DevGpt.SemanticKernel" Version="DEVGPT_VERSION" />
</ItemGroup>
```