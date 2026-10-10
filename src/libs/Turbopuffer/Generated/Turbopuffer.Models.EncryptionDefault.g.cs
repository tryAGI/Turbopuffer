
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Use the default server-side encryption (SSE).
    /// </summary>
    public sealed partial class EncryptionDefault
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"default"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string Mode { get; set; } = "default";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionDefault" /> class.
        /// </summary>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EncryptionDefault(
            string mode = "default")
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionDefault" /> class.
        /// </summary>
        public EncryptionDefault()
        {
        }

    }
}