`Middleware` is a key feature in DevGpt.Net that enables you to customize the behavior of @DevGpt.Core.IAgent.GenerateReplyAsync*. It's similar to the middleware concept in ASP.Net and is widely used in DevGpt.Net for various scenarios, such as function call support, converting message of different types, print message, gather user input, etc.

Here are a few examples of how middleware is used in DevGpt.Net:
- @DevGpt.AssistantAgent is essentially an agent with @DevGpt.Core.FunctionCallMiddleware, @DevGpt.HumanInputMiddleware and default reply middleware.
- @DevGpt.OpenAI.GPTAgent is essentially an @DevGpt.OpenAI.OpenAIChatAgent with @DevGpt.Core.FunctionCallMiddleware and @DevGpt.OpenAI.OpenAIChatRequestMessageConnector.

## Use middleware in an agent
To use middleware in an existing agent, you can either create a @DevGpt.Core.MiddlewareAgent on top of the original agent or register middleware functions to the original agent.

### Create @DevGpt.Core.MiddlewareAgent on top of the original agent
[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/MiddlewareAgentCodeSnippet.cs?name=create_middleware_agent_with_original_agent)]

### Register middleware functions to the original agent
[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/MiddlewareAgentCodeSnippet.cs?name=register_middleware_agent)]

## Short-circuit the next agent
The example below shows how to short-circuit the inner agent

[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/MiddlewareAgentCodeSnippet.cs?name=short_circuit_middleware_agent)]

> [!Note]
> When multiple middleware functions are registered, the order of middleware functions is first registered, last invoked.

## Streaming middleware
You can also modify the behavior of @DevGpt.Core.IStreamingAgent.GenerateStreamingReplyAsync* by registering streaming middleware to it. One example is @DevGpt.OpenAI.OpenAIChatRequestMessageConnector which converts `StreamingChatCompletionsUpdate` to one of `DevGpt.Core.TextMessageUpdate` or `DevGpt.Core.ToolCallMessageUpdate`.

[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/MiddlewareAgentCodeSnippet.cs?name=register_streaming_middleware)]