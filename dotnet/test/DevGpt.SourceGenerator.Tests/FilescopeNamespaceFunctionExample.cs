// Copyright (c) Khulnasoft Ltd. All rights reserved.
// FilescopeNamespaceFunctionExample.cs

using DevGpt.Core;

namespace DevGpt.SourceGenerator.Tests;
public partial class FilescopeNamespaceFunctionExample
{
    [Function]
    public Task<string> Add(int a, int b)
    {
        return Task.FromResult($"{a + b}");
    }
}
