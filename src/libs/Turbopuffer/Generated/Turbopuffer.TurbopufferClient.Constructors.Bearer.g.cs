
#nullable enable

namespace Turbopuffer
{
    public sealed partial class TurbopufferClient
    {
        /// <inheritdoc cref="TurbopufferClient(global::System.Net.Http.HttpClient?, global::System.Uri?, global::System.Collections.Generic.List{global::Turbopuffer.EndPointAuthorization}?, bool)"/>
        public TurbopufferClient(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Turbopuffer.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(httpClient, baseUri, authorizations, disposeHttpClient)
        {
            Authorizing(HttpClient, ref apiKey);

            AuthorizeUsingBearer(apiKey);

            Authorized(HttpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}