#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Turbopuffer
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CopyFromNamespaceRequest : global::System.IEquatable<CopyFromNamespaceRequest>
    {
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
#if NET6_0_OR_GREATER
        public global::Turbopuffer.CopyFromNamespaceRequestVariant2? CopyFromNamespaceRequestVariant2 { get; init; }
#else
        public global::Turbopuffer.CopyFromNamespaceRequestVariant2? CopyFromNamespaceRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CopyFromNamespaceRequestVariant2))]
#endif
        public bool IsCopyFromNamespaceRequestVariant2 => CopyFromNamespaceRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCopyFromNamespaceRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Turbopuffer.CopyFromNamespaceRequestVariant2? value)
        {
            value = CopyFromNamespaceRequestVariant2;
            return IsCopyFromNamespaceRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CopyFromNamespaceRequestVariant2 PickCopyFromNamespaceRequestVariant2() => CopyFromNamespaceRequestVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CopyFromNamespaceRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CopyFromNamespaceRequest(global::Turbopuffer.CopyFromNamespaceConfig value) => new CopyFromNamespaceRequest((global::Turbopuffer.CopyFromNamespaceConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Turbopuffer.CopyFromNamespaceConfig?(CopyFromNamespaceRequest @this) => @this.Config;

        /// <summary>
        ///
        /// </summary>
        public CopyFromNamespaceRequest(global::Turbopuffer.CopyFromNamespaceConfig? value)
        {
            Config = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CopyFromNamespaceRequest FromConfig(global::Turbopuffer.CopyFromNamespaceConfig? value) => new CopyFromNamespaceRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CopyFromNamespaceRequest(global::Turbopuffer.CopyFromNamespaceRequestVariant2 value) => new CopyFromNamespaceRequest((global::Turbopuffer.CopyFromNamespaceRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Turbopuffer.CopyFromNamespaceRequestVariant2?(CopyFromNamespaceRequest @this) => @this.CopyFromNamespaceRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public CopyFromNamespaceRequest(global::Turbopuffer.CopyFromNamespaceRequestVariant2? value)
        {
            CopyFromNamespaceRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CopyFromNamespaceRequest FromCopyFromNamespaceRequestVariant2(global::Turbopuffer.CopyFromNamespaceRequestVariant2? value) => new CopyFromNamespaceRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CopyFromNamespaceRequest(
            global::Turbopuffer.CopyFromNamespaceConfig? config,
            global::Turbopuffer.CopyFromNamespaceRequestVariant2? copyFromNamespaceRequestVariant2
            )
        {
            Config = config;
            CopyFromNamespaceRequestVariant2 = copyFromNamespaceRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CopyFromNamespaceRequestVariant2 as object ??
            Config as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Config?.ToString() ??
            CopyFromNamespaceRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsConfig && IsCopyFromNamespaceRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Turbopuffer.CopyFromNamespaceConfig, TResult>? config = null,
            global::System.Func<global::Turbopuffer.CopyFromNamespaceRequestVariant2, TResult>? copyFromNamespaceRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Config is { } __value0 && config != null)
            {
                return config(__value0);
            }
            else if (CopyFromNamespaceRequestVariant2 is { } __value1 && copyFromNamespaceRequestVariant2 != null)
            {
                return copyFromNamespaceRequestVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Turbopuffer.CopyFromNamespaceConfig>? config = null,

            global::System.Action<global::Turbopuffer.CopyFromNamespaceRequestVariant2>? copyFromNamespaceRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Config is { } __value0)
            {
                config?.Invoke(__value0);
            }
            else if (CopyFromNamespaceRequestVariant2 is { } __value1)
            {
                copyFromNamespaceRequestVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Turbopuffer.CopyFromNamespaceConfig>? config = null,
            global::System.Action<global::Turbopuffer.CopyFromNamespaceRequestVariant2>? copyFromNamespaceRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Config is { } __value0)
            {
                config?.Invoke(__value0);
            }
            else if (CopyFromNamespaceRequestVariant2 is { } __value1)
            {
                copyFromNamespaceRequestVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Config,
                typeof(global::Turbopuffer.CopyFromNamespaceConfig),
                CopyFromNamespaceRequestVariant2,
                typeof(global::Turbopuffer.CopyFromNamespaceRequestVariant2),
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
        public bool Equals(CopyFromNamespaceRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Turbopuffer.CopyFromNamespaceConfig?>.Default.Equals(Config, other.Config) &&
                global::System.Collections.Generic.EqualityComparer<global::Turbopuffer.CopyFromNamespaceRequestVariant2?>.Default.Equals(CopyFromNamespaceRequestVariant2, other.CopyFromNamespaceRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CopyFromNamespaceRequest obj1, CopyFromNamespaceRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CopyFromNamespaceRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CopyFromNamespaceRequest obj1, CopyFromNamespaceRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CopyFromNamespaceRequest o && Equals(o);
        }
    }
}
