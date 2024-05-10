using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

namespace Merge.Client.Ticketing;

public class FieldMappingApiInstance
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("is_integration_wide")]
    public bool? IsIntegrationWide { get; init; }

    [JsonPropertyName("target_field")]
    public FieldMappingApiInstanceTargetField? TargetField { get; init; }

    [JsonPropertyName("remote_field")]
    public FieldMappingApiInstanceRemoteField? RemoteField { get; init; }
}
