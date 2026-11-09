# Materials Groups - GetAll

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_materialsgroups.htm)

## Description

Returns every materials group. Like Storages this call is a plain `GET` - it returns the full
array in one response and does not paginate.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/materialsgroups`
- **Authorization:** API key in header `apiKey`

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns an array of `MaterialsGroup` objects.

### Sample response

```json
[
  {
    "code": "10",
    "name": "Goods",
    "parent": "",
    "path": "10"
  },
  {
    "code": "00002",
    "name": "Stationery",
    "parent": "",
    "path": "00002"
  }
]
```

## Usage example

```bash
curl -X GET "https://api.armsoft.am/accountant/v1/directories/materialsgroups"   -H "accept: application/json"   -H "Accept-Language: hy-AM"   -H "apiKey: YOUR_API_KEY"
```
