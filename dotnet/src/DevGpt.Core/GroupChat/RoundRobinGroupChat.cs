// Copyright (c) Khulnasoft Ltd. All rights reserved.
// RoundRobinGroupChat.cs

using System;
using System.Collections.Generic;

namespace DevGpt.Core;

/// <summary>
/// Obsolete: please use <see cref="RoundRobinGroupChat"/>
/// </summary>
[Obsolete("please use RoundRobinGroupChat")]
public class SequentialGroupChat : RoundRobinGroupChat
{
    [Obsolete("please use RoundRobinGroupChat")]
    public SequentialGroupChat(IEnumerable<IAgent> agents, List<IMessage>? initializeMessages = null)
        : base(agents, initializeMessages)
    {
    }
}

/// <summary>
/// A group chat that allows agents to talk in a round-robin manner.
/// </summary>
public class RoundRobinGroupChat : GroupChat
{
    public RoundRobinGroupChat(
        IEnumerable<IAgent> agents,
        List<IMessage>? initializeMessages = null)
        : base(agents, initializeMessages: initializeMessages)
    {
    }
}
