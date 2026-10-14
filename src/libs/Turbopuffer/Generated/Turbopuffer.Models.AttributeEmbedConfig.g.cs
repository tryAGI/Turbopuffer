
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Configuration options for automatic embedding.
    /// </summary>
    public sealed partial class AttributeEmbedConfig
    {
        /// <summary>
        /// The name of an existing vector attribute to store embeddings in. If omitted, turbopuffer will generate a computed vector attribute named `$embed_&lt;attribute&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute")]
        public string? Attribute { get; set; }

        /// <summary>
        /// The model to use for embedding. See our documentation for a list of models supported in each region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The dimensionality to embed at. If not set, will pick the default for this model. If you're storing embeddings in an existing attribute, this can be omitted, and may not be set to a value other than the dimensions of that attribute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dims")]
        public int? Dims { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeEmbedConfig" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for embedding. See our documentation for a list of models supported in each region.
        /// </param>
        /// <param name="attribute">
        /// The name of an existing vector attribute to store embeddings in. If omitted, turbopuffer will generate a computed vector attribute named `$embed_&lt;attribute&gt;`.
        /// </param>
        /// <param name="dims">
        /// The dimensionality to embed at. If not set, will pick the default for this model. If you're storing embeddings in an existing attribute, this can be omitted, and may not be set to a value other than the dimensions of that attribute.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttributeEmbedConfig(
            string model,
            string? attribute,
            int? dims)
        {
            this.Attribute = attribute;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Dims = dims;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeEmbedConfig" /> class.
        /// </summary>
        public AttributeEmbedConfig()
        {
        }

    }
}