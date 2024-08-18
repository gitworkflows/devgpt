// Copyright (c) Khulnasoft Ltd. All rights reserved.
// Extension.cs

using DevGpt.Core;
using Khulnasoft.AspNetCore.Builder;

namespace DevGpt.WebAPI;

public static class Extension
{
    /// <summary>
    /// Serve the agent as an OpenAI chat completion endpoint using <see cref="OpenAIChatCompletionMiddleware"/>.
    /// If the request path is /v1/chat/completions and model name is the same as the agent name,
    /// the request will be handled by the agent.
    /// otherwise, the request will be passed to the next middleware.
    /// </summary>
    /// <param name="app">application builder</param>
    /// <param name="agent"><see cref="IAgent"/></param>
    public static IApplicationBuilder UseAgentAsOpenAIChatCompletionEndpoint(this IApplicationBuilder app, IAgent agent)
    {
        var middleware = new OpenAIChatCompletionMiddleware(agent);
        return app.Use(middleware.InvokeAsync);
    }
}
