using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ats;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum DisabilityStatusEnum
{
    [EnumMember(Value = "YES_I_HAVE_A_DISABILITY_OR_PREVIOUSLY_HAD_A_DISABILITY")]
    YesIHaveADisabilityOrPreviouslyHadADisability,

    [EnumMember(Value = "NO_I_DONT_HAVE_A_DISABILITY")]
    NoIDontHaveADisability,

    [EnumMember(Value = "I_DONT_WISH_TO_ANSWER")]
    IDontWishToAnswer
}
