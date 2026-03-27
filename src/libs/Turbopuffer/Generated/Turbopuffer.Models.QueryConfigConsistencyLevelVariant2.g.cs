
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Eventual consistency. Does not require a round-trip to object storage, but may not see the latest writes.
    /// </summary>
    public sealed partial class QueryConfigConsistencyLevelVariant2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}