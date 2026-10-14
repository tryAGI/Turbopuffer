
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopyFromNamespaceOperationFinished
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"finished"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "finished";

        /// <summary>
        /// The time at which the operation started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// The time at which the operation finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime FinishTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Turbopuffer.JsonConverters.CopyFromNamespaceOperationResultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Turbopuffer.CopyFromNamespaceOperationResult Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFromNamespaceOperationFinished" /> class.
        /// </summary>
        /// <param name="startTime">
        /// The time at which the operation started.
        /// </param>
        /// <param name="finishTime">
        /// The time at which the operation finished.
        /// </param>
        /// <param name="result"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopyFromNamespaceOperationFinished(
            global::System.DateTime startTime,
            global::System.DateTime finishTime,
            global::Turbopuffer.CopyFromNamespaceOperationResult result,
            string status = "finished")
        {
            this.Status = status;
            this.StartTime = startTime;
            this.FinishTime = finishTime;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFromNamespaceOperationFinished" /> class.
        /// </summary>
        public CopyFromNamespaceOperationFinished()
        {
        }

    }
}