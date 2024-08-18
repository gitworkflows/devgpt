// Copyright (c) Khulnasoft Ltd. All rights reserved.
// ChatComptionClientAgentExtension.cs

using DevGpt.Core;

namespace DevGpt.AzureAIInference.Extension;

public static class ChatComptionClientAgentExtension
{
    /// <summary>
    /// Register an <see cref="AzureAIInferenceChatRequestMessageConnector"/> to the <see cref="ChatCompletionsClientAgent"/>
    /// </summary>
    /// <param name="connector">the connector to use. If null, a new instance of <see cref="AzureAIInferenceChatRequestMessageConnector"/> will be created.</param>
    public static MiddlewareStreamingAgent<ChatCompletionsClientAgent> RegisterMessageConnector(
        this ChatCompletionsClientAgent agent, AzureAIInferenceChatRequestMessageConnector? connector = null)
    {
        if (connector == null)
        {
            connector = new AzureAIInferenceChatRequestMessageConnector();
        }

        return agent.RegisterStreamingMiddleware(connector);
    }

    /// <summary>
    /// Register an <see cref="AzureAIInferenceChatRequestMessageConnector"/> to the <see cref="MiddlewareAgent{T}"/> where T is <see cref="ChatCompletionsClientAgent"/>
    /// </summary>
    /// <param name="connector">the connector to use. If null, a new instance of <see cref="AzureAIInferenceChatRequestMessageConnector"/> will be created.</param>
    public static MiddlewareStreamingAgent<ChatCompletionsClientAgent> RegisterMessageConnector(
        this MiddlewareStreamingAgent<ChatCompletionsClientAgent> agent, AzureAIInferenceChatRequestMessageConnector? connector = null)
    {
        if (connector == null)
        {
            connector = new AzureAIInferenceChatRequestMessageConnector();
        }

        return agent.RegisterStreamingMiddleware(connector);
    }
}
