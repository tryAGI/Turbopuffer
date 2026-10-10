
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Configuration options for RRF.
    /// </summary>
    public sealed partial class RrfParams
    {
        /// <summary>
        /// RRF rank constant (`k`). Must be greater than zero. Defaults to `60`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank_constant")]
        public int? RankConstant { get; set; }

        /// <summary>
        /// A positive weight for each subquery, in the same order as `queries`. The number of weights must match the number of subqueries. When omitted, every subquery has a weight of `1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weights")]
        public global::System.Collections.Generic.IList<float>? Weights { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RrfParams" /> class.
        /// </summary>
        /// <param name="rankConstant">
        /// RRF rank constant (`k`). Must be greater than zero. Defaults to `60`.
        /// </param>
        /// <param name="weights">
        /// A positive weight for each subquery, in the same order as `queries`. The number of weights must match the number of subqueries. When omitted, every subquery has a weight of `1`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RrfParams(
            int? rankConstant,
            global::System.Collections.Generic.IList<float>? weights)
        {
            this.RankConstant = rankConstant;
            this.Weights = weights;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RrfParams" /> class.
        /// </summary>
        public RrfParams()
        {
        }

    }
}