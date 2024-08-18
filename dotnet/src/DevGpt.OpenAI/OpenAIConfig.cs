// Copyright (c) Khulnasoft Ltd. All rights reserved.
// OpenAIConfig.cs

namespace DevGpt.OpenAI;

public class OpenAIConfig : ILLMConfig
{
    public OpenAIConfig(string apiKey, string modelId)
    {
        this.ApiKey = apiKey;
        this.ModelId = modelId;
    }

    public string ApiKey { get; }

    public string ModelId { get; }
}
