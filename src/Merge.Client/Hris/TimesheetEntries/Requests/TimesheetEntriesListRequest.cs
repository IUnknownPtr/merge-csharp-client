using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

public class TimesheetEntriesListRequest
{
    /// <summary>
    /// If provided, will only return objects created after this datetime.
    /// </summary>
    public DateTime? CreatedAfter { get; init; }

    /// <summary>
    /// If provided, will only return objects created before this datetime.
    /// </summary>
    public DateTime? CreatedBefore { get; init; }

    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// If provided, will only return timesheet entries for this employee.
    /// </summary>
    public string? EmployeeId { get; init; }

    /// <summary>
    /// If provided, will only return timesheet entries ended after this datetime.
    /// </summary>
    public string? EndedAfter { get; init; }

    /// <summary>
    /// If provided, will only return timesheet entries ended before this datetime.
    /// </summary>
    public string? EndedBefore { get; init; }

    /// <summary>
    /// Whether to include data that was marked as deleted by third party webhooks.
    /// </summary>
    public bool? IncludeDeletedData { get; init; }

    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; init; }

    /// <summary>
    /// If provided, only objects synced by Merge after this date time will be returned.
    /// </summary>
    public DateTime? ModifiedAfter { get; init; }

    /// <summary>
    /// If provided, only objects synced by Merge before this date time will be returned.
    /// </summary>
    public DateTime? ModifiedBefore { get; init; }

    /// <summary>
    /// Overrides the default ordering for this endpoint. Possible values include: start_time, -start_time.
    /// </summary>
    public TimesheetEntriesListRequestOrderBy? OrderBy { get; init; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// The API provider's ID for the given object.
    /// </summary>
    public string? RemoteId { get; init; }

    /// <summary>
    /// If provided, will only return timesheet entries started after this datetime.
    /// </summary>
    public string? StartedAfter { get; init; }

    /// <summary>
    /// If provided, will only return timesheet entries started before this datetime.
    /// </summary>
    public string? StartedBefore { get; init; }
}
