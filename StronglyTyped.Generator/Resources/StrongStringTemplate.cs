[global::System.Diagnostics.DebuggerDisplay("{Value}")]
[global::System.ComponentModel.TypeConverter(typeof(Converter))]
#if (USE_SYSTEM_TEXT_JSON)
[global::System.Text.Json.Serialization.JsonConverter(typeof(SystemJsonConverter))]
#endif
#if (USE_NEWTONSOFT_JSON)
[global::Newtonsoft.Json.JsonConverter(typeof(NewtonsoftJsonConverter))]
#endif
public readonly partial record struct ZYX : global::StronglyTyped.IStrongString<ZYX>
{
  public required readonly global::System.String Value { get; init; }

  private static readonly ZYX _empty = new(global::System.String.Empty);
  public static ZYX Empty => _empty;

  [global::System.Diagnostics.Contracts.Pure]
  public static explicit operator global::System.String(ZYX value) =>
    value.Value;

  [global::System.Diagnostics.Contracts.Pure]
  public static explicit operator ZYX(global::System.String value) =>
    new(value);

  [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
  public ZYX(global::System.String value)
  {
    global::System.ArgumentNullException.ThrowIfNull(value);
    Value = value;
  }

  public override global::System.Int32 GetHashCode() =>
    Value.GetHashCode();

  public global::System.Int32 Length => Value.Length;

  public static ZYX Create(global::System.String value) =>
    new(value);

  [global::System.Diagnostics.Contracts.Pure]
  public global::System.Int32 CompareTo(global::System.Object? obj)
  {
    var result = obj switch
    {
      null => 1,
      ZYX v => CompareTo(v),
      _ => 1,
    };
    _overrideCompareTo(obj, ref result);
    return result;
  }

  [global::System.Diagnostics.Contracts.Pure]
  public global::System.Int32 CompareTo(ZYX other)
  {
    var result = Value.CompareTo(other.Value);
    _overrideCompareTo(other, ref result);
    return result;
  }

  [global::System.Diagnostics.Contracts.Pure]
  public override global::System.String ToString()
  {
    var s = Value;
    _overrideToString(Value, ref s);
    return s;
  }

  [global::System.Diagnostics.Contracts.Pure]
  public static ZYX From(global::System.String value)
  {
    var s = value;
    _preprocess(ref s);
    return new(s);
  }

  /// <summary>
  /// If implemented, the wrapped value will be preprocessed by this method before creation
  /// Preprocessing runs before validation (if implemented)
  /// (note that using the constructor or cast operators will not use this method)
  /// </summary>
  /// <param name="value">The value which is to be preprocessed</param>
  static partial void _preprocess(ref global::System.String result);

  /// <summary>
  /// If implemented, the result of calling CompareTo on the wrapped value will be modified by this method
  /// </summary>
  /// <param name="result">The value which will be returned by CompareTo</param>
  partial void _overrideEquals(ZYX? obj, ref global::System.Boolean result);

  /// <summary>
  /// If implemented, the result of calling ToString on the wrapped value will be modified by this method
  /// </summary>
  /// <param name="result">The value which will be returned by ToString</param>
  static partial void _overrideToString(global::System.String value, ref global::System.String result);

  /// <summary>
  /// If implemented, the result of calling CompareTo on the wrapped value will be modified by this method
  /// </summary>
  /// <param name="result">The value which will be returned by CompareTo</param>
  partial void _overrideCompareTo(global::System.Object? obj, ref global::System.Int32 result);

  /// <summary>
  /// If implemented, this method will be used to check that the value is valid.
  /// Validation runs after preprocessing (if implemented)
  /// If errors contains any values validation will be considered to have failed.
  /// (note that using the constructor or cast operators will not use this method)
  /// </summary>
  /// <param name="errors">A set of reasons why the value fails validation</param>
  partial void _validate(ref global::System.Collections.Generic.HashSet<global::System.String> errors);

  public static global::System.Boolean TryFrom(global::System.String value, [global::System.Diagnostics.CodeAnalysis.MaybeNull, global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out ZYX result, out global::System.Collections.Generic.IReadOnlySet<global::System.String> failures)
  {
    global::System.Collections.Generic.HashSet<global::System.String> validationFailures = new();

    if (value is null)
    {
      validationFailures.Add($"Cannot create {typeof(Test1).FullName} from <null>");
      failures = validationFailures;
      result = default;
      return false;
    }

    var created = From(value);

    created._validate(ref validationFailures);

    if (validationFailures.Count > 0)
    {
      result = default;
      failures = validationFailures;
      return false;
    }

    result = created;
    failures = validationFailures;
    return true;
  }

  public static global::System.Boolean TryFrom(global::System.String value, [global::System.Diagnostics.CodeAnalysis.MaybeNull, global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out ZYX result) =>
    TryFrom(value, out result, out _);

  [global::System.Diagnostics.Contracts.Pure]
  public global::System.Collections.Generic.IReadOnlyList<global::System.String> Validate()
  {
    global::System.Collections.Generic.HashSet<global::System.String> errors = new();
    _validate(ref errors);

    return global::System.Linq.Enumerable.ToList(errors).AsReadOnly();
  }

  public ZYX Map(global::System.Func<string, string> projection)
  {
    return From(projection(Value));
  }

  private class Converter : global::System.ComponentModel.TypeConverter
  {
    private static readonly global::System.ComponentModel.TypeConverter _baseConverter;

    static Converter()
    {
      _baseConverter = global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.String));
    }

    private readonly Type[] _knownTypes = new[]
    {
      typeof(ZYX),
      typeof(global::System.String),
    };

    public override global::System.Boolean CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext? context, global::System.Type sourceType) =>
      _knownTypes.Contains(sourceType) ||
      (_baseConverter.CanConvertFrom(sourceType) && _baseConverter.CanConvertTo(typeof(global::System.String)));

    public override global::System.Boolean CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext? context, global::System.Type? destinationType) =>
      destinationType == typeof(ZYX);

    public override global::System.Object? ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext? context, global::System.Globalization.CultureInfo? culture, global::System.Object value)
    {
      return value switch
      {
        null => null,
        ZYX v => v,
        global::System.String v => new ZYX(v),
        var v when _baseConverter.CanConvertFrom(v.GetType()) && _baseConverter.CanConvertTo(typeof(global::System.String)) =>
          ConvertFrom(context, culture, _baseConverter.ConvertTo(context, culture, v, typeof(global::System.String))!)!,
        _ => throw new global::System.InvalidCastException($"Cannot convert {value ?? "<null>"} ({value?.GetType().Name ?? "<null>"}) to {nameof(ZYX)}>"),
      };
    }

    public override global::System.Object? ConvertTo(global::System.ComponentModel.ITypeDescriptorContext? context, global::System.Globalization.CultureInfo? culture, global::System.Object? value, global::System.Type destinationType)
    {
      if (destinationType == typeof(global::System.String))
      {
        if (value is ZYX strong)
          return strong.Value.ToString();

        return _baseConverter.ConvertToString(value);
      }

      if (destinationType != typeof(ZYX))
        throw new InvalidCastException($"Cannot convert to Type {destinationType.FullName ?? "<null>"}");

      return ConvertFrom(context, culture, value!);
    }
  }

