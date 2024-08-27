using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

public record OpportunityResponse
{
    [JsonPropertyName("model")]
    public required Opportunity Model { get; set; }

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
