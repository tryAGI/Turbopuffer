
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Additional (optional) parameters for the Highlight compute expression.
    /// </summary>
    public sealed partial class HighlightConfigParams
    {
        /// <summary>
        /// How to rank candidate fragments within the attribute before selecting the top `fragment_limit`. Defaults to the query's `rank_by`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank_fragments_by")]
        public object? RankFragmentsBy { get; set; }

        /// <summary>
        /// How to split a text attribute into fragments for highlighting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fragment_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Turbopuffer.JsonConverters.HighlightFragmentByJsonConverter))]
        public global::Turbopuffer.HighlightFragmentBy? FragmentBy { get; set; }

        /// <summary>
        /// The maximum number of fragments to return. Defaults to `3`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fragment_limit")]
        public int? FragmentLimit { get; set; }

        /// <summary>
        /// The units to report highlighted fragment offsets in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_offsets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Turbopuffer.JsonConverters.HighlightOffsetUnitsJsonConverter))]
        public global::Turbopuffer.HighlightOffsetUnits? IncludeOffsets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HighlightConfigParams" /> class.
        /// </summary>
        /// <param name="rankFragmentsBy">
        /// How to rank candidate fragments within the attribute before selecting the top `fragment_limit`. Defaults to the query's `rank_by`.
        /// </param>
        /// <param name="fragmentBy">
        /// How to split a text attribute into fragments for highlighting.
        /// </param>
        /// <param name="fragmentLimit">
        /// The maximum number of fragments to return. Defaults to `3`.
        /// </param>
        /// <param name="includeOffsets">
        /// The units to report highlighted fragment offsets in.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HighlightConfigParams(
            object? rankFragmentsBy,
            global::Turbopuffer.HighlightFragmentBy? fragmentBy,
            int? fragmentLimit,
            global::Turbopuffer.HighlightOffsetUnits? includeOffsets)
        {
            this.RankFragmentsBy = rankFragmentsBy;
            this.FragmentBy = fragmentBy;
            this.FragmentLimit = fragmentLimit;
            this.IncludeOffsets = includeOffsets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HighlightConfigParams" /> class.
        /// </summary>
        public HighlightConfigParams()
        {
        }

    }
}