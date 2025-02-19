using System;

namespace ShipEngineSDK;

/// <summary>
/// Marks a property as write only, which means it won't be deserialized
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
internal class JsonWriteOnlyAttribute : Attribute
{

}