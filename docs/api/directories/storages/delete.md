# Storages - Delete

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_storages.htm)

## Description

Deletes a storage by code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `DELETE`
- **Route:** `/v1/directories/storages/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Storage code to remove |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json` (empty body)

A storage that already holds material movements cannot be deleted.
