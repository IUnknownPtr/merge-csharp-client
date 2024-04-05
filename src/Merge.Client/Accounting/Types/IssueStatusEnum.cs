using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum IssueStatusEnum
{
    [EnumMember(Value = "ONGOING")]
    Ongoing,

    [EnumMember(Value = "RESOLVED")]
    Resolved
}
