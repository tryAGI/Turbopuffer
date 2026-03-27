#nullable enable

namespace Turbopuffer
{
    public partial interface ITurbopufferClient
    {
        /// <summary>
        /// Delete namespace.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Turbopuffer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Turbopuffer.DeleteNamespacesResponse> DeleteNamespacesByNamespaceAsync(
            string @namespace,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}