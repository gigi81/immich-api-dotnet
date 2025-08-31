namespace Immich.Client;

partial class ImmichClient
{
    public string ApiKey { get; set; }
    
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request, string url)
    {
        if(!string.IsNullOrWhiteSpace(this.ApiKey))
            client.DefaultRequestHeaders.Add("x-api-key", this.ApiKey);
    }
}
