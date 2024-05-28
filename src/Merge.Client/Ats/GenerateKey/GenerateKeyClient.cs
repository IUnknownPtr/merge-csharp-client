using System.Text.Json;
using Merge.Client;
using Merge.Client.Ats;

#nullable enable

namespace Merge.Client.Ats;

public class GenerateKeyClient
{
    private RawClient _client;

    public GenerateKeyClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Create a remote key.
    /// </summary>
    public async Task<RemoteKey> CreateAsync(GenerateRemoteKeyRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/ats/v1/generate-key",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<RemoteKey>(responseBody);
        }
        throw new Exception();
    }
}
