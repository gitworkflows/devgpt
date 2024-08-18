// Copyright (c) Khulnasoft Ltd. All rights reserved.
// MistralAgentExtension.cs

using DevGpt.Core;

namespace DevGpt.Mistral.Extension;

public static class MistralAgentExtension
{
    /// <summary>
    /// Register a <see cref="MistralChatMessageConnector"/> to support more DevGpt message types.
    /// </summary>
    public static MiddlewareStreamingAgent<MistralClientAgent> RegisterMessageConnector(
        this MistralClientAgent agent, MistralChatMessageConnector? connector = null)
    {
        if (connector == null)
        {
            connector = new MistralChatMessageConnector();
        }

        return agent.RegisterStreamingMiddleware(connector);
    }

    /// <summary>
    /// Register a <see cref="MistralChatMessageConnector"/> to support more DevGpt message types.
    /// </summary>
    public static MiddlewareStreamingAgent<MistralClientAgent> RegisterMessageConnector(
        this MiddlewareStreamingAgent<MistralClientAgent> agent, MistralChatMessageConnector? connector = null)
    {
        if (connector == null)
        {
            connector = new MistralChatMessageConnector();
        }

        return agent.RegisterStreamingMiddleware(connector);
    }
}
