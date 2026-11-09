# Materials Groups - Update

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_materialsgroups.htm)

## Description

Updates an existing materials group. Only the fields you send are changed: `name` and
`parent` are applied when present, the group's `code` cannot be changed, and `path` is
ignored.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `PUT`
- **Route:** `/v1/directories/materialsgroups/{code}`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Materials group code to update |

## Request body (example)

A `MaterialsGroup` object.

```json
{
  "name": "Office stationery",
  "parent": "10"
}
```

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the updated `MaterialsGroup` object.
