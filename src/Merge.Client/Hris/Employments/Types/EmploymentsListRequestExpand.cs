using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<EmploymentsListRequestExpand>))]
public enum EmploymentsListRequestExpand
{
    [EnumMember(Value = "employee")]
    Employee,

    [EnumMember(Value = "employee,pay_group")]
    EmployeePayGroup,

    [EnumMember(Value = "pay_group")]
    PayGroup,
}
