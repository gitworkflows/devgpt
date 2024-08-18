// Copyright (c) Khulnasoft Ltd. All rights reserved.
// SampleTests.cs

using DevGpt.Gemini.Sample;
using DevGpt.Tests;

namespace DevGpt.Gemini.Tests;

public class SampleTests
{
    [ApiKeyFact("GCP_VERTEX_PROJECT_ID")]
    public async Task TestChatWithVertexGeminiAsync()
    {
        await Chat_With_Vertex_Gemini.RunAsync();
    }

    [ApiKeyFact("GCP_VERTEX_PROJECT_ID")]
    public async Task TestFunctionCallWithGeminiAsync()
    {
        await Function_Call_With_Gemini.RunAsync();
    }

    [ApiKeyFact("GCP_VERTEX_PROJECT_ID")]
    public async Task TestImageChatWithVertexGeminiAsync()
    {
        await Image_Chat_With_Vertex_Gemini.RunAsync();
    }
}
