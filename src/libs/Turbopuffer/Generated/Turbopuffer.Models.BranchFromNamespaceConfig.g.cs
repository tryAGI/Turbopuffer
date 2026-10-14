
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BranchFromNamespaceConfig
    {
        /// <summary>
        /// The namespace to create an instant, copy-on-write clone of.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceNamespace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchFromNamespaceConfig" /> class.
        /// </summary>
        /// <param name="sourceNamespace">
        /// The namespace to create an instant, copy-on-write clone of.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchFromNamespaceConfig(
            string sourceNamespace)
        {
            this.SourceNamespace = sourceNamespace ?? throw new global::System.ArgumentNullException(nameof(sourceNamespace));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchFromNamespaceConfig" /> class.
        /// </summary>
        public BranchFromNamespaceConfig()
        {
        }

    }
}