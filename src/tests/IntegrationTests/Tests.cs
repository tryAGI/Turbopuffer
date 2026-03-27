namespace Turbopuffer.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static TurbopufferClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("TURBOPUFFER_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("TURBOPUFFER_API_KEY environment variable is not found.");

        var client = new TurbopufferClient(apiKey);
        
        return client;
    }
}
