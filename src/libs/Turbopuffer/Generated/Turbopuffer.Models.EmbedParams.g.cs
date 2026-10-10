
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Additional (optional) parameters for the Embed expression.
    /// </summary>
    public sealed partial class EmbedParams
    {
        /// <summary>
        /// The model to use for embedding, overriding the model configured for the attribute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedParams" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for embedding, overriding the model configured for the attribute.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbedParams(
            string? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedParams" /> class.
        /// </summary>
        public EmbedParams()
        {
        }

    }
}