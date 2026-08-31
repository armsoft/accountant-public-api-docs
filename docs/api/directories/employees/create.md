# Employees - Create

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_employees.htm)

## Description

Creates a new employee record.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/employees`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `Employee` object. `id` is assigned by the server and is ignored on create.
See the [field reference](README.md#employee-fields) for every property.

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

- **Status:** `201 Created`
- **Content type:** `application/json`

Returns the created `Employee` object, including the server-assigned `id`.
