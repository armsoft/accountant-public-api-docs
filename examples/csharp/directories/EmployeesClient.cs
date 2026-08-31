using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

/// <summary>
/// Client for the Employees directory endpoints.
/// Base URL: https://api.armsoft.am/accountant/v1
/// </summary>
public class EmployeesClient
{
    private readonly HttpClient _http;

    public EmployeesClient(string apiKey, string language = "hy-AM")
    {
        _http = new HttpClient { BaseAddress = new Uri("https://api.armsoft.am/accountant/v1") };
        _http.DefaultRequestHeaders.Add("apiKey", apiKey);
        _http.DefaultRequestHeaders.Add("Accept-Language", language);
    }

    // -------------------------------------------------------------------------
    // POST /directories/employees/list
    // -------------------------------------------------------------------------
    public async Task<JsonDocument> ListAsync(object filters)
    {
        var response = await _http.PostAsJsonAsync("directories/employees/list", filters);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    // -------------------------------------------------------------------------
    // POST /directories/employees/list/nextpage
    // -------------------------------------------------------------------------
    public async Task<JsonDocument> ListNextPageAsync(string id, bool close = false)
    {
        var response = await _http.PostAsJsonAsync(
            "directories/employees/list/nextpage", new { id, close });
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    // -------------------------------------------------------------------------
    // GET /directories/employees/{code}
    // -------------------------------------------------------------------------
    public async Task<JsonElement?> GetAsync(string code)
    {
        var response = await _http.GetAsync($"directories/employees/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return null;
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // POST /directories/employees
    // -------------------------------------------------------------------------
    public async Task<JsonElement> CreateAsync(object employee)
    {
        var response = await _http.PostAsJsonAsync("directories/employees", employee);
        if (response.StatusCode == HttpStatusCode.Conflict)
            throw new InvalidOperationException("A employee with that code already exists.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // PUT /directories/employees/{code}
    // -------------------------------------------------------------------------
    public async Task<JsonElement> UpdateAsync(string code, object employee)
    {
        var response = await _http.PutAsJsonAsync(
            $"directories/employees/{Uri.EscapeDataString(code)}", employee);
        if (response.StatusCode == HttpStatusCode.NotFound)
            throw new KeyNotFoundException($"Employee '{code}' not found.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // DELETE /directories/employees/{code}
    // -------------------------------------------------------------------------
    public async Task<bool> DeleteAsync(string code)
    {
        var response = await _http.DeleteAsync($"directories/employees/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return false;
        response.EnsureSuccessStatusCode();
        return true;
    }
}

// =============================================================================
// Usage example
// =============================================================================
// var client = new EmployeesClient("{your-api-key}");
// var list = await client.ListAsync(new { pageSize = 5000 });
