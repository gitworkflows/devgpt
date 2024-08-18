// Copyright (c) Khulnasoft Ltd. All rights reserved.
// TopLevelStatementFunctionExample.cs

using DevGpt.Core;

public partial class TopLevelStatementFunctionExample
{
    [Function]
    public Task<string> Add(int a, int b)
    {
        return Task.FromResult($"{a + b}");
    }
}
