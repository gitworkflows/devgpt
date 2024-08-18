// Copyright (c) Khulnasoft Ltd. All rights reserved.
// Use_Bing_Search_With_Semantic_Kernel_Agent.cs

using DevGpt.Core;
using DevGpt.SemanticKernel.Extension;
using Khulnasoft.SemanticKernel;
using Khulnasoft.SemanticKernel.Plugins.Web;
using Khulnasoft.SemanticKernel.Plugins.Web.Bing;

namespace DevGpt.SemanticKernel.Sample;

public class Use_Bing_Search_With_Semantic_Kernel_Agent
{
    public static async Task RunAsync()
    {
        var bingApiKey = Environment.GetEnvironmentVariable("BING_API_KEY") ?? throw new Exception("BING_API_KEY environment variable is not set");
        var bingSearch = new BingConnector(bingApiKey);
        var webSearchPlugin = new WebSearchEnginePlugin(bingSearch);

        var openAIKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY") ?? throw new Exception("Please set OPENAI_API_KEY environment variable.");
        var modelId = "gpt-3.5-turbo";
        var kernelBuilder = Kernel.CreateBuilder()
            .AddOpenAIChatCompletion(modelId: modelId, apiKey: openAIKey);
        kernelBuilder.Plugins.AddFromObject(webSearchPlugin);

        var kernel = kernelBuilder.Build();

        var skAgent = new SemanticKernelAgent(
            kernel: kernel,
            name: "assistant",
            systemMessage: "You are a helpful AI assistant")
            .RegisterMessageConnector() // register message connector so it support DevGpt built-in message types like TextMessage.
            .RegisterPrintMessage(); // pretty print the message to the console

        await skAgent.SendAsync("Tell me more about gpt-4-o");
    }
}
