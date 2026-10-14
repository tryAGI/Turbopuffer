#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// A function used to calculate sparse vector similarity.
    /// </summary>
    public readonly partial struct SparseDistanceMetric : global::System.IEquatable<SparseDistanceMetric>
    {
        /// <summary>
        /// Defined as `sum(x * y)`. Higher is better.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? SparseDistanceMetricVariant1 { get; init; }
#else
        public string? SparseDistanceMetricVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SparseDistanceMetricVariant1))]
#endif
        public bool IsSparseDistanceMetricVariant1 => SparseDistanceMetricVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSparseDistanceMetricVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = SparseDistanceMetricVariant1;
            return IsSparseDistanceMetricVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickSparseDistanceMetricVariant1() => SparseDistanceMetricVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SparseDistanceMetricVariant1' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SparseDistanceMetric(string value) => new SparseDistanceMetric((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(SparseDistanceMetric @this) => @this.SparseDistanceMetricVariant1;

        /// <summary>
        ///
        /// </summary>
        public SparseDistanceMetric(string? value)
        {
            SparseDistanceMetricVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SparseDistanceMetric FromSparseDistanceMetricVariant1(string? value) => new SparseDistanceMetric(value);

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SparseDistanceMetricVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SparseDistanceMetricVariant1?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSparseDistanceMetricVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? sparseDistanceMetricVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SparseDistanceMetricVariant1 is { } __value0 && sparseDistanceMetricVariant1 != null)
            {
                return sparseDistanceMetricVariant1(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? sparseDistanceMetricVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SparseDistanceMetricVariant1 is { } __value0)
            {
                sparseDistanceMetricVariant1?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? sparseDistanceMetricVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SparseDistanceMetricVariant1 is { } __value0)
            {
                sparseDistanceMetricVariant1?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SparseDistanceMetricVariant1,
                typeof(string),
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
        public bool Equals(SparseDistanceMetric other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(SparseDistanceMetricVariant1, other.SparseDistanceMetricVariant1)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SparseDistanceMetric obj1, SparseDistanceMetric obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SparseDistanceMetric>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SparseDistanceMetric obj1, SparseDistanceMetric obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SparseDistanceMetric o && Equals(o);
        }
    }
}
