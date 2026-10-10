#nullable enable

namespace Turbopuffer
{
    public partial interface ITurbopufferClient
    {
        /// <summary>
        /// Start copying all documents from another namespace into this one. Returns an operation token without waiting for the copy to finish. Use the token to poll for progress and the result.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Turbopuffer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Turbopuffer.CreateNamespacesAsyncStainlessOverloadStartCopyFromResponse> CreateNamespacesByNamespaceAsync?stainlessOverload=startCopyFromAsync(
            string @namespace,

            global::Turbopuffer.CopyFromNamespaceRequest request,
            global::Turbopuffer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start copying all documents from another namespace into this one. Returns an operation token without waiting for the copy to finish. Use the token to poll for progress and the result.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Turbopuffer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Turbopuffer.AutoSDKHttpResponse<global::Turbopuffer.CreateNamespacesAsyncStainlessOverloadStartCopyFromResponse>> CreateNamespacesByNamespaceAsync?stainlessOverload=startCopyFromAsResponseAsync(
            string @namespace,

            global::Turbopuffer.CopyFromNamespaceRequest request,
            global::Turbopuffer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start copying all documents from another namespace into this one. Returns an operation token without waiting for the copy to finish. Use the token to poll for progress and the result.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Turbopuffer.CreateNamespacesAsyncStainlessOverloadStartCopyFromResponse> CreateNamespacesByNamespaceAsync?stainlessOverload=startCopyFromAsync(
            string @namespace,
            global::Turbopuffer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}