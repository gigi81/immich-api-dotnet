namespace Immich.Client.Tests;

public class ImmichClientTest
{
    [Fact]
    public void Can_Create_Client()
    {
        using var httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri("http://localhost:2283");
        
        var client = new ImmichClient(httpClient);

        Assert.NotNull(client);
    }
    
    [Fact]
    public async Task Can_SignUp_Admin()
    {
        using var httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri("http://localhost:2283");
        
        var client = new ImmichClient(httpClient);
        var response = await client.SignUpAdminAsync(new SignUpDto
        {
            Email = "test@test.com",
            Name = "test",
            Password = "test1234!&^"
        });

        Assert.Equal(UserStatus.Active, response.Status);
    }
}
