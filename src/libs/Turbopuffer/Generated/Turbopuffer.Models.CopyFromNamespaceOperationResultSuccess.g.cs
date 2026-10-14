
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopyFromNamespaceOperationResultSuccess
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Turbopuffer.WriteResult Success { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFromNamespaceOperationResultSuccess" /> class.
        /// </summary>
        /// <param name="success"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopyFromNamespaceOperationResultSuccess(
            global::Turbopuffer.WriteResult success)
        {
            this.Success = success ?? throw new global::System.ArgumentNullException(nameof(success));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFromNamespaceOperationResultSuccess" /> class.
        /// </summary>
        public CopyFromNamespaceOperationResultSuccess()
        {
        }

    }
}