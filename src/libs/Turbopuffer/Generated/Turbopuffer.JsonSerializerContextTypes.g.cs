
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Turbopuffer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.NamespaceSummary? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.NamespaceMetadata? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.AttributeSchemaConfig>? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AttributeSchemaConfig? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Encryption? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.OneOf<global::Turbopuffer.NamespaceMetadataIndexIndexUpToDate, global::Turbopuffer.NamespaceMetadataIndexIndexUpdating>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.NamespaceMetadataIndexIndexUpToDate? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.NamespaceMetadataIndexIndexUpdating? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.PinningConfigResponse? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.ShardingConfig? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.NamespaceMetadataPatch? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.OneOf<bool?, global::Turbopuffer.PinningConfig>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.PinningConfig? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Write? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Columns? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Turbopuffer.Row>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Row? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Turbopuffer.Id>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Id? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.DistanceMetric? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.AttributeSchema>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AttributeSchema? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.BranchFromNamespaceParams? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CopyFromNamespaceParams? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.PatchByFilter? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.WriteBilling? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.QueryBilling? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.WritePerformance? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.WriteResult? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Query? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.IncludeAttributes? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AnyOf<int?, global::Turbopuffer.Limit2>? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Limit2? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.QueryConfig? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.VectorEncoding? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.QueryConfigConsistency? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.RerankLimit? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.QueryPerformance? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.QueryResult? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.SingleQueryResult? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.QueryResultVariant2? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.MultiQueryResult? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Turbopuffer.SingleQueryResult>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Turbopuffer.AggregationGroup>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AggregationGroup? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.OneOf<global::System.Collections.Generic.IList<global::Turbopuffer.Vector2>, global::Turbopuffer.Vector2?>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Turbopuffer.Vector2>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Vector2? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.LimitPer? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AttributeSchemaDrop? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.FullTextSearch? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Ann? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.SparseKnn? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AttributeEmbed? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CopyFromNamespaceOperation? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CopyFromNamespaceOperationRunning? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CopyFromNamespaceOperationFinished? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CopyFromNamespaceOperationResult? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CopyFromNamespaceOperationDiscriminator? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CopyFromNamespaceOperationDiscriminatorStatus? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CopyFromNamespaceOperationResultSuccess? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CopyFromNamespaceOperationResultError? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.OperationError? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.ErrorResponse? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CopyFromNamespaceRequest? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CopyFromNamespaceConfig? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CopyFromNamespaceRequestVariant2? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.FullTextSearchConfig? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Language? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Tokenizer? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AnnConfig? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AttributeEmbedConfig? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.SparseDistanceMetric? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.EncryptionCustomerManaged? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.EncryptionDefault? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.PinningConfigResponseVariant2? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.PinningStatus? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AggregateBy? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.GroupBy? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.GroupByFunction>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.GroupByFunction? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Expr? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.ExprRefNew? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.RankBy? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.EmbedParams? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Bm25ClauseParams? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.BranchFromNamespaceConfig? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.ContainsAllTokensFilterParams? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.ContainsAnyTokenFilterParams? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.FuzzyMaxEditDistance? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.FuzzyParams? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Turbopuffer.FuzzyMaxEditDistance>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.SaturateParams? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.DecayParams? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Filter? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.RankByText? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.RankByAttributeOrder? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.RrfParams? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.RerankBy? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.HighlightConfigParams? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.HighlightFragmentBy? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.HighlightOffsetUnits? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.HighlightMatch? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CreateNamespacesDebugRecallRequest? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AllOf<global::Turbopuffer.QueryConfig, global::Turbopuffer.Query>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AllOf<global::Turbopuffer.QueryConfig, global::Turbopuffer.CreateNamespacesMultiQueryRequest2>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CreateNamespacesMultiQueryRequest2? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Turbopuffer.Query>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AnyOf<int?, global::Turbopuffer.RerankLimit>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.GetNamespacesResponse? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Turbopuffer.NamespaceSummary>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.GetNamespacesHintCacheWarmResponse? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CreateNamespacesDebugRecallResponse? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Turbopuffer.CreateNamespacesDebugRecallResponseGroundTruthItem>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CreateNamespacesDebugRecallResponseGroundTruthItem? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.DeleteNamespacesResponse? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CreateNamespacesAsyncStainlessOverloadStartCopyFromResponse? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CreateNamespacesExplainQueryResponse? Type134 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Turbopuffer.Row>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Turbopuffer.Id>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Turbopuffer.SingleQueryResult>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Turbopuffer.AggregationGroup>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.OneOf<global::System.Collections.Generic.List<global::Turbopuffer.Vector2>, global::Turbopuffer.Vector2?>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Turbopuffer.Vector2>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Turbopuffer.FuzzyMaxEditDistance>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<float>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Turbopuffer.Query>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Turbopuffer.NamespaceSummary>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Turbopuffer.CreateNamespacesDebugRecallResponseGroundTruthItem>? ListType16 { get; set; }
    }
}