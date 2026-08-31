# Employees - GetAll

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_employeeslist.htm)

## Description

Returns the list of employee records matching the supplied filters.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/employees/list`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `EmployeeFilters` object. Every filter is optional.

```json
{
  "codes": [
    "0001",
    "0002"
  ],
  "pageSize": 5000
}
```

### Request body field notes

- `codes` - Code.
- `lastModifiedDate` - Last modification date.
- `pageSize` (optional) controls pagination: `0` or omitted returns every row in one response; a value greater than `0` returns pages. See [Pagination](../../../pagination.md).

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `EmployeeRowApiResponse` object with paging metadata and an array of `EmployeeRow` records.

### Sample response

```json
{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "hasMore": true,
  "data": [
    {
      "id": 100001,
      "code": "0001",
      "fullName": "Sample full name",
      "departmentCode": "",
      "departmentName": "",
      "positionCode": "",
      "positionName": "",
      "positionStartDate": "2026-01-15",
      "defaultTimeSheet": "",
      "contractTypeCode": "",
      "contractTypeName": "",
      "employmentStartDate": "2026-01-15",
      "dateOfDismissal": "2026-01-15",
      "birthDate": "2026-01-15",
      "genderCode": "",
      "genderName": "",
      "phone": "+37410000000",
      "passport": "",
      "bankAccount": "",
      "professionCode": "",
      "professionName": "",
      "raCitizen": false,
      "calculateIncomeTax": false,
      "stampFeeType": "",
      "insuranceFeeType": "",
      "insuranceFeeDate": "2026-01-15",
      "salaryAccount": "",
      "partnerCode": "P0001",
      "partnerName": "",
      "tradeUnionDuesPercent": 0,
      "participationStatus": "",
      "lastModifierName": "",
      "lastModifyDate": "2026-01-15T00:00:00Z"
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/directories/employees/list" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"codes": ["0001", "0002"], "pageSize": 5000}'
```

## Pagination

This endpoint supports pagination through the `pageSize` parameter. When the response contains
`hasMore: true`, fetch the following pages from [`/v1/directories/employees/list/nextpage`](nextpage.md).
See [Pagination](../../../pagination.md) for the full workflow.
