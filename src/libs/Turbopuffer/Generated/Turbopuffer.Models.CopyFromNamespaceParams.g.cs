#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Turbopuffer
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CopyFromNamespaceParams : global::System.IEquatable<CopyFromNamespaceParams>
    {
        /// <summary>
        /// The namespace to copy documents from.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? CopyFromNamespaceParamsVariant1 { get; init; }
#else
        public string? CopyFromNamespaceParamsVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CopyFromNamespaceParamsVariant1))]
#endif
        public bool IsCopyFromNamespaceParamsVariant1 => CopyFromNamespaceParamsVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCopyFromNamespaceParamsVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = CopyFromNamespaceParamsVariant1;
            return IsCopyFromNamespaceParamsVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickCopyFromNamespaceParamsVariant1() => CopyFromNamespaceParamsVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CopyFromNamespaceParamsVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Turbopuffer.CopyFromNamespaceConfig? Config { get; init; }
#else
        public global::Turbopuffer.CopyFromNamespaceConfig? Config { get; }
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
            out global::Turbopuffer.CopyFromNamespaceConfig? value)
        {
            value = Config;
            return IsConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CopyFromNamespaceConfig PickConfig() => Config is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Config' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CopyFromNamespaceParams(string value) => new CopyFromNamespaceParams((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(CopyFromNamespaceParams @this) => @this.CopyFromNamespaceParamsVariant1;

        /// <summary>
        ///
        /// </summary>
        public CopyFromNamespaceParams(string? value)
        {
            CopyFromNamespaceParamsVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CopyFromNamespaceParams FromCopyFromNamespaceParamsVariant1(string? value) => new CopyFromNamespaceParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CopyFromNamespaceParams(global::Turbopuffer.CopyFromNamespaceConfig value) => new CopyFromNamespaceParams((global::Turbopuffer.CopyFromNamespaceConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Turbopuffer.CopyFromNamespaceConfig?(CopyFromNamespaceParams @this) => @this.Config;

        /// <summary>
        ///
        /// </summary>
        public CopyFromNamespaceParams(global::Turbopuffer.CopyFromNamespaceConfig? value)
        {
            Config = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CopyFromNamespaceParams FromConfig(global::Turbopuffer.CopyFromNamespaceConfig? value) => new CopyFromNamespaceParams(value);

        /// <summary>
        ///
        /// </summary>
        public CopyFromNamespaceParams(
            string? copyFromNamespaceParamsVariant1,
            global::Turbopuffer.CopyFromNamespaceConfig? config
            )
        {
            CopyFromNamespaceParamsVariant1 = copyFromNamespaceParamsVariant1;
            Config = config;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Config as object ??
            CopyFromNamespaceParamsVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CopyFromNamespaceParamsVariant1?.ToString() ??
            Config?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCopyFromNamespaceParamsVariant1 && !IsConfig || !IsCopyFromNamespaceParamsVariant1 && IsConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? copyFromNamespaceParamsVariant1 = null,
            global::System.Func<global::Turbopuffer.CopyFromNamespaceConfig, TResult>? config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CopyFromNamespaceParamsVariant1 is { } __value0 && copyFromNamespaceParamsVariant1 != null)
            {
                return copyFromNamespaceParamsVariant1(__value0);
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
            global::System.Action<string>? copyFromNamespaceParamsVariant1 = null,

            global::System.Action<global::Turbopuffer.CopyFromNamespaceConfig>? config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CopyFromNamespaceParamsVariant1 is { } __value0)
            {
                copyFromNamespaceParamsVariant1?.Invoke(__value0);
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
            global::System.Action<string>? copyFromNamespaceParamsVariant1 = null,
            global::System.Action<global::Turbopuffer.CopyFromNamespaceConfig>? config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CopyFromNamespaceParamsVariant1 is { } __value0)
            {
                copyFromNamespaceParamsVariant1?.Invoke(__value0);
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
                CopyFromNamespaceParamsVariant1,
                typeof(string),
                Config,
                typeof(global::Turbopuffer.CopyFromNamespaceConfig),
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
        public bool Equals(CopyFromNamespaceParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(CopyFromNamespaceParamsVariant1, other.CopyFromNamespaceParamsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Turbopuffer.CopyFromNamespaceConfig?>.Default.Equals(Config, other.Config)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CopyFromNamespaceParams obj1, CopyFromNamespaceParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CopyFromNamespaceParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CopyFromNamespaceParams obj1, CopyFromNamespaceParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CopyFromNamespaceParams o && Equals(o);
        }
    }
}
