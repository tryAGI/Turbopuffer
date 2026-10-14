
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Rerank retrieved candidates with a model.
    /// </summary>
    public sealed partial class RerankModelParams
    {
        /// <summary>
        /// Which reranking model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The string attribute to score. Must be included in `include_attributes` in every query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Attribute { get; set; }

        /// <summary>
        /// The query text to score each document against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankModelParams" /> class.
        /// </summary>
        /// <param name="model">
        /// Which reranking model to use.
        /// </param>
        /// <param name="attribute">
        /// The string attribute to score. Must be included in `include_attributes` in every query.
        /// </param>
        /// <param name="query">
        /// The query text to score each document against.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankModelParams(
            string model,
            string attribute,
            string query)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Attribute = attribute ?? throw new global::System.ArgumentNullException(nameof(attribute));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankModelParams" /> class.
        /// </summary>
        public RerankModelParams()
        {
        }

    }
}