﻿using System.Diagnostics.CodeAnalysis;

namespace StrictlyTyped
{
    /// <summary>
    /// A strictly-typed value that represents a Guid
    /// </summary>
    /// <typeparam name="TSelf">This type</typeparam>
    public interface IStrictGuid<TSelf> : 
        IStrictType<TSelf, Guid>,
        IEquatable<TSelf>,
        IComparable,
        IComparable<TSelf>,
        ISpanFormattable,
        ISpanParsable<TSelf>
        where TSelf : struct, IStrictGuid<TSelf> 
    {
        static abstract TSelf New();
        static abstract TSelf Empty { get; }
        static abstract bool TryParse(string? s, [MaybeNullWhen(false)] out TSelf result);
        static abstract TSelf Parse(string? s);

        static abstract bool operator ==(TSelf left, string right);
        static abstract bool operator !=(TSelf left, string right);
        static abstract bool operator ==(string left, TSelf right);
        static abstract bool operator !=(string left, TSelf right);
    }
}