#if (USE_SYSTEM_TEXT_JSON)
  /// <summary>
  /// A JsonConverter for System.Text.Json which converts ZYX transparently to and from Json representations of a string
  /// </summary>
  public class SystemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<ZYX>
  {
    public override ZYX Read(ref global::System.Text.Json.Utf8JsonReader reader, global::System.Type typeToConvert, global::System.Text.Json.JsonSerializerOptions options)
    {
      return new(reader.GetString()!);
    }

    public override void Write(global::System.Text.Json.Utf8JsonWriter writer, ZYX value, global::System.Text.Json.JsonSerializerOptions options)
    {
      writer.WriteRawValue(global::System.Text.Json.JsonSerializer.Serialize(value.Value));
    }
  }
#endif

#if (USE_NEWTONSOFT_JSON)
  /// <summary>
  /// A JsonConverter for Newtonsoft.Json which converts ZYX transparently to and from Json representations of a string
  /// </summary>
  public class NewtonsoftJsonConverter : global::Newtonsoft.Json.JsonConverter<ZYX>
  {
    public override ZYX ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, ZYX existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer) =>
      new(reader.Value!.ToString()!);

    public override void WriteJson(Newtonsoft.Json.JsonWriter writer, ZYX value, Newtonsoft.Json.JsonSerializer serializer) =>
      global::Newtonsoft.Json.Linq.JToken.FromObject(((ZYX)value).Value).WriteTo(writer);
  }
#endif
}