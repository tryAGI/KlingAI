namespace KlingAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static KlingAIClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("KLINGAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("KLINGAI_API_KEY environment variable is not found.");

        var client = new KlingAIClient(apiKey);
        
        return client;
    }
}
