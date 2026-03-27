#nullable enable

namespace Turbopuffer
{
    public partial interface ITurbopufferClient
    {
        /// <summary>
        /// Get metadata about a namespace.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Turbopuffer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Turbopuffer.NamespaceMetadata> GetNamespacesByNamespaceMetadataAsync(
            string @namespace,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}