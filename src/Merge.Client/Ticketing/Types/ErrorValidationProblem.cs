using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

public record ErrorValidationProblem
{
    [JsonPropertyName("source")]
    public ValidationProblemSource? Source { get; set; }

    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("detail")]
    public required string Detail { get; set; }

    [JsonPropertyName("problem_type")]
    public required string ProblemType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
