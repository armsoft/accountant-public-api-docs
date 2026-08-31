# Services API

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_services.htm)

Services endpoints map to `ServicesController` in API version `v1`.

## Endpoints

- [List Services](list.md)
- [Next Page](nextpage.md)
- [Create Service](create.md)
- [Get Service](get.md)
- [Update Service](update.md)
- [Delete Service](delete.md)

## Base Path

`/accountant/v1/directories/services`

## `Service` fields

| Field | Type | Description |
|-------|------|-------------|
| `id` | integer | Inner number |
| `code` | string | Code |
| `name` | string | Name |
| `fullName` | string | Full name |
| `unitMeasure` | string | Unit of measure |
| `unitMeasureName` | string | Name |
| `unitMeasureAbbreviation` | string | Unit of measure |
| `cpaClassifier` | string | — |
| `account` | string | Account |
| `revenueAccount` | string | Revenue account |
| `retailRevenueAccount` | string | Retail revenue account |
| `revenueAdjustmentAccount` | string | Revenue adjustment account for Sales Return |
| `wholePrice` | number | Whole price in drams |
| `retailPrice` | number | Retail price in drams |
| `currency` | string | Currency |
| `currencyPrice` | number | Whole price in currency |
| `barcode` | string | Barcode |
| `vat` | boolean | — |
| `isClosed` | boolean | Closed |
