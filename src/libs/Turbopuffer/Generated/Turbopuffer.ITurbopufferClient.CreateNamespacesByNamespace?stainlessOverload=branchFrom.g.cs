#nullable enable

namespace Turbopuffer
{
    public partial interface ITurbopufferClient
    {
        /// <summary>
        /// Creates an instant, copy-on-write clone of a namespace.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Turbopuffer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Turbopuffer.WriteResult> CreateNamespacesByNamespace?stainlessOverload=branchFromAsync(
            string @namespace,

            global::Turbopuffer.BranchFromNamespaceConfig request,
            global::Turbopuffer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates an instant, copy-on-write clone of a namespace.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Turbopuffer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Turbopuffer.AutoSDKHttpResponse<global::Turbopuffer.WriteResult>> CreateNamespacesByNamespace?stainlessOverload=branchFromAsResponseAsync(
            string @namespace,

            global::Turbopuffer.BranchFromNamespaceConfig request,
            global::Turbopuffer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates an instant, copy-on-write clone of a namespace.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="sourceNamespace">
        /// The namespace to create an instant, copy-on-write clone of.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Turbopuffer.WriteResult> CreateNamespacesByNamespace?stainlessOverload=branchFromAsync(
            string @namespace,
            string sourceNamespace,
            global::Turbopuffer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}