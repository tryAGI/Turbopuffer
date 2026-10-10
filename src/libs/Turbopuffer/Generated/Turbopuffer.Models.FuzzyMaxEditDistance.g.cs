
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// An edit distance threshold for the Fuzzy filter.
    /// </summary>
    public sealed partial class FuzzyMaxEditDistance
    {
        /// <summary>
        /// Minimum number of characters in a query where this distance applies. Must be at least 3 · (distance + 1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_query_chars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinQueryChars { get; set; }

        /// <summary>
        /// The maximum edit distance to allow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Distance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FuzzyMaxEditDistance" /> class.
        /// </summary>
        /// <param name="minQueryChars">
        /// Minimum number of characters in a query where this distance applies. Must be at least 3 · (distance + 1).
        /// </param>
        /// <param name="distance">
        /// The maximum edit distance to allow.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FuzzyMaxEditDistance(
            int minQueryChars,
            int distance)
        {
            this.MinQueryChars = minQueryChars;
            this.Distance = distance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FuzzyMaxEditDistance" /> class.
        /// </summary>
        public FuzzyMaxEditDistance()
        {
        }

    }
}