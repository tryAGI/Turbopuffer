#nullable enable

namespace Turbopuffer
{
    public partial interface ITurbopufferClient
    {
        /// <summary>
        /// Update metadata configuration for a namespace.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Turbopuffer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Turbopuffer.NamespaceMetadata> EditNamespacesByNamespaceMetadataAsync(
            string @namespace,

            global::Turbopuffer.NamespaceMetadataPatch request,
            global::Turbopuffer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update metadata configuration for a namespace.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Turbopuffer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Turbopuffer.AutoSDKHttpResponse<global::Turbopuffer.NamespaceMetadata>> EditNamespacesByNamespaceMetadataAsResponseAsync(
            string @namespace,

            global::Turbopuffer.NamespaceMetadataPatch request,
            global::Turbopuffer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update metadata configuration for a namespace.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="pinning">
        /// Configuration for namespace pinning.<br/>
        /// - Missing field: no change to pinning configuration<br/>
        /// - `null` or `false`: explicitly remove pinning<br/>
        /// - `true`: enable pinning with default configuration<br/>
        /// - Object: set pinning configuration
        /// </param>
        /// <param name="readOnly">
        /// Set to `true` to reject document and schema writes, or `false` to allow them. Writes already in progress may still commit. Metadata updates remain available.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Turbopuffer.NamespaceMetadata> EditNamespacesByNamespaceMetadataAsync(
            string @namespace,
            global::Turbopuffer.OneOf<bool?, global::Turbopuffer.PinningConfig>? pinning = default,
            bool? readOnly = default,
            global::Turbopuffer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}