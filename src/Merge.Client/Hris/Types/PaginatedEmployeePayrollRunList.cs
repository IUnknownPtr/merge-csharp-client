using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

public record PaginatedEmployeePayrollRunList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<EmployeePayrollRun>? Results { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
