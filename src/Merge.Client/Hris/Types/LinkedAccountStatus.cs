using System.Text.Json.Serialization;

namespace Merge.Client.Hris;

public class LinkedAccountStatus
{
    [JsonPropertyName("linked_account_status")]
    public string LinkedAccountStatus { get; init; }

    [JsonPropertyName("can_make_request")]
    public bool CanMakeRequest { get; init; }
}
