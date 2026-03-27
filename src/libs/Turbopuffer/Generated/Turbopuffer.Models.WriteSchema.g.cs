
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// The schema of the attributes attached to the documents.
    /// </summary>
    public sealed partial class WriteSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}