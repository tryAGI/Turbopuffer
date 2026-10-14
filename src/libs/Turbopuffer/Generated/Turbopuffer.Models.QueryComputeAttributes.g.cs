
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Computes additional values on documents returned by a query. Each key is the name of the computed attribute; each value is an expression describing how to compute it.
    /// </summary>
    public sealed partial class QueryComputeAttributes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}