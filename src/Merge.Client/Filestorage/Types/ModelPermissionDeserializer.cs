using System.Text.Json.Serialization;

namespace Merge.Client.Filestorage;

public class ModelPermissionDeserializer
{
    [JsonPropertyName("is_enabled")]
    public bool? IsEnabled { get; init; }
}
