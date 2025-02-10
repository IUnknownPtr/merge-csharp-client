using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

public record Group
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
    /// The parent group for this group.
    /// </summary>
    [JsonPropertyName("parent_group")]
    public string? ParentGroup { get; set; }

    /// <summary>
    /// The group name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The Group type returned directly from the third-party.
    ///
    /// - `TEAM` - TEAM
    /// - `DEPARTMENT` - DEPARTMENT
    /// - `COST_CENTER` - COST_CENTER
    /// - `BUSINESS_UNIT` - BUSINESS_UNIT
    /// - `GROUP` - GROUP
    /// </summary>
    [JsonPropertyName("type")]
    public GroupTypeEnum? Type { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    /// <summary>
    /// Indicates whether the Group refers to a team in the third party platform. Note that this is an opinionated view based on how Merge observes most organizations representing teams in each third party platform. If your customer uses a platform different from most, there is a chance this will not be correct.
    /// </summary>
    [JsonPropertyName("is_commonly_used_as_team")]
    public bool? IsCommonlyUsedAsTeam { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
