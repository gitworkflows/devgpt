By default, @DevGpt.OpenAI.OpenAIChatAgent only supports the @DevGpt.Core.IMessage<T> type where `T` is original request or response message from `Azure.AI.OpenAI`. To support more DevGpt built-in message types like @DevGpt.Core.TextMessage, @DevGpt.Core.ImageMessage, @DevGpt.Core.MultiModalMessage and so on, you can register the agent with @DevGpt.OpenAI.OpenAIChatRequestMessageConnector. The @DevGpt.OpenAI.OpenAIChatRequestMessageConnector will convert the message from DevGpt built-in message types to `Azure.AI.OpenAI.ChatRequestMessage` and vice versa.

import the required namespaces:
[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/OpenAICodeSnippet.cs?name=using_statement)]

[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/OpenAICodeSnippet.cs?name=register_openai_chat_message_connector)]