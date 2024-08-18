// Copyright (c) Khulnasoft Ltd. All rights reserved.
// ConversableAgentConfig.cs

using System.Collections.Generic;

namespace DevGpt;

public class ConversableAgentConfig
{
    public IEnumerable<FunctionContract>? FunctionContracts { get; set; }

    public IEnumerable<ILLMConfig>? ConfigList { get; set; }

    public float? Temperature { get; set; } = 0.7f;

    public int? Timeout { get; set; }
}
