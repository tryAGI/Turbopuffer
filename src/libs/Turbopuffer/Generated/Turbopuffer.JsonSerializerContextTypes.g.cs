
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
        public global::Turbopuffer.OneOf<global::Turbopuffer.NamespaceMetadataEncryptionVariant1, global::Turbopuffer.NamespaceMetadataEncryptionVariant2>? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.NamespaceMetadataEncryptionVariant1? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.NamespaceMetadataEncryptionVariant2? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.NamespaceMetadataEncryptionVariant2Cmek? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.OneOf<global::Turbopuffer.NamespaceMetadataIndexIndexUpToDate, global::Turbopuffer.NamespaceMetadataIndexIndexUpdating>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.NamespaceMetadataIndexIndexUpToDate? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.NamespaceMetadataIndexIndexUpdating? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Write? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Columns? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Turbopuffer.Row>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Row? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Turbopuffer.Id>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Id? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.DistanceMetric? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.AttributeSchema>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AttributeSchema? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.OneOf<string, global::Turbopuffer.WriteCopyFromNamespace>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.WriteCopyFromNamespace? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.PatchByFilter? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Encryption2? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.WriteBilling? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.QueryBilling? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.WriteResult? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Query? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.IncludeAttributes? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AnyOf<int?, global::Turbopuffer.Limit2>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Limit2? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.QueryConfig? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.VectorEncoding? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.QueryConfigConsistency? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.QueryPerformance? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.QueryResult? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.SingleQueryResult? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.QueryResultVariant2? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.MultiQueryResult? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Turbopuffer.SingleQueryResult>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Turbopuffer.AggregationGroup>? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AggregationGroup? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.OneOf<global::System.Collections.Generic.IList<global::Turbopuffer.Vector2>, global::Turbopuffer.Vector2?>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Turbopuffer.Vector2>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Vector2? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.LimitPer? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.FullTextSearch? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Ann? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.FullTextSearchConfig? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Language? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Tokenizer? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AnnConfig? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.EncryptionCmek? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.ErrorResponse? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AggregateBy? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Expr? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.ExprRefNew? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Bm25ClauseParams? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.ContainsAllTokensFilterParams? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.ContainsAnyTokenFilterParams? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.SaturateParams? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.DecayParams? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.Filter? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.RankByText? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.RankByAttributeOrder? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.RankBy? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CreateNamespacesDebugRecallRequest? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AllOf<global::Turbopuffer.QueryConfig, global::Turbopuffer.Query>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.AllOf<global::Turbopuffer.QueryConfig, global::Turbopuffer.CreateNamespacesMultiQueryRequest2>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CreateNamespacesMultiQueryRequest2? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Turbopuffer.Query>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.GetNamespacesResponse? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Turbopuffer.NamespaceSummary>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.GetNamespacesHintCacheWarmResponse? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CreateNamespacesDebugRecallResponse? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Turbopuffer.CreateNamespacesDebugRecallResponseGroundTruthItem>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CreateNamespacesDebugRecallResponseGroundTruthItem? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.DeleteNamespacesResponse? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CreateNamespacesExplainQueryResponse? Type91 { get; set; }

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
        public global::System.Collections.Generic.List<global::Turbopuffer.SingleQueryResult>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Turbopuffer.AggregationGroup>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType5 { get; set; }
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
        public global::System.Collections.Generic.List<byte[]>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Turbopuffer.Query>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Turbopuffer.NamespaceSummary>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Turbopuffer.CreateNamespacesDebugRecallResponseGroundTruthItem>? ListType12 { get; set; }
    }
}