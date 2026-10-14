
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateNamespacesAsyncStainlessOverloadStartCopyFromResponse
    {
        /// <summary>
        /// The token identifying the copy operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespacesAsyncStainlessOverloadStartCopyFromResponse" /> class.
        /// </summary>
        /// <param name="token">
        /// The token identifying the copy operation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateNamespacesAsyncStainlessOverloadStartCopyFromResponse(
            string token)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespacesAsyncStainlessOverloadStartCopyFromResponse" /> class.
        /// </summary>
        public CreateNamespacesAsyncStainlessOverloadStartCopyFromResponse()
        {
        }

    }
}