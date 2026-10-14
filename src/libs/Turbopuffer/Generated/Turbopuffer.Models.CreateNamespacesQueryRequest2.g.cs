
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateNamespacesQueryRequest2
    {
        /// <summary>
        /// Rerank retrieved candidates with a model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerank_by")]
        public global::Turbopuffer.RerankModelParams? RerankBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespacesQueryRequest2" /> class.
        /// </summary>
        /// <param name="rerankBy">
        /// Rerank retrieved candidates with a model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateNamespacesQueryRequest2(
            global::Turbopuffer.RerankModelParams? rerankBy)
        {
            this.RerankBy = rerankBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespacesQueryRequest2" /> class.
        /// </summary>
        public CreateNamespacesQueryRequest2()
        {
        }

    }
}