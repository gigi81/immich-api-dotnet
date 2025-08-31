namespace Immich.Client.Tests;

public class ImmichClientTest
{
    [Fact]
    public void Can_Create_Client()
    {
        using var httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri("http://localhost:5001");
        
        var client = new ImmichClient(httpClient);
        client.ApiKey = "your-api-key";
        
        Assert.NotNull(client);
    }
}
