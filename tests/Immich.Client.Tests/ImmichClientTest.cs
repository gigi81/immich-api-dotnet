namespace Immich.Client.Tests;

public class ImmichClientTest
{
    [Fact]
    public void Can_Create_Client()
    {
        var client = new ImmichClient(new HttpClient());
        client.BaseUrl = "https://localhost:5001";
        
        Assert.NotNull(client);
    }
}
