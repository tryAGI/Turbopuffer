
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// A single document, in a row-based format.
    /// </summary>
    public sealed partial class Row
    {
        /// <summary>
        /// An identifier for a document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Turbopuffer.JsonConverters.IdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Turbopuffer.Id Id { get; set; }

        /// <summary>
        /// A vector embedding associated with a document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Turbopuffer.JsonConverters.Vector2JsonConverter))]
        public global::Turbopuffer.Vector2? Vector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Row" /> class.
        /// </summary>
        /// <param name="id">
        /// An identifier for a document.
        /// </param>
        /// <param name="vector">
        /// A vector embedding associated with a document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Row(
            global::Turbopuffer.Id id,
            global::Turbopuffer.Vector2? vector)
        {
            this.Id = id;
            this.Vector = vector;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Row" /> class.
        /// </summary>
        public Row()
        {
        }
    }
}