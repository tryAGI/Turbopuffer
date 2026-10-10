
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Additional parameters for the Fuzzy filter.
    /// </summary>
    public sealed partial class FuzzyParams
    {
        /// <summary>
        /// Maximum edit distance allowed at each query length. Queries shorter than the first threshold return no matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_edit_distance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Turbopuffer.FuzzyMaxEditDistance> MaxEditDistance { get; set; }

        /// <summary>
        /// Whether searching with Fuzzy filter is case-sensitive. Defaults to `true` (i.e. case-sensitive).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("case_sensitive")]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FuzzyParams" /> class.
        /// </summary>
        /// <param name="maxEditDistance">
        /// Maximum edit distance allowed at each query length. Queries shorter than the first threshold return no matches.
        /// </param>
        /// <param name="caseSensitive">
        /// Whether searching with Fuzzy filter is case-sensitive. Defaults to `true` (i.e. case-sensitive).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FuzzyParams(
            global::System.Collections.Generic.IList<global::Turbopuffer.FuzzyMaxEditDistance> maxEditDistance,
            bool? caseSensitive)
        {
            this.MaxEditDistance = maxEditDistance ?? throw new global::System.ArgumentNullException(nameof(maxEditDistance));
            this.CaseSensitive = caseSensitive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FuzzyParams" /> class.
        /// </summary>
        public FuzzyParams()
        {
        }

    }
}