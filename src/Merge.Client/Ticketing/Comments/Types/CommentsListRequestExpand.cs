using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(EnumSerializer<CommentsListRequestExpand>))]
public enum CommentsListRequestExpand
{
    [EnumMember(Value = "contact")]
    Contact,

    [EnumMember(Value = "contact,ticket")]
    ContactTicket,

    [EnumMember(Value = "ticket")]
    Ticket,

    [EnumMember(Value = "user")]
    User,

    [EnumMember(Value = "user,contact")]
    UserContact,

    [EnumMember(Value = "user,contact,ticket")]
    UserContactTicket,

    [EnumMember(Value = "user,ticket")]
    UserTicket,
}
