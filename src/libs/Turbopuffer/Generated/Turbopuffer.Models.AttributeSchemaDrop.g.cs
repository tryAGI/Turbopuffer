
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Drops the attribute from the namespace. Cannot be combined with other schema settings.
    /// </summary>
    public sealed partial class AttributeSchemaDrop
    {
        /// <summary>
        /// Must be `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drop")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Drop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeSchemaDrop" /> class.
        /// </summary>
        /// <param name="drop">
        /// Must be `true`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttributeSchemaDrop(
            bool drop)
        {
            this.Drop = drop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeSchemaDrop" /> class.
        /// </summary>
        public AttributeSchemaDrop()
        {
        }

    }
}