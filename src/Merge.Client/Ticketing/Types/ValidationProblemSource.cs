using System.Text.Json.Serialization;

namespace Merge.Client.Ticketing;

public class ValidationProblemSource
{
    [JsonPropertyName("pointer")]
    public string Pointer { get; init; }
}
