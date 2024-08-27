using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

public record Earning
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; set; }

    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    [JsonPropertyName("employee_payroll_run")]
    public string? EmployeePayrollRun { get; set; }

    /// <summary>
    /// The amount earned.
    /// </summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; set; }

    /// <summary>
    /// The type of earning.
    ///
    /// - `SALARY` - SALARY
    /// - `REIMBURSEMENT` - REIMBURSEMENT
    /// - `OVERTIME` - OVERTIME
    /// - `BONUS` - BONUS
    /// </summary>
    [JsonPropertyName("type")]
    public EarningTypeEnum? Type { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
