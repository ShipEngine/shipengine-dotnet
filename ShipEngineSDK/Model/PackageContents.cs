// <auto-generated />
// DO NOT MODIFY THIS FILE

// Changes can be made in a corresponding partial file, or by changing
// the template in <root>/generation/templates and generating the class again.


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Text.RegularExpressions;

namespace ShipEngineSDK.Model;

/// <summary>
/// The possible package contents values
/// </summary>
/// <value>The possible package contents values</value>
[JsonConverter(typeof(PackageContentsJsonConverter))]
public class PackageContents
{
    private readonly string _value;

    /// <summary>
    /// Create a new instance of PackageContents with a predefined value.
    /// </summary>
    internal PackageContents()
    {
        _value = "merchandise";
    }

    /// <summary>
    /// Create a new instance of PackageContents with a custom value.
    /// </summary>
    /// <param name="value">The value of the PackageContents</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public PackageContents(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum Merchandise for value: merchandise
    /// </summary>
    public static PackageContents Merchandise { get; } = new("merchandise");


    /// <summary>
    /// Enum Documents for value: documents
    /// </summary>
    public static PackageContents Documents { get; } = new("documents");


    /// <summary>
    /// Enum Gift for value: gift
    /// </summary>
    public static PackageContents Gift { get; } = new("gift");


    /// <summary>
    /// Enum ReturnedGoods for value: returned_goods
    /// </summary>
    public static PackageContents ReturnedGoods { get; } = new("returned_goods");


    /// <summary>
    /// Enum Sample for value: sample
    /// </summary>
    public static PackageContents Sample { get; } = new("sample");


    /// <summary>
    /// Enum Other for value: other
    /// </summary>
    public static PackageContents Other { get; } = new("other");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;

    /// <summary>
    /// Get whether this instance is equal to another instance
    /// </summary>
    public override bool Equals(object? obj) =>
        obj is PackageContents other && _value == other._value;

    /// <summary>
    /// Get the hash code of the object
    /// </summary>
    public override int GetHashCode() => _value.GetHashCode();
}

internal class PackageContentsJsonConverter : JsonConverter<PackageContents>
{
    public override PackageContents? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new PackageContents(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, PackageContents value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(PackageContents);
}