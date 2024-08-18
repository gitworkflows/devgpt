// Copyright (c) Khulnasoft Ltd. All rights reserved.
// ErrorResponse.cs

using System.Text.Json.Serialization;

namespace DevGpt.Mistral;

public class ErrorResponse
{
    public ErrorResponse(Error error)
    {
        Error = error;
    }
    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [JsonPropertyName("error")]
    public Error Error { get; set; }
}
