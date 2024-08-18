@DevGpt.Core.PrintMessageMiddleware is a built-in @DevGpt.Core.IMiddleware that pretty print @DevGpt.Core.IMessage to console.

> [!NOTE]
> @DevGpt.Core.PrintMessageMiddleware support the following @DevGpt.Core.IMessage types:
> - @DevGpt.Core.TextMessage
> - @DevGpt.Core.MultiModalMessage
> - @DevGpt.Core.ToolCallMessage
> - @DevGpt.Core.ToolCallResultMessage
> - @DevGpt.Core.Message
> - (streaming) @DevGpt.Core.TextMessageUpdate
> - (streaming) @DevGpt.Core.ToolCallMessageUpdate

## Use @DevGpt.Core.PrintMessageMiddleware in an agent
You can use @DevGpt.Core.PrintMessageMiddlewareExtension.RegisterPrintMessage* to register the @DevGpt.Core.PrintMessageMiddleware to an agent.

[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/PrintMessageMiddlewareCodeSnippet.cs?name=PrintMessageMiddleware)]

@DevGpt.Core.PrintMessageMiddlewareExtension.RegisterPrintMessage* will format the message and print it to console
![image](../images/articles/PrintMessageMiddleware/printMessage.png)

## Streaming message support

@DevGpt.Core.PrintMessageMiddleware also supports streaming message types like @DevGpt.Core.TextMessageUpdate and @DevGpt.Core.ToolCallMessageUpdate. If you register @DevGpt.Core.PrintMessageMiddleware to a @DevGpt.Core.IStreamingAgent, it will format the streaming message and print it to console if the message is of supported type.

[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/PrintMessageMiddlewareCodeSnippet.cs?name=print_message_streaming)]

![image](../images/articles/PrintMessageMiddleware/streamingoutput.gif)
