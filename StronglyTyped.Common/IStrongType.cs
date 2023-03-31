using System.Diagnostics.CodeAnalysis;

// ReSharper disable once CheckNamespace
namespace StronglyTyped
{
    // ReSharper disable once TypeParameterCanBeVariant
    /// <summary>
    /// Base interface for a strongly-typed value that represents a TBase
    /// </summary>
    /// <typeparam name="TBase">The type wrapped</typeparam>
    public interface IStrongType<TBase>
    {
        TBase Value { get; }
    }

    /// <summary>
    /// Interface for a strongly-typed value that represents a TBase
    /// </summary>
    /// <typeparam name="TSelf">This type</typeparam>
    /// <typeparam name="TBase">The type wrapped</typeparam>
    public interface IStrongType<TSelf, TBase> : IStrongType<TBase>
        where TSelf : struct, IStrongType<TSelf, TBase>
    {
        /// <summary>
        /// Creates a strongly typed value from a literal. Preprocessing performed if implemented.
        /// Validation not performed
        /// </summary>
        /// <param name="value">The value to wrap in the strong type</param>
        /// <returns>A strongly typed value</returns>
        static abstract TSelf From(TBase value);

        /// <summary>
        /// Creates a validated strongly typed value. Validation and preprocessing performed if implemented
        /// </summary>
        /// <param name="value">The value to validate and strongly type</param>
        /// <param name="result">The out parameter that contains a SUCCESSFUL creation</param>
        /// <param name="failures">An enumerable of strings listing reasons why it failed (default: empty)</param>
        /// <returns>Whether or not the creation was successful</returns>
        static abstract bool TryFrom(TBase value, [MaybeNull, NotNullWhen(true)] out TSelf result, out IReadOnlySet<string> failures);
        static abstract bool TryFrom(TBase value, [MaybeNull, NotNullWhen(true)] out TSelf result);

        /// <summary>
        /// Creates a strongly typed value. No validation or preprocessing performed
        /// </summary>
        /// <param name="value">The value to strongly type</param>
        /// <returns>The strongly typed value</returns>
        static abstract TSelf Create(TBase value);
    }
}
