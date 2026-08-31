using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

/// <summary>
/// Client for the Materials directory endpoints.
/// Base URL: https://api.armsoft.am/accountant/v1
/// </summary>
public class MaterialsClient
{
    private readonly HttpClient _http;

    public MaterialsClient(string apiKey, string language = "hy-AM")
    {
        _http = new HttpClient { BaseAddress = new Uri("https://api.armsoft.am/accountant/v1") };
        _http.DefaultRequestHeaders.Add("apiKey", apiKey);
        _http.DefaultRequestHeaders.Add("Accept-Language", language);
    }

    // -------------------------------------------------------------------------
    // POST /directories/materials/list
    // -------------------------------------------------------------------------
    public async Task<JsonDocument> ListAsync(object filters)
    {
        var response = await _http.PostAsJsonAsync("directories/materials/list", filters);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    // -------------------------------------------------------------------------
    // POST /directories/materials/list/nextpage
    // -------------------------------------------------------------------------
    public async Task<JsonDocument> ListNextPageAsync(string id, bool close = false)
    {
        var response = await _http.PostAsJsonAsync(
            "directories/materials/list/nextpage", new { id, close });
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    // -------------------------------------------------------------------------
    // GET /directories/materials/{code}
    // -------------------------------------------------------------------------
    public async Task<JsonElement?> GetAsync(string code)
    {
        var response = await _http.GetAsync($"directories/materials/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return null;
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // POST /directories/materials
    // -------------------------------------------------------------------------
    public async Task<JsonElement> CreateAsync(object material)
    {
        var response = await _http.PostAsJsonAsync("directories/materials", material);
        if (response.StatusCode == HttpStatusCode.Conflict)
            throw new InvalidOperationException("A material with that code already exists.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // PUT /directories/materials/{code}
    // -------------------------------------------------------------------------
    public async Task<JsonElement> UpdateAsync(string code, object material)
    {
        var response = await _http.PutAsJsonAsync(
            $"directories/materials/{Uri.EscapeDataString(code)}", material);
        if (response.StatusCode == HttpStatusCode.NotFound)
            throw new KeyNotFoundException($"Material '{code}' not found.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // DELETE /directories/materials/{code}
    // -------------------------------------------------------------------------
    public async Task<bool> DeleteAsync(string code)
    {
        var response = await _http.DeleteAsync($"directories/materials/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return false;
        response.EnsureSuccessStatusCode();
        return true;
    }
}

// =============================================================================
// Usage example
// =============================================================================
// var client = new MaterialsClient("{your-api-key}");
// var list = await client.ListAsync(new { pageSize = 5000 });
