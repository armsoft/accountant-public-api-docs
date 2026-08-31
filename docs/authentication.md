## 🔐 Authentication & Authorization

All API endpoints require authorization using an API Key. Clients must include a valid `apiKey` in the request header for every request.

---
🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_getting_key.htm)

### Authentication Method

**Header Name:**  
`apiKey`

**Header Value:**  
`Your generated API key`

### cURL Authentication Example

```bash
curl -X GET \
    "https://api.armsoft.am/accountant/v1/directories/storages" \
    -H "accept: text/plain" \
    -H "Accept-Language: hy-AM" \
    -H "apiKey: YOUR_API_KEY"
```

Use your real API key in the `apiKey` header.

---

## API Key Types

### 1. Full Access

**Capabilities:**
- ✅ Complete CRUD operations on all resources
- ✅ Access to all directories (Partners, Materials, Services, Employees, Storages)
- ✅ Document creation and management
- ✅ Administrative operations
- ✅ All API endpoints available

**Use Cases:**
- Internal integrations
- ERP system connections
- Full-featured third-party applications
- Administrative tasks

### 2. Limited Access (Read Only)

**Capabilities:**
- ✅ Read-only access to the directories (list / get)
- ✅ Read a single document by its ISN
- ✅ Read journals and reports
- ❌ No directory modification
- ❌ No document creation, update or deletion
- ❌ No administrative functions

**Use Cases:**
- Analytics and BI integrations
- Read-only dashboards
- Data export and reconciliation tools
- Customer-facing reporting applications

### Restricted API Keys (Limited Access)

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_online_store_box.htm)

API keys with restricted permissions are limited to the following endpoints:

#### Directories (Read Only)

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/directories/partners/list` | Get all partners |
| POST | `/directories/partners/list/nextpage` | Next page of partners |
| GET | `/directories/partners/{code}` | Get partner by code |
| POST | `/directories/materials/list` | Get all materials |
| POST | `/directories/materials/list/nextpage` | Next page of materials |
| GET | `/directories/materials/{code}` | Get material by code |
| POST | `/directories/services/list` | Get all services |
| POST | `/directories/services/list/nextpage` | Next page of services |
| GET | `/directories/services/{code}` | Get service by code |
| POST | `/directories/employees/list` | Get all employees |
| POST | `/directories/employees/list/nextpage` | Next page of employees |
| GET | `/directories/employees/{code}` | Get employee by code |
| GET | `/directories/storages` | Get all storages |
| GET | `/directories/storages/{code}` | Get storage by code |

#### Documents (Read Only)

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/documents/invoice/{isn}` | Get invoice by ISN |
| GET | `/documents/retailsale/{isn}` | Get retail sale by ISN |
| GET | `/documents/transferinvoice/{isn}` | Get transfer invoice by ISN |
| GET | `/documents/memorialorder/{isn}` | Get memorial order by ISN |
| GET | `/documents/paymentorder/{isn}` | Get payment order by ISN |
| GET | `/documents/storageinputorder/{isn}` | Get storage input order by ISN |
| GET | `/documents/storageoutputorder/{isn}` | Get storage output order by ISN |
| GET | `/documents/materialsmovement/{isn}` | Get materials movement by ISN |
| GET | `/documents/materialskitting/{isn}` | Get materials kitting by ISN |
| GET | `/documents/overheadexpenseallocation/{isn}` | Get overhead expense allocation by ISN |

#### Journals

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/journals/alldocuments` | Get all documents journal |
| POST | `/journals/alldocuments/nextpage` | Next page of the documents journal |
| POST | `/journals/invoices` | Get invoice documents journal |
| POST | `/journals/invoices/nextpage` | Next page of the invoices journal |
| POST | `/journals/ecrchecks` | Get ECR checks journal |
| POST | `/journals/ecrchecks/nextpage` | Next page of the ECR checks journal |

#### Reports

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/reports/accountsbalances` | Accounts balances report |
| POST | `/reports/accountsturnover` | Accounts turnover report |
| POST | `/reports/transactions` | Transactions journal report |
| POST | `/reports/partnersbalances` | Partners balances report |
| POST | `/reports/partnerstransactions` | Partners transactions report |
| POST | `/reports/materialsbalances` | Materials balances report |
| POST | `/reports/materialsoperationsjournal` | Materials operations journal report |
| POST | `/reports/storageinputordersandreceivedservices` | Storage input orders and received services report |

Every report in the table above also allows its matching `/nextpage` call.

## How Authentication Works

