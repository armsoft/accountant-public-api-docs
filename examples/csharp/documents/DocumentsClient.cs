using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

/// <summary>
/// Client for the document endpoints. Every document type exposes the same four calls,
/// so a single client serves all of them - pass the document route segment
/// ("invoice", "retailsale", "memorialorder", ...) as <c>documentType</c>.
/// Base URL: https://api.armsoft.am/accountant/v1
/// </summary>
public class DocumentsClient
{
    private readonly HttpClient _http;

    public DocumentsClient(string apiKey, string language = "hy-AM")
    {
        _http = new HttpClient { BaseAddress = new Uri("https://api.armsoft.am/accountant/v1") };
        _http.DefaultRequestHeaders.Add("apiKey", apiKey);
        _http.DefaultRequestHeaders.Add("Accept-Language", language);
    }

    // -------------------------------------------------------------------------
    // POST /documents/{documentType}
    // -------------------------------------------------------------------------
    public async Task<JsonElement> CreateAsync(string documentType, object document)
    {
        var response = await _http.PostAsJsonAsync($"documents/{documentType}", document);
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // GET /documents/{documentType}/{isn}
    // -------------------------------------------------------------------------
    public async Task<JsonElement?> GetAsync(string documentType, string isn)
    {
        var response = await _http.GetAsync($"documents/{documentType}/{isn}");
        if (response.StatusCode == HttpStatusCode.NotFound) return null;
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // PUT /documents/{documentType}/{isn}
    // -------------------------------------------------------------------------
    public async Task<JsonElement> UpdateAsync(string documentType, string isn, object document)
    {
        var response = await _http.PutAsJsonAsync($"documents/{documentType}/{isn}", document);
        if (response.StatusCode == HttpStatusCode.NotFound)
            throw new KeyNotFoundException($"Document '{isn}' not found.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // DELETE /documents/{documentType}/{isn}
    // -------------------------------------------------------------------------
    public async Task<bool> DeleteAsync(string documentType, string isn)
    {
        var response = await _http.DeleteAsync($"documents/{documentType}/{isn}");
        if (response.StatusCode == HttpStatusCode.NotFound) return false;
        response.EnsureSuccessStatusCode();
        return true;
    }
}

// =============================================================================
// Usage example
// =============================================================================
// var client = new DocumentsClient("{your-api-key}");
// var created = await client.CreateAsync("invoice", new { date = "2026-01-15" });
// var isn = created.GetProperty("isn").GetString();
