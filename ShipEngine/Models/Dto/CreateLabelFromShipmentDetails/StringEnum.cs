#nullable disable
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

[JsonConverter(typeof(StringEnumJsonConverterFactory))]
public class StringEnum<T> where T : struct
{

    public StringEnum(string value)
    {
        if (Enum.TryParse(value, out T parsed))
        {
            IsValidEnum = true;
            EnumValue = parsed;
        }
        StringValue = value;
    }

    public StringEnum(T value)
    {
        EnumValue = value;
        IsValidEnum = true;
        StringValue = typeof(T)
            .GetTypeInfo()
            .DeclaredMembers
            .SingleOrDefault(x => x.Name == value.ToString())
            ?.GetCustomAttribute<EnumMemberAttribute>(false)
            ?.Value ?? value.ToString();
    }

    public T EnumValue { get; }
    public string StringValue { get; }
    public bool IsValidEnum { get; }

    public static implicit operator StringEnum<T>(T e) => new(e);
    public static implicit operator StringEnum<T>(string s) => new(s);
    public static implicit operator T(StringEnum<T> se) => se.IsValidEnum ? se.EnumValue : throw new InvalidOperationException($"The custom value {se.StringValue} cannot be represented as a {typeof(T).Name}.");
    public static implicit operator string(StringEnum<T> se) => se.StringValue;
}

public class StringEnumJsonConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        return typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(StringEnum<>);
    }

    public override JsonConverter CreateConverter(Type type, JsonSerializerOptions options)
    {
        Type[] typeArguments = type.GetGenericArguments();
        Type enumType = typeArguments[0];


        JsonConverter converter = (JsonConverter)Activator.CreateInstance(
            typeof(StringEnumConverter<>).MakeGenericType(
                [enumType]),
            BindingFlags.Instance | BindingFlags.Public,
            binder: null,
            args: [options],
            culture: null)!;

        return converter;
    }
}
public class StringEnumConverter<T> : JsonConverter<StringEnum<T>> where T : struct
{
    private readonly JsonConverter<T> _valueConverter;
    private readonly JsonConverter<string> _stringConverter;

    public StringEnumConverter(JsonSerializerOptions options)
    {
        _stringConverter = (JsonConverter<string>)options.GetConverter(typeof(string));
    }

    public override StringEnum<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string readValue = _stringConverter.Read(ref reader, typeToConvert, options);
        return new StringEnum<T>(readValue);
    }

    public override void Write(Utf8JsonWriter writer, StringEnum<T> value, JsonSerializerOptions options)
    {
        _stringConverter.Write(writer, value.StringValue, options);
    }

}