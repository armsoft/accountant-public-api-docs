# Employees API

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_employees.htm)

Employees endpoints map to `EmployeesController` in API version `v1`.

## Endpoints

- [List Employees](list.md)
- [Next Page](nextpage.md)
- [Create Employee](create.md)
- [Get Employee](get.md)
- [Update Employee](update.md)
- [Delete Employee](delete.md)

## Base Path

`/accountant/v1/directories/employees`

## `Employee` fields

| Field | Type | Description |
|-------|------|-------------|
| `id` | integer | Inner number |
| `code` | string | Code |
| `fullName` | string | Full name |
| `departmentCode` | string | Department |
| `positionCode` | string | Position |
| `positionStartDate` | date | Position start |
| `professionCode` | string | Profession |
| `genderCode` | string | Gender |
| `birthDate` | date | Birth date |
| `contractTypeCode` | string | Contract type |
| `defaultAccrual` | string | Default accrual |
| `defaultTimeSheet` | string | Default timesheet |
| `employmentStartDate` | date | Employment start date |
| `employmentOrderNumber` | string | N of employment order |
| `dateOfDismissal` | date | Date of dismissal |
| `dismissalOrderNumber` | string | N of dismissal order |
| `raCitizen` | boolean | — |
| `calculateIncomeTax` | boolean | Calculate income tax |
| `reducePensionFromIncomeTax` | boolean | Deduct employee's funded pension amount from the income tax. |
| `salaryAccount` | string | Salary payable |
| `partnerCode` | string | Individual (partner) |
| `tradeUnionDuesPercent` | number | Trade union dues percent |
| `participationStatus` | string | Participation Status |
| `employerPercent` | number | Employer paid percent/summa |
| `employerAmount` | number | Employer paid percent/summa |
| `stampFeeType` | string | Stamp fee |
| `insuranceFeeType` | string | Insurance fee |
| `insuranceFeeDate` | date | Status start date |
| `registrationPlaceRA` | boolean | Place of registration in RA |
| `registrationRegion` | string | Region |
| `registrationCommunity` | string | Community |
| `registrationCity` | string | City, village |
| `registrationStreet` | string | Street, house/building, apartment |
| `registrationHouse` | string | Street, house/building, apartment |
| `registrationApartment` | string | Street, house/building, apartment |
| `registrationSameAsResidence` | boolean | Place of residence is the same with registration place |
| `placeResidenceRA` | boolean | Place of residence is RA |
| `residenceRegion` | string | Region |
| `residenceCommunity` | string | Community |
| `residenceLocation` | string | Location |
| `residenceCity` | string | City, village |
| `residenceStreet` | string | Street, house/building, apartment |
| `residenceHouse` | string | Street, house/building, apartment |
| `residenceApartment` | string | Street, house/building, apartment |
| `residenceCountry` | string | Country |
| `addressLine1` | string | AddressLine 1,2,3 |
| `addressLine2` | string | AddressLine 1,2,3 |
| `addressLine3` | string | AddressLine 1,2,3 |
| `postalCode` | string | Postal N |
| `bankAccount` | string | Employee bank account |
| `socialCardNumber` | string | Social card number |
| `identificationDocumentType` | string | Identification document |
| `passport` | string | Passport N |
| `passportIssueDate` | date | Date issued |
| `passportIssuedBy` | string | Authority |
| `nationality` | string | Nationality |
| `otherDocumentNumber` | string | Other document N |
| `phone` | string | Phone |
| `mobilePhone` | string | Mobile phone |
| `email` | string | E-Mail |
| `languages` | string | Foreign languages |
| `maritalStatus` | string | Marital status |
| `education` | string | Education |
| `institute` | string | Educational institution |
| `educationStartDate` | date | Admiss. year |
| `educationEndDate` | date | Graduation year |
| `educationCertificateNumber` | string | Diploma or Certificate number |
| `militaryServiceDescription` | string | Description |
| `militaryServiceStartDate` | date | Start |
| `militaryServiceEndDate` | date | End |
| `familyMember1Type` | string | Family member |
| `familyMember1FullName` | string | Family member |
| `familyMember2Type` | string | Family member |
| `familyMember2FullName` | string | Family member |
| `familyMember3Type` | string | Family member |
| `familyMember3FullName` | string | Family member |
| `familyMember4Type` | string | Family member |
| `familyMember4FullName` | string | Family member |
| `accrualsDeductions` | array<EmployeeFeeHoldRow> | Accrual/deductions |
