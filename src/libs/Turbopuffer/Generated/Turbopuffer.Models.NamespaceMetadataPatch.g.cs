
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Request to update namespace metadata configuration.
    /// </summary>
    public sealed partial class NamespaceMetadataPatch
    {
        /// <summary>
        /// Configuration for namespace pinning.<br/>
        /// - Missing field: no change to pinning configuration<br/>
        /// - `null` or `false`: explicitly remove pinning<br/>
        /// - `true`: enable pinning with default configuration<br/>
        /// - Object: set pinning configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pinning")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Turbopuffer.JsonConverters.OneOfJsonConverter<bool?, global::Turbopuffer.PinningConfig>))]
        public global::Turbopuffer.OneOf<bool?, global::Turbopuffer.PinningConfig>? Pinning { get; set; }

        /// <summary>
        /// Set to `true` to reject document and schema writes, or `false` to allow them. Writes already in progress may still commit. Metadata updates remain available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceMetadataPatch" /> class.
        /// </summary>
        /// <param name="pinning">
        /// Configuration for namespace pinning.<br/>
        /// - Missing field: no change to pinning configuration<br/>
        /// - `null` or `false`: explicitly remove pinning<br/>
        /// - `true`: enable pinning with default configuration<br/>
        /// - Object: set pinning configuration
        /// </param>
        /// <param name="readOnly">
        /// Set to `true` to reject document and schema writes, or `false` to allow them. Writes already in progress may still commit. Metadata updates remain available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamespaceMetadataPatch(
            global::Turbopuffer.OneOf<bool?, global::Turbopuffer.PinningConfig>? pinning,
            bool? readOnly)
        {
            this.Pinning = pinning;
            this.ReadOnly = readOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceMetadataPatch" /> class.
        /// </summary>
        public NamespaceMetadataPatch()
        {
        }

    }
}