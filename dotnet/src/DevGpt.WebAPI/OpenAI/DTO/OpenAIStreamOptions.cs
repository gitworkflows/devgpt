﻿// Copyright (c) Khulnasoft Ltd. All rights reserved.
// OpenAIStreamOptions.cs

using System.Text.Json.Serialization;

namespace DevGpt.WebAPI.OpenAI.DTO;

internal class OpenAIStreamOptions
{
    [JsonPropertyName("include_usage")]
    public bool? IncludeUsage { get; set; }
}
