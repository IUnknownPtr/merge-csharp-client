using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

public record IgnoreCommonModelRequest
{
    [JsonPropertyName("reason")]
    public required ReasonEnum Reason { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
