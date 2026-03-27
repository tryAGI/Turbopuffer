
#nullable enable

namespace Turbopuffer
{
    public sealed partial class TurbopufferClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingBearer(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Turbopuffer.EndPointAuthorization
            {
                Type = "Http",
                Location = "Header",
                Name = "Bearer",
                Value = apiKey,
            });
        }
    }
}