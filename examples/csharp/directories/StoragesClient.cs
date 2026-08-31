using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

/// <summary>
/// Client for the Storages directory endpoints.
/// Storages return the full list from a plain GET, so there is no paging.
/// Base URL: https://api.armsoft.am/accountant/v1
/// </summary>
public class StoragesClient
{
    private readonly HttpClient _http;

    public StoragesClient(string apiKey, string language = "hy-AM")
    {
        _http = new HttpClient { BaseAddress = new Uri("https://api.armsoft.am/accountant/v1") };
        _http.DefaultRequestHeaders.Add("apiKey", apiKey);
        _http.DefaultRequestHeaders.Add("Accept-Language", language);
    }

    // -------------------------------------------------------------------------
    // GET /directories/storages
    // -------------------------------------------------------------------------
    public async Task<JsonDocument> ListAsync(bool showAlsoClosed = true)
    {
        var response = await _http.GetAsync($"directories/storages?showAlsoClosed={showAlsoClosed}");
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    // -------------------------------------------------------------------------
    // GET /directories/storages/{code}
    // -------------------------------------------------------------------------
    public async Task<JsonElement?> GetAsync(string code)
    {
        var response = await _http.GetAsync($"directories/storages/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return null;
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // POST /directories/storages
    // -------------------------------------------------------------------------
    public async Task<JsonElement> CreateAsync(object storage)
    {
        var response = await _http.PostAsJsonAsync("directories/storages", storage);
        if (response.StatusCode == HttpStatusCode.Conflict)
            throw new InvalidOperationException("A storage with that code already exists.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // PUT /directories/storages/{code}
    // -------------------------------------------------------------------------
    public async Task<JsonElement> UpdateAsync(string code, object storage)
    {
        var response = await _http.PutAsJsonAsync(
            $"directories/storages/{Uri.EscapeDataString(code)}", storage);
        if (response.StatusCode == HttpStatusCode.NotFound)
            throw new KeyNotFoundException($"Storage '{code}' not found.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // DELETE /directories/storages/{code}
    // -------------------------------------------------------------------------
    public async Task<bool> DeleteAsync(string code)
    {
        var response = await _http.DeleteAsync($"directories/storages/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return false;
        response.EnsureSuccessStatusCode();
        return true;
    }
}

// =============================================================================
// Usage example
// =============================================================================
// var client = new StoragesClient("{your-api-key}");
// var storages = await client.ListAsync(showAlsoClosed: false);
