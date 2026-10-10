
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Configuration for namespace pinning.
    /// </summary>
    public sealed partial class PinningConfig
    {
        /// <summary>
        /// The number of read replicas to provision. Defaults to 1 if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        public long? Replicas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PinningConfig" /> class.
        /// </summary>
        /// <param name="replicas">
        /// The number of read replicas to provision. Defaults to 1 if not specified.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PinningConfig(
            long? replicas)
        {
            this.Replicas = replicas;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PinningConfig" /> class.
        /// </summary>
        public PinningConfig()
        {
        }

    }
}