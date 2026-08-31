# Services - Create

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_services.htm)

## Description

Creates a new service record.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/services`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `Service` object. `id` is assigned by the server and is ignored on create.
See the [field reference](README.md#service-fields) for every property.

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

- **Status:** `201 Created`
- **Content type:** `application/json`

Returns the created `Service` object, including the server-assigned `id`.
