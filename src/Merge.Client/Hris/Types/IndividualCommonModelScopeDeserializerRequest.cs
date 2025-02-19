using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

public record IndividualCommonModelScopeDeserializerRequest
{
    [JsonPropertyName("model_name")]
    public required string ModelName { get; set; }

    [JsonPropertyName("model_permissions")]
    public Dictionary<string, ModelPermissionDeserializerRequest>? ModelPermissions { get; set; }

    [JsonPropertyName("field_permissions")]
    public FieldPermissionDeserializerRequest? FieldPermissions { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
