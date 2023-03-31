/// <summary>
/// Represents a strongly-typed record struct for a signed 64-bit integer value
/// </summary>
/// <remarks>
/// This struct is immutable and can be used for performance-sensitive scenarios that require
/// type safety and minimal allocations. It implements the <see cref="global::StronglyTyped.IStrongLong{T}"/> interface
/// for strong typing and can be used with the <see cref="global::StronglyTyped"/> library.
/// </remarks>
[global::System.Diagnostics.DebuggerDisplay("{Value}")]
[global::System.ComponentModel.TypeConverter(typeof(Converter))]
#if (USE_SYSTEM_TEXT_JSON)
[global::System.Text.Json.Serialization.JsonConverter(typeof(SystemJsonConverter))]
#endif
#if (USE_NEWTONSOFT_JSON)
[global::Newtonsoft.Json.JsonConverter(typeof(NewtonsoftJsonConverter))]
#endif
public readonly partial record struct ZYX : global::StronglyTyped.IStrongLong<ZYX>
{
    /// <summary>
    /// Gets the value of the ZYX struct.
    /// </summary>
    public required readonly global::System.Int64 Value { get; init; }

    /// <summary>
    /// Gets a <see cref="ZYX"/> instance representing the value of -1.
    /// </summary>
    public static ZYX NegativeOne => _negativeOne;
    private readonly static ZYX _negativeOne = new(-1);

    /// <summary>
    /// Gets a <see cref="ZYX"/> instance representing the value of 1.
    /// </summary>
    public static ZYX One => _one;
    private readonly static ZYX _one = new(1);

    /// <summary>
    /// Gets a <see cref="ZYX"/> instance representing the value of 0.
    /// </summary>
    public static ZYX Zero => _zero;
    private readonly static ZYX _zero = new(0);

    /// <summary>
    /// Converts a <see cref="ZYX"/> value to an <see cref="global::System.Int64"/> value.
    /// </summary>
    /// <param name="value">The <see cref="ZYX"/> value to convert.</param>
    /// <returns>The <see cref="global::System.Int64"/> value that represents the converted <see cref="ZYX"/> value.</returns>
    /// <remarks>
    /// No validation or preprocessing is performed.
    /// </remarks>
    [global::System.Diagnostics.Contracts.Pure]
    public static explicit operator global::System.Int64(ZYX value) =>
    value.Value;

    /// <summary>
    /// Converts an <see cref="global::System.Int64"/> value to a <see cref="ZYX"/> value.
    /// </summary>
    /// <param name="value">The <see cref="global::System.Int64"/> value to convert.</param>
    /// <returns>A new <see cref="ZYX"/> value that represents the converted <see cref="global::System.Int64"/> value.</returns>
    /// <remarks>
    /// No validation or preprocessing is performed.
    /// </remarks>
    [global::System.Diagnostics.Contracts.Pure]
    public static explicit operator ZYX(global::System.Int64 value) =>
    new(value);

    [global::System.Diagnostics.Contracts.Pure]
    public static global::System.Boolean operator >(ZYX left, ZYX right) =>
    left.CompareTo(right) > 0;

    [global::System.Diagnostics.Contracts.Pure]
    public static global::System.Boolean operator >=(ZYX left, ZYX right) =>
    left.CompareTo(right) >= 0;

    [global::System.Diagnostics.Contracts.Pure]
    public static global::System.Boolean operator <(ZYX left, ZYX right) =>
    left.CompareTo(right) < 0;

    [global::System.Diagnostics.Contracts.Pure]
    public static global::System.Boolean operator <=(ZYX left, ZYX right) =>
    left.CompareTo(right) <= 0;

    [global::System.Diagnostics.Contracts.Pure]
    public static ZYX operator -(ZYX value) =>
    From(-value.Value);

    [global::System.Diagnostics.Contracts.Pure]
    public static ZYX operator +(ZYX value) =>
    From(+value.Value);

    [global::System.Diagnostics.Contracts.Pure]
    public static ZYX operator ++(ZYX value) =>
    From(value.Value + 1);

    [global::System.Diagnostics.Contracts.Pure]
    public static ZYX operator --(ZYX value) =>
    From(value.Value - 1);

    /// <summary>
    /// Initializes a new instance of the <see cref="ZYX"/> struct with the specified value.
    /// </summary>
    /// <param name="value">Thevalue to use as the underlying value of the <see cref="ZYX"/> struct.</param>
    /// <remarks>
    /// No validation or preprocessing is performed.
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    public ZYX(global::System.Int64 value)
    {
        Value = value;
    }

    public override global::System.Int32 GetHashCode() =>
    Value.GetHashCode();

    /// <summary>
    /// Determines whether this instance and another specified <see cref="ZYX"/> object have the same value.
    /// </summary>
    /// <param name="other">The <see cref="ZYX"/> object to compare to this instance.</param>
    /// <returns><see langword="true"/> if the value of the <paramref name="other"/> parameter is the same as the value of this instance; otherwise, <see langword="false"/>.</returns>
    /// 
    /// <remarks>This method can be overridden by implementing partial method <see cref="_overrideEquals"/></remarks>
    public bool Equals(ZYX? other)
    {
        bool result = Value.Equals(other?.Value);
        _overrideEquals(other, ref result);
        return result;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ZYX"/> struct with the specified value.
    /// </summary>
    /// <param name="value">Thevalue to use as the underlying value of the <see cref="ZYX"/> struct.</param>
    /// <remarks>
    /// No validation or preprocessing is performed.
    /// </remarks>
    public static ZYX Create(global::System.Int64 value) =>
    new(value);

    /// <summary>
    /// Parses the string representation of a ZYX value.
    /// </summary>
    /// <param name="s">The string representation of the value to parse.</param>
    /// <returns>A new instance of the <see cref="ZYX"/> struct that represents the parsed value.</returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="s"/> is null.</exception>
    /// <remarks>
    /// No validation or preprocessing is performed.
    /// </remarks>
    [global::System.Diagnostics.Contracts.Pure]
    public static ZYX Parse(global::System.String? s) =>
    new(global::System.Int64.Parse(s!));

    /// <summary>
    /// Converts the span representation of a ZYX value to its <see cref="ZYX"/> equivalent.
    /// </summary>
    /// <param name="s">The span containing the characters to convert.</param>
    /// <returns>A new instance of <see cref="ZYX"/> equivalent to the value represented in <paramref name="s"/>.</returns>
    /// <exception cref="System.FormatException">Thrown when the string representation of the value is not in the correct format.</exception>
    /// <remarks>
    /// No validation or preprocessing is performed.
    /// </remarks>
    [global::System.Diagnostics.Contracts.Pure]
    public static ZYX Parse(global::System.ReadOnlySpan<global::System.Char> s, global::System.IFormatProvider? provider) =>
    new(global::System.Int64.Parse(s, provider));

    /// <summary>
    /// Converts the string representation of a value in a specified culture-specific format to its <see cref="ZYX"/> equivalent.
    /// </summary>
    /// <param name="s">A string that contains the number to convert.</param>
    /// <param name="provider">An object that provides culture-specific formatting information.</param>
    /// <returns>A <see cref="ZYX"/> equivalent to the value contained in <paramref name="s"/>.</returns>
    /// <exception cref="System.ArgumentNullException"><paramref name="s"/> is <see langword="null"/>.</exception>
    /// <exception cref="System.FormatException"><paramref name="s"/> is not in the correct format.</exception>
    /// <remarks>
    /// No validation or preprocessing is performed.
    /// </remarks>
    [global::System.Diagnostics.Contracts.Pure]
    public static ZYX Parse(global::System.String s, global::System.IFormatProvider? provider) =>
    new(global::System.Int64.Parse(s, provider));

    public static global::System.Boolean TryParse(global::System.String? s, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhen(false)] out ZYX result) =>
    TryParse(s, null, out result);

    /// <summary>
    /// Compares the current instance with another object and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
    /// </summary>
    /// <param name="other">The object to compare with this instance.</param>
    /// <returns>A 32-bit signed integer that indicates the relative order of the objects being compared.</returns>
    /// <remarks>
    /// <0: the current instance precedes the other object in the sort order.
    /// >0: the current instance follows the other object in the sort order.
    ///  0: the current instance occurs in the same position in the sort order as the other object.
    ///  </remarks>
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

    /// <summary>
    /// Compares the current instance with another object and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
    /// </summary>
    /// <param name="other">The object to compare with this instance.</param>
    /// <returns>A 32-bit signed integer that indicates the relative order of the objects being compared.</returns>
    /// <remarks>
    /// <0: the current instance precedes the other object in the sort order.
    /// >0: the current instance follows the other object in the sort order.
    ///  0: the current instance occurs in the same position in the sort order as the other object.
    ///  This method can be overridden by implementing <see cref="_overrideCompareTo"/>
    ///  </remarks>
    [global::System.Diagnostics.Contracts.Pure]
    public global::System.Int32 CompareTo(ZYX other)
    {
        var result = Value.CompareTo(other.Value);
        _overrideCompareTo(other, ref result);
        return result;
    }

    [global::System.Diagnostics.Contracts.Pure]
    public string ToString(global::System.String? format, global::System.IFormatProvider? formatProvider) =>
    Value.ToString(format, formatProvider);

    /// <summary>
    /// Returns the string representation of this <see cref="ZYX"/> instance, using the default format specifier.
    /// </summary>
    /// <returns>A string representation of the value of this <see cref="ZYX"/> instance.</returns>
    /// <remarks>
    /// This can be overridden by implementing the partial method <see cref="_overrideToString"/>
    /// </remarks>
    [global::System.Diagnostics.Contracts.Pure]
    public override global::System.String ToString()
    {
        global::System.String s = Value.ToString();
        _overrideToString(Value, ref s);
        return s;
    }

    public global::System.Boolean TryFormat(global::System.Span<global::System.Char> destination, out global::System.Int32 charsWritten, global::System.ReadOnlySpan<global::System.Char> format, global::System.IFormatProvider? _) =>
    Value.TryFormat(destination, out charsWritten, format);

    /// <summary>
    /// Creates a new instance of the <see cref="ZYX"/> struct from a value.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>A new instance of <see cref="ZYX"/> initialized to <paramref name="value"/></returns>
    /// <remarks>
    /// Preprocess <paramref name="value"/> before creating by implementing <see cref="_preprocess"/>
    /// </remarks>
    [global::System.Diagnostics.Contracts.Pure]
    public static ZYX From(global::System.Int64 value)
    {
        _preprocess(ref value);
        return new(value);
    }

    /// <summary>
    /// If implemented, the wrapped value will be preprocessed by this method before creation
    /// Preprocessing runs before validation (if implemented)
    /// (note that using the constructor or cast operators will not use this method)
    /// </summary>
    /// <param name="value">The value which is to be preprocessed</param>
    static partial void _preprocess(ref global::System.Int64 result);

    /// <summary>
    /// If implemented, the result of calling CompareTo on the wrapped value will be modified by this method
    /// </summary>
    /// <param name="result">The value which will be returned by CompareTo</param>
    partial void _overrideEquals(ZYX? obj, ref global::System.Boolean result);

    /// <summary>
    /// If implemented, the result of calling ToString on the wrapped value will be modified by this method
    /// </summary>
    /// <param name="result">The value which will be returned by ToString</param>
    static partial void _overrideToString(global::System.Int64 value, ref global::System.String result);

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

    public static global::System.Boolean TryFrom(global::System.Int64 value, [global::System.Diagnostics.CodeAnalysis.MaybeNull, global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out ZYX result, out global::System.Collections.Generic.IReadOnlySet<global::System.String> failures)
    {
        global::System.Collections.Generic.HashSet<global::System.String> validationFailures = new();

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

    public static global::System.Boolean TryFrom(global::System.Int64 value, [global::System.Diagnostics.CodeAnalysis.MaybeNull, global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out ZYX result) =>
    TryFrom(value, out result, out _);

    public static global::System.Boolean TryFrom(global::System.Int64 value, [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out ZYX? result, out IReadOnlySet<string> failures)
    {
        global::System.Collections.Generic.HashSet<global::System.String> validationFailures = new();

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

    public static global::System.Boolean TryFrom(global::System.Int64 value, [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out ZYX? result) =>
    TryFrom(value, out result, out _);

    [global::System.Diagnostics.Contracts.Pure]
    public global::System.Collections.Generic.IReadOnlyList<global::System.String> Validate()
    {
        global::System.Collections.Generic.HashSet<global::System.String> errors = new();

        _validate(ref errors);

        return global::System.Linq.Enumerable.ToList(errors).AsReadOnly();
    }

    [global::System.Diagnostics.Contracts.Pure]
    public static ZYX Parse(global::System.ReadOnlySpan<char> s, global::System.Globalization.NumberStyles style, global::System.IFormatProvider? provider) =>
    new(global::System.Int64.Parse(s, style, provider));

    [global::System.Diagnostics.Contracts.Pure]
    public static ZYX Parse(global::System.String s, global::System.Globalization.NumberStyles style, IFormatProvider? provider) =>
    new(global::System.Int64.Parse(s, style, provider));

    public static global::System.Boolean TryParse(global::System.ReadOnlySpan<global::System.Char> s, global::System.IFormatProvider? provider, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhen(false)] out ZYX result)
    {
        if (global::System.Int64.TryParse(s, provider, out var r))
        {
            global::System.Collections.Generic.HashSet<global::System.String> errors = new();
            var created = From(r);

            created._validate(ref errors);

            if (errors.Count > 0)
            {
                result = default;
                return false;
            }

            result = created;
            return true;
        }

        result = default;
        return false;
    }

    public static global::System.Boolean TryParse(global::System.String? s, global::System.IFormatProvider? provider, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhen(false)] out ZYX result)
    {
        if (global::System.Int64.TryParse(s, provider, out var r))
        {
            global::System.Collections.Generic.HashSet<global::System.String> errors = new();

            var created = From(r);

            created._validate(ref errors);

            if (errors.Count > 0)
            {
                result = default;
                return false;
            }

            result = created;
            return true;
        }

        result = default;
        return false;
    }

    private class Converter : global::System.ComponentModel.TypeConverter
    {
        private static readonly global::System.ComponentModel.TypeConverter _baseConverter;

        static Converter()
        {
            _baseConverter = global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.Int32));
        }

        private readonly Type[] _knownTypes = new[]
        {
            typeof(ZYX),
            typeof(global::System.String),
            typeof(global::System.Int64),
        };

        public override global::System.Boolean CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext? context, global::System.Type sourceType) =>
        _knownTypes.Contains(sourceType) ||
        (_baseConverter.CanConvertFrom(sourceType) && _baseConverter.CanConvertTo(typeof(global::System.Int64)));

        public override global::System.Boolean CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext? context, global::System.Type? destinationType) =>
        destinationType == typeof(ZYX);

        public override global::System.Object? ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext? context, global::System.Globalization.CultureInfo? culture, global::System.Object value)
        {
            return value switch
            {
                null => null,
                ZYX v => v,
                global::System.Int64 v => new ZYX(v),
                global::System.String v => Parse(v),
                var v when _baseConverter.CanConvertFrom(v.GetType()) && _baseConverter.CanConvertTo(typeof(global::System.Int64)) =>
                new ZYX((global::System.Int64)_baseConverter.ConvertTo(context, culture, v, typeof(global::System.Int64))!),
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
    /// A JsonConverter for System.Text.Json which converts ZYX transparently to and from Json representations
    /// </summary>
    public class SystemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<ZYX>
    {
        public override ZYX Read(ref global::System.Text.Json.Utf8JsonReader reader, global::System.Type typeToConvert, global::System.Text.Json.JsonSerializerOptions options)
        {
            return new(reader.GetInt64());
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