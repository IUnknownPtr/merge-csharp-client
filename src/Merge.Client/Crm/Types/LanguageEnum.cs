using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(EnumSerializer<LanguageEnum>))]
public enum LanguageEnum
{
    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "de")]
    De,
}
