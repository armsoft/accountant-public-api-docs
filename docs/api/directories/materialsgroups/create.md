# Materials Groups - Create

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_materialsgroups.htm)

## Description

Creates a new materials group.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/materialsgroups`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `MaterialsGroup` object. `name` is required; omit `code` to let the system assign the next
sequential code, and `parent` to create a top-level group. `path` is ignored.

```json
{
  "name": "Stationery"
}
```

## Successful response

- **Status:** `201 Created`
- **Content type:** `application/json`

Returns the created `MaterialsGroup` object.

```json
{
  "code": "00002",
  "name": "Stationery",
  "parent": "",
  "path": "00002"
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/directories/materialsgroups"   -H "accept: application/json"   -H "Accept-Language: hy-AM"   -H "apiKey: YOUR_API_KEY"   -H "Content-Type: application/json"   -d '{"name": "Stationery"}'
```
