#nullable enable

namespace Turbopuffer
{
    public partial interface ITurbopufferClient
    {
        /// <summary>
        /// Signal turbopuffer to prepare for low-latency requests.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Turbopuffer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Turbopuffer.GetNamespacesHintCacheWarmResponse> GetNamespacesByNamespaceHintCacheWarmAsync(
            string @namespace,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}