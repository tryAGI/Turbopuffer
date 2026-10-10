
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Configuration for namespace sharding, which partitions a namespace's documents across multiple internal shards to scale indexing and query throughput beyond a single machine.<br/>
    /// Sharding can only be configured on a namespace's inaugural write, and cannot be added to or changed on an existing namespace.
    /// </summary>
    public sealed partial class ShardingConfig
    {
        /// <summary>
        /// The number of shards to partition the namespace into.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_shards")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumShards { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardingConfig" /> class.
        /// </summary>
        /// <param name="numShards">
        /// The number of shards to partition the namespace into.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShardingConfig(
            int numShards)
        {
            this.NumShards = numShards;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardingConfig" /> class.
        /// </summary>
        public ShardingConfig()
        {
        }

    }
}