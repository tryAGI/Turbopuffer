
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// A single matched fragment for a `Highlight` compute attribute. A `Highlight` compute attribute's value in the response is an array of these objects, one per matching fragment.
    /// </summary>
    public sealed partial class HighlightMatch
    {
        /// <summary>
        /// The text of the matched fragment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The `[start, end]` offset of this fragment within the original attribute value, in the units requested by `include_offsets`. Omitted if `include_offsets` was not set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fragment_range")]
        public global::System.Collections.Generic.IList<int>? FragmentRange { get; set; }

        /// <summary>
        /// The `[start, end]` offsets of matched spans within `text`, in the units requested by `include_offsets`. Omitted if `include_offsets` was not set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match_ranges")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? MatchRanges { get; set; }

        /// <summary>
        /// The index into the array, if the highlighted attribute is an array of strings. Omitted for non-array attributes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("array_index")]
        public int? ArrayIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HighlightMatch" /> class.
        /// </summary>
        /// <param name="text">
        /// The text of the matched fragment.
        /// </param>
        /// <param name="fragmentRange">
        /// The `[start, end]` offset of this fragment within the original attribute value, in the units requested by `include_offsets`. Omitted if `include_offsets` was not set.
        /// </param>
        /// <param name="matchRanges">
        /// The `[start, end]` offsets of matched spans within `text`, in the units requested by `include_offsets`. Omitted if `include_offsets` was not set.
        /// </param>
        /// <param name="arrayIndex">
        /// The index into the array, if the highlighted attribute is an array of strings. Omitted for non-array attributes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HighlightMatch(
            string text,
            global::System.Collections.Generic.IList<int>? fragmentRange,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? matchRanges,
            int? arrayIndex)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.FragmentRange = fragmentRange;
            this.MatchRanges = matchRanges;
            this.ArrayIndex = arrayIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HighlightMatch" /> class.
        /// </summary>
        public HighlightMatch()
        {
        }

    }
}