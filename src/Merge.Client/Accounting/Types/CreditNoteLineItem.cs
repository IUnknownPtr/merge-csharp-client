using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Accounting;

public record CreditNoteLineItem
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

    [JsonPropertyName("item")]
    public OneOf<string, Item>? Item { get; set; }

    /// <summary>
    /// The credit note line item's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The description of the item that is owed.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The credit note line item's quantity.
    /// </summary>
    [JsonPropertyName("quantity")]
    public string? Quantity { get; set; }

    /// <summary>
    /// The credit note line item's memo.
    /// </summary>
    [JsonPropertyName("memo")]
    public string? Memo { get; set; }

    /// <summary>
    /// The credit note line item's unit price.
    /// </summary>
    [JsonPropertyName("unit_price")]
    public string? UnitPrice { get; set; }

    /// <summary>
    /// The tax rate that applies to this line item.
    /// </summary>
    [JsonPropertyName("tax_rate")]
    public string? TaxRate { get; set; }

    /// <summary>
    /// The credit note line item's total.
    /// </summary>
    [JsonPropertyName("total_line_amount")]
    public string? TotalLineAmount { get; set; }

    /// <summary>
    /// The credit note line item's associated tracking category.
    /// </summary>
    [JsonPropertyName("tracking_category")]
    public string? TrackingCategory { get; set; }

    /// <summary>
    /// The credit note line item's associated tracking categories.
    /// </summary>
    [JsonPropertyName("tracking_categories")]
    public IEnumerable<string>? TrackingCategories { get; set; }

    /// <summary>
    /// The credit note line item's account.
    /// </summary>
    [JsonPropertyName("account")]
    public string? Account { get; set; }

    /// <summary>
    /// The company the credit note belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public OneOf<string, CompanyInfo>? Company { get; set; }

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
