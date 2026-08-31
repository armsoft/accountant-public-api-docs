# Employees - Update

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_employees.htm)

## Description

Replaces an existing employee record with the supplied values.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `PUT`
- **Route:** `/v1/directories/employees/{code}`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Employee code to update |

## Request body (example)

A complete `Employee` object - properties that are omitted are cleared, so send the full
record. See the [field reference](README.md#employee-fields).

```json
{
  "code": "0001",
  "fullName": "Sample full name",
  "departmentCode": "",
  "positionCode": "",
  "positionStartDate": "2026-01-15",
  "professionCode": "",
  "genderCode": "",
  "birthDate": "2026-01-15",
  "contractTypeCode": "",
  "defaultAccrual": "",
  "defaultTimeSheet": "",
  "employmentStartDate": "2026-01-15",
  "employmentOrderNumber": "",
  "dateOfDismissal": "2026-01-15",
  "dismissalOrderNumber": "",
  "raCitizen": false,
  "calculateIncomeTax": false,
  "reducePensionFromIncomeTax": false,
  "salaryAccount": "",
  "partnerCode": "P0001",
  "tradeUnionDuesPercent": 0,
  "participationStatus": "",
  "employerPercent": 0,
  "employerAmount": 0,
  "stampFeeType": "",
  "insuranceFeeType": "",
  "insuranceFeeDate": "2026-01-15",
  "registrationPlaceRA": false,
  "registrationRegion": "",
  "registrationCommunity": "",
  "registrationCity": "",
  "registrationStreet": "",
  "registrationHouse": "",
  "registrationApartment": "",
  "registrationSameAsResidence": false,
  "placeResidenceRA": false,
  "residenceRegion": "",
  "residenceCommunity": "",
  "residenceLocation": "",
  "residenceCity": "",
  "residenceStreet": "",
  "residenceHouse": "",
  "residenceApartment": "",
  "residenceCountry": "",
  "addressLine1": "",
  "addressLine2": "",
  "addressLine3": "",
  "postalCode": "",
  "bankAccount": "",
  "socialCardNumber": "",
  "identificationDocumentType": "",
  "passport": "",
  "passportIssueDate": "2026-01-15",
  "passportIssuedBy": "",
  "nationality": "",
  "otherDocumentNumber": "",
  "phone": "+37410000000",
  "mobilePhone": "+37491000000",
  "email": "info@example.com",
  "languages": "",
  "maritalStatus": "",
  "education": "",
  "institute": "",
  "educationStartDate": "2026-01-15",
  "educationEndDate": "2026-01-15",
  "educationCertificateNumber": "",
  "militaryServiceDescription": "",
  "militaryServiceStartDate": "2026-01-15",
  "militaryServiceEndDate": "2026-01-15",
  "familyMember1Type": "",
  "familyMember1FullName": "",
  "familyMember2Type": "",
  "familyMember2FullName": "",
  "familyMember3Type": "",
  "familyMember3FullName": "",
  "familyMember4Type": "",
  "familyMember4FullName": "",
  "accrualsDeductions": [
    {
      "date": "2026-01-15",
      "code": "0001",
      "name": "Sample name",
      "amount": 10000,
      "default": false
    }
  ]
}
```

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the updated `Employee` object.
