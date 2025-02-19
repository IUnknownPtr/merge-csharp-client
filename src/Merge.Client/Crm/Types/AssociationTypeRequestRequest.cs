using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

public record AssociationTypeRequestRequest
{
    [JsonPropertyName("source_object_class")]
    public required ObjectClassDescriptionRequest SourceObjectClass { get; set; }

    [JsonPropertyName("target_object_classes")]
    public IEnumerable<ObjectClassDescriptionRequest> TargetObjectClasses { get; set; } =
        new List<ObjectClassDescriptionRequest>();

    [JsonPropertyName("remote_key_name")]
    public required string RemoteKeyName { get; set; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("cardinality")]
    public CardinalityEnum? Cardinality { get; set; }

    [JsonPropertyName("is_required")]
    public bool? IsRequired { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
