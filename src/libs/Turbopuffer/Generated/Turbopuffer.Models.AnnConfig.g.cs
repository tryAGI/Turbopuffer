
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Configuration options for ANN (Approximate Nearest Neighbor) indexing.
    /// </summary>
    public sealed partial class AnnConfig
    {
        /// <summary>
        /// A function used to calculate vector similarity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance_metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Turbopuffer.JsonConverters.DistanceMetricJsonConverter))]
        public global::Turbopuffer.DistanceMetric? DistanceMetric { get; set; }

        /// <summary>
        /// Opt in to late-interaction (MUVERA) indexing. Only valid on fixed-dim `[][N]f32` vector array attributes, and is required to enable an ANN index on such attributes. Defaults to `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("late_interaction")]
        public bool? LateInteraction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnConfig" /> class.
        /// </summary>
        /// <param name="distanceMetric">
        /// A function used to calculate vector similarity.
        /// </param>
        /// <param name="lateInteraction">
        /// Opt in to late-interaction (MUVERA) indexing. Only valid on fixed-dim `[][N]f32` vector array attributes, and is required to enable an ANN index on such attributes. Defaults to `false`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnConfig(
            global::Turbopuffer.DistanceMetric? distanceMetric,
            bool? lateInteraction)
        {
            this.DistanceMetric = distanceMetric;
            this.LateInteraction = lateInteraction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnConfig" /> class.
        /// </summary>
        public AnnConfig()
        {
        }

    }
}