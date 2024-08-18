// Copyright (c) Khulnasoft Ltd. All rights reserved.
// OpenAIChatCompletionMiddlewareTests.cs

using DevGpt.Core;
using DevGpt.OpenAI;
using DevGpt.OpenAI.Extension;
using Azure.AI.OpenAI;
using Azure.Core.Pipeline;
using FluentAssertions;
using Khulnasoft.AspNetCore.Hosting;
using Khulnasoft.AspNetCore.TestHost;
using Khulnasoft.Extensions.DependencyInjection;
using Khulnasoft.Extensions.Hosting;

namespace DevGpt.WebAPI.Tests;

public class OpenAIChatCompletionMiddlewareTests
{
    [Fact]
    public async Task ItReturnTextMessageWhenSendTextMessage()
    {
        var agent = new EchoAgent("test");
        var hostBuilder = CreateHostBuilder(agent);
        using var host = await hostBuilder.StartAsync();
        var client = host.GetTestClient();
        var openaiClient = CreateOpenAIClient(client);
        var openAIAgent = new OpenAIChatAgent(openaiClient, "test", "test")
            .RegisterMessageConnector();

        var response = await openAIAgent.SendAsync("Hey");

        response.GetContent().Should().Be("Hey");
        response.Should().BeOfType<TextMessage>();
        response.From.Should().Be("test");
    }

    [Fact]
    public async Task ItReturnTextMessageWhenSendTextMessageUseStreaming()
    {
        var agent = new EchoAgent("test");
        var hostBuilder = CreateHostBuilder(agent);
        using var host = await hostBuilder.StartAsync();
        var client = host.GetTestClient();
        var openaiClient = CreateOpenAIClient(client);
        var openAIAgent = new OpenAIChatAgent(openaiClient, "test", "test")
            .RegisterMessageConnector();

        var message = new TextMessage(Role.User, "ABCDEFGHIJKLMN");
        var chunks = new List<IMessage>();
        await foreach (var chunk in openAIAgent.GenerateStreamingReplyAsync([message]))
        {
            chunk.Should().BeOfType<TextMessageUpdate>();
            chunks.Add(chunk);
        }

        var mergedChunks = string.Join("", chunks.Select(c => c.GetContent()));
        mergedChunks.Should().Be("ABCDEFGHIJKLMN");
        chunks.Count.Should().Be(14);
    }

    private IHostBuilder CreateHostBuilder(IAgent agent)
    {
        return new HostBuilder()
            .ConfigureWebHost(webHost =>
            {
                webHost.UseTestServer();
                webHost.Configure(app =>
                {
                    app.UseAgentAsOpenAIChatCompletionEndpoint(agent);
                });
            });
    }

    private OpenAIClient CreateOpenAIClient(HttpClient client)
    {
        var clientOption = new OpenAIClientOptions(OpenAIClientOptions.ServiceVersion.V2024_02_15_Preview)
        {
            Transport = new HttpClientTransport(client),
        };
        return new OpenAIClient("api-key", clientOption);
    }
}
