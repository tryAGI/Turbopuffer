
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PinningConfigResponseVariant2
    {
        /// <summary>
        /// Operational status for a pinned namespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::Turbopuffer.PinningStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PinningConfigResponseVariant2" /> class.
        /// </summary>
        /// <param name="status">
        /// Operational status for a pinned namespace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PinningConfigResponseVariant2(
            global::Turbopuffer.PinningStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PinningConfigResponseVariant2" /> class.
        /// </summary>
        public PinningConfigResponseVariant2()
        {
        }

    }
}