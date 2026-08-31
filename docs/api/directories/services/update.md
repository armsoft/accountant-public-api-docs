# Services - Update

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_services.htm)

## Description

Replaces an existing service record with the supplied values.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `PUT`
- **Route:** `/v1/directories/services/{code}`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Service code to update |

## Request body (example)

A complete `Service` object - properties that are omitted are cleared, so send the full
record. See the [field reference](README.md#service-fields).

```json
{
  "code": "S001",
  "name": "Sample name",
  "fullName": "Sample full name",
  "unitMeasure": "001",
  "unitMeasureName": "",
  "unitMeasureAbbreviation": "pcs",
  "cpaClassifier": "",
  "account": "2110",
  "revenueAccount": "6110",
  "retailRevenueAccount": "",
  "revenueAdjustmentAccount": "",
  "wholePrice": 1000,
  "retailPrice": 1200,
  "currency": "AMD",
  "currencyPrice": 2.5,
  "barcode": "1234567890123",
  "vat": true,
  "isClosed": false
}
```

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the updated `Service` object.
