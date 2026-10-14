
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OperationError
    {
        /// <summary>
        /// The HTTP status code of the operation's error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// The response to an unsuccessful request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Turbopuffer.ErrorResponse Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationError" /> class.
        /// </summary>
        /// <param name="statusCode">
        /// The HTTP status code of the operation's error.
        /// </param>
        /// <param name="detail">
        /// The response to an unsuccessful request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OperationError(
            int statusCode,
            global::Turbopuffer.ErrorResponse detail)
        {
            this.StatusCode = statusCode;
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationError" /> class.
        /// </summary>
        public OperationError()
        {
        }

    }
}