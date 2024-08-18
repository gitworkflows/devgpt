// Copyright (c) Khulnasoft Ltd. All rights reserved.
// ITextEmbeddingService.cs

using System.Threading;
using System.Threading.Tasks;

namespace DevGpt.Ollama;

public interface ITextEmbeddingService
{
    public Task<TextEmbeddingsResponse> GenerateAsync(TextEmbeddingsRequest request, CancellationToken cancellationToken);
}
