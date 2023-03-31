/// <summary>
/// Represents a strongly-typed record struct for a boolean value
/// </summary>
/// <remarks>
/// This struct is immutable and can be used for performance-sensitive scenarios that require
/// type safety and minimal allocations. It implements the <see cref="IStrongBool{T}"/> interface
/// for strong typing and can be used with the <see cref="StronglyTyped"/> library.
/// </remarks>
[global::System.Diagnostics.DebuggerDisplay("{Value}")]
[global::System.ComponentModel.TypeConverter(typeof(Converter))]
#if (USE_SYSTEM_TEXT_JSON)
[global::System.Text.Json.Serialization.JsonConverter(typeof(SystemJsonConverter))]
#endif
#if (USE_NEWTONSOFT_JSON)
[global::Newtonsoft.Json.JsonConverter(typeof(NewtonsoftJsonConverter))]
#endif
public readonly partial record struct ZYX : global::StronglyTyped.IStrongBool<ZYX>
{
    /// <summary>
    /// Gets the value of the ZYX struct.
    /// </summary>
    public required readonly global::System.Boolean Value { get; init; }

    /// <summary>
    /// Gets a <see cref="ZYX"/> instance representing the value of true.
    /// </summary>
    public static ZYX True => _true;
  private static readonly ZYX _true = new(true);

    /// <summary>
    /// Gets a <see cref="ZYX"/> instance representing the value of false.
    /// </summary>
    public static ZYX False => _false;
  private static readonly ZYX _false = new(false);

  /// <summary>
  /// Is the value wrapped in this ZYX true
  /// </summary>
  public bool IsTrue => Value;

  /// <summary>
  /// Is the value wrapped in this ZYX false
  /// </summary>
  public bool IsFalse => !Value;

    /// <summary>
    /// Converts a <see cref="ZYX"/> value to an <see cref="global::System.Boolean"/> value (implicitly).
    /// </summary>
    /// <param name="value">The <see cref="ZYX"/> value to convert.</param>
    /// <returns>The <see cref="global::System.Boolean"/> value that represents the converted <see cref="ZYX"/> value.</returns>
    [global::System.Diagnostics.Contracts.Pure]
  public static implicit operator global::System.Boolean(ZYX value) =>
    value.Value;

    /// <summary>
    /// Converts an <see cref="global::System.Boolean"/> value to a <see cref="ZYX"/> value.
    /// </summary>
    /// <param name="value">The <see cref="global::System.Boolean"/> value to convert.</param>
    /// <returns>A new <see cref="ZYX"/> value that represents the converted <see cref="global::System.Boolean"/> value.</returns>
    [global::System.Diagnostics.Contracts.Pure]
  public static explicit operator ZYX(global::System.Boolean value) =>
    new(value);

  /// <summary>
  /// Creates a new ZYX, without preprocessing or validation
  /// </summary>
  /// <param name="value">The value to wrap</param>
  [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
  public ZYX(global::System.Boolean value)
  {
    Value = value;
  }

  [global::System.Diagnostics.Contracts.Pure]
  public bool Equals(ZYX? other)
  {
    bool result = Value.Equals(other?.Value);
    return result;
  }

  /// <summary>
  /// Creates a new ZYX from a bool value. Does not perform preprocessing or validation
  /// </summary>
  /// <param name="value">The value to wrap</param>
  /// <returns>The ZYX created</returns>
  public static ZYX Create(global::System.Boolean value) =>
    new(value);

  /// <summary>
  /// Parses a ZYX from the string representation of a bool. Does not perfrom preprocessing or validation
  /// </summary>
  /// <param name="s">The string to parse</param>
  /// <returns>The ZYX created</returns>
  [global::System.Diagnostics.Contracts.Pure]
  public static ZYX Parse(global::System.String? s) =>
    new(global::System.Boolean.Parse(s!));

  /// <summary>
  /// Parses a ZYX from a ReadOnlySpan<char> representation of a bool. Does not perform preprocessing or validation
  /// </summary>
  /// <param name="s">The span to parse</param>
  /// <returns>The ZYX created</returns>
  [global::System.Diagnostics.Contracts.Pure]
  public static ZYX Parse(global::System.ReadOnlySpan<global::System.Char> s) =>
    new(global::System.Boolean.Parse(s));

  /// <summary>
  /// Attempts to parse a ZYX from a string representation of a bool
  /// </summary>
  /// <param name="s">The string to parse</param>
  /// <param name="result">Out parameter that will contain the result</param>
  /// <returns>Whether or not the parse succeeded</returns>
  public static global::System.Boolean TryParse(global::System.String? s, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhen(false)] out ZYX result) =>
    TryParse(s, null, out result);

  /// <summary>
  /// Compares a ZYX to any object
  /// </summary>
  /// <param name="obj">The object to compare to</param>
  /// <returns></returns>
  [global::System.Diagnostics.Contracts.Pure]
  public global::System.Int32 CompareTo(global::System.Object? obj)
  {
    var result = obj switch
    {
      null => 1,
      ZYX v => CompareTo(v),
      _ => 1,
    };
    return result;
  }

  /// <summary>
  /// Compares a ZYX to another ZYX
  /// </summary>
  /// <param name="other">The ZYX to compare to</param>
  /// <returns></returns>
  [global::System.Diagnostics.Contracts.Pure]
  public global::System.Int32 CompareTo(ZYX other)
  {
    var result = Value.CompareTo(other.Value);
    return result;
  }

  /// <summary>
  /// Converts a ZYX to a human-readable string representation. This can be overridden with _overrideToString
  /// </summary>
  /// <returns>The string representation of the ZYX</returns>
  [global::System.Diagnostics.Contracts.Pure]
  public override global::System.String ToString()
  {
    global::System.String s = Value.ToString();
    _overrideToString(Value, ref s);
    return s;
  }

  public global::System.Boolean TryFormat(global::System.Span<global::System.Char> destination, out global::System.Int32 charsWritten, global::System.ReadOnlySpan<global::System.Char> _) =>
    Value.TryFormat(destination, out charsWritten);

  /// <summary>
  /// Creates a new ZYX. For IStrongBool<TSelf> this does does the same as Create.
  /// </summary>
  /// <param name="value">The value to wrap</param>
  /// <returns>The created ZYX</returns>
  [global::System.Diagnostics.Contracts.Pure]
  public static ZYX From(global::System.Boolean value)
  {
    return new(value);
  }

  /// <summary>
  /// If implemented, the result of calling ToString on the wrapped value will be modified by this method
  /// </summary>
  /// <param name="result">The value which will be returned by ToString</param>
  static partial void _overrideToString(global::System.Boolean value, ref global::System.String result);

  public static global::System.Boolean TryFrom(global::System.Boolean value, [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out ZYX result)
  {
    var created = From(value);

    result = created;
    return true;
  }


  public static global::System.Boolean TryParse(global::System.ReadOnlySpan<global::System.Char> s, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhen(false)] out ZYX result)
  {
    if (global::System.Boolean.TryParse(s, out var r))
    {
      result = From(r);
      return true;
    }

    result = default;
    return false;
  }

  public static global::System.Boolean TryParse(global::System.String? s, global::System.IFormatProvider? _, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhen(false)] out ZYX result)
  {
    if (global::System.Boolean.TryParse(s, out var r))
    {
      result = From(r);
      return true;
    }

    result = default;
    return false;
  }

  public static bool TryFrom(bool value, [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out ZYX result, out IReadOnlySet<string> failures)
  {
    result = From(value);
    failures = new HashSet<string>();
    return true;
  }

  private class Converter : global::System.ComponentModel.TypeConverter
  {
    private static readonly global::System.ComponentModel.TypeConverter _baseConverter;

    static Converter()
    {
      _baseConverter = global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.Boolean));
    }

    private readonly Type[] _knownTypes = new[]
    {
      typeof(ZYX),
      typeof(global::System.String),
      typeof(global::System.Boolean),
    };

    public override global::System.Boolean CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext? context, global::System.Type sourceType) =>
      _knownTypes.Contains(sourceType) ||
      (_baseConverter.CanConvertFrom(sourceType) && _baseConverter.CanConvertTo(typeof(global::System.Boolean)));

    public override global::System.Boolean CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext? context, global::System.Type? destinationType) =>
      destinationType == typeof(ZYX) || destinationType == typeof(global::System.String);

    public override global::System.Object? ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext? context, global::System.Globalization.CultureInfo? culture, global::System.Object value)
    {
      return value switch
      {
        null => null,
        ZYX v => v,
        global::System.Boolean v => new ZYX(v!),
        global::System.String v => Parse(v!),
        var v when _baseConverter.CanConvertFrom(v.GetType()) && _baseConverter.CanConvertTo(typeof(global::System.Boolean)) =>
          new ZYX((global::System.Boolean)_baseConverter.ConvertTo(context, culture, v!, typeof(global::System.Boolean))!),
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

      if (destinationType == typeof(global::System.Guid))
      {
        if (value is ZYX strong)
          return strong.Value;

        return _baseConverter.ConvertTo(value, typeof(global::System.Guid));
      }

      if (destinationType != typeof(ZYX))
        throw new InvalidCastException($"Cannot convert to Type {destinationType.FullName ?? "<null>"}");

      return ConvertFrom(context, culture, value!);
    }
  }

