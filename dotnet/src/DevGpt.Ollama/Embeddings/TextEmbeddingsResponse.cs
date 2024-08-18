// Copyright (c) Khulnasoft Ltd. All rights reserved.
// TextEmbeddingsResponse.cs

using System.Text.Json.Serialization;

namespace DevGpt.Ollama;

public class TextEmbeddingsResponse
{
    [JsonPropertyName("embedding")]
    public double[]? Embedding { get; set; }
}
