
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopyFromNamespaceRequestVariant2
    {
        /// <summary>
        /// (Optional) The encryption configuration for the destination namespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dest_encryption")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Turbopuffer.JsonConverters.EncryptionJsonConverter))]
        public global::Turbopuffer.Encryption? DestEncryption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFromNamespaceRequestVariant2" /> class.
        /// </summary>
        /// <param name="destEncryption">
        /// (Optional) The encryption configuration for the destination namespace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopyFromNamespaceRequestVariant2(
            global::Turbopuffer.Encryption? destEncryption)
        {
            this.DestEncryption = destEncryption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFromNamespaceRequestVariant2" /> class.
        /// </summary>
        public CopyFromNamespaceRequestVariant2()
        {
        }

    }
}