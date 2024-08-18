This example shows how to use @DevGpt.Gemini.GeminiChatAgent for image chat with Gemini model.

To run this example, you need to have a project on Google Cloud with access to Vertex AI API. For more information please refer to [Google Vertex AI](https://cloud.google.com/vertex-ai/docs).


> [!NOTE]
> You can find the complete sample code [here](https://github.com/khulnasoft/devgpt/blob/main/dotnet/sample/DevGpt.Gemini.Sample/Image_Chat_With_Vertex_Gemini.cs)

### Step 1: Install DevGpt.Gemini

First, install the DevGpt.Gemini package using the following command:

```bash
dotnet add package DevGpt.Gemini
```

### Step 2: Add using statement
[!code-csharp[](../../../sample/DevGpt.Gemini.Sample/Image_Chat_With_Vertex_Gemini.cs?name=Using)]

### Step 3: Create a Gemini agent

[!code-csharp[](../../../sample/DevGpt.Gemini.Sample/Image_Chat_With_Vertex_Gemini.cs?name=Create_Gemini_Agent)]

### Step 4: Send image to Gemini
[!code-csharp[](../../../sample/DevGpt.Gemini.Sample/Image_Chat_With_Vertex_Gemini.cs?name=Send_Image_Request)]