#if (USE_SYSTEM_TEXT_JSON)
  /// <summary>
  /// A JsonConverter for System.Text.Json which converts ZYX transparently to and from Json representations
  /// </summary>
  public class SystemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<ZYX>
  {
    public override ZYX Read(ref global::System.Text.Json.Utf8JsonReader reader, global::System.Type typeToConvert, global::System.Text.Json.JsonSerializerOptions options)
    {
      return new(reader.GetBoolean());
    }

    public override void Write(global::System.Text.Json.Utf8JsonWriter writer, ZYX value, global::System.Text.Json.JsonSerializerOptions options)
    {
      writer.WriteRawValue(global::System.Text.Json.JsonSerializer.Serialize(value.Value));
    }
  }
#endif

#if (USE_NEWTONSOFT_JSON)
  /// <summary>
  /// A JsonConverter for Newtonsoft.Json which converts ZYX transparently to and from Json representations
  /// </summary>
  public class NewtonsoftJsonConverter : global::Newtonsoft.Json.JsonConverter<ZYX>
  {
    public override ZYX ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, ZYX existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer) =>
      Parse(reader.Value!.ToString());

    public override void WriteJson(Newtonsoft.Json.JsonWriter writer, ZYX value, Newtonsoft.Json.JsonSerializer serializer) =>
      global::Newtonsoft.Json.Linq.JToken.FromObject(((ZYX)value).Value).WriteTo(writer);
  }
#endif
}
