﻿// Copyright (c) Khulnasoft Ltd. All rights reserved.
// ChatResponseUpdate.cs

using System.Text.Json.Serialization;

namespace DevGpt.Ollama;

public class ChatResponseUpdate
{
    [JsonPropertyName("model")]
    public string Model { get; set; } = string.Empty;

    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; } = string.Empty;

    [JsonPropertyName("message")]
    public Message? Message { get; set; }

    [JsonPropertyName("done")]
    public bool Done { get; set; }
}
