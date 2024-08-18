This tutorial shows how to use DevGpt.Net agent as model in AG Studio

## Step 1. Create Dotnet empty web app and install DevGpt and DevGpt.WebAPI package

```bash
dotnet new web
dotnet add package DevGpt
dotnet add package DevGpt.WebAPI
```

## Step 2. Replace the Program.cs with following code

```bash
using DevGpt.Core;
using DevGpt.Service;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var helloWorldAgent = new HelloWorldAgent();
app.UseAgentAsOpenAIChatCompletionEndpoint(helloWorldAgent);

app.Run();

class HelloWorldAgent : IAgent
{
    public string Name => "HelloWorld";

    public Task<IMessage> GenerateReplyAsync(IEnumerable<IMessage> messages, GenerateReplyOptions? options = null, CancellationToken cancellationToken = default)
    {
        return Task.FromResult<IMessage>(new TextMessage(Role.Assistant, "Hello World!", from: this.Name));
    }
}
```

## Step 3: Start the web app

Run the following command to start web api

```bash
dotnet RUN
```

The web api will listen at `http://localhost:5264/v1/chat/completion

![terminal](../images/articles/UseDevGptAsModelinAGStudio/Terminal.png)

## Step 4: In another terminal, start devgpt-studio

```bash
devgptstudio ui
```

## Step 5: Navigate to DevGpt Studio UI and add hello world agent as openai Model

### Step 5.1: Go to model tab

![The Model Tab](../images/articles/UseDevGptAsModelinAGStudio/TheModelTab.png)

### Step 5.2: Select "OpenAI model" card

![Open AI model Card](../images/articles/UseDevGptAsModelinAGStudio/Step5.2OpenAIModel.png)

### Step 5.3: Fill the model name and url

The model name needs to be same with agent name

![Fill the model name and url](../images/articles/UseDevGptAsModelinAGStudio/Step5.3ModelNameAndURL.png)

## Step 6: Create a hello world agent that uses the hello world model

![Create a hello world agent that uses the hello world model](../images/articles/UseDevGptAsModelinAGStudio/Step6.png)

![Agent Configuration](../images/articles/UseDevGptAsModelinAGStudio/Step6b.png)

## Final Step: Use the hello world agent in workflow

![Use the hello world agent in workflow](../images/articles/UseDevGptAsModelinAGStudio/FinalStepsA.png)

![Use the hello world agent in workflow](../images/articles/UseDevGptAsModelinAGStudio/FinalStepsA.png)

![Use the hello world agent in workflow](../images/articles/UseDevGptAsModelinAGStudio/FinalStepsB.png)

![Use the hello world agent in workflow](../images/articles/UseDevGptAsModelinAGStudio/FinalStepsC.png)
