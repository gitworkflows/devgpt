### Function comparison between Python DevGpt and DevGpt\.Net


#### Agentic pattern

| Feature | DevGpt | DevGpt\.Net |
| :---------------- | :------ | :---- |
| Code interpreter | run python code in local/docker/notebook executor | run csharp code in dotnet interactive executor |
| Single agent chat pattern | ✔️ | ✔️ |
| Two agent chat pattern | ✔️ | ✔️ |
| group chat (include FSM)| ✔️ | ✔️ (using workflow for FSM groupchat) |
| Nest chat| ✔️ | ✔️ (using middleware pattern)|
|Sequential chat | ✔️ | ❌ (need to manually create task in code) |
| Tool | ✔️ | ✔️ |


#### LLM platform support

ℹ️ Note 

``` Other than the platforms list below, DevGpt.Net also supports all the platforms that semantic kernel supports via DevGpt.SemanticKernel as a bridge ```

| Feature | DevGpt | DevGpt\.Net |
| :---------------- | :------ | :---- |
| OpenAI (include third-party) | ✔️ | ✔️ |
| Mistral |	✔️|	✔️|
| Ollama |	✔️|	✔️|
|Claude	|✔️	|✔️|
|Gemini (Include Vertex) | ✔️ | ✔️ |

#### Popular Contrib Agent support


| Feature | DevGpt | DevGpt\.Net |
| :---------------- | :------ | :---- |
| Rag Agent |	✔️|	❌ |
| Web surfer |	✔️|	❌ |
