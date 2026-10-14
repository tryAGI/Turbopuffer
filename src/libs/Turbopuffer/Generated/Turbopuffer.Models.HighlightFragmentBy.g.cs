#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// How to split a text attribute into fragments for highlighting.
    /// </summary>
    public readonly partial struct HighlightFragmentBy : global::System.IEquatable<HighlightFragmentBy>
    {
        /// <summary>
        /// Treat the whole attribute as a single fragment.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? HighlightFragmentByVariant1 { get; init; }
#else
        public string? HighlightFragmentByVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HighlightFragmentByVariant1))]
#endif
        public bool IsHighlightFragmentByVariant1 => HighlightFragmentByVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHighlightFragmentByVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = HighlightFragmentByVariant1;
            return IsHighlightFragmentByVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickHighlightFragmentByVariant1() => HighlightFragmentByVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HighlightFragmentByVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Split the attribute into sentences. This is the default.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? HighlightFragmentByVariant2 { get; init; }
#else
        public string? HighlightFragmentByVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HighlightFragmentByVariant2))]
#endif
        public bool IsHighlightFragmentByVariant2 => HighlightFragmentByVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHighlightFragmentByVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = HighlightFragmentByVariant2;
            return IsHighlightFragmentByVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickHighlightFragmentByVariant2() => HighlightFragmentByVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HighlightFragmentByVariant2' but the value was {ToString()}.");

        /// <summary>
        /// Split the attribute into paragraphs.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? HighlightFragmentByVariant3 { get; init; }
#else
        public string? HighlightFragmentByVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HighlightFragmentByVariant3))]
#endif
        public bool IsHighlightFragmentByVariant3 => HighlightFragmentByVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHighlightFragmentByVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = HighlightFragmentByVariant3;
            return IsHighlightFragmentByVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickHighlightFragmentByVariant3() => HighlightFragmentByVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HighlightFragmentByVariant3' but the value was {ToString()}.");

        /// <summary>
        /// Split the attribute into individual words.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? HighlightFragmentByVariant4 { get; init; }
#else
        public string? HighlightFragmentByVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HighlightFragmentByVariant4))]
#endif
        public bool IsHighlightFragmentByVariant4 => HighlightFragmentByVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHighlightFragmentByVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = HighlightFragmentByVariant4;
            return IsHighlightFragmentByVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickHighlightFragmentByVariant4() => HighlightFragmentByVariant4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HighlightFragmentByVariant4' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator HighlightFragmentBy(string value) => new HighlightFragmentBy((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(HighlightFragmentBy @this) => @this.HighlightFragmentByVariant1;

        /// <summary>
        ///
        /// </summary>
        public HighlightFragmentBy(string? value)
        {
            HighlightFragmentByVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static HighlightFragmentBy FromHighlightFragmentByVariant1(string? value) => new HighlightFragmentBy(value);

        /// <summary>
        ///
        /// </summary>
        public HighlightFragmentBy(
            string? highlightFragmentByVariant1,
            string? highlightFragmentByVariant2,
            string? highlightFragmentByVariant3,
            string? highlightFragmentByVariant4
            )
        {
            HighlightFragmentByVariant1 = highlightFragmentByVariant1;
            HighlightFragmentByVariant2 = highlightFragmentByVariant2;
            HighlightFragmentByVariant3 = highlightFragmentByVariant3;
            HighlightFragmentByVariant4 = highlightFragmentByVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            HighlightFragmentByVariant4 as object ??
            HighlightFragmentByVariant3 as object ??
            HighlightFragmentByVariant2 as object ??
            HighlightFragmentByVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            HighlightFragmentByVariant1?.ToString() ??
            HighlightFragmentByVariant2?.ToString() ??
            HighlightFragmentByVariant3?.ToString() ??
            HighlightFragmentByVariant4?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsHighlightFragmentByVariant1 || IsHighlightFragmentByVariant2 || IsHighlightFragmentByVariant3 || IsHighlightFragmentByVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? highlightFragmentByVariant1 = null,
            global::System.Func<string, TResult>? highlightFragmentByVariant2 = null,
            global::System.Func<string, TResult>? highlightFragmentByVariant3 = null,
            global::System.Func<string, TResult>? highlightFragmentByVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (HighlightFragmentByVariant1 is { } __value0 && highlightFragmentByVariant1 != null)
            {
                return highlightFragmentByVariant1(__value0);
            }
            else if (HighlightFragmentByVariant2 is { } __value1 && highlightFragmentByVariant2 != null)
            {
                return highlightFragmentByVariant2(__value1);
            }
            else if (HighlightFragmentByVariant3 is { } __value2 && highlightFragmentByVariant3 != null)
            {
                return highlightFragmentByVariant3(__value2);
            }
            else if (HighlightFragmentByVariant4 is { } __value3 && highlightFragmentByVariant4 != null)
            {
                return highlightFragmentByVariant4(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? highlightFragmentByVariant1 = null,

            global::System.Action<string>? highlightFragmentByVariant2 = null,

            global::System.Action<string>? highlightFragmentByVariant3 = null,

            global::System.Action<string>? highlightFragmentByVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (HighlightFragmentByVariant1 is { } __value0)
            {
                highlightFragmentByVariant1?.Invoke(__value0);
            }
            else if (HighlightFragmentByVariant2 is { } __value1)
            {
                highlightFragmentByVariant2?.Invoke(__value1);
            }
            else if (HighlightFragmentByVariant3 is { } __value2)
            {
                highlightFragmentByVariant3?.Invoke(__value2);
            }
            else if (HighlightFragmentByVariant4 is { } __value3)
            {
                highlightFragmentByVariant4?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? highlightFragmentByVariant1 = null,
            global::System.Action<string>? highlightFragmentByVariant2 = null,
            global::System.Action<string>? highlightFragmentByVariant3 = null,
            global::System.Action<string>? highlightFragmentByVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (HighlightFragmentByVariant1 is { } __value0)
            {
                highlightFragmentByVariant1?.Invoke(__value0);
            }
            else if (HighlightFragmentByVariant2 is { } __value1)
            {
                highlightFragmentByVariant2?.Invoke(__value1);
            }
            else if (HighlightFragmentByVariant3 is { } __value2)
            {
                highlightFragmentByVariant3?.Invoke(__value2);
            }
            else if (HighlightFragmentByVariant4 is { } __value3)
            {
                highlightFragmentByVariant4?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                HighlightFragmentByVariant1,
                typeof(string),
                HighlightFragmentByVariant2,
                typeof(string),
                HighlightFragmentByVariant3,
                typeof(string),
                HighlightFragmentByVariant4,
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
        public bool Equals(HighlightFragmentBy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(HighlightFragmentByVariant1, other.HighlightFragmentByVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(HighlightFragmentByVariant2, other.HighlightFragmentByVariant2) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(HighlightFragmentByVariant3, other.HighlightFragmentByVariant3) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(HighlightFragmentByVariant4, other.HighlightFragmentByVariant4)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(HighlightFragmentBy obj1, HighlightFragmentBy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<HighlightFragmentBy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(HighlightFragmentBy obj1, HighlightFragmentBy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is HighlightFragmentBy o && Equals(o);
        }
    }
}
