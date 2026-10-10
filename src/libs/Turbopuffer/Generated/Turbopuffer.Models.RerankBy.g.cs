#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Configuration for combining the rows returned by a multi-query into a single ranked list.
    /// </summary>
    public readonly partial struct RerankBy : global::System.IEquatable<RerankBy>
    {
        /// <summary>
        /// Rerank with RRF.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? RerankByVariant1 { get; init; }
#else
        public byte[]? RerankByVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RerankByVariant1))]
#endif
        public bool IsRerankByVariant1 => RerankByVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRerankByVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out byte[]? value)
        {
            value = RerankByVariant1;
            return IsRerankByVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public byte[] PickRerankByVariant1() => RerankByVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RerankByVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Rerank with RRF.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? RerankByVariant2 { get; init; }
#else
        public byte[]? RerankByVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RerankByVariant2))]
#endif
        public bool IsRerankByVariant2 => RerankByVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRerankByVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out byte[]? value)
        {
            value = RerankByVariant2;
            return IsRerankByVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public byte[] PickRerankByVariant2() => RerankByVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RerankByVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RerankBy(byte[] value) => new RerankBy((byte[]?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator byte[]?(RerankBy @this) => @this.RerankByVariant1;

        /// <summary>
        ///
        /// </summary>
        public RerankBy(byte[]? value)
        {
            RerankByVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RerankBy FromRerankByVariant1(byte[]? value) => new RerankBy(value);

        /// <summary>
        ///
        /// </summary>
        public RerankBy(
            byte[]? rerankByVariant1,
            byte[]? rerankByVariant2
            )
        {
            RerankByVariant1 = rerankByVariant1;
            RerankByVariant2 = rerankByVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RerankByVariant2 as object ??
            RerankByVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RerankByVariant1?.ToString() ??
            RerankByVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRerankByVariant1 || IsRerankByVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<byte[], TResult>? rerankByVariant1 = null,
            global::System.Func<byte[], TResult>? rerankByVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RerankByVariant1 is { } __value0 && rerankByVariant1 != null)
            {
                return rerankByVariant1(__value0);
            }
            else if (RerankByVariant2 is { } __value1 && rerankByVariant2 != null)
            {
                return rerankByVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<byte[]>? rerankByVariant1 = null,

            global::System.Action<byte[]>? rerankByVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RerankByVariant1 is { } __value0)
            {
                rerankByVariant1?.Invoke(__value0);
            }
            else if (RerankByVariant2 is { } __value1)
            {
                rerankByVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<byte[]>? rerankByVariant1 = null,
            global::System.Action<byte[]>? rerankByVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RerankByVariant1 is { } __value0)
            {
                rerankByVariant1?.Invoke(__value0);
            }
            else if (RerankByVariant2 is { } __value1)
            {
                rerankByVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RerankByVariant1,
                typeof(byte[]),
                RerankByVariant2,
                typeof(byte[]),
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
        public bool Equals(RerankBy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(RerankByVariant1, other.RerankByVariant1) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(RerankByVariant2, other.RerankByVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RerankBy obj1, RerankBy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RerankBy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RerankBy obj1, RerankBy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RerankBy o && Equals(o);
        }
    }
}
