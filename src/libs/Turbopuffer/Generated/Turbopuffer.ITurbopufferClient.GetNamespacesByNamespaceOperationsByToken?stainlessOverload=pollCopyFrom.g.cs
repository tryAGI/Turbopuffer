#nullable enable

namespace Turbopuffer
{
    public partial interface ITurbopufferClient
    {
        /// <summary>
        /// Retrieve the current status of a copy operation.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="token"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Turbopuffer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Turbopuffer.CopyFromNamespaceOperation> GetNamespacesByNamespaceOperationsByToken?stainlessOverload=pollCopyFromAsync(
            string @namespace,
            string token,
            global::Turbopuffer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve the current status of a copy operation.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="token"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Turbopuffer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Turbopuffer.AutoSDKHttpResponse<global::Turbopuffer.CopyFromNamespaceOperation>> GetNamespacesByNamespaceOperationsByToken?stainlessOverload=pollCopyFromAsResponseAsync(
            string @namespace,
            string token,
            global::Turbopuffer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}