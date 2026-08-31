# Services - Next Page

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_serviceslist.htm)

## Description

Fetches the next page of results for a previously executed `/list` request. Use it when the
initial list call returned `hasMore: true`.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/services/list/nextpage`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body

`NextPageRequest` object, for example:

```json
{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "close": false
}
```

Optionally send `"close": true` when you no longer need additional pages - the server then
releases the pagination context.

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the same `ServiceRowApiResponse` format as the initial `/list` call.

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/directories/services/list/nextpage" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"id": "550e8400-e29b-41d4-a716-446655440000", "close": false}'
```
