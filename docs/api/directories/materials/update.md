# Materials - Update

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_materials.htm)

## Description

Replaces an existing material record with the supplied values.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `PUT`
- **Route:** `/v1/directories/materials/{code}`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Material code to update |

## Request body (example)

A complete `Material` object - properties that are omitted are cleared, so send the full
record. See the [field reference](README.md#material-fields).

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

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the updated `Material` object.
