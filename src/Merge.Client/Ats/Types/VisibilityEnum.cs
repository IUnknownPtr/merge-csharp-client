using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public enum VisibilityEnum
{
    [EnumMember(Value = "ADMIN_ONLY")]
    AdminOnly,

    [EnumMember(Value = "PUBLIC")]
    Public,

    [EnumMember(Value = "PRIVATE")]
    Private
}
