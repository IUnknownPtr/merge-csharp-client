using System.Text.Json.Serialization;
using Merge.Client.Accounting;
using OneOf;

namespace Merge.Client.Accounting;

public class VendorCreditLine
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// This is the datetime that this object was last updated by Merge
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    /// <summary>
    /// The full value of the credit.
    /// </summary>
    [JsonPropertyName("net_amount")]
    public double? NetAmount { get; init; }

    /// <summary>
    /// The line's associated tracking category.
    /// </summary>
    [JsonPropertyName("tracking_category")]
    public string? TrackingCategory { get; init; }

    /// <summary>
    /// The line's associated tracking categories.
    /// </summary>
    [JsonPropertyName("tracking_categories")]
    public List<string> TrackingCategories { get; init; }

    /// <summary>
    /// The line's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The line's account.
    /// </summary>
    [JsonPropertyName("account")]
    public OneOf<string, Account>? Account { get; init; }

    /// <summary>
    /// The company the line belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; init; }

    /// <summary>
    /// The vendor credit line item's exchange rate.
    /// </summary>
    [JsonPropertyName("exchange_rate")]
    public string? ExchangeRate { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }
}
