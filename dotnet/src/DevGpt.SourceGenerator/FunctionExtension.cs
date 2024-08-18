// Copyright (c) Khulnasoft Ltd. All rights reserved.
// FunctionExtension.cs

using DevGpt.SourceGenerator;

internal static class FunctionExtension
{
    public static string GetFunctionName(this SourceGeneratorFunctionContract function)
    {
        return function.Name ?? string.Empty;
    }

    public static string GetFunctionSchemaClassName(this SourceGeneratorFunctionContract function)
    {
        return $"{function.GetFunctionName()}Schema";
    }

    public static string GetFunctionDefinitionName(this SourceGeneratorFunctionContract function)
    {
        return $"{function.GetFunctionName()}Function";
    }

    public static string GetFunctionWrapperName(this SourceGeneratorFunctionContract function)
    {
        return $"{function.GetFunctionName()}Wrapper";
    }

    public static string GetFunctionContractName(this SourceGeneratorFunctionContract function)
    {
        return $"{function.GetFunctionName()}FunctionContract";
    }
}
