using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<JobsListRequestStatus>))]
public enum JobsListRequestStatus
{
    [EnumMember(Value = "ARCHIVED")]
    Archived,

    [EnumMember(Value = "CLOSED")]
    Closed,

    [EnumMember(Value = "DRAFT")]
    Draft,

    [EnumMember(Value = "OPEN")]
    Open,

    [EnumMember(Value = "PENDING")]
    Pending,
}
