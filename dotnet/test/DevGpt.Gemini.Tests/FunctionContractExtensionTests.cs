﻿// Copyright (c) Khulnasoft Ltd. All rights reserved.
// FunctionContractExtensionTests.cs

using ApprovalTests;
using ApprovalTests.Namers;
using ApprovalTests.Reporters;
using DevGpt.Gemini.Extension;
using Google.Protobuf;
using Xunit;

namespace DevGpt.Gemini.Tests;

public class FunctionContractExtensionTests
{
    private readonly Functions functions = new Functions();
    [Fact]
    [UseReporter(typeof(DiffReporter))]
    [UseApprovalSubdirectory("ApprovalTests")]
    public void ItGenerateGetWeatherToolTest()
    {
        var contract = functions.GetWeatherAsyncFunctionContract;
        var tool = contract.ToFunctionDeclaration();
        var formatter = new JsonFormatter(JsonFormatter.Settings.Default.WithIndentation("  "));
        var json = formatter.Format(tool);
        Approvals.Verify(json);
    }
}
