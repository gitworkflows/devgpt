// Copyright (c) Khulnasoft Ltd. All rights reserved.
// MiddlewareContext.cs

using System.Collections.Generic;

namespace DevGpt.Core;

public class MiddlewareContext
{
    public MiddlewareContext(
        IEnumerable<IMessage> messages,
        GenerateReplyOptions? options)
    {
        this.Messages = messages;
        this.Options = options;
    }

    /// <summary>
    /// Messages to send to the agent
    /// </summary>
    public IEnumerable<IMessage> Messages { get; }

    /// <summary>
    /// Options to generate the reply
    /// </summary>
    public GenerateReplyOptions? Options { get; }
}
