
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryResultVariant2
    {
        /// <summary>
        /// The performance information for a query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("performance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Turbopuffer.QueryPerformance Performance { get; set; }

        /// <summary>
        /// The billing information for a query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Turbopuffer.QueryBilling Billing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResultVariant2" /> class.
        /// </summary>
        /// <param name="performance">
        /// The performance information for a query.
        /// </param>
        /// <param name="billing">
        /// The billing information for a query.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryResultVariant2(
            global::Turbopuffer.QueryPerformance performance,
            global::Turbopuffer.QueryBilling billing)
        {
            this.Performance = performance ?? throw new global::System.ArgumentNullException(nameof(performance));
            this.Billing = billing ?? throw new global::System.ArgumentNullException(nameof(billing));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResultVariant2" /> class.
        /// </summary>
        public QueryResultVariant2()
        {
        }
    }
}