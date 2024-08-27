using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

public record DebugModelLogSummary
{
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("method")]
    public required string Method { get; set; }

    [JsonPropertyName("status_code")]
    public required int StatusCode { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
