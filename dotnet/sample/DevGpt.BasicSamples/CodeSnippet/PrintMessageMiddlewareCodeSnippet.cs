// Copyright (c) Khulnasoft Ltd. All rights reserved.
// PrintMessageMiddlewareCodeSnippet.cs

using DevGpt.Core;
using DevGpt.OpenAI;
using DevGpt.OpenAI.Extension;
using Azure;
using Azure.AI.OpenAI;

namespace DevGpt.BasicSample.CodeSnippet;

internal class PrintMessageMiddlewareCodeSnippet
{
    public async Task PrintMessageMiddlewareAsync()
    {
        var config = LLMConfiguration.GetAzureOpenAIGPT3_5_Turbo();
        var endpoint = new Uri(config.Endpoint);
        var openaiClient = new OpenAIClient(endpoint, new AzureKeyCredential(config.ApiKey));
        var agent = new OpenAIChatAgent(openaiClient, "assistant", config.DeploymentName)
            .RegisterMessageConnector();

        #region PrintMessageMiddleware
        var agentWithPrintMessageMiddleware = agent
            .RegisterPrintMessage();

        await agentWithPrintMessageMiddleware.SendAsync("write a long poem");
        #endregion PrintMessageMiddleware
    }

    public async Task PrintMessageStreamingMiddlewareAsync()
    {
        var config = LLMConfiguration.GetAzureOpenAIGPT3_5_Turbo();
        var endpoint = new Uri(config.Endpoint);
        var openaiClient = new OpenAIClient(endpoint, new AzureKeyCredential(config.ApiKey));

        #region print_message_streaming
        var streamingAgent = new OpenAIChatAgent(openaiClient, "assistant", config.DeploymentName)
            .RegisterMessageConnector()
            .RegisterPrintMessage();

        await streamingAgent.SendAsync("write a long poem");
        #endregion print_message_streaming
    }
}
