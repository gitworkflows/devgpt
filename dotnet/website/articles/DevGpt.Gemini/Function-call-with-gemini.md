This example shows how to use @DevGpt.Gemini.GeminiChatAgent to make function call. This example is modified from [gemini-api function call example](https://ai.google.dev/gemini-api/docs/function-calling)

To run this example, you need to have a project on Google Cloud with access to Vertex AI API. For more information please refer to [Google Vertex AI](https://cloud.google.com/vertex-ai/docs).


> [!NOTE]
> You can find the complete sample code [here](https://github.com/khulnasoft/devgpt/blob/main/dotnet/sample/DevGpt.Gemini.Sample/Function_Call_With_Gemini.cs)

### Step 1: Install DevGpt.Gemini and DevGpt.SourceGenerator

First, install the DevGpt.Gemini package using the following command:

```bash
dotnet add package DevGpt.Gemini
dotnet add package DevGpt.SourceGenerator
```

The DevGpt.SourceGenerator package is required to generate the @DevGpt.Core.FunctionContract. For more information, please refer to [Create-type-safe-function-call](../Create-type-safe-function-call.md)

### Step 2: Add using statement
[!code-csharp[](../../../sample/DevGpt.Gemini.Sample/Function_call_with_gemini.cs?name=Using)]

### Step 3: Create `MovieFunction`

[!code-csharp[](../../../sample/DevGpt.Gemini.Sample/Function_call_with_gemini.cs?name=MovieFunction)]

### Step 4: Create a Gemini agent

[!code-csharp[](../../../sample/DevGpt.Gemini.Sample/Function_call_with_gemini.cs?name=Create_Gemini_Agent)]

### Step 5: Single turn function call

[!code-csharp[](../../../sample/DevGpt.Gemini.Sample/Function_call_with_gemini.cs?name=Single_turn)]

### Step 6: Multi-turn function call

[!code-csharp[](../../../sample/DevGpt.Gemini.Sample/Function_call_with_gemini.cs?name=Multi_turn)]

