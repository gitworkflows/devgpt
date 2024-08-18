In `DevGpt`, you can start a conversation between two agents using @DevGpt.Core.AgentExtension.InitiateChatAsync* or one of @DevGpt.Core.AgentExtension.SendAsync* APIs. When conversation starts, the sender agent will firstly send a message to receiver agent, then receiver agent will generate a reply and send it back to sender agent. This process will repeat until either one of the agent sends a termination message or the maximum number of turns is reached.

> [!NOTE]
> A termination message is an @DevGpt.Core.IMessage which content contains the keyword: @DevGpt.Core.GroupChatExtension.TERMINATE. To determine if a message is a terminate message, you can use @DevGpt.Core.GroupChatExtension.IsGroupChatTerminateMessage*.

## A basic example

The following example shows how to start a conversation between the teacher agent and student agent, where the student agent starts the conversation by asking teacher to create math questions.

> [!TIP]
> You can use @DevGpt.Core.PrintMessageMiddlewareExtension.RegisterPrintMessage* to pretty print the message replied by the agent.

> [!NOTE]
> The conversation is terminated when teacher agent sends a message containing the keyword: @DevGpt.Core.GroupChatExtension.TERMINATE.

> [!NOTE]
> The teacher agent uses @DevGpt.Core.MiddlewareExtension.RegisterPostProcess* to register a post process function which returns a hard-coded termination message when a certain condition is met. Comparing with putting the @DevGpt.Core.GroupChatExtension.TERMINATE keyword in the prompt, this approach is more robust especially when a weaker LLM model is used.

[!code-csharp[](../../sample/DevGpt.BasicSamples/Example02_TwoAgent_MathChat.cs?name=code_snippet_1)]
