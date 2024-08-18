@DevGpt.SemanticKernel.SemanticKernelAgent only supports the original `ChatMessageContent` type via `IMessage<ChatMessageContent>`. To support more DevGpt built-in message types like @DevGpt.Core.TextMessage, @DevGpt.Core.ImageMessage, @DevGpt.Core.MultiModalMessage, you can register the agent with @DevGpt.SemanticKernel.SemanticKernelChatMessageContentConnector. The @DevGpt.SemanticKernel.SemanticKernelChatMessageContentConnector will convert the message from DevGpt built-in message types to `ChatMessageContent` and vice versa.
> [!NOTE]
> At the current stage, @DevGpt.SemanticKernel.SemanticKernelChatMessageContentConnector only supports conversation for the followng built-in @DevGpt.Core.IMessage
> - @DevGpt.Core.TextMessage
> - @DevGpt.Core.ImageMessage
> - @DevGpt.Core.MultiModalMessage
>
> Function call message type like @DevGpt.Core.ToolCallMessage and @DevGpt.Core.ToolCallResultMessage are not supported yet.

[!code-csharp[](../../../sample/DevGpt.BasicSamples/CodeSnippet/SemanticKernelCodeSnippet.cs?name=register_semantic_kernel_chat_message_content_connector)]