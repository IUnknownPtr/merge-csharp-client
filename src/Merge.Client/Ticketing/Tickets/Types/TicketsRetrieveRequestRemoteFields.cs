using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public enum TicketsRetrieveRequestRemoteFields
{
    [EnumMember(Value = "priority")]
    Priority,

    [EnumMember(Value = "priority,status")]
    PriorityStatus,

    [EnumMember(Value = "priority,status,ticket_type")]
    PriorityStatusTicketType,

    [EnumMember(Value = "priority,ticket_type")]
    PriorityTicketType,

    [EnumMember(Value = "status")]
    Status,

    [EnumMember(Value = "status,ticket_type")]
    StatusTicketType,

    [EnumMember(Value = "ticket_type")]
    TicketType
}
