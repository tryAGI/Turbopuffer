#nullable enable

namespace Turbopuffer
{
    public partial interface ITurbopufferClient
    {
        /// <summary>
        /// Update namespace schema.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Turbopuffer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.AttributeSchemaConfig>> CreateNamespacesByNamespaceSchemaAsync(
            string @namespace,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update namespace schema.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.AttributeSchemaConfig>> CreateNamespacesByNamespaceSchemaAsync(
            string @namespace,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}