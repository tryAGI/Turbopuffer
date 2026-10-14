
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Limits the total number of reranked documents returned.
    /// </summary>
    public sealed partial class RerankLimit
    {
        /// <summary>
        /// Limits the total number of documents returned after reranking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankLimit" /> class.
        /// </summary>
        /// <param name="total">
        /// Limits the total number of documents returned after reranking.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankLimit(
            int total)
        {
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankLimit" /> class.
        /// </summary>
        public RerankLimit()
        {
        }

    }
}