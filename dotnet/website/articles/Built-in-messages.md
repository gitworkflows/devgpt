## An overview of built-in @DevGpt.Core.IMessage types

Start from 0.0.9, DevGpt introduces the @DevGpt.Core.IMessage and @DevGpt.Core.IMessage`1 types to provide a unified message interface for different agents. The @DevGpt.Core.IMessage is a non-generic interface that represents a message. The @DevGpt.Core.IMessage`1 is a generic interface that represents a message with a specific `T` where `T` can be any type.

Besides, DevGpt also provides a set of built-in message types that implement the @DevGpt.Core.IMessage and @DevGpt.Core.IMessage`1 interfaces. These built-in message types are designed to cover different types of messages as much as possilbe. The built-in message types include:

> [!NOTE]
> The minimal requirement for an agent to be used as admin in @DevGpt.Core.GroupChat is to support @DevGpt.Core.TextMessage.

> [!NOTE]
> @DevGpt.Core.Message will be deprecated in 0.0.14. Please replace it with a more specific message type like @DevGpt.Core.TextMessage, @DevGpt.Core.ImageMessage, etc.

- @DevGpt.Core.TextMessage: A message that contains a piece of text.
- @DevGpt.Core.ImageMessage: A message that contains an image.
- @DevGpt.Core.MultiModalMessage: A message that contains multiple modalities like text, image, etc.
- @DevGpt.Core.ToolCallMessage: A message that represents a function call request.
- @DevGpt.Core.ToolCallResultMessage: A message that represents a function call result.
- @DevGpt.Core.ToolCallAggregateMessage: A message that contains both @DevGpt.Core.ToolCallMessage and @DevGpt.Core.ToolCallResultMessage. This type of message is used by @DevGpt.Core.FunctionCallMiddleware to aggregate both @DevGpt.Core.ToolCallMessage and @DevGpt.Core.ToolCallResultMessage into a single message.
- @DevGpt.Core.MessageEnvelope`1: A message that represents an envelope that contains a message of any type.
- @DevGpt.Core.Message: The original message type before 0.0.9. This message type is reserved for backward compatibility. It is recommended to replace it with a more specific message type like @DevGpt.Core.TextMessage, @DevGpt.Core.ImageMessage, etc.

### Streaming message support
DevGpt also introduces @DevGpt.Core.IStreamingMessage and @DevGpt.Core.IStreamingMessage`1 which are used in streaming call api. The following built-in message types implement the @DevGpt.Core.IStreamingMessage and @DevGpt.Core.IStreamingMessage`1 interfaces:

> [!NOTE]
> All @DevGpt.Core.IMessage is also a @DevGpt.Core.IStreamingMessage. That means you can return an @DevGpt.Core.IMessage from a streaming call method. It's also recommended to return the final updated result instead of the last update as the last message in the streaming call method to indicate the end of the stream, which saves caller's effort of assembling the final result from multiple updates. 
- @DevGpt.Core.TextMessageUpdate: A message that contains a piece of text update.
- @DevGpt.Core.ToolCallMessageUpdate: A message that contains a function call request update.

#### Usage

The below code snippet shows how to print a streaming update to console and update the final result on the caller side.
[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/BuildInMessageCodeSnippet.cs?name=StreamingCallCodeSnippet)]

If the agent returns a final result instead of the last update as the last message in the streaming call method, the caller can directly use the final result without assembling the final result from multiple updates.

[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/BuildInMessageCodeSnippet.cs?name=StreamingCallWithFinalMessage)]