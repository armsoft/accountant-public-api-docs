using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

/// <summary>
/// Client for the Reports endpoints. Every report takes a parameter object,
/// returns paginated rows, and has a matching /nextpage call.
/// Base URL: https://api.armsoft.am/accountant/v1
/// </summary>
public class ReportsClient
{
    private readonly HttpClient _http;

    public ReportsClient(string apiKey, string language = "hy-AM")
    {
        _http = new HttpClient { BaseAddress = new Uri("https://api.armsoft.am/accountant/v1") };
        _http.DefaultRequestHeaders.Add("apiKey", apiKey);
        _http.DefaultRequestHeaders.Add("Accept-Language", language);
    }

    // -------------------------------------------------------------------------
    // POST /reports/{name}
    // -------------------------------------------------------------------------
    public async Task<JsonDocument> QueryAsync(string name, object parameters)
    {
        var response = await _http.PostAsJsonAsync($"reports/{name}", parameters);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    // -------------------------------------------------------------------------
    // POST /reports/{name}/nextpage
    // -------------------------------------------------------------------------
    public async Task<JsonDocument> NextPageAsync(string name, string id, bool close = false)
    {
        var response = await _http.PostAsJsonAsync($"reports/{name}/nextpage", new { id, close });
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    /// <summary>Reads every page of a report and returns all rows.</summary>
    public async Task<List<JsonElement>> QueryAllAsync(string name, object parameters)
    {
        var rows = new List<JsonElement>();
        var page = await QueryAsync(name, parameters);

        while (true)
        {
            rows.AddRange(page.RootElement.GetProperty("data").EnumerateArray());
            if (!page.RootElement.GetProperty("hasMore").GetBoolean()) break;
            page = await NextPageAsync(name, page.RootElement.GetProperty("id").GetString());
        }

        return rows;
    }
}

// =============================================================================
// Available names
// =============================================================================
// reports/accountsbalances
// reports/accountsturnover
// reports/transactions
// reports/partnersbalances
// reports/partnerstransactions
// reports/materialsbalances
// reports/materialsoperationsjournal
// reports/storageinputordersandreceivedservices
