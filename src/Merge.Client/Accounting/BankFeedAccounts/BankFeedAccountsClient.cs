using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

public partial class BankFeedAccountsClient
{
    private RawClient _client;

    internal BankFeedAccountsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `BankFeedAccount` objects.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Accounting.BankFeedAccounts.ListAsync(new BankFeedAccountsListRequest());
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<PaginatedBankFeedAccountList> ListAsync(
        BankFeedAccountsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Cursor != null)
        {
            _query["cursor"] = request.Cursor;
        }
        if (request.IncludeDeletedData != null)
        {
            _query["include_deleted_data"] = JsonUtils.Serialize(request.IncludeDeletedData.Value);
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = JsonUtils.Serialize(request.IncludeRemoteData.Value);
        }
        if (request.IncludeShellData != null)
        {
            _query["include_shell_data"] = JsonUtils.Serialize(request.IncludeShellData.Value);
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize.Value.ToString();
        }
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "accounting/v1/bank-feed-accounts",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<PaginatedBankFeedAccountList>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MergeException("Failed to deserialize response", e);
            }
        }

        throw new MergeApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// Creates a `BankFeedAccount` object with the given values.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Accounting.BankFeedAccounts.CreateAsync(
    ///     new BankFeedAccountEndpointRequest { Model = new BankFeedAccountRequest() }
    /// );
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<BankFeedAccountResponse> CreateAsync(
        BankFeedAccountEndpointRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.IsDebugMode != null)
        {
            _query["is_debug_mode"] = JsonUtils.Serialize(request.IsDebugMode.Value);
        }
        if (request.RunAsync != null)
        {
            _query["run_async"] = JsonUtils.Serialize(request.RunAsync.Value);
        }
        var requestBody = new Dictionary<string, object>() { { "model", request.Model } };
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "accounting/v1/bank-feed-accounts",
                    Body = requestBody,
                    Query = _query,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<BankFeedAccountResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MergeException("Failed to deserialize response", e);
            }
        }

        throw new MergeApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// Returns a `BankFeedAccount` object with the given `id`.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Accounting.BankFeedAccounts.RetrieveAsync("id", new BankFeedAccountsRetrieveRequest());
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<BankFeedAccount> RetrieveAsync(
        string id,
        BankFeedAccountsRetrieveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = JsonUtils.Serialize(request.IncludeRemoteData.Value);
        }
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = $"accounting/v1/bank-feed-accounts/{id}",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<BankFeedAccount>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MergeException("Failed to deserialize response", e);
            }
        }

        throw new MergeApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// Returns metadata for `BankFeedAccount` POSTs.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Accounting.BankFeedAccounts.MetaPostRetrieveAsync();
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<MetaResponse> MetaPostRetrieveAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "accounting/v1/bank-feed-accounts/meta/post",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<MetaResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MergeException("Failed to deserialize response", e);
            }
        }

        throw new MergeApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }
}
