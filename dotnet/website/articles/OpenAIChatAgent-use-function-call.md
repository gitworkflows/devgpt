The following example shows how to create a `GetWeatherAsync` function and pass it to @DevGpt.OpenAI.OpenAIChatAgent.

Firstly, you need to install the following packages:
```xml
<ItemGroup>
    <PackageReference Include="DevGpt.OpenAI" Version="DEVGPT_VERSION" />
    <PackageReference Include="DevGpt.SourceGenerator" Version="DEVGPT_VERSION" />
</ItemGroup>
```

> [!Note]
> The `DevGpt.SourceGenerator` package carries a source generator that adds support for type-safe function definition generation. For more information, please check out [Create type-safe function](./Create-type-safe-function-call.md).

> [!NOTE]
> If you are using VSCode as your editor, you may need to restart the editor to see the generated code.

Firstly, import the required namespaces:
[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/OpenAICodeSnippet.cs?name=using_statement)]

Then, define a public partial class: `Function` with `GetWeather` method
[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/OpenAICodeSnippet.cs?name=weather_function)]

Then, create an @DevGpt.OpenAI.OpenAIChatAgent and register it with @DevGpt.OpenAI.OpenAIChatRequestMessageConnector so it can support @DevGpt.Core.ToolCallMessage and @DevGpt.Core.ToolCallResultMessage. These message types are necessary to use @DevGpt.Core.FunctionCallMiddleware, which provides support for processing and invoking function calls.

[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/OpenAICodeSnippet.cs?name=openai_chat_agent_get_weather_function_call)]

Then, create an @DevGpt.Core.FunctionCallMiddleware with `GetWeather` function and register it with the agent above. When creating the middleware, we also pass a `functionMap` to @DevGpt.Core.FunctionCallMiddleware, which means the function will be automatically invoked when the agent replies a `GetWeather` function call.

[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/OpenAICodeSnippet.cs?name=create_function_call_middleware)]

Finally, you can chat with the @DevGpt.OpenAI.OpenAIChatAgent and invoke the `GetWeather` function.

[!code-csharp[](../../sample/DevGpt.BasicSamples/CodeSnippet/OpenAICodeSnippet.cs?name=chat_agent_send_function_call)]