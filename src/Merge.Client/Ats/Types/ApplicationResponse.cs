using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

public record ApplicationResponse
{
    [JsonPropertyName("model")]
    public required Application Model { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<WarningValidationProblem> Warnings { get; set; } =
        new List<WarningValidationProblem>();

    [JsonPropertyName("errors")]
    public IEnumerable<ErrorValidationProblem> Errors { get; set; } =
        new List<ErrorValidationProblem>();

    [JsonPropertyName("logs")]
    public IEnumerable<DebugModeLog>? Logs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
