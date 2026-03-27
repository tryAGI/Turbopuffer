#nullable enable

namespace Turbopuffer
{
    public partial interface ITurbopufferClient
    {
        /// <summary>
        /// Issue multiple concurrent queries filter or search documents.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Turbopuffer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Turbopuffer.MultiQueryResult> CreateNamespacesByNamespaceMultiQueryAsync(
            string @namespace,

            global::Turbopuffer.AllOf<global::Turbopuffer.QueryConfig, global::Turbopuffer.CreateNamespacesMultiQueryRequest2> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Issue multiple concurrent queries filter or search documents.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Turbopuffer.MultiQueryResult> CreateNamespacesByNamespaceMultiQueryAsync(
            string @namespace,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}