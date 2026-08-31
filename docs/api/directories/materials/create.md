# Materials - Create

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_materials.htm)

## Description

Creates a new material record.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/materials`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `Material` object. `id` is assigned by the server and is ignored on create.
See the [field reference](README.md#material-fields) for every property.

```json
{
  "code": "1001",
  "name": "Sample name",
  "fullName": "Sample full name",
  "unitMeasure": "001",
  "unitMeasureName": "",
  "unitMeasureAbbreviation": "pcs",
  "group": "01",
  "cpaClassifier": "",
  "account": "2110",
  "wholePrice": 1000,
  "retailPrice": 1200,
  "currency": "AMD",
  "currencyPrice": 2.5,
  "specification": "",
  "barcode": "1234567890123",
  "externalCode": "",
  "costingMethod": "",
  "aoeCoefficient": 0,
  "discountPercent": 0,
  "environmentalFeePercent": 0,
  "minimumQuantity": 0,
  "maximumQuantity": 0,
  "vat": true,
  "revenueAccount": "6110",
  "retailRevenueAccount": "",
  "expenseAccount": "7110",
  "revenueAdjustmentAccount": "",
  "isClosed": false
}
```

## Successful response

- **Status:** `201 Created`
- **Content type:** `application/json`

Returns the created `Material` object, including the server-assigned `id`.
