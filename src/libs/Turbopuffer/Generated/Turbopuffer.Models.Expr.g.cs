#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// An expression that computes a value.
    /// </summary>
    public readonly partial struct Expr : global::System.IEquatable<Expr>
    {
        /// <summary>
        /// A reference to an attribute in a new document.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Turbopuffer.ExprRefNew? RefNew { get; init; }
#else
        public global::Turbopuffer.ExprRefNew? RefNew { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RefNew))]
#endif
        public bool IsRefNew => RefNew != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRefNew(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Turbopuffer.ExprRefNew? value)
        {
            value = RefNew;
            return IsRefNew;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.ExprRefNew PickRefNew() => RefNew is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RefNew' but the value was {ToString()}.");

        /// <summary>
        /// Embed the input text using the embedding model configured for the attribute the expression is evaluated against.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? ExprVariant2 { get; init; }
#else
        public byte[]? ExprVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExprVariant2))]
#endif
        public bool IsExprVariant2 => ExprVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickExprVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out byte[]? value)
        {
            value = ExprVariant2;
            return IsExprVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public byte[] PickExprVariant2() => ExprVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ExprVariant2' but the value was {ToString()}.");

        /// <summary>
        /// Embed the input text using the specified embedding model, overriding the model configured for the attribute the expression is evaluated against.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? ExprVariant3 { get; init; }
#else
        public byte[]? ExprVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExprVariant3))]
#endif
        public bool IsExprVariant3 => ExprVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickExprVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out byte[]? value)
        {
            value = ExprVariant3;
            return IsExprVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public byte[] PickExprVariant3() => ExprVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ExprVariant3' but the value was {ToString()}.");

        /// <summary>
        /// The distance between a vector attribute and a query vector.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? VectorDist { get; init; }
#else
        public byte[]? VectorDist { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorDist))]
#endif
        public bool IsVectorDist => VectorDist != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVectorDist(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out byte[]? value)
        {
            value = VectorDist;
            return IsVectorDist;
        }

        /// <summary>
        ///
        /// </summary>
        public byte[] PickVectorDist() => VectorDist is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VectorDist' but the value was {ToString()}.");

        /// <summary>
        /// Highlights matching fragments of a text attribute.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Highlight { get; init; }
#else
        public byte[]? Highlight { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Highlight))]
#endif
        public bool IsHighlight => Highlight != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHighlight(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out byte[]? value)
        {
            value = Highlight;
            return IsHighlight;
        }

        /// <summary>
        ///
        /// </summary>
        public byte[] PickHighlight() => Highlight is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Highlight' but the value was {ToString()}.");

        /// <summary>
        /// Highlights matching fragments of a text attribute, with additional configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? HighlightWithConfig { get; init; }
#else
        public byte[]? HighlightWithConfig { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HighlightWithConfig))]
#endif
        public bool IsHighlightWithConfig => HighlightWithConfig != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHighlightWithConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out byte[]? value)
        {
            value = HighlightWithConfig;
            return IsHighlightWithConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public byte[] PickHighlightWithConfig() => HighlightWithConfig is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HighlightWithConfig' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Turbopuffer.RankBy? Score { get; init; }
#else
        public global::Turbopuffer.RankBy? Score { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Score))]
