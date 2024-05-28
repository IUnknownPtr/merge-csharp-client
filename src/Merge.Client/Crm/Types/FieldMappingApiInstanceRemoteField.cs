using System.Text.Json.Serialization;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class FieldMappingApiInstanceRemoteField
{
    [JsonPropertyName("remote_key_name")]
    public string RemoteKeyName { get; init; }

    [JsonPropertyName("schema")]
    public Dictionary<string, object> Schema { get; init; }

    [JsonPropertyName("remote_endpoint_info")]
    public FieldMappingApiInstanceRemoteFieldRemoteEndpointInfo RemoteEndpointInfo { get; init; }
}
