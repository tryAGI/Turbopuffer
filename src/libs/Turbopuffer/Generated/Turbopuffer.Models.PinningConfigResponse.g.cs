#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Configuration for namespace pinning, along with the current status of the pinned namespace.
    /// </summary>
    public readonly partial struct PinningConfigResponse : global::System.IEquatable<PinningConfigResponse>
    {
        /// <summary>
        /// Configuration for namespace pinning.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Turbopuffer.PinningConfig? PinningConfig { get; init; }
#else
        public global::Turbopuffer.PinningConfig? PinningConfig { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PinningConfig))]
#endif
        public bool IsPinningConfig => PinningConfig != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPinningConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Turbopuffer.PinningConfig? value)
        {
            value = PinningConfig;
            return IsPinningConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.PinningConfig PickPinningConfig() => PinningConfig is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PinningConfig' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Turbopuffer.PinningConfigResponseVariant2? PinningConfigResponseVariant2 { get; init; }
#else
        public global::Turbopuffer.PinningConfigResponseVariant2? PinningConfigResponseVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PinningConfigResponseVariant2))]
#endif
        public bool IsPinningConfigResponseVariant2 => PinningConfigResponseVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPinningConfigResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Turbopuffer.PinningConfigResponseVariant2? value)
        {
            value = PinningConfigResponseVariant2;
            return IsPinningConfigResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.PinningConfigResponseVariant2 PickPinningConfigResponseVariant2() => PinningConfigResponseVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PinningConfigResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PinningConfigResponse(global::Turbopuffer.PinningConfig value) => new PinningConfigResponse((global::Turbopuffer.PinningConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Turbopuffer.PinningConfig?(PinningConfigResponse @this) => @this.PinningConfig;

        /// <summary>
        ///
        /// </summary>
        public PinningConfigResponse(global::Turbopuffer.PinningConfig? value)
        {
            PinningConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PinningConfigResponse FromPinningConfig(global::Turbopuffer.PinningConfig? value) => new PinningConfigResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PinningConfigResponse(global::Turbopuffer.PinningConfigResponseVariant2 value) => new PinningConfigResponse((global::Turbopuffer.PinningConfigResponseVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Turbopuffer.PinningConfigResponseVariant2?(PinningConfigResponse @this) => @this.PinningConfigResponseVariant2;

        /// <summary>
        ///
        /// </summary>
        public PinningConfigResponse(global::Turbopuffer.PinningConfigResponseVariant2? value)
        {
            PinningConfigResponseVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PinningConfigResponse FromPinningConfigResponseVariant2(global::Turbopuffer.PinningConfigResponseVariant2? value) => new PinningConfigResponse(value);

        /// <summary>
        ///
        /// </summary>
        public PinningConfigResponse(
            global::Turbopuffer.PinningConfig? pinningConfig,
            global::Turbopuffer.PinningConfigResponseVariant2? pinningConfigResponseVariant2
            )
        {
            PinningConfig = pinningConfig;
            PinningConfigResponseVariant2 = pinningConfigResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PinningConfigResponseVariant2 as object ??
            PinningConfig as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PinningConfig?.ToString() ??
            PinningConfigResponseVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPinningConfig && IsPinningConfigResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Turbopuffer.PinningConfig, TResult>? pinningConfig = null,
            global::System.Func<global::Turbopuffer.PinningConfigResponseVariant2, TResult>? pinningConfigResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PinningConfig is { } __value0 && pinningConfig != null)
            {
                return pinningConfig(__value0);
            }
            else if (PinningConfigResponseVariant2 is { } __value1 && pinningConfigResponseVariant2 != null)
            {
                return pinningConfigResponseVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Turbopuffer.PinningConfig>? pinningConfig = null,

            global::System.Action<global::Turbopuffer.PinningConfigResponseVariant2>? pinningConfigResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PinningConfig is { } __value0)
            {
                pinningConfig?.Invoke(__value0);
            }
            else if (PinningConfigResponseVariant2 is { } __value1)
            {
                pinningConfigResponseVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Turbopuffer.PinningConfig>? pinningConfig = null,
            global::System.Action<global::Turbopuffer.PinningConfigResponseVariant2>? pinningConfigResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PinningConfig is { } __value0)
            {
                pinningConfig?.Invoke(__value0);
            }
            else if (PinningConfigResponseVariant2 is { } __value1)
            {
                pinningConfigResponseVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PinningConfig,
                typeof(global::Turbopuffer.PinningConfig),
                PinningConfigResponseVariant2,
                typeof(global::Turbopuffer.PinningConfigResponseVariant2),
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
        public bool Equals(PinningConfigResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Turbopuffer.PinningConfig?>.Default.Equals(PinningConfig, other.PinningConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Turbopuffer.PinningConfigResponseVariant2?>.Default.Equals(PinningConfigResponseVariant2, other.PinningConfigResponseVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PinningConfigResponse obj1, PinningConfigResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PinningConfigResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PinningConfigResponse obj1, PinningConfigResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PinningConfigResponse o && Equals(o);
        }
    }
}
