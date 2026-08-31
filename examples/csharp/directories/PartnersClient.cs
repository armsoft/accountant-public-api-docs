using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

/// <summary>
/// Client for the Partners directory endpoints.
/// Base URL: https://api.armsoft.am/accountant/v1
/// </summary>
public class PartnersClient
{
    private readonly HttpClient _http;

    public PartnersClient(string apiKey, string language = "hy-AM")
    {
        _http = new HttpClient { BaseAddress = new Uri("https://api.armsoft.am/accountant/v1") };
        _http.DefaultRequestHeaders.Add("apiKey", apiKey);
        _http.DefaultRequestHeaders.Add("Accept-Language", language);
    }

    // -------------------------------------------------------------------------
    // POST /directories/partners/list
    // -------------------------------------------------------------------------
    public async Task<JsonDocument> ListAsync(object filters)
    {
        var response = await _http.PostAsJsonAsync("directories/partners/list", filters);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    // -------------------------------------------------------------------------
    // POST /directories/partners/list/nextpage
    // -------------------------------------------------------------------------
    public async Task<JsonDocument> ListNextPageAsync(string id, bool close = false)
    {
        var response = await _http.PostAsJsonAsync(
            "directories/partners/list/nextpage", new { id, close });
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    // -------------------------------------------------------------------------
    // GET /directories/partners/{code}
    // -------------------------------------------------------------------------
    public async Task<JsonElement?> GetAsync(string code)
    {
        var response = await _http.GetAsync($"directories/partners/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return null;
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // POST /directories/partners
    // -------------------------------------------------------------------------
    public async Task<JsonElement> CreateAsync(object partner)
    {
        var response = await _http.PostAsJsonAsync("directories/partners", partner);
        if (response.StatusCode == HttpStatusCode.Conflict)
            throw new InvalidOperationException("A partner with that code already exists.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // PUT /directories/partners/{code}
    // -------------------------------------------------------------------------
    public async Task<JsonElement> UpdateAsync(string code, object partner)
    {
        var response = await _http.PutAsJsonAsync(
            $"directories/partners/{Uri.EscapeDataString(code)}", partner);
        if (response.StatusCode == HttpStatusCode.NotFound)
            throw new KeyNotFoundException($"Partner '{code}' not found.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // DELETE /directories/partners/{code}
    // -------------------------------------------------------------------------
    public async Task<bool> DeleteAsync(string code)
    {
        var response = await _http.DeleteAsync($"directories/partners/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return false;
        response.EnsureSuccessStatusCode();
        return true;
    }
}

// =============================================================================
// Usage example
// =============================================================================
// var client = new PartnersClient("{your-api-key}");
// var list = await client.ListAsync(new { pageSize = 5000 });
