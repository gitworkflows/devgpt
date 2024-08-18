// Copyright (c) Khulnasoft Ltd. All rights reserved.
// IStreamingAgent.cs

using System.Collections.Generic;
using System.Threading;

namespace DevGpt.Core;

/// <summary>
/// agent that supports streaming reply
/// </summary>
public interface IStreamingAgent : IAgent
{
    public IAsyncEnumerable<IMessage> GenerateStreamingReplyAsync(
        IEnumerable<IMessage> messages,
        GenerateReplyOptions? options = null,
        CancellationToken cancellationToken = default);
}
