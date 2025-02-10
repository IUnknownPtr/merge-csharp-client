using Merge.Client.Core;

namespace Merge.Client.Hris;

public record EmployerBenefitsRetrieveRequest
{
    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
