#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Specifies a value to group documents by.
    /// </summary>
    public readonly partial struct GroupBy : global::System.IEquatable<GroupBy>
    {
        /// <summary>
        /// An attribute name to group documents by.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? GroupByVariant1 { get; init; }
#else
        public string? GroupByVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GroupByVariant1))]
#endif
        public bool IsGroupByVariant1 => GroupByVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGroupByVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = GroupByVariant1;
            return IsGroupByVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickGroupByVariant1() => GroupByVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GroupByVariant1' but the value was {ToString()}.");

        /// <summary>
        /// An expression to group documents by, with an explicit output attribute name.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.GroupByFunction>? GroupByVariant2 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.GroupByFunction>? GroupByVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GroupByVariant2))]
#endif
        public bool IsGroupByVariant2 => GroupByVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGroupByVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.GroupByFunction>? value)
        {
            value = GroupByVariant2;
            return IsGroupByVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.GroupByFunction> PickGroupByVariant2() => GroupByVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GroupByVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator GroupBy(string value) => new GroupBy((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(GroupBy @this) => @this.GroupByVariant1;

        /// <summary>
        ///
        /// </summary>
        public GroupBy(string? value)
        {
            GroupByVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GroupBy FromGroupByVariant1(string? value) => new GroupBy(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GroupBy(global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.GroupByFunction> value) => new GroupBy((global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.GroupByFunction>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.GroupByFunction>?(GroupBy @this) => @this.GroupByVariant2;

        /// <summary>
        ///
        /// </summary>
        public GroupBy(global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.GroupByFunction>? value)
        {
            GroupByVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GroupBy FromGroupByVariant2(global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.GroupByFunction>? value) => new GroupBy(value);

        /// <summary>
        ///
        /// </summary>
        public GroupBy(
            string? groupByVariant1,
            global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.GroupByFunction>? groupByVariant2
            )
        {
            GroupByVariant1 = groupByVariant1;
            GroupByVariant2 = groupByVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GroupByVariant2 as object ??
            GroupByVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GroupByVariant1?.ToString() ??
            GroupByVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGroupByVariant1 || IsGroupByVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? groupByVariant1 = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.GroupByFunction>, TResult>? groupByVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GroupByVariant1 is { } __value0 && groupByVariant1 != null)
            {
                return groupByVariant1(__value0);
            }
            else if (GroupByVariant2 is { } __value1 && groupByVariant2 != null)
            {
                return groupByVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? groupByVariant1 = null,

            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.GroupByFunction>>? groupByVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GroupByVariant1 is { } __value0)
            {
                groupByVariant1?.Invoke(__value0);
            }
            else if (GroupByVariant2 is { } __value1)
            {
                groupByVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? groupByVariant1 = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.GroupByFunction>>? groupByVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GroupByVariant1 is { } __value0)
            {
                groupByVariant1?.Invoke(__value0);
            }
            else if (GroupByVariant2 is { } __value1)
            {
                groupByVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GroupByVariant1,
                typeof(string),
                GroupByVariant2,
                typeof(global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.GroupByFunction>),
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
        public bool Equals(GroupBy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(GroupByVariant1, other.GroupByVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.GroupByFunction>?>.Default.Equals(GroupByVariant2, other.GroupByVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(GroupBy obj1, GroupBy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GroupBy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GroupBy obj1, GroupBy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GroupBy o && Equals(o);
        }
    }
}
