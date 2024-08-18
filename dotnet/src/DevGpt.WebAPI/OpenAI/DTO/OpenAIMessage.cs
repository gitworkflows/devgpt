// Copyright (c) Khulnasoft Ltd. All rights reserved.
// OpenAIMessage.cs

using System.Text.Json.Serialization;

namespace DevGpt.WebAPI.OpenAI.DTO;

[JsonConverter(typeof(OpenAIMessageConverter))]
internal abstract class OpenAIMessage
{
    [JsonPropertyName("role")]
    public abstract string? Role { get; }
}
