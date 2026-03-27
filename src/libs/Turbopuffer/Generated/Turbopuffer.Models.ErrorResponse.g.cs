
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// The response to an unsuccessful request.
    /// </summary>
    public sealed partial class ErrorResponse
    {
        /// <summary>
        /// The status of the request.
        /// </summary>
        /// <default>"error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "error";

        /// <summary>
        /// The error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the request.
        /// </param>
        /// <param name="error">
        /// The error message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorResponse(
            string error,
            string status = "error")
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        public ErrorResponse()
        {
        }
    }
}