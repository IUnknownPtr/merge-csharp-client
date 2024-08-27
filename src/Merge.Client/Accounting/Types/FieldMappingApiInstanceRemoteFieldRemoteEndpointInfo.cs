using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

public record FieldMappingApiInstanceRemoteFieldRemoteEndpointInfo
{
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    [JsonPropertyName("url_path")]
    public string? UrlPath { get; set; }

    [JsonPropertyName("field_traversal_path")]
    public IEnumerable<string>? FieldTraversalPath { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
