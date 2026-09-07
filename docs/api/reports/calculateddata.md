# Reports - Calculated Data

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_reports_calculateddata.htm)

## Description

Returns the wages **Calculated data** report (`Հաշվարկային տվյալներ` / `Расчетные данные`): every
accrual and deduction confirmed and calculated for a period, per employee, with the income tax,
funded pension, stamp fee and insurance fee amounts and the accounting entry each row belongs to.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/reports/calculateddata`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey` (also reachable with a limited-access key)

## Request body (example)

A `CalculatedDataParam` object.

```json
{
  "startDate": "2026-01-01",
  "endDate": "2026-01-31",
  "department": "01",
  "extended": false,
  "pageSize": 5000
}
```

### Request body fields

| Field | Type | Description |
|-------|------|-------------|
| `startDate` | date | Period begin. Defaults to the current date when omitted |
| `endDate` | date | Period end. Defaults to the current date when omitted |
| `accrualDeduction` | string | Accrual/deduction code. When filled, only rows of that accrual/deduction are returned |
| `contractType` | string | Contract type - `1` employment, `2` civil |
| `employees` | array of string | Employee numbers (`employeeCode`). When empty, every employee is returned |
| `department` | string | Department code |
| `extended` | boolean | Extended mode - see [Extended mode](#extended-mode) |
| `pageSize` | integer | Pagination; `0` or omitted returns every row in one response. See [Pagination](../../pagination.md) |

### Extended mode

With `extended: false` the response carries the calculation itself - period, employee,
accrual/deduction, amounts, accounts and timesheet figures.

With `extended: true` the service additionally resolves the accrual/deduction, employee and partner
attributes: `amountCalculationMethodName`, `incomeTypeName`, `includeInAverageWageName`,
`fundingSourceName`, `vacationType`, `debitPartnerCode`, `debitPartnerName`, `creditPartnerCode`
and `creditPartnerName`. Those fields come back empty when `extended` is `false`.

`vacationType` is filled only for the system vacation accrual/deductions (`941`, `942`, `943`);
for every other accrual/deduction the same source value is reported as `fundingSource` /
`fundingSourceName` instead.

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `CalculatedDataRowApiResponse` object with paging metadata and an array of
`CalculatedDataRow` rows.

### Sample response

```json
{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "hasMore": true,
  "data": [
    {
      "year": 2026,
      "month": "01",
      "department": "01",
      "employeeId": 100001,
      "employeeCode": "0001",
      "employeeName": "Sample employee",
      "socialCardNumber": "12345678",
      "contractType": "1",
      "contractTypeName": "Employment",
      "accrualDeductionCode": "001",
      "accrualDeductionName": "Salary",
      "calculatedAmount": 300000,
      "debitAccount": "7130",
      "debitPartnerId": 0,
      "debitPartnerCode": "",
      "debitPartnerName": "",
      "creditAccount": "5270",
      "creditPartnerId": 0,
      "creditPartnerCode": "",
      "creditPartnerName": "",
      "analytic1": "",
      "analytic2": "",
      "date": "2026-01-31",
      "initialAmount": 300000,
      "incomeTax": 60000,
      "pension": 15000,
      "stampFeeAmount": 1500,
      "insuranceFeeAmount": 0,
      "monthDays": 22,
      "actualDays": 22,
      "monthHours": 176,
      "actualHours": 176,
      "paymentType": "",
      "accrualDeductionType": "1",
      "amountCalculationMethod": "1",
      "amountCalculationMethodName": "Monthly rate",
      "useEmployeeTimesheet": true,
      "timesheetCode": "01",
      "coefficient": 1,
      "fundingSource": "1",
      "fundingSourceName": "At employer's account",
      "vacationType": "",
      "incomeType": "1",
      "incomeTypeName": "BaseIncome",
      "reverseCalculation": false,
      "deductAccrualDeductionIncomeTax": true,
      "reducedIncome": false,
      "storedInMandatoryFundedPension": true,
      "reduceStampFeeTaxableAmount": false,
      "reduceInsuranceFeeTaxableAmount": false,
      "participatingInEmployerPensionCalculation": false,
      "onlyForTaxCalculation": false,
      "calculateTradeUnionDue": false,
      "includeInAverageWage": "1",
      "includeInAverageWageName": "Included",
      "resident": true,
      "deductEmployeeIncomeTax": true,
      "deductFundedPensionFromIncomeTax": true,
      "participationStatus": "1",
      "percentPaidByEmployer": 0,
      "amountPaidByEmployer": 0,
      "stampFee": "1",
      "insuranceFee": "0",
      "userId": 1,
      "userName": "admin",
      "transaction": true
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/reports/calculateddata" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"startDate": "2026-01-01", "endDate": "2026-01-31", "department": "01", "extended": false, "pageSize": 5000}'
```

## `CalculatedDataRow` fields

| Field | Type | Description |
|-------|------|-------------|
| `year` | integer | Year |
| `month` | string | Month, two digits (`01` - `12`) |
| `department` | string | Department |
| `employeeId` | integer | Employee inner number |
| `employeeCode` | string | Employee number |
| `employeeName` | string | Employee |
| `socialCardNumber` | string | Social card number |
| `contractType` | string | Contract type |
| `contractTypeName` | string | Contract type name |
| `accrualDeductionCode` | string | Accrual/deduction code |
| `accrualDeductionName` | string | Accrual/deduction name |
| `calculatedAmount` | number | Calc. amount |
| `debitAccount` | string | Account debit |
| `debitPartnerId` | integer | Debit partner inner number |
| `debitPartnerCode` | string | Debit partner (extended mode) |
| `debitPartnerName` | string | Debit partner name (extended mode) |
| `creditAccount` | string | Account credit |
| `creditPartnerId` | integer | Credit partner inner number |
| `creditPartnerCode` | string | Credit partner (extended mode) |
| `creditPartnerName` | string | Credit partner name (extended mode) |
| `analytic1` | string | An. dimension 1 |
| `analytic2` | string | An. dimension 2 |
| `date` | date | Date |
| `initialAmount` | number | Initial amount |
| `incomeTax` | number | Income tax |
| `pension` | number | Pension |
| `stampFeeAmount` | number | Stamp fee amount |
| `insuranceFeeAmount` | number | Insurance fee amount |
| `monthDays` | number | Month days |
| `actualDays` | number | Actual days |
| `monthHours` | number | Month hours |
| `actualHours` | number | Actual hours |
| `paymentType` | string | Payment type |
| `accrualDeductionType` | string | Accrual/deduction type |
| `amountCalculationMethod` | string | Amount calculation method |
| `amountCalculationMethodName` | string | Amount calculation method name (extended mode) |
| `useEmployeeTimesheet` | boolean | Use employee's timesheet |
| `timesheetCode` | string | Timesheet code |
| `coefficient` | number | Coefficient |
| `fundingSource` | string | Funding source |
| `fundingSourceName` | string | Funding source name (extended mode) |
| `vacationType` | string | Type of vacation (extended mode, vacation accrual/deductions only) |
| `incomeType` | string | Income Type |
| `incomeTypeName` | string | Income type name (extended mode) |
| `reverseCalculation` | boolean | Reverse calculation (net to gross) |
| `deductAccrualDeductionIncomeTax` | boolean | Deduct accrual/deduction income tax |
| `reducedIncome` | boolean | F/H reduced income |
| `storedInMandatoryFundedPension` | boolean | F/H Stored in the mandatory funded pension |
| `reduceStampFeeTaxableAmount` | boolean | Reduce from taxable amount of stamp fee |
| `reduceInsuranceFeeTaxableAmount` | boolean | Reduce from taxable amount of insurance fee |
| `participatingInEmployerPensionCalculation` | boolean | F/H Participating in employer-provided pension calculation |
| `onlyForTaxCalculation` | boolean | Only for tax calculation |
| `calculateTradeUnionDue` | boolean | Calculate trade union due |
| `includeInAverageWage` | string | Include in the average wage |
| `includeInAverageWageName` | string | Include in the average wage - name (extended mode) |
| `resident` | boolean | RA citizen (resident) |
| `deductEmployeeIncomeTax` | boolean | Deduct employee income tax |
| `deductFundedPensionFromIncomeTax` | boolean | Employee's funded pension amount is deducted from the income tax. |
| `participationStatus` | string | Participation Status |
| `percentPaidByEmployer` | number | Percent paid by the employer |
| `amountPaidByEmployer` | number | Summa paid by the employer |
| `stampFee` | string | Stamp fee |
| `insuranceFee` | string | Insurance fee |
| `userId` | integer | User inner number |
| `userName` | string | User name |
| `transaction` | boolean | Whether the accounting entries of the row are registered |

### Coded field values

| Field | Value | Meaning |
|-------|-------|---------|
| `contractType` | `1` / `2` | Employment / Civil |
| `accrualDeductionType` | `1` / `2` | Accruals / Deductions |
| `amountCalculationMethod` | `1` / `2` / `3` | Monthly rate / Daily rate / Hourly rate |
| `incomeType` | `1` / `2` / `3` | Base income / Civil contract income / Other income |
| `includeInAverageWage` | `0` / `1` / `2` | Not included / Included / Included with 1/12 part |
| `fundingSource` | `1` / `2` | At employer's account / At state budget's account |
| `participationStatus` | `0` - `5` | Funded pension participation: `0` not participant, `1` mandatory system mandatory participant, `2` mandatory system voluntary participant, `3` voluntary system participant, `4` both systems mandatory participant, `5` both systems voluntary participant |
| `stampFee` | `0` / `1` / `2` / `3` | Not payer / Payer / Paid by employer / With minimum wage verification |
| `insuranceFee` | `0` / `1` / `2` | Not payer / Payer / Paid by employer |

`vacationType`, `contractTypeName`, `amountCalculationMethodName`, `incomeTypeName`,
`fundingSourceName` and `includeInAverageWageName` carry the localized caption of the
corresponding code, translated according to the `Accept-Language` header. `vacationType` is one
of Annual vacation, Additional vacation, Study leave, Leave to perform state duties or
Paternity leave.

`paymentType` is filled only in public-sector mode.

## Pagination

When the response contains `hasMore: true`, fetch the following pages from
[`/v1/reports/calculateddata/nextpage`](calculateddata-nextpage.md). See [Pagination](../../pagination.md).
