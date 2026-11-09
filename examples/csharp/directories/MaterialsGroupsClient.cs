using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

/// <summary>
/// Client for the Materials Groups directory endpoints.
/// Materials groups return the full list from a plain GET, so there is no paging.
/// Base URL: https://api.armsoft.am/accountant/v1
/// </summary>
public class MaterialsGroupsClient
{
    private readonly HttpClient _http;

    public MaterialsGroupsClient(string apiKey, string language = "hy-AM")
    {
        _http = new HttpClient { BaseAddress = new Uri("https://api.armsoft.am/accountant/v1") };
        _http.DefaultRequestHeaders.Add("apiKey", apiKey);
        _http.DefaultRequestHeaders.Add("Accept-Language", language);
    }

    // -------------------------------------------------------------------------
    // GET /directories/materialsgroups
    // -------------------------------------------------------------------------
    public async Task<JsonDocument> ListAsync()
    {
        var response = await _http.GetAsync("directories/materialsgroups");
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    // -------------------------------------------------------------------------
    // GET /directories/materialsgroups/{code}
    // -------------------------------------------------------------------------
    public async Task<JsonElement?> GetAsync(string code)
    {
        var response = await _http.GetAsync($"directories/materialsgroups/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return null;
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // POST /directories/materialsgroups
    // -------------------------------------------------------------------------
    public async Task<JsonElement> CreateAsync(object materialsGroup)
    {
        var response = await _http.PostAsJsonAsync("directories/materialsgroups", materialsGroup);
        if (response.StatusCode == HttpStatusCode.Conflict)
            throw new InvalidOperationException("A materials group with that code already exists.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // PUT /directories/materialsgroups/{code}
    // -------------------------------------------------------------------------
    public async Task<JsonElement> UpdateAsync(string code, object materialsGroup)
    {
        var response = await _http.PutAsJsonAsync(
            $"directories/materialsgroups/{Uri.EscapeDataString(code)}", materialsGroup);
        if (response.StatusCode == HttpStatusCode.NotFound)
            throw new KeyNotFoundException($"Materials group '{code}' not found.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // DELETE /directories/materialsgroups/{code}
    // -------------------------------------------------------------------------
    public async Task<bool> DeleteAsync(string code)
    {
        var response = await _http.DeleteAsync($"directories/materialsgroups/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return false;
        response.EnsureSuccessStatusCode();
        return true;
    }
}

// =============================================================================
// Usage example
// =============================================================================
// var client = new MaterialsGroupsClient("{your-api-key}");
// var groups = await client.ListAsync();
