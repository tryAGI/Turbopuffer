#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Turbopuffer
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CopyFromNamespaceOperationResult : global::System.IEquatable<CopyFromNamespaceOperationResult>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Turbopuffer.CopyFromNamespaceOperationResultSuccess? Success { get; init; }
#else
        public global::Turbopuffer.CopyFromNamespaceOperationResultSuccess? Success { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Success))]
#endif
        public bool IsSuccess => Success != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Turbopuffer.CopyFromNamespaceOperationResultSuccess? value)
        {
            value = Success;
            return IsSuccess;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CopyFromNamespaceOperationResultSuccess PickSuccess() => Success is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Success' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Turbopuffer.CopyFromNamespaceOperationResultError? Error { get; init; }
#else
        public global::Turbopuffer.CopyFromNamespaceOperationResultError? Error { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Turbopuffer.CopyFromNamespaceOperationResultError? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CopyFromNamespaceOperationResultError PickError() => Error is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CopyFromNamespaceOperationResult(global::Turbopuffer.CopyFromNamespaceOperationResultSuccess value) => new CopyFromNamespaceOperationResult((global::Turbopuffer.CopyFromNamespaceOperationResultSuccess?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Turbopuffer.CopyFromNamespaceOperationResultSuccess?(CopyFromNamespaceOperationResult @this) => @this.Success;

        /// <summary>
        ///
        /// </summary>
        public CopyFromNamespaceOperationResult(global::Turbopuffer.CopyFromNamespaceOperationResultSuccess? value)
        {
            Success = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CopyFromNamespaceOperationResult FromSuccess(global::Turbopuffer.CopyFromNamespaceOperationResultSuccess? value) => new CopyFromNamespaceOperationResult(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CopyFromNamespaceOperationResult(global::Turbopuffer.CopyFromNamespaceOperationResultError value) => new CopyFromNamespaceOperationResult((global::Turbopuffer.CopyFromNamespaceOperationResultError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Turbopuffer.CopyFromNamespaceOperationResultError?(CopyFromNamespaceOperationResult @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public CopyFromNamespaceOperationResult(global::Turbopuffer.CopyFromNamespaceOperationResultError? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CopyFromNamespaceOperationResult FromError(global::Turbopuffer.CopyFromNamespaceOperationResultError? value) => new CopyFromNamespaceOperationResult(value);

        /// <summary>
        ///
        /// </summary>
        public CopyFromNamespaceOperationResult(
            global::Turbopuffer.CopyFromNamespaceOperationResultSuccess? success,
            global::Turbopuffer.CopyFromNamespaceOperationResultError? error
            )
        {
            Success = success;
            Error = error;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Error as object ??
            Success as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Success?.ToString() ??
            Error?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSuccess && !IsError || !IsSuccess && IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Turbopuffer.CopyFromNamespaceOperationResultSuccess, TResult>? success = null,
            global::System.Func<global::Turbopuffer.CopyFromNamespaceOperationResultError, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Success is { } __value0 && success != null)
            {
                return success(__value0);
            }
            else if (Error is { } __value1 && error != null)
            {
                return error(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Turbopuffer.CopyFromNamespaceOperationResultSuccess>? success = null,

            global::System.Action<global::Turbopuffer.CopyFromNamespaceOperationResultError>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Success is { } __value0)
            {
                success?.Invoke(__value0);
            }
            else if (Error is { } __value1)
            {
                error?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Turbopuffer.CopyFromNamespaceOperationResultSuccess>? success = null,
            global::System.Action<global::Turbopuffer.CopyFromNamespaceOperationResultError>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Success is { } __value0)
            {
                success?.Invoke(__value0);
            }
            else if (Error is { } __value1)
            {
                error?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Success,
                typeof(global::Turbopuffer.CopyFromNamespaceOperationResultSuccess),
                Error,
                typeof(global::Turbopuffer.CopyFromNamespaceOperationResultError),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(CopyFromNamespaceOperationResult other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Turbopuffer.CopyFromNamespaceOperationResultSuccess?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::Turbopuffer.CopyFromNamespaceOperationResultError?>.Default.Equals(Error, other.Error)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CopyFromNamespaceOperationResult obj1, CopyFromNamespaceOperationResult obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CopyFromNamespaceOperationResult>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CopyFromNamespaceOperationResult obj1, CopyFromNamespaceOperationResult obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CopyFromNamespaceOperationResult o && Equals(o);
        }
    }
}
