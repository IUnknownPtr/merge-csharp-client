using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Accounting;

public record VendorCreditLine
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

    /// <summary>
    /// The full value of the credit.
    /// </summary>
    [JsonPropertyName("net_amount")]
    public double? NetAmount { get; set; }

    /// <summary>
    /// The line's associated tracking category.
    /// </summary>
    [JsonPropertyName("tracking_category")]
    public string? TrackingCategory { get; set; }

    /// <summary>
    /// The vendor credit line item's associated tracking categories.
    /// </summary>
    [JsonPropertyName("tracking_categories")]
    public IEnumerable<string>? TrackingCategories { get; set; }

    /// <summary>
    /// The line's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The line's account.
    /// </summary>
    [JsonPropertyName("account")]
    public OneOf<string, Account>? Account { get; set; }

    /// <summary>
    /// The company the line belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; set; }

    /// <summary>
    /// The tax rate that applies to this line item.
    /// </summary>
    [JsonPropertyName("tax_rate")]
    public string? TaxRate { get; set; }

    /// <summary>
    /// The vendor credit line item's exchange rate.
    /// </summary>
    [JsonPropertyName("exchange_rate")]
    public string? ExchangeRate { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
