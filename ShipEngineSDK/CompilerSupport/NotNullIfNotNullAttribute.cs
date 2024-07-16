/*
 * Add an implementation of NotNullIfNotNull for NETStandard2
 * https://medium.com/@pawel.gerr/c-8-nullable-reference-types-in-net-standard-2-1-and-net-4-x-e1f5a3e657f3
 */

#if !NETSTANDARD2_1
namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
internal sealed class NotNullIfNotNullAttribute(string parameterName) : Attribute
{
    public string ParameterName { get; } = parameterName;
}
#endif