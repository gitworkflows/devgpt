// Copyright (c) Khulnasoft Ltd. All rights reserved.
// OpenAIUserImageContent.cs

using System.Text.Json.Serialization;

namespace DevGpt.WebAPI.OpenAI.DTO;

internal class OpenAIUserImageContent : OpenAIUserMessageItem
{
    [JsonPropertyName("type")]
    public override string MessageType { get; } = "image";

    [JsonPropertyName("image_url")]
    public string? Url { get; set; }
}
