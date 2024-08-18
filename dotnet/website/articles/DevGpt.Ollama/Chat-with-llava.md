This sample shows how to use @DevGpt.Ollama.OllamaAgent to chat with LLaVA model.

To run this example, you need to have an Ollama server running aside and have `llava:latest` model installed. For how to setup an Ollama server, please refer to [Ollama](https://ollama.com/).

> [!NOTE]
> You can find the complete sample code [here](https://github.com/khulnasoft/devgpt/blob/main/dotnet/sample/DevGpt.Ollama.Sample/Chat_With_LLaVA.cs)

### Step 1: Install DevGpt.Ollama

First, install the DevGpt.Ollama package using the following command:

```bash
dotnet add package DevGpt.Ollama
```

For how to install from nightly build, please refer to [Installation](../Installation.md).

### Step 2: Add using statement

[!code-csharp[](../../../sample/DevGpt.Ollama.Sample/Chat_With_LLaVA.cs?name=Using)]

### Step 3: Create @DevGpt.Ollama.OllamaAgent

[!code-csharp[](../../../sample/DevGpt.Ollama.Sample/Chat_With_LLaVA.cs?name=Create_Ollama_Agent)]

### Step 4: Start MultiModal Chat
LLaVA is a multimodal model that supports both text and image inputs. In this step, we create an image message along with a question about the image.

[!code-csharp[](../../../sample/DevGpt.Ollama.Sample/Chat_With_LLaVA.cs?name=Send_Message)]