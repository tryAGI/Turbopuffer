
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Create, update, or delete documents.
    /// </summary>
    public sealed partial class Write
    {
        /// <summary>
        /// A list of documents in columnar format. Each key is a column name, mapped to an array of values for that column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upsert_columns")]
        public global::Turbopuffer.Columns? UpsertColumns { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upsert_rows")]
        public global::System.Collections.Generic.IList<global::Turbopuffer.Row>? UpsertRows { get; set; }

        /// <summary>
        /// A list of documents in columnar format. Each key is a column name, mapped to an array of values for that column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch_columns")]
        public global::Turbopuffer.Columns? PatchColumns { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch_rows")]
        public global::System.Collections.Generic.IList<global::Turbopuffer.Row>? PatchRows { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletes")]
        public global::System.Collections.Generic.IList<global::Turbopuffer.Id>? Deletes { get; set; }

        /// <summary>
        /// A condition evaluated against the current value of each document targeted by an upsert write. Only documents that pass the condition are upserted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upsert_condition")]
        public object? UpsertCondition { get; set; }

        /// <summary>
        /// A condition evaluated against the current value of each document targeted by a patch write. Only documents that pass the condition are patched.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch_condition")]
        public object? PatchCondition { get; set; }

        /// <summary>
        /// A condition evaluated against the current value of each document targeted by a delete write. Only documents that pass the condition are deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_condition")]
        public object? DeleteCondition { get; set; }

        /// <summary>
        /// A function used to calculate vector similarity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance_metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Turbopuffer.JsonConverters.DistanceMetricJsonConverter))]
        public global::Turbopuffer.DistanceMetric? DistanceMetric { get; set; }

        /// <summary>
        /// The schema of the attributes attached to the documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.AttributeSchema>? Schema { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_from_namespace")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Turbopuffer.JsonConverters.BranchFromNamespaceParamsJsonConverter))]
        public global::Turbopuffer.BranchFromNamespaceParams? BranchFromNamespace { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copy_from_namespace")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Turbopuffer.JsonConverters.CopyFromNamespaceParamsJsonConverter))]
        public global::Turbopuffer.CopyFromNamespaceParams? CopyFromNamespace { get; set; }

        /// <summary>
        /// The filter specifying which documents to delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_by_filter")]
        public object? DeleteByFilter { get; set; }

        /// <summary>
        /// Allow partial completion when filter matches too many documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_by_filter_allow_partial")]
        public bool? DeleteByFilterAllowPartial { get; set; }

        /// <summary>
        /// The patch and filter specifying which documents to patch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch_by_filter")]
        public global::Turbopuffer.PatchByFilter? PatchByFilter { get; set; }

        /// <summary>
        /// Allow partial completion when filter matches too many documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch_by_filter_allow_partial")]
        public bool? PatchByFilterAllowPartial { get; set; }

        /// <summary>
        /// If true, return the IDs of affected rows (deleted, patched, upserted) in the response. For filtered and conditional writes, only IDs for writes that succeeded will be included.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_affected_ids")]
        public bool? ReturnAffectedIds { get; set; }

        /// <summary>
        /// The encryption configuration for a namespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encryption")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Turbopuffer.JsonConverters.EncryptionJsonConverter))]
        public global::Turbopuffer.Encryption? Encryption { get; set; }

        /// <summary>
        /// Configuration for namespace sharding, which partitions a namespace's documents across multiple internal shards to scale indexing and query throughput beyond a single machine.<br/>
        /// Sharding can only be configured on a namespace's inaugural write, and cannot be added to or changed on an existing namespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharding")]
        public global::Turbopuffer.ShardingConfig? Sharding { get; set; }

        /// <summary>
        /// Disables write throttling (HTTP 429 responses) during high-volume ingestion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_backpressure")]
        public bool? DisableBackpressure { get; set; }

        /// <summary>
        /// If `true`, ensures the namespace is created, even if the request writes no documents. Creating an empty namespace requires the `id` type to be declared in `schema`. If `false`, a namespace is never created, and a 404 is returned if it does not exist. If omitted, a namespace is created by the first request that writes documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_namespace")]
        public bool? CreateNamespace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Write" /> class.
        /// </summary>
        /// <param name="upsertColumns">
        /// A list of documents in columnar format. Each key is a column name, mapped to an array of values for that column.
        /// </param>
        /// <param name="upsertRows"></param>
        /// <param name="patchColumns">
        /// A list of documents in columnar format. Each key is a column name, mapped to an array of values for that column.
        /// </param>
        /// <param name="patchRows"></param>
        /// <param name="deletes"></param>
        /// <param name="upsertCondition">
        /// A condition evaluated against the current value of each document targeted by an upsert write. Only documents that pass the condition are upserted.
        /// </param>
        /// <param name="patchCondition">
        /// A condition evaluated against the current value of each document targeted by a patch write. Only documents that pass the condition are patched.
        /// </param>
        /// <param name="deleteCondition">
        /// A condition evaluated against the current value of each document targeted by a delete write. Only documents that pass the condition are deleted.
        /// </param>
        /// <param name="distanceMetric">
        /// A function used to calculate vector similarity.
        /// </param>
        /// <param name="schema">
        /// The schema of the attributes attached to the documents.
        /// </param>
        /// <param name="branchFromNamespace"></param>
        /// <param name="copyFromNamespace"></param>
        /// <param name="deleteByFilter">
        /// The filter specifying which documents to delete.
        /// </param>
        /// <param name="deleteByFilterAllowPartial">
        /// Allow partial completion when filter matches too many documents.
        /// </param>
        /// <param name="patchByFilter">
        /// The patch and filter specifying which documents to patch.
        /// </param>
        /// <param name="patchByFilterAllowPartial">
        /// Allow partial completion when filter matches too many documents.
        /// </param>
        /// <param name="returnAffectedIds">
        /// If true, return the IDs of affected rows (deleted, patched, upserted) in the response. For filtered and conditional writes, only IDs for writes that succeeded will be included.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="encryption">
        /// The encryption configuration for a namespace.
        /// </param>
        /// <param name="sharding">
        /// Configuration for namespace sharding, which partitions a namespace's documents across multiple internal shards to scale indexing and query throughput beyond a single machine.<br/>
        /// Sharding can only be configured on a namespace's inaugural write, and cannot be added to or changed on an existing namespace.
        /// </param>
        /// <param name="disableBackpressure">
        /// Disables write throttling (HTTP 429 responses) during high-volume ingestion.
        /// </param>
        /// <param name="createNamespace">
        /// If `true`, ensures the namespace is created, even if the request writes no documents. Creating an empty namespace requires the `id` type to be declared in `schema`. If `false`, a namespace is never created, and a 404 is returned if it does not exist. If omitted, a namespace is created by the first request that writes documents.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Write(
            global::Turbopuffer.Columns? upsertColumns,
            global::System.Collections.Generic.IList<global::Turbopuffer.Row>? upsertRows,
            global::Turbopuffer.Columns? patchColumns,
            global::System.Collections.Generic.IList<global::Turbopuffer.Row>? patchRows,
            global::System.Collections.Generic.IList<global::Turbopuffer.Id>? deletes,
            object? upsertCondition,
            object? patchCondition,
            object? deleteCondition,
            global::Turbopuffer.DistanceMetric? distanceMetric,
            global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.AttributeSchema>? schema,
            global::Turbopuffer.BranchFromNamespaceParams? branchFromNamespace,
            global::Turbopuffer.CopyFromNamespaceParams? copyFromNamespace,
            object? deleteByFilter,
            bool? deleteByFilterAllowPartial,
            global::Turbopuffer.PatchByFilter? patchByFilter,
            bool? patchByFilterAllowPartial,
            bool? returnAffectedIds,
            global::Turbopuffer.Encryption? encryption,
            global::Turbopuffer.ShardingConfig? sharding,
            bool? disableBackpressure,
            bool? createNamespace)
        {
            this.UpsertColumns = upsertColumns;
            this.UpsertRows = upsertRows;
            this.PatchColumns = patchColumns;
            this.PatchRows = patchRows;
            this.Deletes = deletes;
            this.UpsertCondition = upsertCondition;
            this.PatchCondition = patchCondition;
            this.DeleteCondition = deleteCondition;
            this.DistanceMetric = distanceMetric;
            this.Schema = schema;
            this.BranchFromNamespace = branchFromNamespace;
            this.CopyFromNamespace = copyFromNamespace;
            this.DeleteByFilter = deleteByFilter;
            this.DeleteByFilterAllowPartial = deleteByFilterAllowPartial;
            this.PatchByFilter = patchByFilter;
            this.PatchByFilterAllowPartial = patchByFilterAllowPartial;
            this.ReturnAffectedIds = returnAffectedIds;
            this.Encryption = encryption;
            this.Sharding = sharding;
            this.DisableBackpressure = disableBackpressure;
            this.CreateNamespace = createNamespace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Write" /> class.
        /// </summary>
        public Write()
        {
        }

    }
}