## DevGpt.LMStudio

This package provides support for consuming openai-like API from LMStudio local server.

## Installation
To use `DevGpt.LMStudio`, add the following package to your `.csproj` file:

```xml
<ItemGroup>
    <PackageReference Include="DevGpt.LMStudio" Version="DEVGPT_VERSION" />
</ItemGroup>
```

## Usage
```csharp
using DevGpt.LMStudio;
var localServerEndpoint = "localhost";
var port = 5000;
var lmStudioConfig = new LMStudioConfig(localServerEndpoint, port);
var agent = new LMStudioAgent(
    name: "agent",
    systemMessage: "You are an agent that help user to do some tasks.",
    lmStudioConfig: lmStudioConfig)
    .RegisterPrintMessage(); // register a hook to print message nicely to console

await agent.SendAsync("Can you write a piece of C# code to calculate 100th of fibonacci?");
```

## Update history
### Update on 0.0.7 (2024-02-11)
- Add `LMStudioAgent` to support consuming openai-like API from LMStudio local server.
