@DevGpt.Core.IGroupChat is a fundamental feature in DevGpt. It provides a way to organize multiple agents under the same context and work together to resolve a given task.

In DevGpt, there are two types of group chat:
- @DevGpt.Core.RoundRobinGroupChat : This group chat runs agents in a round-robin sequence. The chat history plus the most recent reply from the previous agent will be passed to the next agent.
- @DevGpt.Core.GroupChat : This group chat provides a more dynamic yet controlable way to determine the next speaker agent. You can either use a llm agent as group admin, or use a @DevGpt.Core.Graph, which is introduced by [this PR](https://github.com/khulnasoft/devgpt/pull/1761), or both to determine the next speaker agent.

> [!NOTE]
> In @DevGpt.Core.GroupChat, when only the group admin is used to determine the next speaker agent, it's recommented to use a more powerful llm model, such as `gpt-4` to ensure the best experience.