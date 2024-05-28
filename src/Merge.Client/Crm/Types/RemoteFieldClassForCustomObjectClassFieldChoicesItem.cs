using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public class RemoteFieldClassForCustomObjectClassFieldChoicesItem
{
    [JsonPropertyName("value")]
    public object? Value { get; init; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; init; }
}
