#nullable enable

namespace Turbopuffer
{
    public partial interface ITurbopufferClient
    {
        /// <summary>
        /// Get namespace schema.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Turbopuffer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::Turbopuffer.AttributeSchemaConfig>> GetNamespacesByNamespaceSchemaAsync(
            string @namespace,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}