# Journals - Invoices (Next Page)

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_invoices.htm)

## Description

Retrieves the next page of an ongoing `/v1/journals/invoices` request.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/journals/invoices/nextpage`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

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

Returns the same `InvoiceDocumentsJournalDataRowApiResponse` format as the initial call.

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/journals/invoices/nextpage" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"id": "550e8400-e29b-41d4-a716-446655440000", "close": false}'
```
