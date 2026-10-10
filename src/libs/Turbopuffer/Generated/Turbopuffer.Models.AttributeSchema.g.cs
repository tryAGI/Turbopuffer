#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// The schema for an attribute attached to a document.
    /// </summary>
    public readonly partial struct AttributeSchema : global::System.IEquatable<AttributeSchema>
    {
        /// <summary>
        /// The data type of the attribute.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AttributeTypeName { get; init; }
#else
        public string? AttributeTypeName { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AttributeTypeName))]
#endif
        public bool IsAttributeTypeName => AttributeTypeName != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAttributeTypeName(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AttributeTypeName;
            return IsAttributeTypeName;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickAttributeTypeName() => AttributeTypeName is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AttributeTypeName' but the value was {ToString()}.");

        /// <summary>
        /// Detailed configuration for an attribute attached to a document.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Turbopuffer.AttributeSchemaConfig? Config { get; init; }
#else
        public global::Turbopuffer.AttributeSchemaConfig? Config { get; }
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
            out global::Turbopuffer.AttributeSchemaConfig? value)
        {
            value = Config;
            return IsConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AttributeSchemaConfig PickConfig() => Config is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Config' but the value was {ToString()}.");

        /// <summary>
        /// Drops the attribute from the namespace. Cannot be combined with other schema settings.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Turbopuffer.AttributeSchemaDrop? Drop { get; init; }
#else
        public global::Turbopuffer.AttributeSchemaDrop? Drop { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Drop))]
#endif
        public bool IsDrop => Drop != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDrop(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Turbopuffer.AttributeSchemaDrop? value)
        {
            value = Drop;
            return IsDrop;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AttributeSchemaDrop PickDrop() => Drop is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Drop' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AttributeSchema(string value) => new AttributeSchema((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(AttributeSchema @this) => @this.AttributeTypeName;

        /// <summary>
        ///
        /// </summary>
        public AttributeSchema(string? value)
        {
            AttributeTypeName = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AttributeSchema FromAttributeTypeName(string? value) => new AttributeSchema(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AttributeSchema(global::Turbopuffer.AttributeSchemaConfig value) => new AttributeSchema((global::Turbopuffer.AttributeSchemaConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Turbopuffer.AttributeSchemaConfig?(AttributeSchema @this) => @this.Config;

        /// <summary>
        ///
        /// </summary>
        public AttributeSchema(global::Turbopuffer.AttributeSchemaConfig? value)
        {
            Config = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AttributeSchema FromConfig(global::Turbopuffer.AttributeSchemaConfig? value) => new AttributeSchema(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AttributeSchema(global::Turbopuffer.AttributeSchemaDrop value) => new AttributeSchema((global::Turbopuffer.AttributeSchemaDrop?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Turbopuffer.AttributeSchemaDrop?(AttributeSchema @this) => @this.Drop;

        /// <summary>
        ///
        /// </summary>
        public AttributeSchema(global::Turbopuffer.AttributeSchemaDrop? value)
        {
            Drop = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AttributeSchema FromDrop(global::Turbopuffer.AttributeSchemaDrop? value) => new AttributeSchema(value);

        /// <summary>
        ///
        /// </summary>
        public AttributeSchema(
            string? attributeTypeName,
            global::Turbopuffer.AttributeSchemaConfig? config,
            global::Turbopuffer.AttributeSchemaDrop? drop
            )
        {
            AttributeTypeName = attributeTypeName;
            Config = config;
            Drop = drop;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Drop as object ??
            Config as object ??
            AttributeTypeName as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AttributeTypeName?.ToString() ??
            Config?.ToString() ??
            Drop?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAttributeTypeName || IsConfig || IsDrop;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? attributeTypeName = null,
            global::System.Func<global::Turbopuffer.AttributeSchemaConfig, TResult>? config = null,
            global::System.Func<global::Turbopuffer.AttributeSchemaDrop, TResult>? drop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AttributeTypeName is { } __value0 && attributeTypeName != null)
            {
                return attributeTypeName(__value0);
            }
            else if (Config is { } __value1 && config != null)
            {
                return config(__value1);
            }
            else if (Drop is { } __value2 && drop != null)
            {
                return drop(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? attributeTypeName = null,

            global::System.Action<global::Turbopuffer.AttributeSchemaConfig>? config = null,

            global::System.Action<global::Turbopuffer.AttributeSchemaDrop>? drop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AttributeTypeName is { } __value0)
            {
                attributeTypeName?.Invoke(__value0);
            }
            else if (Config is { } __value1)
            {
                config?.Invoke(__value1);
            }
            else if (Drop is { } __value2)
            {
                drop?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? attributeTypeName = null,
            global::System.Action<global::Turbopuffer.AttributeSchemaConfig>? config = null,
            global::System.Action<global::Turbopuffer.AttributeSchemaDrop>? drop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AttributeTypeName is { } __value0)
            {
                attributeTypeName?.Invoke(__value0);
            }
            else if (Config is { } __value1)
            {
                config?.Invoke(__value1);
            }
            else if (Drop is { } __value2)
            {
                drop?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AttributeTypeName,
                typeof(string),
                Config,
                typeof(global::Turbopuffer.AttributeSchemaConfig),
                Drop,
                typeof(global::Turbopuffer.AttributeSchemaDrop),
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
        public bool Equals(AttributeSchema other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AttributeTypeName, other.AttributeTypeName) &&
                global::System.Collections.Generic.EqualityComparer<global::Turbopuffer.AttributeSchemaConfig?>.Default.Equals(Config, other.Config) &&
                global::System.Collections.Generic.EqualityComparer<global::Turbopuffer.AttributeSchemaDrop?>.Default.Equals(Drop, other.Drop)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AttributeSchema obj1, AttributeSchema obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AttributeSchema>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AttributeSchema obj1, AttributeSchema obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AttributeSchema o && Equals(o);
        }
    }
}
