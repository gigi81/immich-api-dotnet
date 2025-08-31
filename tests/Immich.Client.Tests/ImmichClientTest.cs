namespace Immich.Client.Tests;

public class ImmichClientTest : IDisposable
{
    private readonly HttpClient _httpClient;
    private readonly ImmichClient _client;

    public ImmichClientTest()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("http://localhost:2283");
        
        _client = new ImmichClient(_httpClient);

        var response = _client.SignUpAdminAsync(new SignUpDto
        {
            Email = "test@test.com",
            Name = "test",
            Password = "test1234!&^"
        }).Result;

        Assert.Equal(UserStatus.Active, response.Status);
    }
    
    [Fact]
    public async Task Can_SignUp_Admin()
    {
        var version = await _client.GetServerVersionAsync();
        Assert.NotNull(version);
        Assert.Equal(1, version.Major);
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}
