`DevGpt.SemanticKernel` provides built-in support for `ChatCompletionAgent` via @DevGpt.SemanticKernel.SemanticKernelChatCompletionAgent. By default the @DevGpt.SemanticKernel.SemanticKernelChatCompletionAgent only supports the original `ChatMessageContent` type via `IMessage<ChatMessageContent>`. To support more DevGpt built-in message types like @DevGpt.Core.TextMessage, @DevGpt.Core.ImageMessage, @DevGpt.Core.MultiModalMessage, you can register the agent with @DevGpt.SemanticKernel.SemanticKernelChatMessageContentConnector. The @DevGpt.SemanticKernel.SemanticKernelChatMessageContentConnector will convert the message from DevGpt built-in message types to `ChatMessageContent` and vice versa.

The following step-by-step example shows how to create an @DevGpt.SemanticKernel.SemanticKernelChatCompletionAgent and chat with it:

> [!NOTE]
> You can find the complete sample code [here](https://github.com/khulnasoft/devgpt/blob/main/dotnet/sample/DevGpt.SemanticKernel.Sample/Create_Semantic_Kernel_Chat_Agent.cs).

### Step 1: add using statement
[!code-csharp[](../../../sample/DevGpt.SemanticKernel.Sample/Create_Semantic_Kernel_Chat_Agent.cs?name=Using)]

### Step 2: create kernel
[!code-csharp[](../../../sample/DevGpt.SemanticKernel.Sample/Create_Semantic_Kernel_Chat_Agent.cs?name=Create_Kernel)]

### Step 3: create ChatCompletionAgent
[!code-csharp[](../../../sample/DevGpt.SemanticKernel.Sample/Create_Semantic_Kernel_Chat_Agent.cs?name=Create_ChatCompletionAgent)]

### Step 4: create @DevGpt.SemanticKernel.SemanticKernelChatCompletionAgent
In this step, we create an @DevGpt.SemanticKernel.SemanticKernelChatCompletionAgent and register it with @DevGpt.SemanticKernel.SemanticKernelChatMessageContentConnector. The @DevGpt.SemanticKernel.SemanticKernelChatMessageContentConnector will convert the message from DevGpt built-in message types to `ChatMessageContent` and vice versa.
[!code-csharp[](../../../sample/DevGpt.SemanticKernel.Sample/Create_Semantic_Kernel_Chat_Agent.cs?name=Create_SemanticKernelChatCompletionAgent)]

### Step 5: chat with @DevGpt.SemanticKernel.SemanticKernelChatCompletionAgent
[!code-csharp[](../../../sample/DevGpt.SemanticKernel.Sample/Create_Semantic_Kernel_Chat_Agent.cs?name=Send_Message)]