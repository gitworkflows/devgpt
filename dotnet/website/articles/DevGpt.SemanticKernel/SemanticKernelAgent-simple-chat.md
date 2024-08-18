You can chat with @DevGpt.SemanticKernel.SemanticKernelAgent using both streaming and non-streaming methods and use native `ChatMessageContent` type via `IMessage<ChatMessageContent>`.

The following example shows how to create an @DevGpt.SemanticKernel.SemanticKernelAgent and chat with it using non-streaming method:

[!code-csharp[](../../../sample/DevGpt.BasicSamples/CodeSnippet/SemanticKernelCodeSnippet.cs?name=create_semantic_kernel_agent)]

@DevGpt.SemanticKernel.SemanticKernelAgent also supports streaming chat via @DevGpt.Core.IStreamingAgent.GenerateStreamingReplyAsync*.

[!code-csharp[](../../../sample/DevGpt.BasicSamples/CodeSnippet/SemanticKernelCodeSnippet.cs?name=create_semantic_kernel_agent_streaming)]