#endif
        public bool IsScore => Score != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScore(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Turbopuffer.RankBy? value)
        {
            value = Score;
            return IsScore;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.RankBy PickScore() => Score is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Score' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Expr(global::Turbopuffer.ExprRefNew value) => new Expr((global::Turbopuffer.ExprRefNew?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Turbopuffer.ExprRefNew?(Expr @this) => @this.RefNew;

        /// <summary>
        ///
        /// </summary>
        public Expr(global::Turbopuffer.ExprRefNew? value)
        {
            RefNew = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Expr FromRefNew(global::Turbopuffer.ExprRefNew? value) => new Expr(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Expr(byte[] value) => new Expr((byte[]?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator byte[]?(Expr @this) => @this.ExprVariant2;

        /// <summary>
        ///
        /// </summary>
        public Expr(byte[]? value)
        {
            ExprVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Expr FromExprVariant2(byte[]? value) => new Expr(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Expr(global::Turbopuffer.RankBy value) => new Expr((global::Turbopuffer.RankBy?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Turbopuffer.RankBy?(Expr @this) => @this.Score;

        /// <summary>
        ///
        /// </summary>
        public Expr(global::Turbopuffer.RankBy? value)
        {
            Score = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Expr FromScore(global::Turbopuffer.RankBy? value) => new Expr(value);

        /// <summary>
        ///
        /// </summary>
        public Expr(
            global::Turbopuffer.ExprRefNew? refNew,
            byte[]? exprVariant2,
            byte[]? exprVariant3,
            byte[]? vectorDist,
            byte[]? highlight,
            byte[]? highlightWithConfig,
            global::Turbopuffer.RankBy? score
            )
        {
            RefNew = refNew;
            ExprVariant2 = exprVariant2;
            ExprVariant3 = exprVariant3;
            VectorDist = vectorDist;
            Highlight = highlight;
            HighlightWithConfig = highlightWithConfig;
            Score = score;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Score as object ??
            HighlightWithConfig as object ??
            Highlight as object ??
            VectorDist as object ??
            ExprVariant3 as object ??
            ExprVariant2 as object ??
            RefNew as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RefNew?.ToString() ??
            ExprVariant2?.ToString() ??
            ExprVariant3?.ToString() ??
            VectorDist?.ToString() ??
            Highlight?.ToString() ??
            HighlightWithConfig?.ToString() ??
            Score?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRefNew || IsExprVariant2 || IsExprVariant3 || IsVectorDist || IsHighlight || IsHighlightWithConfig || IsScore;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Turbopuffer.ExprRefNew, TResult>? refNew = null,
            global::System.Func<byte[], TResult>? exprVariant2 = null,
            global::System.Func<byte[], TResult>? exprVariant3 = null,
            global::System.Func<byte[], TResult>? vectorDist = null,
            global::System.Func<byte[], TResult>? highlight = null,
            global::System.Func<byte[], TResult>? highlightWithConfig = null,
            global::System.Func<global::Turbopuffer.RankBy?, TResult>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RefNew is { } __value0 && refNew != null)
            {
                return refNew(__value0);
            }
            else if (ExprVariant2 is { } __value1 && exprVariant2 != null)
            {
                return exprVariant2(__value1);
            }
            else if (ExprVariant3 is { } __value2 && exprVariant3 != null)
            {
                return exprVariant3(__value2);
            }
            else if (VectorDist is { } __value3 && vectorDist != null)
            {
                return vectorDist(__value3);
            }
            else if (Highlight is { } __value4 && highlight != null)
            {
                return highlight(__value4);
            }
            else if (HighlightWithConfig is { } __value5 && highlightWithConfig != null)
            {
                return highlightWithConfig(__value5);
            }
            else if (Score is { } __value6 && score != null)
            {
                return score(__value6);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Turbopuffer.ExprRefNew>? refNew = null,

            global::System.Action<byte[]>? exprVariant2 = null,

            global::System.Action<byte[]>? exprVariant3 = null,

            global::System.Action<byte[]>? vectorDist = null,

            global::System.Action<byte[]>? highlight = null,

            global::System.Action<byte[]>? highlightWithConfig = null,

            global::System.Action<global::Turbopuffer.RankBy?>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RefNew is { } __value0)
            {
                refNew?.Invoke(__value0);
            }
            else if (ExprVariant2 is { } __value1)
            {
                exprVariant2?.Invoke(__value1);
            }
            else if (ExprVariant3 is { } __value2)
            {
                exprVariant3?.Invoke(__value2);
            }
            else if (VectorDist is { } __value3)
            {
                vectorDist?.Invoke(__value3);
            }
            else if (Highlight is { } __value4)
            {
                highlight?.Invoke(__value4);
            }
            else if (HighlightWithConfig is { } __value5)
            {
                highlightWithConfig?.Invoke(__value5);
            }
            else if (Score is { } __value6)
            {
                score?.Invoke(__value6);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Turbopuffer.ExprRefNew>? refNew = null,
            global::System.Action<byte[]>? exprVariant2 = null,
            global::System.Action<byte[]>? exprVariant3 = null,
            global::System.Action<byte[]>? vectorDist = null,
            global::System.Action<byte[]>? highlight = null,
            global::System.Action<byte[]>? highlightWithConfig = null,
            global::System.Action<global::Turbopuffer.RankBy?>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RefNew is { } __value0)
            {
                refNew?.Invoke(__value0);
            }
            else if (ExprVariant2 is { } __value1)
            {
                exprVariant2?.Invoke(__value1);
            }
            else if (ExprVariant3 is { } __value2)
            {
                exprVariant3?.Invoke(__value2);
            }
            else if (VectorDist is { } __value3)
            {
                vectorDist?.Invoke(__value3);
            }
            else if (Highlight is { } __value4)
            {
                highlight?.Invoke(__value4);
            }
            else if (HighlightWithConfig is { } __value5)
            {
                highlightWithConfig?.Invoke(__value5);
            }
            else if (Score is { } __value6)
            {
                score?.Invoke(__value6);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RefNew,
                typeof(global::Turbopuffer.ExprRefNew),
                ExprVariant2,
                typeof(byte[]),
                ExprVariant3,
                typeof(byte[]),
                VectorDist,
                typeof(byte[]),
                Highlight,
                typeof(byte[]),
                HighlightWithConfig,
                typeof(byte[]),
                Score,
                typeof(global::Turbopuffer.RankBy),
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
        public bool Equals(Expr other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Turbopuffer.ExprRefNew?>.Default.Equals(RefNew, other.RefNew) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(ExprVariant2, other.ExprVariant2) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(ExprVariant3, other.ExprVariant3) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(VectorDist, other.VectorDist) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Highlight, other.Highlight) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(HighlightWithConfig, other.HighlightWithConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Turbopuffer.RankBy?>.Default.Equals(Score, other.Score)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Expr obj1, Expr obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Expr>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Expr obj1, Expr obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Expr o && Equals(o);
        }
    }
}
