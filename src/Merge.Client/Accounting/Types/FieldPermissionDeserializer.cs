using System.Text.Json.Serialization;

namespace Merge.Client.Accounting;

public class FieldPermissionDeserializer
{
    [JsonPropertyName("enabled")]
    public List<object>? Enabled { get; init; }

    [JsonPropertyName("disabled")]
    public List<object>? Disabled { get; init; }
}
