
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Operational status for a pinned namespace.
    /// </summary>
    public sealed partial class PinningStatus
    {
        /// <summary>
        /// The timestamp of the latest pinning status snapshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The number of replicas that are warm and serving traffic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ready_replicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ReadyReplicas { get; set; }

        /// <summary>
        /// The number of running replicas for the namespace. Replicas are billed once running, even before they finish warming their caches and become ready to serve traffic. This count is updated independently and may briefly disagree with the other status fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Replicas { get; set; }

        /// <summary>
        /// Aggregate utilization for the pinned namespace, reported as a value between 0.0 and 1.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utilization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Utilization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PinningStatus" /> class.
        /// </summary>
        /// <param name="updatedAt">
        /// The timestamp of the latest pinning status snapshot.
        /// </param>
        /// <param name="readyReplicas">
        /// The number of replicas that are warm and serving traffic.
        /// </param>
        /// <param name="replicas">
        /// The number of running replicas for the namespace. Replicas are billed once running, even before they finish warming their caches and become ready to serve traffic. This count is updated independently and may briefly disagree with the other status fields.
        /// </param>
        /// <param name="utilization">
        /// Aggregate utilization for the pinned namespace, reported as a value between 0.0 and 1.0.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PinningStatus(
            global::System.DateTime updatedAt,
            long readyReplicas,
            long replicas,
            double utilization)
        {
            this.UpdatedAt = updatedAt;
            this.ReadyReplicas = readyReplicas;
            this.Replicas = replicas;
            this.Utilization = utilization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PinningStatus" /> class.
        /// </summary>
        public PinningStatus()
        {
        }

    }
}