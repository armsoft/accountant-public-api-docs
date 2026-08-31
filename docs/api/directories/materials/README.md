# Materials API

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_materials.htm)

Materials endpoints map to `MaterialsController` in API version `v1`.

## Endpoints

- [List Materials](list.md)
- [Next Page](nextpage.md)
- [Create Material](create.md)
- [Get Material](get.md)
- [Update Material](update.md)
- [Delete Material](delete.md)

## Base Path

`/accountant/v1/directories/materials`

## `Material` fields

| Field | Type | Description |
|-------|------|-------------|
| `id` | integer | Inner number |
| `code` | string | Code |
| `name` | string | Name |
| `fullName` | string | Full name |
| `unitMeasure` | string | Unit of measure |
| `unitMeasureName` | string | Name |
| `unitMeasureAbbreviation` | string | Unit of measure |
| `group` | string | Group |
| `cpaClassifier` | string | — |
| `account` | string | Account |
| `wholePrice` | number | Whole price in drams |
| `retailPrice` | number | Retail price in drams |
| `currency` | string | Currency |
| `currencyPrice` | number | Whole price in currency |
| `specification` | string | Specification |
| `barcode` | string | Barcode |
| `externalCode` | string | External code |
| `costingMethod` | string | Costing  method |
| `aoeCoefficient` | number | — |
| `discountPercent` | number | Discount |
| `environmentalFeePercent` | number | Environmental fee (%) |
| `minimumQuantity` | number | Minimum quantity |
| `maximumQuantity` | number | Maximal quantity (max) |
| `vat` | boolean | — |
| `revenueAccount` | string | Revenue account |
| `retailRevenueAccount` | string | Retail revenue account |
| `expenseAccount` | string | Expense account |
| `revenueAdjustmentAccount` | string | Adjustment of income from materials sales returns |
| `isClosed` | boolean | Closed |
