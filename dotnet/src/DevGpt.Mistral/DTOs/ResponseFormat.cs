// Copyright (c) Khulnasoft Ltd. All rights reserved.
// ResponseFormat.cs

using System.Text.Json.Serialization;

namespace DevGpt.Mistral;

public class ResponseFormat
{
    [JsonPropertyName("type")]
    public string ResponseFormatType { get; set; } = "json_object";
}
