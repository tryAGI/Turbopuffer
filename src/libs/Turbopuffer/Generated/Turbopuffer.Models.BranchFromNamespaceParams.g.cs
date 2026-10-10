#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Turbopuffer
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BranchFromNamespaceParams : global::System.IEquatable<BranchFromNamespaceParams>
    {
        /// <summary>
        /// The namespace to create an instant, copy-on-write clone of.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BranchFromNamespaceParamsVariant1 { get; init; }
#else
        public string? BranchFromNamespaceParamsVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BranchFromNamespaceParamsVariant1))]
#endif
        public bool IsBranchFromNamespaceParamsVariant1 => BranchFromNamespaceParamsVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBranchFromNamespaceParamsVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BranchFromNamespaceParamsVariant1;
            return IsBranchFromNamespaceParamsVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBranchFromNamespaceParamsVariant1() => BranchFromNamespaceParamsVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BranchFromNamespaceParamsVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Turbopuffer.BranchFromNamespaceConfig? Config { get; init; }
#else
        public global::Turbopuffer.BranchFromNamespaceConfig? Config { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Config))]
#endif
        public bool IsConfig => Config != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Turbopuffer.BranchFromNamespaceConfig? value)
        {
            value = Config;
            return IsConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.BranchFromNamespaceConfig PickConfig() => Config is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Config' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BranchFromNamespaceParams(string value) => new BranchFromNamespaceParams((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(BranchFromNamespaceParams @this) => @this.BranchFromNamespaceParamsVariant1;

        /// <summary>
        ///
        /// </summary>
        public BranchFromNamespaceParams(string? value)
        {
            BranchFromNamespaceParamsVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BranchFromNamespaceParams FromBranchFromNamespaceParamsVariant1(string? value) => new BranchFromNamespaceParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BranchFromNamespaceParams(global::Turbopuffer.BranchFromNamespaceConfig value) => new BranchFromNamespaceParams((global::Turbopuffer.BranchFromNamespaceConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Turbopuffer.BranchFromNamespaceConfig?(BranchFromNamespaceParams @this) => @this.Config;

        /// <summary>
        ///
        /// </summary>
        public BranchFromNamespaceParams(global::Turbopuffer.BranchFromNamespaceConfig? value)
        {
            Config = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BranchFromNamespaceParams FromConfig(global::Turbopuffer.BranchFromNamespaceConfig? value) => new BranchFromNamespaceParams(value);

        /// <summary>
        ///
        /// </summary>
        public BranchFromNamespaceParams(
            string? branchFromNamespaceParamsVariant1,
            global::Turbopuffer.BranchFromNamespaceConfig? config
            )
        {
            BranchFromNamespaceParamsVariant1 = branchFromNamespaceParamsVariant1;
            Config = config;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Config as object ??
            BranchFromNamespaceParamsVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BranchFromNamespaceParamsVariant1?.ToString() ??
            Config?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBranchFromNamespaceParamsVariant1 && !IsConfig || !IsBranchFromNamespaceParamsVariant1 && IsConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? branchFromNamespaceParamsVariant1 = null,
            global::System.Func<global::Turbopuffer.BranchFromNamespaceConfig, TResult>? config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BranchFromNamespaceParamsVariant1 is { } __value0 && branchFromNamespaceParamsVariant1 != null)
            {
                return branchFromNamespaceParamsVariant1(__value0);
            }
            else if (Config is { } __value1 && config != null)
            {
                return config(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? branchFromNamespaceParamsVariant1 = null,

            global::System.Action<global::Turbopuffer.BranchFromNamespaceConfig>? config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BranchFromNamespaceParamsVariant1 is { } __value0)
            {
                branchFromNamespaceParamsVariant1?.Invoke(__value0);
            }
            else if (Config is { } __value1)
            {
                config?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? branchFromNamespaceParamsVariant1 = null,
            global::System.Action<global::Turbopuffer.BranchFromNamespaceConfig>? config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BranchFromNamespaceParamsVariant1 is { } __value0)
            {
                branchFromNamespaceParamsVariant1?.Invoke(__value0);
            }
            else if (Config is { } __value1)
            {
                config?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BranchFromNamespaceParamsVariant1,
                typeof(string),
                Config,
                typeof(global::Turbopuffer.BranchFromNamespaceConfig),
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
        public bool Equals(BranchFromNamespaceParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BranchFromNamespaceParamsVariant1, other.BranchFromNamespaceParamsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Turbopuffer.BranchFromNamespaceConfig?>.Default.Equals(Config, other.Config)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BranchFromNamespaceParams obj1, BranchFromNamespaceParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BranchFromNamespaceParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BranchFromNamespaceParams obj1, BranchFromNamespaceParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BranchFromNamespaceParams o && Equals(o);
        }
    }
}
