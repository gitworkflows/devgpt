This tutorial shows how to perform image chat with an agent using the @DevGpt.OpenAI.OpenAIChatAgent as an example.

> [!NOTE]
> To chat image with an agent, the model behind the agent needs to support image input. Here is a partial list of models that support image input:
> - gpt-4o
> - gemini-1.5
> - llava
> - claude-3
> - ...
>
> In this example, we are using the gpt-4o model as the backend model for the agent.

> [!NOTE]
> The complete code example can be found in [Image_Chat_With_Agent.cs](https://github.com/khulnasoft/devgpt/blob/main/dotnet/sample/DevGpt.BasicSamples/GettingStart/Image_Chat_With_Agent.cs)

## Step 1: Install DevGpt

First, install the DevGpt package using the following command:

```bash
dotnet add package DevGpt
```

## Step 2: Add Using Statements

[!code-csharp[Using Statements](../../sample/DevGpt.BasicSamples/GettingStart/Image_Chat_With_Agent.cs?name=Using)]

## Step 3: Create an @DevGpt.OpenAI.OpenAIChatAgent

[!code-csharp[Create an OpenAIChatAgent](../../sample/DevGpt.BasicSamples/GettingStart/Image_Chat_With_Agent.cs?name=Create_Agent)]

## Step 4: Prepare Image Message

In DevGpt, you can create an image message using either @DevGpt.Core.ImageMessage or @DevGpt.Core.MultiModalMessage. The @DevGpt.Core.ImageMessage takes a single image as input, whereas the @DevGpt.Core.MultiModalMessage allows you to pass multiple modalities like text or image.

Here is how to create an image message using @DevGpt.Core.ImageMessage:
[!code-csharp[Create Image Message](../../sample/DevGpt.BasicSamples/GettingStart/Image_Chat_With_Agent.cs?name=Prepare_Image_Input)]

Here is how to create a multimodal message using @DevGpt.Core.MultiModalMessage:
[!code-csharp[Create MultiModal Message](../../sample/DevGpt.BasicSamples/GettingStart/Image_Chat_With_Agent.cs?name=Prepare_Multimodal_Input)]

## Step 5: Generate Response

To generate response, you can use one of the overloaded methods of @DevGpt.Core.AgentExtension.SendAsync* method. The following code shows how to generate response with an image message:

[!code-csharp[Generate Response](../../sample/DevGpt.BasicSamples/GettingStart/Image_Chat_With_Agent.cs?name=Chat_With_Agent)]

## Further Reading
- [Image chat with gemini](../articles/DevGpt.Gemini/Image-chat-with-gemini.md)
- [Image chat with llava](../articles/DevGpt.Ollama/Chat-with-llava.md)