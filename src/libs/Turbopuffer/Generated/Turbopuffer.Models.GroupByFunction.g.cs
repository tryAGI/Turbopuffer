#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// A function that produces group keys.
    /// </summary>
    public readonly partial struct GroupByFunction : global::System.IEquatable<GroupByFunction>
    {
        /// <summary>
        /// Use the `ForEachUnique` operator to explode an array attribute when grouping. Each unique element of the array becomes a separate group.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? GroupByFunctionVariant1 { get; init; }
#else
        public byte[]? GroupByFunctionVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GroupByFunctionVariant1))]
#endif
        public bool IsGroupByFunctionVariant1 => GroupByFunctionVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGroupByFunctionVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out byte[]? value)
        {
            value = GroupByFunctionVariant1;
            return IsGroupByFunctionVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public byte[] PickGroupByFunctionVariant1() => GroupByFunctionVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GroupByFunctionVariant1' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator GroupByFunction(byte[] value) => new GroupByFunction((byte[]?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator byte[]?(GroupByFunction @this) => @this.GroupByFunctionVariant1;

        /// <summary>
        ///
        /// </summary>
        public GroupByFunction(byte[]? value)
        {
            GroupByFunctionVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GroupByFunction FromGroupByFunctionVariant1(byte[]? value) => new GroupByFunction(value);

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GroupByFunctionVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GroupByFunctionVariant1?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGroupByFunctionVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<byte[], TResult>? groupByFunctionVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GroupByFunctionVariant1 is { } __value0 && groupByFunctionVariant1 != null)
            {
                return groupByFunctionVariant1(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<byte[]>? groupByFunctionVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GroupByFunctionVariant1 is { } __value0)
            {
                groupByFunctionVariant1?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<byte[]>? groupByFunctionVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GroupByFunctionVariant1 is { } __value0)
            {
                groupByFunctionVariant1?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GroupByFunctionVariant1,
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
        public bool Equals(GroupByFunction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(GroupByFunctionVariant1, other.GroupByFunctionVariant1)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(GroupByFunction obj1, GroupByFunction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GroupByFunction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GroupByFunction obj1, GroupByFunction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GroupByFunction o && Equals(o);
        }
    }
}
