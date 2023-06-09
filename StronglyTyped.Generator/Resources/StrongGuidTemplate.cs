﻿/// <summary>
/// Represents a strongly-typed record struct for a Guid
/// </summary>
/// <remarks>
/// This struct is immutable and can be used for performance-sensitive scenarios that require
/// type safety and minimal allocations. It implements the <see cref="global::StronglyTyped.IStrongGuid{T}"/> interface
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
public readonly partial record struct ZYX : global::StronglyTyped.IStrongGuid<ZYX>
{
    /// <summary>
    /// Gets the value of the ZYX struct.
    /// </summary>
    public required readonly global::System.Guid Value { get; init; }

    /// <summary>
    /// Creates a new ZYX from a newly generated Guid
    /// </summary>
    /// <returns>A strongly typed new Guid</returns>
    public static ZYX New() =>
        new(global::System.Guid.NewGuid());

    /// <summary>
    /// A ZYX created from Guid.Empty
    /// </summary>
    public static ZYX Empty => _empty;
    private readonly static ZYX _empty = new(global::System.Guid.Empty);

    /// <summary>
    /// Converts a <see cref="ZYX"/> value to an <see cref="global::System.Guid"/> value.
    /// </summary>
    /// <param name="value">The <see cref="ZYX"/> value to convert.</param>
    /// <returns>The <see cref="global::System.Guid"/> value that represents the converted <see cref="ZYX"/> value.</returns>
    [global::System.Diagnostics.Contracts.Pure]
    public static explicit operator global::System.Guid(ZYX value) =>
        value.Value;

    /// <summary>
    /// Converts an <see cref="global::System.Guid"/> value to a <see cref="ZYX"/> value.
    /// </summary>
    /// <param name="value">The <see cref="global::System.Guid"/> value to convert.</param>
    /// <returns>A new <see cref="ZYX"/> value that represents the converted <see cref="global::System.Guid"/> value.</returns>
    /// <remarks>
    /// No validation or preprocessing is performed.
    /// </remarks>
    [global::System.Diagnostics.Contracts.Pure]
    public static explicit operator ZYX(global::System.Guid value) =>
        new(value);

    /// <summary>
    /// Parses a <see cref="global::System.String"/> value to a <see cref="global::System.Guid"/>, then a <see cref="ZYX"/> value.
    /// </summary>
    /// <param name="value">The <see cref="global::System.String"/> value to convert.</param>
    /// <returns>A new <see cref="ZYX"/> value that represents the parsed then converted <see cref="global::System.Guid"/> value.</returns>
    /// <remarks>
    /// No validation or preprocessing is performed.
    /// </remarks>
    [global::System.Diagnostics.Contracts.Pure]
    public static explicit operator ZYX(global::System.String value) =>
        Parse(value);

    /// <summary>
    /// Initializes a new instance of the <see cref="ZYX"/> struct with the specified value.
    /// </summary>
    /// <param name="value">The value to use as the underlying value of the <see cref="ZYX"/> struct.</param>
    /// <remarks>
    /// No validation or preprocessing is performed.
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    public ZYX(global::System.Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ZYX"/> struct with the specified value.
    /// </summary>
    /// <param name="value">The string value to parse to use as the underlying value of the <see cref="ZYX"/> struct.</param>
    /// <remarks>
    /// No validation or preprocessing is performed.
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    public ZYX(global::System.String value)
        : this(global::System.Guid.Parse(value))
    { }

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

    public static bool operator ==(ZYX left, string? right) =>
        left.Value.ToString().Equals(right!);

    public static bool operator !=(ZYX left, string? right) =>
        !(left == right);

    public static bool operator ==(string? left, ZYX right) =>
        right == left;

    public static bool operator !=(string? left, ZYX right) =>
        !(right == left);

    /// <summary>
    /// Initializes a new instance of the <see cref="ZYX"/> struct with the specified value.
    /// </summary>
    /// <param name="value">Thevalue to use as the underlying value of the <see cref="ZYX"/> struct.</param>
    /// <remarks>
    /// No validation or preprocessing is performed.
    /// </remarks>
    public static ZYX Create(global::System.Guid value) =>
        new(value);

    /// <summary>
    /// Parses the string representation of a ZYX value.
    /// </summary>
    /// <param name="s">The string representation of the <see cref="global::System.Guid"/> to parse.</param>
    /// <returns>A new instance of the <see cref="ZYX"/> struct that represents the parsed value.</returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="s"/> is null.</exception>
    /// <remarks>
    /// No validation or preprocessing is performed.
    /// </remarks>
    [global::System.Diagnostics.Contracts.Pure]
    public static ZYX Parse(global::System.String? s) =>
        new(global::System.Guid.Parse(s!));

    /// <summary>
    /// Converts the span representation of a ZYX value to its <see cref="ZYX"/> equivalent.
    /// </summary>
    /// <param name="s">The span containing the <see cref="global::System.Guid"/> to convert.</param>
    /// <returns>A new instance of <see cref="ZYX"/> equivalent to the value represented in <paramref name="s"/>.</returns>
    /// <exception cref="System.FormatException">Thrown when the string representation of the value is not in the correct format.</exception>
    /// <remarks>
    /// No validation or preprocessing is performed.
    /// </remarks>
    [global::System.Diagnostics.Contracts.Pure]
    public static ZYX Parse(global::System.ReadOnlySpan<global::System.Char> s, global::System.IFormatProvider? provider) =>
        From(global::System.Guid.Parse(s, provider));

    /// <summary>
    /// Converts the string representation of a value in a specified culture-specific format to its <see cref="ZYX"/> equivalent.
    /// </summary>
    /// <param name="s">A string that contains the <see cref="global::System.Guid"/> to convert.</param>
    /// <param name="provider">An object that provides culture-specific formatting information.</param>
    /// <returns>A <see cref="ZYX"/> equivalent to the value contained in <paramref name="s"/>.</returns>
    /// <exception cref="System.ArgumentNullException"><paramref name="s"/> is <see langword="null"/>.</exception>
    /// <exception cref="System.FormatException"><paramref name="s"/> is not in the correct format.</exception>
    /// <remarks>
    /// No validation or preprocessing is performed.
    /// </remarks>
    [global::System.Diagnostics.Contracts.Pure]
    public static ZYX Parse(global::System.String s, global::System.IFormatProvider? provider) =>
        From(global::System.Guid.Parse(s, provider));

    /// <summary>
    /// Attempts to parse a string to a Guid then create a ZYX. Validation and processing will be performed, if implemented
    /// </summary>
    /// <param name="s">The string representation of a Guid</param>
    /// <param name="result">out ZYX created (if successful)</param>
    /// <returns>Whether or not the creation was successful</returns>
    public static global::System.Boolean TryParse(global::System.String? s, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhen(false)] out ZYX result) =>
        TryParse(s, null, out result);

    /// <summary>
    /// Attempts to parse a string to a Guid then create a ZYX. Validation and processing will be performed, if implemented
    /// </summary>
    /// <param name="s">The ReadOnlySpan of char representation of a Guid</param>
    /// <param name="provider">A format provider</param>
    /// <param name="result">out ZYX created (if successful)</param>
    /// <returns>Whether or not the creation was successful</returns>
    public static global::System.Boolean TryParse(global::System.ReadOnlySpan<global::System.Char> s, global::System.IFormatProvider? provider, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhen(false)] out ZYX result)
    {
        if (global::System.Guid.TryParse(s, provider, out global::System.Guid r))
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

    /// <summary>
    /// Attempts to parse a string to a Guid then create a ZYX. Validation and processing will be performed, if implemented
    /// </summary>
    /// <param name="s">The string representation of a Guid</param>
    /// <param name="provider">A format provider</param>
    /// <param name="result">out ZYX created (if successful)</param>
    /// <returns>Whether or not the creation was successful</returns>
    public static global::System.Boolean TryParse(global::System.String? s, global::System.IFormatProvider? provider, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhen(false)] out ZYX result)
    {
        if (global::System.Guid.TryParse(s, provider, out global::System.Guid r))
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
    /// <exception cref="System.ArgumentException">obj is not the same type as this instance</exception>
    [global::System.Diagnostics.Contracts.Pure]
    public global::System.Int32 CompareTo(global::System.Object? obj)
    {
        var result = obj switch
        {
            null => 1,
            ZYX v => CompareTo(v),
            _ => throw new ArgumentException("Value cannot be compared to ZYX", nameof(obj)),
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

    /// <summary>
    /// Produces a string representation of this ZYX. The result is not affected by _overrideToString
    /// </summary>
    /// <param name="format">The format to use</param>
    /// <param name="formatProvider">Currently ignored (behaves like System.Guid)</param>
    /// <returns>A string representation of the ZYX</returns>
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

    /// <summary>
    /// Attempts to produce a Span of char representation of this ZYX 
    /// </summary>
    /// <param name="destination">The Span of char which will receieve the representation</param>
    /// <param name="charsWritten">The number of characters written</param>
    /// <param name="format">The format to use</param>
    /// <param name="_">Currently ignored (behaves like System.Guid)</param>
    /// <returns></returns>
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
    public static ZYX From(global::System.Guid value)
    {
        _preprocess(ref value);
        return new(value);
    }

    /// <summary>
    /// If implemented, the wrapped value will be preprocessed by this method before creation
    /// Preprocessing runs before validation (if implemented)
    /// </summary>
    /// <param name="value">The value which is to be preprocessed</param>
    static partial void _preprocess(ref global::System.Guid result);

    /// <summary>
    /// If implemented, the result of calling CompareTo on the wrapped value will be modified by this method
    /// </summary>
    /// <param name="result">The value which will be returned by CompareTo</param>
#pragma warning disable IDE0051 // Remove unused private members
    partial void _overrideEquals(ZYX? obj, ref global::System.Boolean result);
#pragma warning restore IDE0051 // Remove unused private members

    /// <summary>
    /// If implemented, the result of calling ToString on the wrapped value will be modified by this method
    /// </summary>
    /// <param name="result">The value which will be returned by ToString</param>
    static partial void _overrideToString(global::System.Guid value, ref global::System.String result);

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

    public static global::System.Boolean TryFrom(global::System.Guid value, [global::System.Diagnostics.CodeAnalysis.MaybeNull, global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out ZYX result, out global::System.Collections.Generic.IReadOnlySet<global::System.String> failures)
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

    /// <summary>
    /// Attempts to create a ZYX from a Guid. Validation and preprocessing will be performed, if implemented
    /// </summary>
    /// <param name="value">The Guid to create the ZYX from</param>
    /// <param name="result">out ZYX result</param>
    /// <returns>Whether or not the creation succeeded</returns>
    public static global::System.Boolean TryFrom(global::System.Guid value, [global::System.Diagnostics.CodeAnalysis.MaybeNull, global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out ZYX result) =>
        TryFrom(value, out result, out _);

    /// <summary>
    /// Attempts to validate a ZYX based on implementation of _validate, if not implemented no validation will occur
    /// </summary>
    /// <returns>A read-only list of strings representing the reasons why this ZYX is not valid</returns>
    [global::System.Diagnostics.Contracts.Pure]
    public global::System.Collections.Generic.IReadOnlyList<global::System.String> Validate()
    {
        global::System.Collections.Generic.HashSet<global::System.String> errors = new();
        _validate(ref errors);

        return global::System.Linq.Enumerable.ToList(errors).AsReadOnly();
    }

    /// <summary>
    /// TypeConverter which converts to and from objects of type ZYX
    /// </summary>
    private class Converter : global::System.ComponentModel.TypeConverter
    {
        private static readonly global::System.ComponentModel.TypeConverter _baseConverter;

        static Converter()
        {
            _baseConverter = global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.Guid));
        }

        private readonly Type[] _knownTypes = new[]
        {
            typeof(ZYX),
            typeof(global::System.String),
            typeof(global::System.Guid),
        };

        public override global::System.Boolean CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext? context, global::System.Type sourceType) =>
            _knownTypes.Contains(sourceType) ||
            (_baseConverter.CanConvertFrom(sourceType) && _baseConverter.CanConvertTo(typeof(global::System.Guid)));

        public override global::System.Boolean CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext? context, global::System.Type? destinationType) =>
            destinationType == typeof(ZYX);

        public override global::System.Object? ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext? context, global::System.Globalization.CultureInfo? culture, global::System.Object value)
        {
            return value switch
            {
                null => null,
                ZYX v => v,
                global::System.Guid v => new ZYX(v),
                global::System.String v => Parse(v),
                var v when _baseConverter.CanConvertFrom(v.GetType()) && _baseConverter.CanConvertTo(typeof(global::System.Guid)) =>
                ConvertFrom(context, culture, _baseConverter.ConvertTo(context, culture, v!, typeof(global::System.Guid))!),
                _ => throw new global::System.InvalidCastException($"Cannot convert {value ?? "<null>"} ({value?.GetType().Name ?? "<null>"}) to {typeof(ZYX).FullName}>"),
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
    /// A JsonConverter for System.Text.Json which converts ZYX transparently to and from Json representations of a Guid
    /// </summary>
    public class SystemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<ZYX>
    {
        public override ZYX Read(ref global::System.Text.Json.Utf8JsonReader reader, global::System.Type typeToConvert, global::System.Text.Json.JsonSerializerOptions options)
        {
            return new(reader.GetGuid());
        }

        public override void Write(global::System.Text.Json.Utf8JsonWriter writer, ZYX value, global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteRawValue(global::System.Text.Json.JsonSerializer.Serialize(value.Value));
        }
    }
#endif

#if (USE_NEWTONSOFT_JSON)
    /// <summary>
    /// A JsonConverter for Newtonsoft.Json which converts ZYX transparently to and from Json representations of a Guid
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