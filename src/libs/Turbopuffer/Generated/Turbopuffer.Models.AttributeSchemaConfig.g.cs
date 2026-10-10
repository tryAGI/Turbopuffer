
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Detailed configuration for an attribute attached to a document.
    /// </summary>
    public sealed partial class AttributeSchemaConfig
    {
        /// <summary>
        /// The data type of the attribute. Valid values: string, int, uint, float, uuid, datetime, bool, []string, []int, []uint, []float, []uuid, []datetime, []bool, [DIMS]f16, [DIMS]f32, {}f16.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Whether or not the attributes can be used in filters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterable")]
        public bool? Filterable { get; set; }

        /// <summary>
        /// Whether to enable Regex filters on this attribute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regex")]
        public bool? Regex { get; set; }

        /// <summary>
        /// Whether to enable Glob filters on this attribute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("glob")]
        public bool? Glob { get; set; }

        /// <summary>
        /// Whether to enable Fuzzy filters on this attribute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fuzzy")]
        public bool? Fuzzy { get; set; }

        /// <summary>
        /// Whether this attribute can be used as part of a BM25 full-text search. Requires the `string` or `[]string` type, and by default, BM25-enabled attributes are not filterable. You can override this by setting `filterable: true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_text_search")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Turbopuffer.JsonConverters.FullTextSearchJsonConverter))]
        public global::Turbopuffer.FullTextSearch? FullTextSearch { get; set; }

        /// <summary>
        /// Whether to create an approximate nearest neighbor index for the attribute. Can be a boolean or a detailed configuration object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ann")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Turbopuffer.JsonConverters.AnnJsonConverter))]
        public global::Turbopuffer.Ann? Ann { get; set; }

        /// <summary>
        /// Whether to create a sparse kNN index for the attribute. Requires the `{}f16` type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sparse_knn")]
        public global::Turbopuffer.SparseKnn? SparseKnn { get; set; }

        /// <summary>
        /// Whether to automatically embed this string attribute into a vector attribute. Can be a model name, a detailed configuration object, or `null` to remove an existing embedding configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Turbopuffer.JsonConverters.AttributeEmbedJsonConverter))]
        public global::Turbopuffer.AttributeEmbed? Embed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeSchemaConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// The data type of the attribute. Valid values: string, int, uint, float, uuid, datetime, bool, []string, []int, []uint, []float, []uuid, []datetime, []bool, [DIMS]f16, [DIMS]f32, {}f16.
        /// </param>
        /// <param name="filterable">
        /// Whether or not the attributes can be used in filters.
        /// </param>
        /// <param name="regex">
        /// Whether to enable Regex filters on this attribute.
        /// </param>
        /// <param name="glob">
        /// Whether to enable Glob filters on this attribute.
        /// </param>
        /// <param name="fuzzy">
        /// Whether to enable Fuzzy filters on this attribute.
        /// </param>
        /// <param name="fullTextSearch">
        /// Whether this attribute can be used as part of a BM25 full-text search. Requires the `string` or `[]string` type, and by default, BM25-enabled attributes are not filterable. You can override this by setting `filterable: true`.
        /// </param>
        /// <param name="ann">
        /// Whether to create an approximate nearest neighbor index for the attribute. Can be a boolean or a detailed configuration object.
        /// </param>
        /// <param name="sparseKnn">
        /// Whether to create a sparse kNN index for the attribute. Requires the `{}f16` type.
        /// </param>
        /// <param name="embed">
        /// Whether to automatically embed this string attribute into a vector attribute. Can be a model name, a detailed configuration object, or `null` to remove an existing embedding configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttributeSchemaConfig(
            string type,
            bool? filterable,
            bool? regex,
            bool? glob,
            bool? fuzzy,
            global::Turbopuffer.FullTextSearch? fullTextSearch,
            global::Turbopuffer.Ann? ann,
            global::Turbopuffer.SparseKnn? sparseKnn,
            global::Turbopuffer.AttributeEmbed? embed)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Filterable = filterable;
            this.Regex = regex;
            this.Glob = glob;
            this.Fuzzy = fuzzy;
            this.FullTextSearch = fullTextSearch;
            this.Ann = ann;
            this.SparseKnn = sparseKnn;
            this.Embed = embed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeSchemaConfig" /> class.
        /// </summary>
        public AttributeSchemaConfig()
        {
        }

    }
}