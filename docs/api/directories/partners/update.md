# Partners - Update

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_partners.htm)

## Description

Replaces an existing partner record with the supplied values.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `PUT`
- **Route:** `/v1/directories/partners/{code}`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Partner code to update |

## Request body (example)

A complete `Partner` object - properties that are omitted are cleared, so send the full
record. See the [field reference](README.md#partner-fields).

```json
{
  "code": "P0001",
  "name": "Sample name",
  "fullName": "Sample full name",
  "taxCode": "01234567",
  "group": "01",
  "vatPayer": true,
  "legalAddress": "",
  "businessAddress": "",
  "managerName": "",
  "managerPosition": "",
  "accountantName": "",
  "accountantPosition": "",
  "stateRegisterNumber": "",
  "idDocumentType": "",
  "passportNumber": "",
  "socialCardNumber": "",
  "paymentMainAim": "",
  "phoneNumber": "+37410000000",
  "email": "info@example.com",
  "contract": "",
  "contractDate": "2026-01-15",
  "salesDiscountPercent": 0,
  "status": "",
  "additionalData": "",
  "shippingMethod": "",
  "additionalFullName": "",
  "credentialNumber": "",
  "credentialDate": "2026-01-15",
  "isClosed": false,
  "settlementAccounts": [
    {
      "account": "2110",
      "name": "Sample name",
      "default": false
    }
  ],
  "additionalAddresses": [
    {
      "name": "Sample name",
      "default": false
    }
  ]
}
```

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the updated `Partner` object.
