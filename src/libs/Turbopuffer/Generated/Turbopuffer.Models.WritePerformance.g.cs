
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// The performance information for a write request.
    /// </summary>
    public sealed partial class WritePerformance
    {
        /// <summary>
        /// Request time measured on the server, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_total_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ServerTotalMs { get; set; }

        /// <summary>
        /// The number of tokens embedded. Only set when using a native embedding model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_tokens")]
        public int? EmbeddingTokens { get; set; }

        /// <summary>
        /// Time spent embedding text, in milliseconds. Only set when using a native embedding model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_ms")]
        public int? EmbeddingMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WritePerformance" /> class.
        /// </summary>
        /// <param name="serverTotalMs">
        /// Request time measured on the server, in milliseconds.
        /// </param>
        /// <param name="embeddingTokens">
        /// The number of tokens embedded. Only set when using a native embedding model.
        /// </param>
        /// <param name="embeddingMs">
        /// Time spent embedding text, in milliseconds. Only set when using a native embedding model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WritePerformance(
            int serverTotalMs,
            int? embeddingTokens,
            int? embeddingMs)
        {
            this.ServerTotalMs = serverTotalMs;
            this.EmbeddingTokens = embeddingTokens;
            this.EmbeddingMs = embeddingMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WritePerformance" /> class.
        /// </summary>
        public WritePerformance()
        {
        }

    }
}