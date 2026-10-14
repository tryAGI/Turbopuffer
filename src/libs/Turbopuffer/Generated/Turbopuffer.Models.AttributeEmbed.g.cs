#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Whether to automatically embed this string attribute into a vector attribute. Can be a model name, a detailed configuration object, or `null` to remove an existing embedding configuration.
    /// </summary>
    public readonly partial struct AttributeEmbed : global::System.IEquatable<AttributeEmbed>
    {
        /// <summary>
        /// The model to use for embedding. If you only specify a model, turbopuffer will generate a vector attribute for you to store the embedding.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AttributeEmbedVariant1 { get; init; }
#else
        public string? AttributeEmbedVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AttributeEmbedVariant1))]
#endif
        public bool IsAttributeEmbedVariant1 => AttributeEmbedVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAttributeEmbedVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AttributeEmbedVariant1;
            return IsAttributeEmbedVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickAttributeEmbedVariant1() => AttributeEmbedVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AttributeEmbedVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Configuration options for automatic embedding.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Turbopuffer.AttributeEmbedConfig? Config { get; init; }
#else
        public global::Turbopuffer.AttributeEmbedConfig? Config { get; }
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
            out global::Turbopuffer.AttributeEmbedConfig? value)
        {
            value = Config;
            return IsConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AttributeEmbedConfig PickConfig() => Config is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Config' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AttributeEmbed(string value) => new AttributeEmbed((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(AttributeEmbed @this) => @this.AttributeEmbedVariant1;

        /// <summary>
        ///
        /// </summary>
        public AttributeEmbed(string? value)
        {
            AttributeEmbedVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AttributeEmbed FromAttributeEmbedVariant1(string? value) => new AttributeEmbed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AttributeEmbed(global::Turbopuffer.AttributeEmbedConfig value) => new AttributeEmbed((global::Turbopuffer.AttributeEmbedConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Turbopuffer.AttributeEmbedConfig?(AttributeEmbed @this) => @this.Config;

        /// <summary>
        ///
        /// </summary>
        public AttributeEmbed(global::Turbopuffer.AttributeEmbedConfig? value)
        {
            Config = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AttributeEmbed FromConfig(global::Turbopuffer.AttributeEmbedConfig? value) => new AttributeEmbed(value);

        /// <summary>
        ///
        /// </summary>
        public AttributeEmbed(
            string? attributeEmbedVariant1,
            global::Turbopuffer.AttributeEmbedConfig? config
            )
        {
            AttributeEmbedVariant1 = attributeEmbedVariant1;
            Config = config;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Config as object ??
            AttributeEmbedVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AttributeEmbedVariant1?.ToString() ??
            Config?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAttributeEmbedVariant1 && !IsConfig || !IsAttributeEmbedVariant1 && IsConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? attributeEmbedVariant1 = null,
            global::System.Func<global::Turbopuffer.AttributeEmbedConfig, TResult>? config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AttributeEmbedVariant1 is { } __value0 && attributeEmbedVariant1 != null)
            {
                return attributeEmbedVariant1(__value0);
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
            global::System.Action<string>? attributeEmbedVariant1 = null,

            global::System.Action<global::Turbopuffer.AttributeEmbedConfig>? config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AttributeEmbedVariant1 is { } __value0)
            {
                attributeEmbedVariant1?.Invoke(__value0);
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
            global::System.Action<string>? attributeEmbedVariant1 = null,
            global::System.Action<global::Turbopuffer.AttributeEmbedConfig>? config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AttributeEmbedVariant1 is { } __value0)
            {
                attributeEmbedVariant1?.Invoke(__value0);
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
                AttributeEmbedVariant1,
                typeof(string),
                Config,
                typeof(global::Turbopuffer.AttributeEmbedConfig),
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
        public bool Equals(AttributeEmbed other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AttributeEmbedVariant1, other.AttributeEmbedVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Turbopuffer.AttributeEmbedConfig?>.Default.Equals(Config, other.Config)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AttributeEmbed obj1, AttributeEmbed obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AttributeEmbed>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AttributeEmbed obj1, AttributeEmbed obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AttributeEmbed o && Equals(o);
        }
    }
}
