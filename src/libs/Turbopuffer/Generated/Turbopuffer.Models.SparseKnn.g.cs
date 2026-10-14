
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Whether to create a sparse kNN index for the attribute. Requires the `{}f16` type.
    /// </summary>
    public sealed partial class SparseKnn
    {
        /// <summary>
        /// A function used to calculate sparse vector similarity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance_metric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DistanceMetric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseKnn" /> class.
        /// </summary>
        /// <param name="distanceMetric">
        /// A function used to calculate sparse vector similarity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SparseKnn(
            string distanceMetric)
        {
            this.DistanceMetric = distanceMetric ?? throw new global::System.ArgumentNullException(nameof(distanceMetric));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseKnn" /> class.
        /// </summary>
        public SparseKnn()
        {
        }

    }
}