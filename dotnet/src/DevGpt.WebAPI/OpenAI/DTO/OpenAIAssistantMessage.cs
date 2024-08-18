// Copyright (c) Khulnasoft Ltd. All rights reserved.
// OpenAIAssistantMessage.cs

using System.Text.Json.Serialization;

namespace DevGpt.WebAPI.OpenAI.DTO;

internal class OpenAIAssistantMessage : OpenAIMessage
{
    [JsonPropertyName("role")]
    public override string? Role { get; } = "assistant";

    [JsonPropertyName("content")]
    public string? Content { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tool_calls")]
    public OpenAIToolCallObject[]? ToolCalls { get; set; }
}
