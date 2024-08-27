using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ticketing;

public record AvailableActions
{
    [JsonPropertyName("integration")]
    public required AccountIntegration Integration { get; set; }

    [JsonPropertyName("passthrough_available")]
    public required bool PassthroughAvailable { get; set; }

    [JsonPropertyName("available_model_operations")]
    public IEnumerable<ModelOperation>? AvailableModelOperations { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