Every request is validated server-side before processing:
1. The server reads the `apiKey` header value.
2. The key is looked up in the system and its access level is checked.
3. If the key is missing, a `401 Unauthorized` response is returned immediately.
4. If the key is not valid, a `401 Unauthorized` response is returned with the message produced by the authorization service.
5. If the key exists but Public API access is not enabled for it, a `403 Forbidden` with an access-denied message is returned.
6. If the key exists but lacks permission for the requested operation, a `403 Forbidden` with an access-denied message is returned.
7. On success, the request proceeds and the response is localized according to the `Accept-Language` header.

Authenticated clients are cached for 30 minutes, so a key that has just been revoked may keep working for a short while.

## Response Codes & Errors

### Authentication Errors

| Status Code | Description | Error Response |
|------------|-------------|----------------|
| `401 Unauthorized` | API key header is missing | `{ "message": "Missing API Key" }` |
| `401 Unauthorized` | API key is invalid | `{ "message": "..." }` (message from the authorization service) |
| `403 Forbidden` | Public API is not enabled for the key | `{ "message": "Public API access is not available for this API Key" }` |
| `403 Forbidden` | Insufficient permissions | `{ "message": "Access denied. This API Key has limited access and cannot perform this operation." }` |

### Error Examples

#### Missing API Key
**Request:**

```bash
curl -X GET "https://api.armsoft.am/accountant/v1/directories/materials/1001"
```

**Response:**

```json
HTTP/1.1 401 Unauthorized
{ "message": "Missing API Key" }
```

#### API Key Without Public API Access
**Request:**

```bash
curl -X GET "https://api.armsoft.am/accountant/v1/directories/materials/1001" \
  -H "apiKey: not-enabled-key-12345"
```

**Response:**

```json
HTTP/1.1 403 Forbidden
{ "message": "Public API access is not available for this API Key" }
```

#### Access Denied (Limited Access Key)
**Request:**

```bash
curl -X DELETE "https://api.armsoft.am/accountant/v1/directories/materials/1001" \
  -H "apiKey: limited-access-key"
```

**Response:**

```json
HTTP/1.1 403 Forbidden
{ "message": "Access denied. This API Key has limited access and cannot perform this operation." }
```

## Multi-Language Support

### Setting Language
Use the `Accept-Language` header:

```http
Accept-Language: hy-AM  # Armenian (default)
Accept-Language: en-US  # English
Accept-Language: ru-RU  # Russian
```

### Language Impact

The language setting affects:
- ✅ Error messages
- ✅ Validation messages
- ✅ Localized field names

### Example: Armenian Response

```bash
curl -X GET "https://api.armsoft.am/accountant/v1/directories/materials/INVALID" \
  -H "apiKey: your-api-key-here" \
  -H "Accept-Language: hy-AM"
```

**Response:**

```json
{ "message": "Նյութը չի գտնվել" }
```

### Example: English Response

```bash
curl -X GET "https://api.armsoft.am/accountant/v1/directories/materials/INVALID" \
  -H "apiKey: your-api-key-here" \
  -H "Accept-Language: en-US"
```

**Response:**

```json
{ "message": "Material not found" }
```

## Obtaining an API Key

### Contact Administrator

Contact your ArmSoft system administrator or account manager to request an API key.

### Specify Access Level

Determine which type of API key you need:
- **Full Access**: For internal systems and trusted integrations
- **Limited Access**: For read-only reporting and analytics applications

### Receive Credentials

You will receive:
- API Key (string format)
- API Base URL
- Documentation link
- Access level details

## Implementation Examples

### C# (.NET)

#### Basic HTTP Client Setup

```csharp
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class ArmsoftApiClient
{
    private readonly HttpClient _httpClient;
    private const string BaseUrl = "https://api.armsoft.am/accountant/v1";

    public ArmsoftApiClient(string apiKey, string language = "en-US")
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(BaseUrl)
        };

        // Add authentication and language headers
        _httpClient.DefaultRequestHeaders.Add("apiKey", apiKey);
        _httpClient.DefaultRequestHeaders.Add("Accept-Language", language);
    }

    public async Task<T> GetAsync<T>(string endpoint)
    {
        var response = await _httpClient.GetAsync(endpoint);

        if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized ||
            response.StatusCode == System.Net.HttpStatusCode.Forbidden)
        {
            throw new UnauthorizedAccessException("Invalid API key or insufficient permissions");
        }

        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<T>();
    }
}
```

#### Usage Example

```csharp
// Get API key from environment variable
var apiKey = Environment.GetEnvironmentVariable("ARMSOFT_API_KEY");
var client = new ArmsoftApiClient(apiKey, "en-US");

try
{
    var material = await client.GetAsync<Material>("directories/materials/1001");
    Console.WriteLine($"Material: {material.Name}");
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine($"Authentication Error: {ex.Message}");
}
catch (HttpRequestException ex)
{
    Console.WriteLine($"API Error: {ex.Message}");
}
```
