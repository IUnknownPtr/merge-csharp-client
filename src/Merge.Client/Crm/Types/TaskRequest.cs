using System.Text.Json.Serialization;
using OneOf;
using Merge.Client.Crm;
using StringEnum;

namespace Merge.Client.Crm;

public class TaskRequest
{
    /// <summary>
    /// The task's subject.
    /// </summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; init; }

    /// <summary>
    /// The task's content.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; init; }

    /// <summary>
    /// The task's owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public OneOf<string, User>? Owner { get; init; }

    /// <summary>
    /// The task's account.
    /// </summary>
    [JsonPropertyName("account")]
    public OneOf<string, Account>? Account { get; init; }

    /// <summary>
    /// The task's opportunity.
    /// </summary>
    [JsonPropertyName("opportunity")]
    public OneOf<string, Opportunity>? Opportunity { get; init; }

    /// <summary>
    /// When the task is completed.
    /// </summary>
    [JsonPropertyName("completed_date")]
    public DateTime? CompletedDate { get; init; }

    /// <summary>
    /// When the task is due.
    /// </summary>
    [JsonPropertyName("due_date")]
    public DateTime? DueDate { get; init; }

    /// <summary>
    /// The task's status.
    /// 
    /// - `OPEN` - OPEN
    /// - `CLOSED` - CLOSED
    /// </summary>
    [JsonPropertyName("status")]
    public StringEnum<TaskStatusEnum>? Status { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }

    [JsonPropertyName("remote_fields")]
    public List<RemoteFieldRequest>? RemoteFields { get; init; }
}
