# Immich.Client

dotnet immich client library built from the openapi specs available from the [immich official repo](https://github.com/immich-app/immich)

## Usage

```csharp
using Immich.Client
    
using var httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("http://localhost:5001");

var client = new ImmichClient(httpClient);
client.ApiKey = "your-api-key";

//call apis, for example
var version = await client.GetServerVersionAsync(CancellationToken.None);
```