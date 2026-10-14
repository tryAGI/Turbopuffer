
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopyFromNamespaceOperationRunning
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"running"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "running";

        /// <summary>
        /// The time at which the operation started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// A freeform description of the operation's progress. May be absent, and its format may change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public string? Progress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFromNamespaceOperationRunning" /> class.
        /// </summary>
        /// <param name="startTime">
        /// The time at which the operation started.
        /// </param>
        /// <param name="progress">
        /// A freeform description of the operation's progress. May be absent, and its format may change.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopyFromNamespaceOperationRunning(
            global::System.DateTime startTime,
            string? progress,
            string status = "running")
        {
            this.Status = status;
            this.StartTime = startTime;
            this.Progress = progress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFromNamespaceOperationRunning" /> class.
        /// </summary>
        public CopyFromNamespaceOperationRunning()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CopyFromNamespaceOperationRunning"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CopyFromNamespaceOperationRunning FromStartTime(global::System.DateTime startTime)
        {
            return new CopyFromNamespaceOperationRunning
            {
                StartTime = startTime,
            };
        }

    }
}