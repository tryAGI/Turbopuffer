#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// The units to report highlighted fragment offsets in.
    /// </summary>
    public readonly partial struct HighlightOffsetUnits : global::System.IEquatable<HighlightOffsetUnits>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? HighlightOffsetUnitsVariant1 { get; init; }
#else
        public string? HighlightOffsetUnitsVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HighlightOffsetUnitsVariant1))]
#endif
        public bool IsHighlightOffsetUnitsVariant1 => HighlightOffsetUnitsVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHighlightOffsetUnitsVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = HighlightOffsetUnitsVariant1;
            return IsHighlightOffsetUnitsVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickHighlightOffsetUnitsVariant1() => HighlightOffsetUnitsVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HighlightOffsetUnitsVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? HighlightOffsetUnitsVariant2 { get; init; }
#else
        public string? HighlightOffsetUnitsVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HighlightOffsetUnitsVariant2))]
#endif
        public bool IsHighlightOffsetUnitsVariant2 => HighlightOffsetUnitsVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHighlightOffsetUnitsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = HighlightOffsetUnitsVariant2;
            return IsHighlightOffsetUnitsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickHighlightOffsetUnitsVariant2() => HighlightOffsetUnitsVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HighlightOffsetUnitsVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? HighlightOffsetUnitsVariant3 { get; init; }
#else
        public string? HighlightOffsetUnitsVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HighlightOffsetUnitsVariant3))]
#endif
        public bool IsHighlightOffsetUnitsVariant3 => HighlightOffsetUnitsVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHighlightOffsetUnitsVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = HighlightOffsetUnitsVariant3;
            return IsHighlightOffsetUnitsVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickHighlightOffsetUnitsVariant3() => HighlightOffsetUnitsVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HighlightOffsetUnitsVariant3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator HighlightOffsetUnits(string value) => new HighlightOffsetUnits((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(HighlightOffsetUnits @this) => @this.HighlightOffsetUnitsVariant1;

        /// <summary>
        ///
        /// </summary>
        public HighlightOffsetUnits(string? value)
        {
            HighlightOffsetUnitsVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static HighlightOffsetUnits FromHighlightOffsetUnitsVariant1(string? value) => new HighlightOffsetUnits(value);

        /// <summary>
        ///
        /// </summary>
        public HighlightOffsetUnits(
            string? highlightOffsetUnitsVariant1,
            string? highlightOffsetUnitsVariant2,
            string? highlightOffsetUnitsVariant3
            )
        {
            HighlightOffsetUnitsVariant1 = highlightOffsetUnitsVariant1;
            HighlightOffsetUnitsVariant2 = highlightOffsetUnitsVariant2;
            HighlightOffsetUnitsVariant3 = highlightOffsetUnitsVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            HighlightOffsetUnitsVariant3 as object ??
            HighlightOffsetUnitsVariant2 as object ??
            HighlightOffsetUnitsVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            HighlightOffsetUnitsVariant1?.ToString() ??
            HighlightOffsetUnitsVariant2?.ToString() ??
            HighlightOffsetUnitsVariant3?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsHighlightOffsetUnitsVariant1 || IsHighlightOffsetUnitsVariant2 || IsHighlightOffsetUnitsVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? highlightOffsetUnitsVariant1 = null,
            global::System.Func<string, TResult>? highlightOffsetUnitsVariant2 = null,
            global::System.Func<string, TResult>? highlightOffsetUnitsVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (HighlightOffsetUnitsVariant1 is { } __value0 && highlightOffsetUnitsVariant1 != null)
            {
                return highlightOffsetUnitsVariant1(__value0);
            }
            else if (HighlightOffsetUnitsVariant2 is { } __value1 && highlightOffsetUnitsVariant2 != null)
            {
                return highlightOffsetUnitsVariant2(__value1);
            }
            else if (HighlightOffsetUnitsVariant3 is { } __value2 && highlightOffsetUnitsVariant3 != null)
            {
                return highlightOffsetUnitsVariant3(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? highlightOffsetUnitsVariant1 = null,

            global::System.Action<string>? highlightOffsetUnitsVariant2 = null,

            global::System.Action<string>? highlightOffsetUnitsVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (HighlightOffsetUnitsVariant1 is { } __value0)
            {
                highlightOffsetUnitsVariant1?.Invoke(__value0);
            }
            else if (HighlightOffsetUnitsVariant2 is { } __value1)
            {
                highlightOffsetUnitsVariant2?.Invoke(__value1);
            }
            else if (HighlightOffsetUnitsVariant3 is { } __value2)
            {
                highlightOffsetUnitsVariant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? highlightOffsetUnitsVariant1 = null,
            global::System.Action<string>? highlightOffsetUnitsVariant2 = null,
            global::System.Action<string>? highlightOffsetUnitsVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (HighlightOffsetUnitsVariant1 is { } __value0)
            {
                highlightOffsetUnitsVariant1?.Invoke(__value0);
            }
            else if (HighlightOffsetUnitsVariant2 is { } __value1)
            {
                highlightOffsetUnitsVariant2?.Invoke(__value1);
            }
            else if (HighlightOffsetUnitsVariant3 is { } __value2)
            {
                highlightOffsetUnitsVariant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                HighlightOffsetUnitsVariant1,
                typeof(string),
                HighlightOffsetUnitsVariant2,
                typeof(string),
                HighlightOffsetUnitsVariant3,
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
        public bool Equals(HighlightOffsetUnits other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(HighlightOffsetUnitsVariant1, other.HighlightOffsetUnitsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(HighlightOffsetUnitsVariant2, other.HighlightOffsetUnitsVariant2) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(HighlightOffsetUnitsVariant3, other.HighlightOffsetUnitsVariant3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(HighlightOffsetUnits obj1, HighlightOffsetUnits obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<HighlightOffsetUnits>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(HighlightOffsetUnits obj1, HighlightOffsetUnits obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is HighlightOffsetUnits o && Equals(o);
        }
    }
}
