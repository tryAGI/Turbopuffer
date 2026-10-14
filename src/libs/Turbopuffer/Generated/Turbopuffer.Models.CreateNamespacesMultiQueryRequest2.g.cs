
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateNamespacesMultiQueryRequest2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Turbopuffer.Query> Queries { get; set; }

        /// <summary>
        /// How to combine the rows returned by each sub-query into a single ranked list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerank_by")]
        public object? RerankBy { get; set; }

        /// <summary>
        /// Limits the total number of reranked documents returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Turbopuffer.JsonConverters.AnyOfJsonConverter<int?, global::Turbopuffer.RerankLimit>))]
        public global::Turbopuffer.AnyOf<int?, global::Turbopuffer.RerankLimit>? Limit { get; set; }

        /// <summary>
        /// Number of reranked documents to skip before returning results. Requires `rerank_by` and `limit`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespacesMultiQueryRequest2" /> class.
        /// </summary>
        /// <param name="queries"></param>
        /// <param name="rerankBy">
        /// How to combine the rows returned by each sub-query into a single ranked list.
        /// </param>
        /// <param name="limit">
        /// Limits the total number of reranked documents returned.
        /// </param>
        /// <param name="offset">
        /// Number of reranked documents to skip before returning results. Requires `rerank_by` and `limit`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateNamespacesMultiQueryRequest2(
            global::System.Collections.Generic.IList<global::Turbopuffer.Query> queries,
            object? rerankBy,
            global::Turbopuffer.AnyOf<int?, global::Turbopuffer.RerankLimit>? limit,
            int? offset)
        {
            this.Queries = queries ?? throw new global::System.ArgumentNullException(nameof(queries));
            this.RerankBy = rerankBy;
            this.Limit = limit;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespacesMultiQueryRequest2" /> class.
        /// </summary>
        public CreateNamespacesMultiQueryRequest2()
        {
        }

    }
}