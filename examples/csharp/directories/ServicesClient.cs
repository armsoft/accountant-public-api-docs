using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

/// <summary>
/// Client for the Services directory endpoints.
/// Base URL: https://api.armsoft.am/accountant/v1
/// </summary>
public class ServicesClient
{
    private readonly HttpClient _http;

    public ServicesClient(string apiKey, string language = "hy-AM")
    {
        _http = new HttpClient { BaseAddress = new Uri("https://api.armsoft.am/accountant/v1") };
        _http.DefaultRequestHeaders.Add("apiKey", apiKey);
        _http.DefaultRequestHeaders.Add("Accept-Language", language);
    }

    // -------------------------------------------------------------------------
    // POST /directories/services/list
    // -------------------------------------------------------------------------
    public async Task<JsonDocument> ListAsync(object filters)
    {
        var response = await _http.PostAsJsonAsync("directories/services/list", filters);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    // -------------------------------------------------------------------------
    // POST /directories/services/list/nextpage
    // -------------------------------------------------------------------------
    public async Task<JsonDocument> ListNextPageAsync(string id, bool close = false)
    {
        var response = await _http.PostAsJsonAsync(
            "directories/services/list/nextpage", new { id, close });
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    // -------------------------------------------------------------------------
    // GET /directories/services/{code}
    // -------------------------------------------------------------------------
    public async Task<JsonElement?> GetAsync(string code)
    {
        var response = await _http.GetAsync($"directories/services/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return null;
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // POST /directories/services
    // -------------------------------------------------------------------------
    public async Task<JsonElement> CreateAsync(object service)
    {
        var response = await _http.PostAsJsonAsync("directories/services", service);
        if (response.StatusCode == HttpStatusCode.Conflict)
            throw new InvalidOperationException("A service with that code already exists.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // PUT /directories/services/{code}
    // -------------------------------------------------------------------------
    public async Task<JsonElement> UpdateAsync(string code, object service)
    {
        var response = await _http.PutAsJsonAsync(
            $"directories/services/{Uri.EscapeDataString(code)}", service);
        if (response.StatusCode == HttpStatusCode.NotFound)
            throw new KeyNotFoundException($"Service '{code}' not found.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // DELETE /directories/services/{code}
    // -------------------------------------------------------------------------
    public async Task<bool> DeleteAsync(string code)
    {
        var response = await _http.DeleteAsync($"directories/services/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return false;
        response.EnsureSuccessStatusCode();
        return true;
    }
}

// =============================================================================
// Usage example
// =============================================================================
// var client = new ServicesClient("{your-api-key}");
// var list = await client.ListAsync(new { pageSize = 5000 });
