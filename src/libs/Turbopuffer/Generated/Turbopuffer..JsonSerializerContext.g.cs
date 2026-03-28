
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Turbopuffer
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Turbopuffer.JsonConverters.QueryResultJsonConverter),

            typeof(global::Turbopuffer.JsonConverters.IdJsonConverter),

            typeof(global::Turbopuffer.JsonConverters.Vector2JsonConverter),

            typeof(global::Turbopuffer.JsonConverters.VectorEncodingJsonConverter),

            typeof(global::Turbopuffer.JsonConverters.DistanceMetricJsonConverter),

            typeof(global::Turbopuffer.JsonConverters.IncludeAttributesJsonConverter),

            typeof(global::Turbopuffer.JsonConverters.AttributeSchemaJsonConverter),

            typeof(global::Turbopuffer.JsonConverters.FullTextSearchJsonConverter),

            typeof(global::Turbopuffer.JsonConverters.LanguageJsonConverter),

            typeof(global::Turbopuffer.JsonConverters.TokenizerJsonConverter),

            typeof(global::Turbopuffer.JsonConverters.AnnJsonConverter),

            typeof(global::Turbopuffer.JsonConverters.AggregateByJsonConverter),

            typeof(global::Turbopuffer.JsonConverters.ExprJsonConverter),

            typeof(global::Turbopuffer.JsonConverters.FilterJsonConverter),

            typeof(global::Turbopuffer.JsonConverters.RankByTextJsonConverter),

            typeof(global::Turbopuffer.JsonConverters.RankByAttributeOrderJsonConverter),

            typeof(global::Turbopuffer.JsonConverters.RankByJsonConverter),

            typeof(global::Turbopuffer.JsonConverters.OneOfJsonConverter<global::Turbopuffer.NamespaceMetadataEncryptionVariant1, global::Turbopuffer.NamespaceMetadataEncryptionVariant2>),

            typeof(global::Turbopuffer.JsonConverters.OneOfJsonConverter<global::Turbopuffer.NamespaceMetadataIndexIndexUpToDate, global::Turbopuffer.NamespaceMetadataIndexIndexUpdating>),

            typeof(global::Turbopuffer.JsonConverters.OneOfJsonConverter<string, global::Turbopuffer.WriteCopyFromNamespace>),

            typeof(global::Turbopuffer.JsonConverters.AnyOfJsonConverter<int?, global::Turbopuffer.Limit2>),

            typeof(global::Turbopuffer.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Turbopuffer.Vector2>, global::Turbopuffer.Vector2?>),

            typeof(global::Turbopuffer.JsonConverters.AllOfJsonConverter<global::Turbopuffer.QueryConfig, global::Turbopuffer.Query>),

            typeof(global::Turbopuffer.JsonConverters.AllOfJsonConverter<global::Turbopuffer.QueryConfig, global::Turbopuffer.Query>),

            typeof(global::Turbopuffer.JsonConverters.AllOfJsonConverter<global::Turbopuffer.QueryConfig, global::Turbopuffer.CreateNamespacesMultiQueryRequest2>),

            typeof(global::Turbopuffer.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.NamespaceSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.NamespaceMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.AttributeSchemaConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.AttributeSchemaConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.OneOf<global::Turbopuffer.NamespaceMetadataEncryptionVariant1, global::Turbopuffer.NamespaceMetadataEncryptionVariant2>), TypeInfoPropertyName = "OneOfNamespaceMetadataEncryptionVariant1NamespaceMetadataEncryptionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.NamespaceMetadataEncryptionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.NamespaceMetadataEncryptionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.NamespaceMetadataEncryptionVariant2Cmek))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.OneOf<global::Turbopuffer.NamespaceMetadataIndexIndexUpToDate, global::Turbopuffer.NamespaceMetadataIndexIndexUpdating>), TypeInfoPropertyName = "OneOfNamespaceMetadataIndexIndexUpToDateNamespaceMetadataIndexIndexUpdating2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.NamespaceMetadataIndexIndexUpToDate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.NamespaceMetadataIndexIndexUpdating))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.Write))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.Columns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Turbopuffer.Row>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.Row))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Turbopuffer.Id>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.Id), TypeInfoPropertyName = "Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.DistanceMetric), TypeInfoPropertyName = "DistanceMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.AttributeSchema), TypeInfoPropertyName = "AttributeSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.OneOf<string, global::Turbopuffer.WriteCopyFromNamespace>), TypeInfoPropertyName = "OneOfStringWriteCopyFromNamespace2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.WriteCopyFromNamespace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.PatchByFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.Encryption2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.WriteBilling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.QueryBilling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.WriteResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.Query))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.IncludeAttributes), TypeInfoPropertyName = "IncludeAttributes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.AnyOf<int?, global::Turbopuffer.Limit2>), TypeInfoPropertyName = "AnyOfInt32Limit22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.Limit2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.QueryConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.VectorEncoding), TypeInfoPropertyName = "VectorEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.QueryConfigConsistency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.QueryPerformance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.QueryResult), TypeInfoPropertyName = "QueryResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.SingleQueryResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.QueryResultVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.MultiQueryResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Turbopuffer.SingleQueryResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.OneOf<global::System.Collections.Generic.IList<global::Turbopuffer.Vector2>, global::Turbopuffer.Vector2?>), TypeInfoPropertyName = "OneOfIListVector2Vector22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Turbopuffer.Vector2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.Vector2), TypeInfoPropertyName = "Vector22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.LimitPer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.FullTextSearch), TypeInfoPropertyName = "FullTextSearch2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.Ann), TypeInfoPropertyName = "Ann2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.FullTextSearchConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.Language), TypeInfoPropertyName = "Language2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.Tokenizer), TypeInfoPropertyName = "Tokenizer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.AnnConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.EncryptionCmek))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.AggregateBy), TypeInfoPropertyName = "AggregateBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.Expr), TypeInfoPropertyName = "Expr2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.ExprRefNew))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.Bm25ClauseParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.ContainsAllTokensFilterParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.ContainsAnyTokenFilterParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.SaturateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.DecayParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.Filter), TypeInfoPropertyName = "Filter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.RankByText), TypeInfoPropertyName = "RankByText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.RankByAttributeOrder), TypeInfoPropertyName = "RankByAttributeOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.RankBy), TypeInfoPropertyName = "RankBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.CreateNamespacesDebugRecallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.AllOf<global::Turbopuffer.QueryConfig, global::Turbopuffer.Query>), TypeInfoPropertyName = "AllOfQueryConfigQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.AllOf<global::Turbopuffer.QueryConfig, global::Turbopuffer.CreateNamespacesMultiQueryRequest2>), TypeInfoPropertyName = "AllOfQueryConfigCreateNamespacesMultiQueryRequest22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.CreateNamespacesMultiQueryRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Turbopuffer.Query>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.GetNamespacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Turbopuffer.NamespaceSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.GetNamespacesHintCacheWarmResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.CreateNamespacesDebugRecallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Turbopuffer.CreateNamespacesDebugRecallResponseGroundTruthItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.CreateNamespacesDebugRecallResponseGroundTruthItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.DeleteNamespacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.CreateNamespacesExplainQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Turbopuffer.Row>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Turbopuffer.Id>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Turbopuffer.SingleQueryResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Turbopuffer.OneOf<global::System.Collections.Generic.List<global::Turbopuffer.Vector2>, global::Turbopuffer.Vector2?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Turbopuffer.Vector2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Turbopuffer.Query>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Turbopuffer.NamespaceSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Turbopuffer.CreateNamespacesDebugRecallResponseGroundTruthItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}