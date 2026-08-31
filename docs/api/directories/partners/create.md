# Partners - Create

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_partners.htm)

## Description

Creates a new partner record.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/partners`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `Partner` object. `id` is assigned by the server and is ignored on create.
See the [field reference](README.md#partner-fields) for every property.

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

- **Status:** `201 Created`
- **Content type:** `application/json`

Returns the created `Partner` object, including the server-assigned `id`.
