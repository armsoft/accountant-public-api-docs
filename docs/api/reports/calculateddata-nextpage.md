# Reports - Calculated Data (Next Page)

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_reports_calculateddata.htm)

## Description

Retrieves the next page of an ongoing `/v1/reports/calculateddata` request.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/reports/calculateddata/nextpage`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey` (also reachable with a limited-access key)

## Request body (example)

```json
{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "close": false
}
```

Send `"close": true` when you no longer need additional pages, so the server can release the
pagination context.

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the same `CalculatedDataRowApiResponse` format as the initial call. When the pagination
context has already been closed or has expired, an empty response (`hasMore: false`, `data: []`)
is returned.

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/reports/calculateddata/nextpage" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"id": "550e8400-e29b-41d4-a716-446655440000", "close": false}'
```
