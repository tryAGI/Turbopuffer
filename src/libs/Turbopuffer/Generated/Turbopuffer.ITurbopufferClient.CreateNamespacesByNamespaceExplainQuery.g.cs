#nullable enable

namespace Turbopuffer
{
    public partial interface ITurbopufferClient
    {
        /// <summary>
        /// Explain a query plan.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Turbopuffer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Turbopuffer.CreateNamespacesExplainQueryResponse> CreateNamespacesByNamespaceExplainQueryAsync(
            string @namespace,

            global::Turbopuffer.AllOf<global::Turbopuffer.QueryConfig, global::Turbopuffer.Query> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Explain a query plan.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Turbopuffer.CreateNamespacesExplainQueryResponse> CreateNamespacesByNamespaceExplainQueryAsync(
            string @namespace,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}