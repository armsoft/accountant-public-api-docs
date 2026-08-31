# Partners API

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_partners.htm)

Partners endpoints map to `PartnersController` in API version `v1`.

## Endpoints

- [List Partners](list.md)
- [Next Page](nextpage.md)
- [Create Partner](create.md)
- [Get Partner](get.md)
- [Update Partner](update.md)
- [Delete Partner](delete.md)

## Base Path

`/accountant/v1/directories/partners`

## `Partner` fields

| Field | Type | Description |
|-------|------|-------------|
| `id` | integer | Inner number |
| `code` | string | Code |
| `name` | string | Name |
| `fullName` | string | Full name |
| `taxCode` | string | Taxpayer’s ID |
| `group` | string | Group |
| `vatPayer` | boolean | — |
| `legalAddress` | string | Legal address |
| `businessAddress` | string | Bus. address |
| `managerName` | string | Manager first name, last name |
| `managerPosition` | string | Manager position |
| `accountantName` | string | Accountant first name, last name |
| `accountantPosition` | string | Accountant position |
| `stateRegisterNumber` | string | S/P state regist. N |
| `idDocumentType` | string | Identification document |
| `passportNumber` | string | Passport N |
| `socialCardNumber` | string | Social card number |
| `paymentMainAim` | string | Payment main aim |
| `phoneNumber` | string | Phone number |
| `email` | string | E-Mail |
| `contract` | string | Contract |
| `contractDate` | date | Contract date |
| `salesDiscountPercent` | number | Sales discount percent |
| `status` | string | Status |
| `additionalData` | string | Additional data |
| `shippingMethod` | string | Shipping method |
| `additionalFullName` | string | Full name |
| `credentialNumber` | string | Credential number |
| `credentialDate` | date | Credential date |
| `isClosed` | boolean | Closed |
| `settlementAccounts` | array<PartnerSettlementAccountRow> | Settlement accounts |
| `additionalAddresses` | array<PartnerBusinessAddressRow> | Business address |
