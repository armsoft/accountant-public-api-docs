<!-- Generator: Widdershins v4.0.1 -->

<h1 id="accountant-public-api">Accountant Public API v1.0</h1>

> Scroll down for code samples, example requests and responses. Select a language for code samples from the tabs above or the mobile navigation menu.

Base URLs:

* <a href="/accountant">/accountant</a>

Email: <a href="mailto:support@armsoft.am">Armsoft</a> Web: <a href="https://www.armsoft.am">Armsoft</a> 

# Authentication

* API Key (API Key)
    - Parameter Name: **apiKey**, in: header. Please insert client api key into field

<h1 id="accountant-public-api-employees">Employees</h1>

## post__v1_directories_employees_list

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/directories/employees/list \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/directories/employees/list HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "codes": [
    "string"
  ],
  "lastModifiedDate": "2019-08-24T14:15:22Z"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/employees/list',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/directories/employees/list',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/directories/employees/list', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/directories/employees/list', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/employees/list");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/directories/employees/list", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/employees/list`

> Body parameter

```json
{
  "pageSize": 0,
  "codes": [
    "string"
  ],
  "lastModifiedDate": "2019-08-24T14:15:22Z"
}
```

<h3 id="post__v1_directories_employees_list-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[EmployeeFilters](#schemaemployeefilters)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","fullName":"string","departmentCode":"string","departmentName":"string","positionCode":"string","positionName":"string","positionStartDate":"2019-08-24","defaultTimeSheet":"string","contractTypeCode":"string","contractTypeName":"string","employmentStartDate":"2019-08-24","dateOfDismissal":"2019-08-24","birthDate":"2019-08-24","genderCode":"string","genderName":"string","phone":"string","passport":"string","bankAccount":"string","professionCode":"string","professionName":"string","raCitizen":true,"calculateIncomeTax":true,"stampFeeType":"string","insuranceFeeType":"string","insuranceFeeDate":"2019-08-24","salaryAccount":"string","partnerCode":"string","partnerName":"string","tradeUnionDuesPercent":0.1,"participationStatus":"string","lastModifierName":"string","lastModifyDate":"2019-08-24T14:15:22Z"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "fullName": "string",
      "departmentCode": "string",
      "departmentName": "string",
      "positionCode": "string",
      "positionName": "string",
      "positionStartDate": "2019-08-24",
      "defaultTimeSheet": "string",
      "contractTypeCode": "string",
      "contractTypeName": "string",
      "employmentStartDate": "2019-08-24",
      "dateOfDismissal": "2019-08-24",
      "birthDate": "2019-08-24",
      "genderCode": "string",
      "genderName": "string",
      "phone": "string",
      "passport": "string",
      "bankAccount": "string",
      "professionCode": "string",
      "professionName": "string",
      "raCitizen": true,
      "calculateIncomeTax": true,
      "stampFeeType": "string",
      "insuranceFeeType": "string",
      "insuranceFeeDate": "2019-08-24",
      "salaryAccount": "string",
      "partnerCode": "string",
      "partnerName": "string",
      "tradeUnionDuesPercent": 0.1,
      "participationStatus": "string",
      "lastModifierName": "string",
      "lastModifyDate": "2019-08-24T14:15:22Z"
    }
  ]
}
```

<h3 id="post__v1_directories_employees_list-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[EmployeeRowApiResponse](#schemaemployeerowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_employees_list_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/directories/employees/list/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/directories/employees/list/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/employees/list/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/directories/employees/list/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/directories/employees/list/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/directories/employees/list/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/employees/list/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/directories/employees/list/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/employees/list/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_directories_employees_list_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","fullName":"string","departmentCode":"string","departmentName":"string","positionCode":"string","positionName":"string","positionStartDate":"2019-08-24","defaultTimeSheet":"string","contractTypeCode":"string","contractTypeName":"string","employmentStartDate":"2019-08-24","dateOfDismissal":"2019-08-24","birthDate":"2019-08-24","genderCode":"string","genderName":"string","phone":"string","passport":"string","bankAccount":"string","professionCode":"string","professionName":"string","raCitizen":true,"calculateIncomeTax":true,"stampFeeType":"string","insuranceFeeType":"string","insuranceFeeDate":"2019-08-24","salaryAccount":"string","partnerCode":"string","partnerName":"string","tradeUnionDuesPercent":0.1,"participationStatus":"string","lastModifierName":"string","lastModifyDate":"2019-08-24T14:15:22Z"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "fullName": "string",
      "departmentCode": "string",
      "departmentName": "string",
      "positionCode": "string",
      "positionName": "string",
      "positionStartDate": "2019-08-24",
      "defaultTimeSheet": "string",
      "contractTypeCode": "string",
      "contractTypeName": "string",
      "employmentStartDate": "2019-08-24",
      "dateOfDismissal": "2019-08-24",
      "birthDate": "2019-08-24",
      "genderCode": "string",
      "genderName": "string",
      "phone": "string",
      "passport": "string",
      "bankAccount": "string",
      "professionCode": "string",
      "professionName": "string",
      "raCitizen": true,
      "calculateIncomeTax": true,
      "stampFeeType": "string",
      "insuranceFeeType": "string",
      "insuranceFeeDate": "2019-08-24",
      "salaryAccount": "string",
      "partnerCode": "string",
      "partnerName": "string",
      "tradeUnionDuesPercent": 0.1,
      "participationStatus": "string",
      "lastModifierName": "string",
      "lastModifyDate": "2019-08-24T14:15:22Z"
    }
  ]
}
```

<h3 id="post__v1_directories_employees_list_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[EmployeeRowApiResponse](#schemaemployeerowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## get__v1_directories_employees_{code}

> Code samples

```shell
# You can also use wget
curl -X GET /accountant/v1/directories/employees/{code} \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /accountant/v1/directories/employees/{code} HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/employees/{code}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/accountant/v1/directories/employees/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/accountant/v1/directories/employees/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/accountant/v1/directories/employees/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/employees/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/accountant/v1/directories/employees/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/employees/{code}`

<h3 id="get__v1_directories_employees_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
{"id":0,"code":"string","fullName":"string","departmentCode":"string","positionCode":"string","positionStartDate":"2019-08-24","professionCode":"string","genderCode":"string","birthDate":"2019-08-24","contractTypeCode":"string","defaultAccrual":"string","defaultTimeSheet":"string","employmentStartDate":"2019-08-24","employmentOrderNumber":"string","dateOfDismissal":"2019-08-24","dismissalOrderNumber":"string","raCitizen":true,"calculateIncomeTax":true,"reducePensionFromIncomeTax":true,"salaryAccount":"string","partnerCode":"string","tradeUnionDuesPercent":0.1,"participationStatus":"string","employerPercent":0.1,"employerAmount":0.1,"stampFeeType":"string","insuranceFeeType":"string","insuranceFeeDate":"2019-08-24","registrationPlaceRA":true,"registrationRegion":"string","registrationCommunity":"string","registrationCity":"string","registrationStreet":"string","registrationHouse":"string","registrationApartment":"string","registrationSameAsResidence":true,"placeResidenceRA":true,"residenceRegion":"string","residenceCommunity":"string","residenceLocation":"string","residenceCity":"string","residenceStreet":"string","residenceHouse":"string","residenceApartment":"string","residenceCountry":"string","addressLine1":"string","addressLine2":"string","addressLine3":"string","postalCode":"string","bankAccount":"string","socialCardNumber":"string","identificationDocumentType":"string","passport":"string","passportIssueDate":"2019-08-24","passportIssuedBy":"string","nationality":"string","otherDocumentNumber":"string","phone":"string","mobilePhone":"string","email":"string","languages":"string","maritalStatus":"string","education":"string","institute":"string","educationStartDate":"2019-08-24","educationEndDate":"2019-08-24","educationCertificateNumber":"string","militaryServiceDescription":"string","militaryServiceStartDate":"2019-08-24","militaryServiceEndDate":"2019-08-24","familyMember1Type":"string","familyMember1FullName":"string","familyMember2Type":"string","familyMember2FullName":"string","familyMember3Type":"string","familyMember3FullName":"string","familyMember4Type":"string","familyMember4FullName":"string","accrualsDeductions":[{"date":"2019-08-24","code":"string","name":"string","amount":0.1,"default":true}]}
```

```json
{
  "id": 0,
  "code": "string",
  "fullName": "string",
  "departmentCode": "string",
  "positionCode": "string",
  "positionStartDate": "2019-08-24",
  "professionCode": "string",
  "genderCode": "string",
  "birthDate": "2019-08-24",
  "contractTypeCode": "string",
  "defaultAccrual": "string",
  "defaultTimeSheet": "string",
  "employmentStartDate": "2019-08-24",
  "employmentOrderNumber": "string",
  "dateOfDismissal": "2019-08-24",
  "dismissalOrderNumber": "string",
  "raCitizen": true,
  "calculateIncomeTax": true,
  "reducePensionFromIncomeTax": true,
  "salaryAccount": "string",
  "partnerCode": "string",
  "tradeUnionDuesPercent": 0.1,
  "participationStatus": "string",
  "employerPercent": 0.1,
  "employerAmount": 0.1,
  "stampFeeType": "string",
  "insuranceFeeType": "string",
  "insuranceFeeDate": "2019-08-24",
  "registrationPlaceRA": true,
  "registrationRegion": "string",
  "registrationCommunity": "string",
  "registrationCity": "string",
  "registrationStreet": "string",
  "registrationHouse": "string",
  "registrationApartment": "string",
  "registrationSameAsResidence": true,
  "placeResidenceRA": true,
  "residenceRegion": "string",
  "residenceCommunity": "string",
  "residenceLocation": "string",
  "residenceCity": "string",
  "residenceStreet": "string",
  "residenceHouse": "string",
  "residenceApartment": "string",
  "residenceCountry": "string",
  "addressLine1": "string",
  "addressLine2": "string",
  "addressLine3": "string",
  "postalCode": "string",
  "bankAccount": "string",
  "socialCardNumber": "string",
  "identificationDocumentType": "string",
  "passport": "string",
  "passportIssueDate": "2019-08-24",
  "passportIssuedBy": "string",
  "nationality": "string",
  "otherDocumentNumber": "string",
  "phone": "string",
  "mobilePhone": "string",
  "email": "string",
  "languages": "string",
  "maritalStatus": "string",
  "education": "string",
  "institute": "string",
  "educationStartDate": "2019-08-24",
  "educationEndDate": "2019-08-24",
  "educationCertificateNumber": "string",
  "militaryServiceDescription": "string",
  "militaryServiceStartDate": "2019-08-24",
  "militaryServiceEndDate": "2019-08-24",
  "familyMember1Type": "string",
  "familyMember1FullName": "string",
  "familyMember2Type": "string",
  "familyMember2FullName": "string",
  "familyMember3Type": "string",
  "familyMember3FullName": "string",
  "familyMember4Type": "string",
  "familyMember4FullName": "string",
  "accrualsDeductions": [
    {
      "date": "2019-08-24",
      "code": "string",
      "name": "string",
      "amount": 0.1,
      "default": true
    }
  ]
}
```

<h3 id="get__v1_directories_employees_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[Employee](#schemaemployee)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_directories_employees_{code}

> Code samples

```shell
# You can also use wget
curl -X PUT /accountant/v1/directories/employees/{code} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /accountant/v1/directories/employees/{code} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": 0,
  "code": "string",
  "fullName": "string",
  "departmentCode": "string",
  "positionCode": "string",
  "positionStartDate": "2019-08-24",
  "professionCode": "string",
  "genderCode": "string",
  "birthDate": "2019-08-24",
  "contractTypeCode": "string",
  "defaultAccrual": "string",
  "defaultTimeSheet": "string",
  "employmentStartDate": "2019-08-24",
  "employmentOrderNumber": "string",
  "dateOfDismissal": "2019-08-24",
  "dismissalOrderNumber": "string",
  "raCitizen": true,
  "calculateIncomeTax": true,
  "reducePensionFromIncomeTax": true,
  "salaryAccount": "string",
  "partnerCode": "string",
  "tradeUnionDuesPercent": 0.1,
  "participationStatus": "string",
  "employerPercent": 0.1,
  "employerAmount": 0.1,
  "stampFeeType": "string",
  "insuranceFeeType": "string",
  "insuranceFeeDate": "2019-08-24",
  "registrationPlaceRA": true,
  "registrationRegion": "string",
  "registrationCommunity": "string",
  "registrationCity": "string",
  "registrationStreet": "string",
  "registrationHouse": "string",
  "registrationApartment": "string",
  "registrationSameAsResidence": true,
  "placeResidenceRA": true,
  "residenceRegion": "string",
  "residenceCommunity": "string",
  "residenceLocation": "string",
  "residenceCity": "string",
  "residenceStreet": "string",
  "residenceHouse": "string",
  "residenceApartment": "string",
  "residenceCountry": "string",
  "addressLine1": "string",
  "addressLine2": "string",
  "addressLine3": "string",
  "postalCode": "string",
  "bankAccount": "string",
  "socialCardNumber": "string",
  "identificationDocumentType": "string",
  "passport": "string",
  "passportIssueDate": "2019-08-24",
  "passportIssuedBy": "string",
  "nationality": "string",
  "otherDocumentNumber": "string",
  "phone": "string",
  "mobilePhone": "string",
  "email": "string",
  "languages": "string",
  "maritalStatus": "string",
  "education": "string",
  "institute": "string",
  "educationStartDate": "2019-08-24",
  "educationEndDate": "2019-08-24",
  "educationCertificateNumber": "string",
  "militaryServiceDescription": "string",
  "militaryServiceStartDate": "2019-08-24",
  "militaryServiceEndDate": "2019-08-24",
  "familyMember1Type": "string",
  "familyMember1FullName": "string",
  "familyMember2Type": "string",
  "familyMember2FullName": "string",
  "familyMember3Type": "string",
  "familyMember3FullName": "string",
  "familyMember4Type": "string",
  "familyMember4FullName": "string",
  "accrualsDeductions": [
    {
      "date": "2019-08-24",
      "code": "string",
      "name": "string",
      "amount": 0.1,
      "default": true
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/employees/{code}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/accountant/v1/directories/employees/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/accountant/v1/directories/employees/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/accountant/v1/directories/employees/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/employees/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/accountant/v1/directories/employees/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/directories/employees/{code}`

> Body parameter

```json
{
  "id": 0,
  "code": "string",
  "fullName": "string",
  "departmentCode": "string",
  "positionCode": "string",
  "positionStartDate": "2019-08-24",
  "professionCode": "string",
  "genderCode": "string",
  "birthDate": "2019-08-24",
  "contractTypeCode": "string",
  "defaultAccrual": "string",
  "defaultTimeSheet": "string",
  "employmentStartDate": "2019-08-24",
  "employmentOrderNumber": "string",
  "dateOfDismissal": "2019-08-24",
  "dismissalOrderNumber": "string",
  "raCitizen": true,
  "calculateIncomeTax": true,
  "reducePensionFromIncomeTax": true,
  "salaryAccount": "string",
  "partnerCode": "string",
  "tradeUnionDuesPercent": 0.1,
  "participationStatus": "string",
  "employerPercent": 0.1,
  "employerAmount": 0.1,
  "stampFeeType": "string",
  "insuranceFeeType": "string",
  "insuranceFeeDate": "2019-08-24",
  "registrationPlaceRA": true,
  "registrationRegion": "string",
  "registrationCommunity": "string",
  "registrationCity": "string",
  "registrationStreet": "string",
  "registrationHouse": "string",
  "registrationApartment": "string",
  "registrationSameAsResidence": true,
  "placeResidenceRA": true,
  "residenceRegion": "string",
  "residenceCommunity": "string",
  "residenceLocation": "string",
  "residenceCity": "string",
  "residenceStreet": "string",
  "residenceHouse": "string",
  "residenceApartment": "string",
  "residenceCountry": "string",
  "addressLine1": "string",
  "addressLine2": "string",
  "addressLine3": "string",
  "postalCode": "string",
  "bankAccount": "string",
  "socialCardNumber": "string",
  "identificationDocumentType": "string",
  "passport": "string",
  "passportIssueDate": "2019-08-24",
  "passportIssuedBy": "string",
  "nationality": "string",
  "otherDocumentNumber": "string",
  "phone": "string",
  "mobilePhone": "string",
  "email": "string",
  "languages": "string",
  "maritalStatus": "string",
  "education": "string",
  "institute": "string",
  "educationStartDate": "2019-08-24",
  "educationEndDate": "2019-08-24",
  "educationCertificateNumber": "string",
  "militaryServiceDescription": "string",
  "militaryServiceStartDate": "2019-08-24",
  "militaryServiceEndDate": "2019-08-24",
  "familyMember1Type": "string",
  "familyMember1FullName": "string",
  "familyMember2Type": "string",
  "familyMember2FullName": "string",
  "familyMember3Type": "string",
  "familyMember3FullName": "string",
  "familyMember4Type": "string",
  "familyMember4FullName": "string",
  "accrualsDeductions": [
    {
      "date": "2019-08-24",
      "code": "string",
      "name": "string",
      "amount": 0.1,
      "default": true
    }
  ]
}
```

<h3 id="put__v1_directories_employees_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Employee](#schemaemployee)|false|none|

> Example responses

> 200 Response

```
{"id":0,"code":"string","fullName":"string","departmentCode":"string","positionCode":"string","positionStartDate":"2019-08-24","professionCode":"string","genderCode":"string","birthDate":"2019-08-24","contractTypeCode":"string","defaultAccrual":"string","defaultTimeSheet":"string","employmentStartDate":"2019-08-24","employmentOrderNumber":"string","dateOfDismissal":"2019-08-24","dismissalOrderNumber":"string","raCitizen":true,"calculateIncomeTax":true,"reducePensionFromIncomeTax":true,"salaryAccount":"string","partnerCode":"string","tradeUnionDuesPercent":0.1,"participationStatus":"string","employerPercent":0.1,"employerAmount":0.1,"stampFeeType":"string","insuranceFeeType":"string","insuranceFeeDate":"2019-08-24","registrationPlaceRA":true,"registrationRegion":"string","registrationCommunity":"string","registrationCity":"string","registrationStreet":"string","registrationHouse":"string","registrationApartment":"string","registrationSameAsResidence":true,"placeResidenceRA":true,"residenceRegion":"string","residenceCommunity":"string","residenceLocation":"string","residenceCity":"string","residenceStreet":"string","residenceHouse":"string","residenceApartment":"string","residenceCountry":"string","addressLine1":"string","addressLine2":"string","addressLine3":"string","postalCode":"string","bankAccount":"string","socialCardNumber":"string","identificationDocumentType":"string","passport":"string","passportIssueDate":"2019-08-24","passportIssuedBy":"string","nationality":"string","otherDocumentNumber":"string","phone":"string","mobilePhone":"string","email":"string","languages":"string","maritalStatus":"string","education":"string","institute":"string","educationStartDate":"2019-08-24","educationEndDate":"2019-08-24","educationCertificateNumber":"string","militaryServiceDescription":"string","militaryServiceStartDate":"2019-08-24","militaryServiceEndDate":"2019-08-24","familyMember1Type":"string","familyMember1FullName":"string","familyMember2Type":"string","familyMember2FullName":"string","familyMember3Type":"string","familyMember3FullName":"string","familyMember4Type":"string","familyMember4FullName":"string","accrualsDeductions":[{"date":"2019-08-24","code":"string","name":"string","amount":0.1,"default":true}]}
```

```json
{
  "id": 0,
  "code": "string",
  "fullName": "string",
  "departmentCode": "string",
  "positionCode": "string",
  "positionStartDate": "2019-08-24",
  "professionCode": "string",
  "genderCode": "string",
  "birthDate": "2019-08-24",
  "contractTypeCode": "string",
  "defaultAccrual": "string",
  "defaultTimeSheet": "string",
  "employmentStartDate": "2019-08-24",
  "employmentOrderNumber": "string",
  "dateOfDismissal": "2019-08-24",
  "dismissalOrderNumber": "string",
  "raCitizen": true,
  "calculateIncomeTax": true,
  "reducePensionFromIncomeTax": true,
  "salaryAccount": "string",
  "partnerCode": "string",
  "tradeUnionDuesPercent": 0.1,
  "participationStatus": "string",
  "employerPercent": 0.1,
  "employerAmount": 0.1,
  "stampFeeType": "string",
  "insuranceFeeType": "string",
  "insuranceFeeDate": "2019-08-24",
  "registrationPlaceRA": true,
  "registrationRegion": "string",
  "registrationCommunity": "string",
  "registrationCity": "string",
  "registrationStreet": "string",
  "registrationHouse": "string",
  "registrationApartment": "string",
  "registrationSameAsResidence": true,
  "placeResidenceRA": true,
  "residenceRegion": "string",
  "residenceCommunity": "string",
  "residenceLocation": "string",
  "residenceCity": "string",
  "residenceStreet": "string",
  "residenceHouse": "string",
  "residenceApartment": "string",
  "residenceCountry": "string",
  "addressLine1": "string",
  "addressLine2": "string",
  "addressLine3": "string",
  "postalCode": "string",
  "bankAccount": "string",
  "socialCardNumber": "string",
  "identificationDocumentType": "string",
  "passport": "string",
  "passportIssueDate": "2019-08-24",
  "passportIssuedBy": "string",
  "nationality": "string",
  "otherDocumentNumber": "string",
  "phone": "string",
  "mobilePhone": "string",
  "email": "string",
  "languages": "string",
  "maritalStatus": "string",
  "education": "string",
  "institute": "string",
  "educationStartDate": "2019-08-24",
  "educationEndDate": "2019-08-24",
  "educationCertificateNumber": "string",
  "militaryServiceDescription": "string",
  "militaryServiceStartDate": "2019-08-24",
  "militaryServiceEndDate": "2019-08-24",
  "familyMember1Type": "string",
  "familyMember1FullName": "string",
  "familyMember2Type": "string",
  "familyMember2FullName": "string",
  "familyMember3Type": "string",
  "familyMember3FullName": "string",
  "familyMember4Type": "string",
  "familyMember4FullName": "string",
  "accrualsDeductions": [
    {
      "date": "2019-08-24",
      "code": "string",
      "name": "string",
      "amount": 0.1,
      "default": true
    }
  ]
}
```

<h3 id="put__v1_directories_employees_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[Employee](#schemaemployee)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_directories_employees_{code}

> Code samples

```shell
# You can also use wget
curl -X DELETE /accountant/v1/directories/employees/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /accountant/v1/directories/employees/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/employees/{code}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/accountant/v1/directories/employees/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/accountant/v1/directories/employees/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/accountant/v1/directories/employees/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/employees/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/accountant/v1/directories/employees/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/directories/employees/{code}`

<h3 id="delete__v1_directories_employees_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_directories_employees_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_employees

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/directories/employees \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/directories/employees HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": 0,
  "code": "string",
  "fullName": "string",
  "departmentCode": "string",
  "positionCode": "string",
  "positionStartDate": "2019-08-24",
  "professionCode": "string",
  "genderCode": "string",
  "birthDate": "2019-08-24",
  "contractTypeCode": "string",
  "defaultAccrual": "string",
  "defaultTimeSheet": "string",
  "employmentStartDate": "2019-08-24",
  "employmentOrderNumber": "string",
  "dateOfDismissal": "2019-08-24",
  "dismissalOrderNumber": "string",
  "raCitizen": true,
  "calculateIncomeTax": true,
  "reducePensionFromIncomeTax": true,
  "salaryAccount": "string",
  "partnerCode": "string",
  "tradeUnionDuesPercent": 0.1,
  "participationStatus": "string",
  "employerPercent": 0.1,
  "employerAmount": 0.1,
  "stampFeeType": "string",
  "insuranceFeeType": "string",
  "insuranceFeeDate": "2019-08-24",
  "registrationPlaceRA": true,
  "registrationRegion": "string",
  "registrationCommunity": "string",
  "registrationCity": "string",
  "registrationStreet": "string",
  "registrationHouse": "string",
  "registrationApartment": "string",
  "registrationSameAsResidence": true,
  "placeResidenceRA": true,
  "residenceRegion": "string",
  "residenceCommunity": "string",
  "residenceLocation": "string",
  "residenceCity": "string",
  "residenceStreet": "string",
  "residenceHouse": "string",
  "residenceApartment": "string",
  "residenceCountry": "string",
  "addressLine1": "string",
  "addressLine2": "string",
  "addressLine3": "string",
  "postalCode": "string",
  "bankAccount": "string",
  "socialCardNumber": "string",
  "identificationDocumentType": "string",
  "passport": "string",
  "passportIssueDate": "2019-08-24",
  "passportIssuedBy": "string",
  "nationality": "string",
  "otherDocumentNumber": "string",
  "phone": "string",
  "mobilePhone": "string",
  "email": "string",
  "languages": "string",
  "maritalStatus": "string",
  "education": "string",
  "institute": "string",
  "educationStartDate": "2019-08-24",
  "educationEndDate": "2019-08-24",
  "educationCertificateNumber": "string",
  "militaryServiceDescription": "string",
  "militaryServiceStartDate": "2019-08-24",
  "militaryServiceEndDate": "2019-08-24",
  "familyMember1Type": "string",
  "familyMember1FullName": "string",
  "familyMember2Type": "string",
  "familyMember2FullName": "string",
  "familyMember3Type": "string",
  "familyMember3FullName": "string",
  "familyMember4Type": "string",
  "familyMember4FullName": "string",
  "accrualsDeductions": [
    {
      "date": "2019-08-24",
      "code": "string",
      "name": "string",
      "amount": 0.1,
      "default": true
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/employees',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/directories/employees',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/directories/employees', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/directories/employees', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/employees");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/directories/employees", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/employees`

> Body parameter

```json
{
  "id": 0,
  "code": "string",
  "fullName": "string",
  "departmentCode": "string",
  "positionCode": "string",
  "positionStartDate": "2019-08-24",
  "professionCode": "string",
  "genderCode": "string",
  "birthDate": "2019-08-24",
  "contractTypeCode": "string",
  "defaultAccrual": "string",
  "defaultTimeSheet": "string",
  "employmentStartDate": "2019-08-24",
  "employmentOrderNumber": "string",
  "dateOfDismissal": "2019-08-24",
  "dismissalOrderNumber": "string",
  "raCitizen": true,
  "calculateIncomeTax": true,
  "reducePensionFromIncomeTax": true,
  "salaryAccount": "string",
  "partnerCode": "string",
  "tradeUnionDuesPercent": 0.1,
  "participationStatus": "string",
  "employerPercent": 0.1,
  "employerAmount": 0.1,
  "stampFeeType": "string",
  "insuranceFeeType": "string",
  "insuranceFeeDate": "2019-08-24",
  "registrationPlaceRA": true,
  "registrationRegion": "string",
  "registrationCommunity": "string",
  "registrationCity": "string",
  "registrationStreet": "string",
  "registrationHouse": "string",
  "registrationApartment": "string",
  "registrationSameAsResidence": true,
  "placeResidenceRA": true,
  "residenceRegion": "string",
  "residenceCommunity": "string",
  "residenceLocation": "string",
  "residenceCity": "string",
  "residenceStreet": "string",
  "residenceHouse": "string",
  "residenceApartment": "string",
  "residenceCountry": "string",
  "addressLine1": "string",
  "addressLine2": "string",
  "addressLine3": "string",
  "postalCode": "string",
  "bankAccount": "string",
  "socialCardNumber": "string",
  "identificationDocumentType": "string",
  "passport": "string",
  "passportIssueDate": "2019-08-24",
  "passportIssuedBy": "string",
  "nationality": "string",
  "otherDocumentNumber": "string",
  "phone": "string",
  "mobilePhone": "string",
  "email": "string",
  "languages": "string",
  "maritalStatus": "string",
  "education": "string",
  "institute": "string",
  "educationStartDate": "2019-08-24",
  "educationEndDate": "2019-08-24",
  "educationCertificateNumber": "string",
  "militaryServiceDescription": "string",
  "militaryServiceStartDate": "2019-08-24",
  "militaryServiceEndDate": "2019-08-24",
  "familyMember1Type": "string",
  "familyMember1FullName": "string",
  "familyMember2Type": "string",
  "familyMember2FullName": "string",
  "familyMember3Type": "string",
  "familyMember3FullName": "string",
  "familyMember4Type": "string",
  "familyMember4FullName": "string",
  "accrualsDeductions": [
    {
      "date": "2019-08-24",
      "code": "string",
      "name": "string",
      "amount": 0.1,
      "default": true
    }
  ]
}
```

<h3 id="post__v1_directories_employees-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Employee](#schemaemployee)|false|none|

> Example responses

> 201 Response

```
{"id":0,"code":"string","fullName":"string","departmentCode":"string","positionCode":"string","positionStartDate":"2019-08-24","professionCode":"string","genderCode":"string","birthDate":"2019-08-24","contractTypeCode":"string","defaultAccrual":"string","defaultTimeSheet":"string","employmentStartDate":"2019-08-24","employmentOrderNumber":"string","dateOfDismissal":"2019-08-24","dismissalOrderNumber":"string","raCitizen":true,"calculateIncomeTax":true,"reducePensionFromIncomeTax":true,"salaryAccount":"string","partnerCode":"string","tradeUnionDuesPercent":0.1,"participationStatus":"string","employerPercent":0.1,"employerAmount":0.1,"stampFeeType":"string","insuranceFeeType":"string","insuranceFeeDate":"2019-08-24","registrationPlaceRA":true,"registrationRegion":"string","registrationCommunity":"string","registrationCity":"string","registrationStreet":"string","registrationHouse":"string","registrationApartment":"string","registrationSameAsResidence":true,"placeResidenceRA":true,"residenceRegion":"string","residenceCommunity":"string","residenceLocation":"string","residenceCity":"string","residenceStreet":"string","residenceHouse":"string","residenceApartment":"string","residenceCountry":"string","addressLine1":"string","addressLine2":"string","addressLine3":"string","postalCode":"string","bankAccount":"string","socialCardNumber":"string","identificationDocumentType":"string","passport":"string","passportIssueDate":"2019-08-24","passportIssuedBy":"string","nationality":"string","otherDocumentNumber":"string","phone":"string","mobilePhone":"string","email":"string","languages":"string","maritalStatus":"string","education":"string","institute":"string","educationStartDate":"2019-08-24","educationEndDate":"2019-08-24","educationCertificateNumber":"string","militaryServiceDescription":"string","militaryServiceStartDate":"2019-08-24","militaryServiceEndDate":"2019-08-24","familyMember1Type":"string","familyMember1FullName":"string","familyMember2Type":"string","familyMember2FullName":"string","familyMember3Type":"string","familyMember3FullName":"string","familyMember4Type":"string","familyMember4FullName":"string","accrualsDeductions":[{"date":"2019-08-24","code":"string","name":"string","amount":0.1,"default":true}]}
```

```json
{
  "id": 0,
  "code": "string",
  "fullName": "string",
  "departmentCode": "string",
  "positionCode": "string",
  "positionStartDate": "2019-08-24",
  "professionCode": "string",
  "genderCode": "string",
  "birthDate": "2019-08-24",
  "contractTypeCode": "string",
  "defaultAccrual": "string",
  "defaultTimeSheet": "string",
  "employmentStartDate": "2019-08-24",
  "employmentOrderNumber": "string",
  "dateOfDismissal": "2019-08-24",
  "dismissalOrderNumber": "string",
  "raCitizen": true,
  "calculateIncomeTax": true,
  "reducePensionFromIncomeTax": true,
  "salaryAccount": "string",
  "partnerCode": "string",
  "tradeUnionDuesPercent": 0.1,
  "participationStatus": "string",
  "employerPercent": 0.1,
  "employerAmount": 0.1,
  "stampFeeType": "string",
  "insuranceFeeType": "string",
  "insuranceFeeDate": "2019-08-24",
  "registrationPlaceRA": true,
  "registrationRegion": "string",
  "registrationCommunity": "string",
  "registrationCity": "string",
  "registrationStreet": "string",
  "registrationHouse": "string",
  "registrationApartment": "string",
  "registrationSameAsResidence": true,
  "placeResidenceRA": true,
  "residenceRegion": "string",
  "residenceCommunity": "string",
  "residenceLocation": "string",
  "residenceCity": "string",
  "residenceStreet": "string",
  "residenceHouse": "string",
  "residenceApartment": "string",
  "residenceCountry": "string",
  "addressLine1": "string",
  "addressLine2": "string",
  "addressLine3": "string",
  "postalCode": "string",
  "bankAccount": "string",
  "socialCardNumber": "string",
  "identificationDocumentType": "string",
  "passport": "string",
  "passportIssueDate": "2019-08-24",
  "passportIssuedBy": "string",
  "nationality": "string",
  "otherDocumentNumber": "string",
  "phone": "string",
  "mobilePhone": "string",
  "email": "string",
  "languages": "string",
  "maritalStatus": "string",
  "education": "string",
  "institute": "string",
  "educationStartDate": "2019-08-24",
  "educationEndDate": "2019-08-24",
  "educationCertificateNumber": "string",
  "militaryServiceDescription": "string",
  "militaryServiceStartDate": "2019-08-24",
  "militaryServiceEndDate": "2019-08-24",
  "familyMember1Type": "string",
  "familyMember1FullName": "string",
  "familyMember2Type": "string",
  "familyMember2FullName": "string",
  "familyMember3Type": "string",
  "familyMember3FullName": "string",
  "familyMember4Type": "string",
  "familyMember4FullName": "string",
  "accrualsDeductions": [
    {
      "date": "2019-08-24",
      "code": "string",
      "name": "string",
      "amount": 0.1,
      "default": true
    }
  ]
}
```

<h3 id="post__v1_directories_employees-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[Employee](#schemaemployee)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="accountant-public-api-invoice">Invoice</h1>

## get__v1_documents_invoice_{isn}

> Code samples

```shell
# You can also use wget
curl -X GET /accountant/v1/documents/invoice/{isn} \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /accountant/v1/documents/invoice/{isn} HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/invoice/{isn}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/accountant/v1/documents/invoice/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/accountant/v1/documents/invoice/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/accountant/v1/documents/invoice/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/invoice/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/accountant/v1/documents/invoice/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/documents/invoice/{isn}`

<h3 id="get__v1_documents_invoice_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","customer":"string","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"state":0,"contract":"string","contractDate":"2019-08-24","customerAccount":"string","receivedPrepaymentAccount":"string","vatAccount":"string","environmentalFeeAccount":"string","analytic1":"string","analytic2":"string","bookNumber":"string","bookPage":0,"bookLine":0,"taxExportType":"string","taxInvoiceSeries":"string","taxInvoiceNumber":"string","submissionDate":"2019-08-24","comment":"string","vatCalculationType":"string","dealType":"string","storage":"string","discountPercent":0.1,"vatAmount":0.1,"totalAmount":0.1,"supplierBusinessAddress":"string","supplierSettlementAccount":"string","supplierManagerPosition":"string","supplierManagerName":"string","supplierAccountantPosition":"string","supplierAccountantName":"string","supplierAdditionalData":"string","customerName":"string","customerLegalAddress":"string","customerBusinessAddress":"string","customerSettlementAccount":"string","customerTaxCode":"string","customerManagerPosition":"string","customerManagerName":"string","customerAccountantPosition":"string","customerAccountantName":"string","stateRegisterNumber":"string","idDocumentType":"string","passportNumber":"string","socialCardNumber":"string","customerAdditionalData":"string","shippingMethod":"string","citizenOfRA":true,"socialExpensesType":"string","socialExpenseSocialCard":"string","socialExpenseCitizenName":"string","socialExpenseIdentityDocument":"string","socialExpenseSerialNumber":"string","additionalFullName":"string","credentialNumber":"string","credentialDate":"2019-08-24","baseECRCheckNumber":"string","itemList":[{"type":"string","storage":"string","id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"environmentalFeePercent":0.1,"environmentalFeeAmount":0.1,"vat":true,"dealType":"string","expenseAccount":"string","incomeAccount":"string","markingList":["string"],"cpaClassifier":"string","rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "state": 0,
  "contract": "string",
  "contractDate": "2019-08-24",
  "customerAccount": "string",
  "receivedPrepaymentAccount": "string",
  "vatAccount": "string",
  "environmentalFeeAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "dealType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "supplierAdditionalData": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "customerAdditionalData": "string",
  "shippingMethod": "string",
  "citizenOfRA": true,
  "socialExpensesType": "string",
  "socialExpenseSocialCard": "string",
  "socialExpenseCitizenName": "string",
  "socialExpenseIdentityDocument": "string",
  "socialExpenseSerialNumber": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "baseECRCheckNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "expenseAccount": "string",
      "incomeAccount": "string",
      "markingList": [
        "string"
      ],
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="get__v1_documents_invoice_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[Invoice](#schemainvoice)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_documents_invoice_{isn}

> Code samples

```shell
# You can also use wget
curl -X PUT /accountant/v1/documents/invoice/{isn} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /accountant/v1/documents/invoice/{isn} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "state": 0,
  "contract": "string",
  "contractDate": "2019-08-24",
  "customerAccount": "string",
  "receivedPrepaymentAccount": "string",
  "vatAccount": "string",
  "environmentalFeeAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "dealType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "supplierAdditionalData": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "customerAdditionalData": "string",
  "shippingMethod": "string",
  "citizenOfRA": true,
  "socialExpensesType": "string",
  "socialExpenseSocialCard": "string",
  "socialExpenseCitizenName": "string",
  "socialExpenseIdentityDocument": "string",
  "socialExpenseSerialNumber": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "baseECRCheckNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "expenseAccount": "string",
      "incomeAccount": "string",
      "markingList": [
        "string"
      ],
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/invoice/{isn}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/accountant/v1/documents/invoice/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/accountant/v1/documents/invoice/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/accountant/v1/documents/invoice/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/invoice/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/accountant/v1/documents/invoice/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/documents/invoice/{isn}`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "state": 0,
  "contract": "string",
  "contractDate": "2019-08-24",
  "customerAccount": "string",
  "receivedPrepaymentAccount": "string",
  "vatAccount": "string",
  "environmentalFeeAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "dealType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "supplierAdditionalData": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "customerAdditionalData": "string",
  "shippingMethod": "string",
  "citizenOfRA": true,
  "socialExpensesType": "string",
  "socialExpenseSocialCard": "string",
  "socialExpenseCitizenName": "string",
  "socialExpenseIdentityDocument": "string",
  "socialExpenseSerialNumber": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "baseECRCheckNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "expenseAccount": "string",
      "incomeAccount": "string",
      "markingList": [
        "string"
      ],
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_invoice_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Invoice](#schemainvoice)|false|none|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","customer":"string","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"state":0,"contract":"string","contractDate":"2019-08-24","customerAccount":"string","receivedPrepaymentAccount":"string","vatAccount":"string","environmentalFeeAccount":"string","analytic1":"string","analytic2":"string","bookNumber":"string","bookPage":0,"bookLine":0,"taxExportType":"string","taxInvoiceSeries":"string","taxInvoiceNumber":"string","submissionDate":"2019-08-24","comment":"string","vatCalculationType":"string","dealType":"string","storage":"string","discountPercent":0.1,"vatAmount":0.1,"totalAmount":0.1,"supplierBusinessAddress":"string","supplierSettlementAccount":"string","supplierManagerPosition":"string","supplierManagerName":"string","supplierAccountantPosition":"string","supplierAccountantName":"string","supplierAdditionalData":"string","customerName":"string","customerLegalAddress":"string","customerBusinessAddress":"string","customerSettlementAccount":"string","customerTaxCode":"string","customerManagerPosition":"string","customerManagerName":"string","customerAccountantPosition":"string","customerAccountantName":"string","stateRegisterNumber":"string","idDocumentType":"string","passportNumber":"string","socialCardNumber":"string","customerAdditionalData":"string","shippingMethod":"string","citizenOfRA":true,"socialExpensesType":"string","socialExpenseSocialCard":"string","socialExpenseCitizenName":"string","socialExpenseIdentityDocument":"string","socialExpenseSerialNumber":"string","additionalFullName":"string","credentialNumber":"string","credentialDate":"2019-08-24","baseECRCheckNumber":"string","itemList":[{"type":"string","storage":"string","id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"environmentalFeePercent":0.1,"environmentalFeeAmount":0.1,"vat":true,"dealType":"string","expenseAccount":"string","incomeAccount":"string","markingList":["string"],"cpaClassifier":"string","rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "state": 0,
  "contract": "string",
  "contractDate": "2019-08-24",
  "customerAccount": "string",
  "receivedPrepaymentAccount": "string",
  "vatAccount": "string",
  "environmentalFeeAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "dealType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "supplierAdditionalData": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "customerAdditionalData": "string",
  "shippingMethod": "string",
  "citizenOfRA": true,
  "socialExpensesType": "string",
  "socialExpenseSocialCard": "string",
  "socialExpenseCitizenName": "string",
  "socialExpenseIdentityDocument": "string",
  "socialExpenseSerialNumber": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "baseECRCheckNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "expenseAccount": "string",
      "incomeAccount": "string",
      "markingList": [
        "string"
      ],
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_invoice_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[Invoice](#schemainvoice)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_documents_invoice_{isn}

> Code samples

```shell
# You can also use wget
curl -X DELETE /accountant/v1/documents/invoice/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /accountant/v1/documents/invoice/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/invoice/{isn}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/accountant/v1/documents/invoice/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/accountant/v1/documents/invoice/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/accountant/v1/documents/invoice/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/invoice/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/accountant/v1/documents/invoice/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/documents/invoice/{isn}`

<h3 id="delete__v1_documents_invoice_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_documents_invoice_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_documents_invoice

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/documents/invoice \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/documents/invoice HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "state": 0,
  "contract": "string",
  "contractDate": "2019-08-24",
  "customerAccount": "string",
  "receivedPrepaymentAccount": "string",
  "vatAccount": "string",
  "environmentalFeeAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "dealType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "supplierAdditionalData": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "customerAdditionalData": "string",
  "shippingMethod": "string",
  "citizenOfRA": true,
  "socialExpensesType": "string",
  "socialExpenseSocialCard": "string",
  "socialExpenseCitizenName": "string",
  "socialExpenseIdentityDocument": "string",
  "socialExpenseSerialNumber": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "baseECRCheckNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "expenseAccount": "string",
      "incomeAccount": "string",
      "markingList": [
        "string"
      ],
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/invoice',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/documents/invoice',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/documents/invoice', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/documents/invoice', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/invoice");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/documents/invoice", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/documents/invoice`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "state": 0,
  "contract": "string",
  "contractDate": "2019-08-24",
  "customerAccount": "string",
  "receivedPrepaymentAccount": "string",
  "vatAccount": "string",
  "environmentalFeeAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "dealType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "supplierAdditionalData": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "customerAdditionalData": "string",
  "shippingMethod": "string",
  "citizenOfRA": true,
  "socialExpensesType": "string",
  "socialExpenseSocialCard": "string",
  "socialExpenseCitizenName": "string",
  "socialExpenseIdentityDocument": "string",
  "socialExpenseSerialNumber": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "baseECRCheckNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "expenseAccount": "string",
      "incomeAccount": "string",
      "markingList": [
        "string"
      ],
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_invoice-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Invoice](#schemainvoice)|false|none|

> Example responses

> 201 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","customer":"string","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"state":0,"contract":"string","contractDate":"2019-08-24","customerAccount":"string","receivedPrepaymentAccount":"string","vatAccount":"string","environmentalFeeAccount":"string","analytic1":"string","analytic2":"string","bookNumber":"string","bookPage":0,"bookLine":0,"taxExportType":"string","taxInvoiceSeries":"string","taxInvoiceNumber":"string","submissionDate":"2019-08-24","comment":"string","vatCalculationType":"string","dealType":"string","storage":"string","discountPercent":0.1,"vatAmount":0.1,"totalAmount":0.1,"supplierBusinessAddress":"string","supplierSettlementAccount":"string","supplierManagerPosition":"string","supplierManagerName":"string","supplierAccountantPosition":"string","supplierAccountantName":"string","supplierAdditionalData":"string","customerName":"string","customerLegalAddress":"string","customerBusinessAddress":"string","customerSettlementAccount":"string","customerTaxCode":"string","customerManagerPosition":"string","customerManagerName":"string","customerAccountantPosition":"string","customerAccountantName":"string","stateRegisterNumber":"string","idDocumentType":"string","passportNumber":"string","socialCardNumber":"string","customerAdditionalData":"string","shippingMethod":"string","citizenOfRA":true,"socialExpensesType":"string","socialExpenseSocialCard":"string","socialExpenseCitizenName":"string","socialExpenseIdentityDocument":"string","socialExpenseSerialNumber":"string","additionalFullName":"string","credentialNumber":"string","credentialDate":"2019-08-24","baseECRCheckNumber":"string","itemList":[{"type":"string","storage":"string","id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"environmentalFeePercent":0.1,"environmentalFeeAmount":0.1,"vat":true,"dealType":"string","expenseAccount":"string","incomeAccount":"string","markingList":["string"],"cpaClassifier":"string","rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "state": 0,
  "contract": "string",
  "contractDate": "2019-08-24",
  "customerAccount": "string",
  "receivedPrepaymentAccount": "string",
  "vatAccount": "string",
  "environmentalFeeAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "dealType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "supplierAdditionalData": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "customerAdditionalData": "string",
  "shippingMethod": "string",
  "citizenOfRA": true,
  "socialExpensesType": "string",
  "socialExpenseSocialCard": "string",
  "socialExpenseCitizenName": "string",
  "socialExpenseIdentityDocument": "string",
  "socialExpenseSerialNumber": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "baseECRCheckNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "expenseAccount": "string",
      "incomeAccount": "string",
      "markingList": [
        "string"
      ],
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_invoice-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[Invoice](#schemainvoice)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="accountant-public-api-journals">Journals</h1>

## post__v1_journals_alldocuments

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/journals/alldocuments \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/journals/alldocuments HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "documentTypes": [
    "string"
  ],
  "currency": "string",
  "partner": "string",
  "employee": "string",
  "material": "string",
  "inventoryNumber": "string",
  "documentState": "string"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/journals/alldocuments',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/journals/alldocuments',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/journals/alldocuments', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/journals/alldocuments', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/journals/alldocuments");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/journals/alldocuments", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/journals/alldocuments`

> Body parameter

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "documentTypes": [
    "string"
  ],
  "currency": "string",
  "partner": "string",
  "employee": "string",
  "material": "string",
  "inventoryNumber": "string",
  "documentState": "string"
}
```

<h3 id="post__v1_journals_alldocuments-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[AllDocumentsJournalParam](#schemaalldocumentsjournalparam)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","dayOrderNumber":0,"documentNumber":"string","type":0,"typeName":"string","currency":"string","amount":0.1,"state":0,"stateName":"string","partnerId":0,"partnerCode":"string","partnerName":"string","employeeCode":"string","employeeName":"string","comment":"string","userName":"string","lastChange":"2019-08-24T14:15:22Z"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "dayOrderNumber": 0,
      "documentNumber": "string",
      "type": 0,
      "typeName": "string",
      "currency": "string",
      "amount": 0.1,
      "state": 0,
      "stateName": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "employeeCode": "string",
      "employeeName": "string",
      "comment": "string",
      "userName": "string",
      "lastChange": "2019-08-24T14:15:22Z"
    }
  ]
}
```

<h3 id="post__v1_journals_alldocuments-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[AllDocumentsJournalDataRowApiResponse](#schemaalldocumentsjournaldatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_journals_alldocuments_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/journals/alldocuments/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/journals/alldocuments/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/journals/alldocuments/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/journals/alldocuments/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/journals/alldocuments/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/journals/alldocuments/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/journals/alldocuments/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/journals/alldocuments/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/journals/alldocuments/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_journals_alldocuments_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","dayOrderNumber":0,"documentNumber":"string","type":0,"typeName":"string","currency":"string","amount":0.1,"state":0,"stateName":"string","partnerId":0,"partnerCode":"string","partnerName":"string","employeeCode":"string","employeeName":"string","comment":"string","userName":"string","lastChange":"2019-08-24T14:15:22Z"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "dayOrderNumber": 0,
      "documentNumber": "string",
      "type": 0,
      "typeName": "string",
      "currency": "string",
      "amount": 0.1,
      "state": 0,
      "stateName": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "employeeCode": "string",
      "employeeName": "string",
      "comment": "string",
      "userName": "string",
      "lastChange": "2019-08-24T14:15:22Z"
    }
  ]
}
```

<h3 id="post__v1_journals_alldocuments_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[AllDocumentsJournalDataRowApiResponse](#schemaalldocumentsjournaldatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_journals_ecrchecks

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/journals/ecrchecks \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/journals/ecrchecks HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "documentTypes": [
    "string"
  ],
  "partner": "string",
  "cashDesk": "string",
  "showPayments": true,
  "showOutputAmountsAsNegatives": true,
  "documentState": "string"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/journals/ecrchecks',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/journals/ecrchecks',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/journals/ecrchecks', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/journals/ecrchecks', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/journals/ecrchecks");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/journals/ecrchecks", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/journals/ecrchecks`

> Body parameter

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "documentTypes": [
    "string"
  ],
  "partner": "string",
  "cashDesk": "string",
  "showPayments": true,
  "showOutputAmountsAsNegatives": true,
  "documentState": "string"
}
```

<h3 id="post__v1_journals_ecrchecks-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[ECRChecksJournalParam](#schemaecrchecksjournalparam)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","ecrCheckNumber":"string","type":0,"typeName":"string","amount":0.1,"cashAmount":0.1,"nonCashAmount":0.1,"prepaymentAmount":0.1,"receivablesAmount":0.1,"state":0,"stateName":"string","cashDesk":"string","partnerId":0,"partnerCode":"string","partnerName":"string","partnerTaxCode":"string","comment":"string","userName":"string","lastChange":"2019-08-24T14:15:22Z"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "ecrCheckNumber": "string",
      "type": 0,
      "typeName": "string",
      "amount": 0.1,
      "cashAmount": 0.1,
      "nonCashAmount": 0.1,
      "prepaymentAmount": 0.1,
      "receivablesAmount": 0.1,
      "state": 0,
      "stateName": "string",
      "cashDesk": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "partnerTaxCode": "string",
      "comment": "string",
      "userName": "string",
      "lastChange": "2019-08-24T14:15:22Z"
    }
  ]
}
```

<h3 id="post__v1_journals_ecrchecks-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[ECRChecksJournalDataRowApiResponse](#schemaecrchecksjournaldatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_journals_ecrchecks_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/journals/ecrchecks/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/journals/ecrchecks/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/journals/ecrchecks/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/journals/ecrchecks/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/journals/ecrchecks/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/journals/ecrchecks/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/journals/ecrchecks/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/journals/ecrchecks/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/journals/ecrchecks/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_journals_ecrchecks_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","ecrCheckNumber":"string","type":0,"typeName":"string","amount":0.1,"cashAmount":0.1,"nonCashAmount":0.1,"prepaymentAmount":0.1,"receivablesAmount":0.1,"state":0,"stateName":"string","cashDesk":"string","partnerId":0,"partnerCode":"string","partnerName":"string","partnerTaxCode":"string","comment":"string","userName":"string","lastChange":"2019-08-24T14:15:22Z"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "ecrCheckNumber": "string",
      "type": 0,
      "typeName": "string",
      "amount": 0.1,
      "cashAmount": 0.1,
      "nonCashAmount": 0.1,
      "prepaymentAmount": 0.1,
      "receivablesAmount": 0.1,
      "state": 0,
      "stateName": "string",
      "cashDesk": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "partnerTaxCode": "string",
      "comment": "string",
      "userName": "string",
      "lastChange": "2019-08-24T14:15:22Z"
    }
  ]
}
```

<h3 id="post__v1_journals_ecrchecks_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[ECRChecksJournalDataRowApiResponse](#schemaecrchecksjournaldatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_journals_invoices

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/journals/invoices \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/journals/invoices HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "documentTypes": [
    "string"
  ],
  "currency": "string",
  "partner": "string",
  "showOutputAmountsAsNegatives": true,
  "documentState": "string"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/journals/invoices',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/journals/invoices',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/journals/invoices', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/journals/invoices', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/journals/invoices");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/journals/invoices", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/journals/invoices`

> Body parameter

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "documentTypes": [
    "string"
  ],
  "currency": "string",
  "partner": "string",
  "showOutputAmountsAsNegatives": true,
  "documentState": "string"
}
```

<h3 id="post__v1_journals_invoices-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[InvoiceDocumentsJournalParam](#schemainvoicedocumentsjournalparam)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","type":0,"typeName":"string","submissionDate":"2019-08-24","taxSerialNumber":"string","currency":"string","amount":0.1,"vatType":"string","vatTypeName":"string","state":0,"stateName":"string","partnerId":0,"partnerCode":"string","partnerName":"string","partnerTaxCode":"string","partnerStatus":"string","comment":"string","taxExportType":"string","userName":"string","lastChange":"2019-08-24T14:15:22Z"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "type": 0,
      "typeName": "string",
      "submissionDate": "2019-08-24",
      "taxSerialNumber": "string",
      "currency": "string",
      "amount": 0.1,
      "vatType": "string",
      "vatTypeName": "string",
      "state": 0,
      "stateName": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "partnerTaxCode": "string",
      "partnerStatus": "string",
      "comment": "string",
      "taxExportType": "string",
      "userName": "string",
      "lastChange": "2019-08-24T14:15:22Z"
    }
  ]
}
```

<h3 id="post__v1_journals_invoices-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[InvoiceDocumentsJournalDataRowApiResponse](#schemainvoicedocumentsjournaldatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_journals_invoices_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/journals/invoices/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/journals/invoices/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/journals/invoices/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/journals/invoices/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/journals/invoices/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/journals/invoices/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/journals/invoices/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/journals/invoices/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/journals/invoices/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_journals_invoices_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","type":0,"typeName":"string","submissionDate":"2019-08-24","taxSerialNumber":"string","currency":"string","amount":0.1,"vatType":"string","vatTypeName":"string","state":0,"stateName":"string","partnerId":0,"partnerCode":"string","partnerName":"string","partnerTaxCode":"string","partnerStatus":"string","comment":"string","taxExportType":"string","userName":"string","lastChange":"2019-08-24T14:15:22Z"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "type": 0,
      "typeName": "string",
      "submissionDate": "2019-08-24",
      "taxSerialNumber": "string",
      "currency": "string",
      "amount": 0.1,
      "vatType": "string",
      "vatTypeName": "string",
      "state": 0,
      "stateName": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "partnerTaxCode": "string",
      "partnerStatus": "string",
      "comment": "string",
      "taxExportType": "string",
      "userName": "string",
      "lastChange": "2019-08-24T14:15:22Z"
    }
  ]
}
```

<h3 id="post__v1_journals_invoices_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[InvoiceDocumentsJournalDataRowApiResponse](#schemainvoicedocumentsjournaldatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="accountant-public-api-materials">Materials</h1>

## post__v1_directories_materials_list

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/directories/materials/list \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/directories/materials/list HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "codes": [
    "string"
  ],
  "lastModifiedDate": "2019-08-24T14:15:22Z",
  "group": "string",
  "showAlsoClosed": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/materials/list',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/directories/materials/list',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/directories/materials/list', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/directories/materials/list', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/materials/list");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/directories/materials/list", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/materials/list`

> Body parameter

```json
{
  "pageSize": 0,
  "codes": [
    "string"
  ],
  "lastModifiedDate": "2019-08-24T14:15:22Z",
  "group": "string",
  "showAlsoClosed": true
}
```

<h3 id="post__v1_directories_materials_list-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[MaterialFilters](#schemamaterialfilters)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","fullName":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","group":"string","cpaClassifier":"string","account":"string","wholePrice":0.1,"retailPrice":0.1,"specification":"string","barcode":"string","externalCode":"string","costingMethod":"string","aoeCoefficient":0.1,"discountPercent":0.1,"environmentalFeePercent":0.1,"minimumQuantity":0.1,"maximumQuantity":0.1,"vat":true,"revenueAccount":"string","retailRevenueAccount":"string","expenseAccount":"string","revenueAdjustmentAccount":"string","lastModifierName":"string","lastModifyDate":"2019-08-24T14:15:22Z","isClosed":true}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "group": "string",
      "cpaClassifier": "string",
      "account": "string",
      "wholePrice": 0.1,
      "retailPrice": 0.1,
      "specification": "string",
      "barcode": "string",
      "externalCode": "string",
      "costingMethod": "string",
      "aoeCoefficient": 0.1,
      "discountPercent": 0.1,
      "environmentalFeePercent": 0.1,
      "minimumQuantity": 0.1,
      "maximumQuantity": 0.1,
      "vat": true,
      "revenueAccount": "string",
      "retailRevenueAccount": "string",
      "expenseAccount": "string",
      "revenueAdjustmentAccount": "string",
      "lastModifierName": "string",
      "lastModifyDate": "2019-08-24T14:15:22Z",
      "isClosed": true
    }
  ]
}
```

<h3 id="post__v1_directories_materials_list-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[MaterialRowApiResponse](#schemamaterialrowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_materials_list_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/directories/materials/list/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/directories/materials/list/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/materials/list/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/directories/materials/list/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/directories/materials/list/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/directories/materials/list/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/materials/list/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/directories/materials/list/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/materials/list/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_directories_materials_list_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","fullName":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","group":"string","cpaClassifier":"string","account":"string","wholePrice":0.1,"retailPrice":0.1,"specification":"string","barcode":"string","externalCode":"string","costingMethod":"string","aoeCoefficient":0.1,"discountPercent":0.1,"environmentalFeePercent":0.1,"minimumQuantity":0.1,"maximumQuantity":0.1,"vat":true,"revenueAccount":"string","retailRevenueAccount":"string","expenseAccount":"string","revenueAdjustmentAccount":"string","lastModifierName":"string","lastModifyDate":"2019-08-24T14:15:22Z","isClosed":true}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "group": "string",
      "cpaClassifier": "string",
      "account": "string",
      "wholePrice": 0.1,
      "retailPrice": 0.1,
      "specification": "string",
      "barcode": "string",
      "externalCode": "string",
      "costingMethod": "string",
      "aoeCoefficient": 0.1,
      "discountPercent": 0.1,
      "environmentalFeePercent": 0.1,
      "minimumQuantity": 0.1,
      "maximumQuantity": 0.1,
      "vat": true,
      "revenueAccount": "string",
      "retailRevenueAccount": "string",
      "expenseAccount": "string",
      "revenueAdjustmentAccount": "string",
      "lastModifierName": "string",
      "lastModifyDate": "2019-08-24T14:15:22Z",
      "isClosed": true
    }
  ]
}
```

<h3 id="post__v1_directories_materials_list_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[MaterialRowApiResponse](#schemamaterialrowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## get__v1_directories_materials_{code}

> Code samples

```shell
# You can also use wget
curl -X GET /accountant/v1/directories/materials/{code} \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /accountant/v1/directories/materials/{code} HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/materials/{code}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/accountant/v1/directories/materials/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/accountant/v1/directories/materials/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/accountant/v1/directories/materials/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/materials/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/accountant/v1/directories/materials/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/materials/{code}`

<h3 id="get__v1_directories_materials_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
{"id":0,"code":"string","name":"string","fullName":"string","unitMeasure":"string","unitMeasureName":"string","unitMeasureAbbreviation":"string","group":"string","cpaClassifier":"string","account":"string","wholePrice":0.1,"retailPrice":0.1,"currency":"string","currencyPrice":0.1,"specification":"string","barcode":"string","externalCode":"string","costingMethod":"string","aoeCoefficient":0.1,"discountPercent":0.1,"environmentalFeePercent":0.1,"minimumQuantity":0.1,"maximumQuantity":0.1,"vat":true,"revenueAccount":"string","retailRevenueAccount":"string","expenseAccount":"string","revenueAdjustmentAccount":"string","isClosed":true}
```

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "group": "string",
  "cpaClassifier": "string",
  "account": "string",
  "wholePrice": 0.1,
  "retailPrice": 0.1,
  "currency": "string",
  "currencyPrice": 0.1,
  "specification": "string",
  "barcode": "string",
  "externalCode": "string",
  "costingMethod": "string",
  "aoeCoefficient": 0.1,
  "discountPercent": 0.1,
  "environmentalFeePercent": 0.1,
  "minimumQuantity": 0.1,
  "maximumQuantity": 0.1,
  "vat": true,
  "revenueAccount": "string",
  "retailRevenueAccount": "string",
  "expenseAccount": "string",
  "revenueAdjustmentAccount": "string",
  "isClosed": true
}
```

<h3 id="get__v1_directories_materials_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[Material](#schemamaterial)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_directories_materials_{code}

> Code samples

```shell
# You can also use wget
curl -X PUT /accountant/v1/directories/materials/{code} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /accountant/v1/directories/materials/{code} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "group": "string",
  "cpaClassifier": "string",
  "account": "string",
  "wholePrice": 0.1,
  "retailPrice": 0.1,
  "currency": "string",
  "currencyPrice": 0.1,
  "specification": "string",
  "barcode": "string",
  "externalCode": "string",
  "costingMethod": "string",
  "aoeCoefficient": 0.1,
  "discountPercent": 0.1,
  "environmentalFeePercent": 0.1,
  "minimumQuantity": 0.1,
  "maximumQuantity": 0.1,
  "vat": true,
  "revenueAccount": "string",
  "retailRevenueAccount": "string",
  "expenseAccount": "string",
  "revenueAdjustmentAccount": "string",
  "isClosed": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/materials/{code}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/accountant/v1/directories/materials/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/accountant/v1/directories/materials/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/accountant/v1/directories/materials/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/materials/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/accountant/v1/directories/materials/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/directories/materials/{code}`

> Body parameter

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "group": "string",
  "cpaClassifier": "string",
  "account": "string",
  "wholePrice": 0.1,
  "retailPrice": 0.1,
  "currency": "string",
  "currencyPrice": 0.1,
  "specification": "string",
  "barcode": "string",
  "externalCode": "string",
  "costingMethod": "string",
  "aoeCoefficient": 0.1,
  "discountPercent": 0.1,
  "environmentalFeePercent": 0.1,
  "minimumQuantity": 0.1,
  "maximumQuantity": 0.1,
  "vat": true,
  "revenueAccount": "string",
  "retailRevenueAccount": "string",
  "expenseAccount": "string",
  "revenueAdjustmentAccount": "string",
  "isClosed": true
}
```

<h3 id="put__v1_directories_materials_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Material](#schemamaterial)|false|none|

> Example responses

> 200 Response

```
{"id":0,"code":"string","name":"string","fullName":"string","unitMeasure":"string","unitMeasureName":"string","unitMeasureAbbreviation":"string","group":"string","cpaClassifier":"string","account":"string","wholePrice":0.1,"retailPrice":0.1,"currency":"string","currencyPrice":0.1,"specification":"string","barcode":"string","externalCode":"string","costingMethod":"string","aoeCoefficient":0.1,"discountPercent":0.1,"environmentalFeePercent":0.1,"minimumQuantity":0.1,"maximumQuantity":0.1,"vat":true,"revenueAccount":"string","retailRevenueAccount":"string","expenseAccount":"string","revenueAdjustmentAccount":"string","isClosed":true}
```

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "group": "string",
  "cpaClassifier": "string",
  "account": "string",
  "wholePrice": 0.1,
  "retailPrice": 0.1,
  "currency": "string",
  "currencyPrice": 0.1,
  "specification": "string",
  "barcode": "string",
  "externalCode": "string",
  "costingMethod": "string",
  "aoeCoefficient": 0.1,
  "discountPercent": 0.1,
  "environmentalFeePercent": 0.1,
  "minimumQuantity": 0.1,
  "maximumQuantity": 0.1,
  "vat": true,
  "revenueAccount": "string",
  "retailRevenueAccount": "string",
  "expenseAccount": "string",
  "revenueAdjustmentAccount": "string",
  "isClosed": true
}
```

<h3 id="put__v1_directories_materials_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[Material](#schemamaterial)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_directories_materials_{code}

> Code samples

```shell
# You can also use wget
curl -X DELETE /accountant/v1/directories/materials/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /accountant/v1/directories/materials/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/materials/{code}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/accountant/v1/directories/materials/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/accountant/v1/directories/materials/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/accountant/v1/directories/materials/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/materials/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/accountant/v1/directories/materials/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/directories/materials/{code}`

<h3 id="delete__v1_directories_materials_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_directories_materials_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_materials

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/directories/materials \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/directories/materials HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "group": "string",
  "cpaClassifier": "string",
  "account": "string",
  "wholePrice": 0.1,
  "retailPrice": 0.1,
  "currency": "string",
  "currencyPrice": 0.1,
  "specification": "string",
  "barcode": "string",
  "externalCode": "string",
  "costingMethod": "string",
  "aoeCoefficient": 0.1,
  "discountPercent": 0.1,
  "environmentalFeePercent": 0.1,
  "minimumQuantity": 0.1,
  "maximumQuantity": 0.1,
  "vat": true,
  "revenueAccount": "string",
  "retailRevenueAccount": "string",
  "expenseAccount": "string",
  "revenueAdjustmentAccount": "string",
  "isClosed": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/materials',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/directories/materials',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/directories/materials', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/directories/materials', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/materials");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/directories/materials", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/materials`

> Body parameter

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "group": "string",
  "cpaClassifier": "string",
  "account": "string",
  "wholePrice": 0.1,
  "retailPrice": 0.1,
  "currency": "string",
  "currencyPrice": 0.1,
  "specification": "string",
  "barcode": "string",
  "externalCode": "string",
  "costingMethod": "string",
  "aoeCoefficient": 0.1,
  "discountPercent": 0.1,
  "environmentalFeePercent": 0.1,
  "minimumQuantity": 0.1,
  "maximumQuantity": 0.1,
  "vat": true,
  "revenueAccount": "string",
  "retailRevenueAccount": "string",
  "expenseAccount": "string",
  "revenueAdjustmentAccount": "string",
  "isClosed": true
}
```

<h3 id="post__v1_directories_materials-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Material](#schemamaterial)|false|none|

> Example responses

> 201 Response

```
{"id":0,"code":"string","name":"string","fullName":"string","unitMeasure":"string","unitMeasureName":"string","unitMeasureAbbreviation":"string","group":"string","cpaClassifier":"string","account":"string","wholePrice":0.1,"retailPrice":0.1,"currency":"string","currencyPrice":0.1,"specification":"string","barcode":"string","externalCode":"string","costingMethod":"string","aoeCoefficient":0.1,"discountPercent":0.1,"environmentalFeePercent":0.1,"minimumQuantity":0.1,"maximumQuantity":0.1,"vat":true,"revenueAccount":"string","retailRevenueAccount":"string","expenseAccount":"string","revenueAdjustmentAccount":"string","isClosed":true}
```

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "group": "string",
  "cpaClassifier": "string",
  "account": "string",
  "wholePrice": 0.1,
  "retailPrice": 0.1,
  "currency": "string",
  "currencyPrice": 0.1,
  "specification": "string",
  "barcode": "string",
  "externalCode": "string",
  "costingMethod": "string",
  "aoeCoefficient": 0.1,
  "discountPercent": 0.1,
  "environmentalFeePercent": 0.1,
  "minimumQuantity": 0.1,
  "maximumQuantity": 0.1,
  "vat": true,
  "revenueAccount": "string",
  "retailRevenueAccount": "string",
  "expenseAccount": "string",
  "revenueAdjustmentAccount": "string",
  "isClosed": true
}
```

<h3 id="post__v1_directories_materials-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[Material](#schemamaterial)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="accountant-public-api-materialskitting">MaterialsKitting</h1>

## get__v1_documents_materialskitting_{isn}

> Code samples

```shell
# You can also use wget
curl -X GET /accountant/v1/documents/materialskitting/{isn} \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /accountant/v1/documents/materialskitting/{isn} HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/materialskitting/{isn}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/accountant/v1/documents/materialskitting/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/accountant/v1/documents/materialskitting/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/accountant/v1/documents/materialskitting/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/materialskitting/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/accountant/v1/documents/materialskitting/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/documents/materialskitting/{isn}`

<h3 id="get__v1_documents_materialskitting_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"storageOutput":"string","storageInput":"string","kit":"string","quantity":0.1,"account":"string","transitAccount":"string","analytic1":"string","analytic2":"string","comment":"string","kitComponents":[{"id":0,"type":"string","code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"amount":0.1,"account":"string","rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "kit": "string",
  "quantity": 0.1,
  "account": "string",
  "transitAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "kitComponents": [
    {
      "id": 0,
      "type": "string",
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "account": "string",
      "rowId": 0
    }
  ]
}
```

<h3 id="get__v1_documents_materialskitting_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[MaterialsKitting](#schemamaterialskitting)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_documents_materialskitting_{isn}

> Code samples

```shell
# You can also use wget
curl -X PUT /accountant/v1/documents/materialskitting/{isn} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /accountant/v1/documents/materialskitting/{isn} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "kit": "string",
  "quantity": 0.1,
  "account": "string",
  "transitAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "kitComponents": [
    {
      "id": 0,
      "type": "string",
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "account": "string",
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/materialskitting/{isn}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/accountant/v1/documents/materialskitting/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/accountant/v1/documents/materialskitting/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/accountant/v1/documents/materialskitting/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/materialskitting/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/accountant/v1/documents/materialskitting/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/documents/materialskitting/{isn}`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "kit": "string",
  "quantity": 0.1,
  "account": "string",
  "transitAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "kitComponents": [
    {
      "id": 0,
      "type": "string",
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "account": "string",
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_materialskitting_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[MaterialsKitting](#schemamaterialskitting)|false|none|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"storageOutput":"string","storageInput":"string","kit":"string","quantity":0.1,"account":"string","transitAccount":"string","analytic1":"string","analytic2":"string","comment":"string","kitComponents":[{"id":0,"type":"string","code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"amount":0.1,"account":"string","rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "kit": "string",
  "quantity": 0.1,
  "account": "string",
  "transitAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "kitComponents": [
    {
      "id": 0,
      "type": "string",
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "account": "string",
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_materialskitting_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[MaterialsKitting](#schemamaterialskitting)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_documents_materialskitting_{isn}

> Code samples

```shell
# You can also use wget
curl -X DELETE /accountant/v1/documents/materialskitting/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /accountant/v1/documents/materialskitting/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/materialskitting/{isn}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/accountant/v1/documents/materialskitting/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/accountant/v1/documents/materialskitting/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/accountant/v1/documents/materialskitting/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/materialskitting/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/accountant/v1/documents/materialskitting/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/documents/materialskitting/{isn}`

<h3 id="delete__v1_documents_materialskitting_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_documents_materialskitting_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_documents_materialskitting

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/documents/materialskitting \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/documents/materialskitting HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "kit": "string",
  "quantity": 0.1,
  "account": "string",
  "transitAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "kitComponents": [
    {
      "id": 0,
      "type": "string",
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "account": "string",
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/materialskitting',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/documents/materialskitting',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/documents/materialskitting', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/documents/materialskitting', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/materialskitting");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/documents/materialskitting", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/documents/materialskitting`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "kit": "string",
  "quantity": 0.1,
  "account": "string",
  "transitAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "kitComponents": [
    {
      "id": 0,
      "type": "string",
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "account": "string",
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_materialskitting-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[MaterialsKitting](#schemamaterialskitting)|false|none|

> Example responses

> 201 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"storageOutput":"string","storageInput":"string","kit":"string","quantity":0.1,"account":"string","transitAccount":"string","analytic1":"string","analytic2":"string","comment":"string","kitComponents":[{"id":0,"type":"string","code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"amount":0.1,"account":"string","rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "kit": "string",
  "quantity": 0.1,
  "account": "string",
  "transitAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "kitComponents": [
    {
      "id": 0,
      "type": "string",
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "account": "string",
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_materialskitting-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[MaterialsKitting](#schemamaterialskitting)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="accountant-public-api-materialsmovement">MaterialsMovement</h1>

## get__v1_documents_materialsmovement_{isn}

> Code samples

```shell
# You can also use wget
curl -X GET /accountant/v1/documents/materialsmovement/{isn} \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /accountant/v1/documents/materialsmovement/{isn} HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/materialsmovement/{isn}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/accountant/v1/documents/materialsmovement/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/accountant/v1/documents/materialsmovement/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/accountant/v1/documents/materialsmovement/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/materialsmovement/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/accountant/v1/documents/materialsmovement/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/documents/materialsmovement/{isn}`

<h3 id="get__v1_documents_materialsmovement_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"storageOutput":"string","storageInput":"string","printSalePriceType":"string","analytic1":"string","analytic2":"string","comment":"string","chiefAccountant":"string","mediator":"string","allowed":"string","bookNumber":"string","bookPage":0,"bookLine":0,"taxExportType":"string","taxInvoiceSeries":"string","taxInvoiceNumber":"string","submissionDate":"2019-08-24","transportationMethod":"string","vehicle":true,"brand":"string","licensePlate":"string","contract":"string","contractDate":"2019-08-24","additionalData":"string","materialsList":[{"id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"amount":0.1,"account":"string","rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "printSalePriceType": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "chiefAccountant": "string",
  "mediator": "string",
  "allowed": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "transportationMethod": "string",
  "vehicle": true,
  "brand": "string",
  "licensePlate": "string",
  "contract": "string",
  "contractDate": "2019-08-24",
  "additionalData": "string",
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "account": "string",
      "rowId": 0
    }
  ]
}
```

<h3 id="get__v1_documents_materialsmovement_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[MaterialsMovement](#schemamaterialsmovement)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_documents_materialsmovement_{isn}

> Code samples

```shell
# You can also use wget
curl -X PUT /accountant/v1/documents/materialsmovement/{isn} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /accountant/v1/documents/materialsmovement/{isn} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "printSalePriceType": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "chiefAccountant": "string",
  "mediator": "string",
  "allowed": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "transportationMethod": "string",
  "vehicle": true,
  "brand": "string",
  "licensePlate": "string",
  "contract": "string",
  "contractDate": "2019-08-24",
  "additionalData": "string",
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "account": "string",
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/materialsmovement/{isn}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/accountant/v1/documents/materialsmovement/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/accountant/v1/documents/materialsmovement/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/accountant/v1/documents/materialsmovement/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/materialsmovement/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/accountant/v1/documents/materialsmovement/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/documents/materialsmovement/{isn}`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "printSalePriceType": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "chiefAccountant": "string",
  "mediator": "string",
  "allowed": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "transportationMethod": "string",
  "vehicle": true,
  "brand": "string",
  "licensePlate": "string",
  "contract": "string",
  "contractDate": "2019-08-24",
  "additionalData": "string",
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "account": "string",
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_materialsmovement_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[MaterialsMovement](#schemamaterialsmovement)|false|none|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"storageOutput":"string","storageInput":"string","printSalePriceType":"string","analytic1":"string","analytic2":"string","comment":"string","chiefAccountant":"string","mediator":"string","allowed":"string","bookNumber":"string","bookPage":0,"bookLine":0,"taxExportType":"string","taxInvoiceSeries":"string","taxInvoiceNumber":"string","submissionDate":"2019-08-24","transportationMethod":"string","vehicle":true,"brand":"string","licensePlate":"string","contract":"string","contractDate":"2019-08-24","additionalData":"string","materialsList":[{"id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"amount":0.1,"account":"string","rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "printSalePriceType": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "chiefAccountant": "string",
  "mediator": "string",
  "allowed": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "transportationMethod": "string",
  "vehicle": true,
  "brand": "string",
  "licensePlate": "string",
  "contract": "string",
  "contractDate": "2019-08-24",
  "additionalData": "string",
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "account": "string",
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_materialsmovement_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[MaterialsMovement](#schemamaterialsmovement)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_documents_materialsmovement_{isn}

> Code samples

```shell
# You can also use wget
curl -X DELETE /accountant/v1/documents/materialsmovement/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /accountant/v1/documents/materialsmovement/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/materialsmovement/{isn}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/accountant/v1/documents/materialsmovement/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/accountant/v1/documents/materialsmovement/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/accountant/v1/documents/materialsmovement/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/materialsmovement/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/accountant/v1/documents/materialsmovement/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/documents/materialsmovement/{isn}`

<h3 id="delete__v1_documents_materialsmovement_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_documents_materialsmovement_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_documents_materialsmovement

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/documents/materialsmovement \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/documents/materialsmovement HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "printSalePriceType": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "chiefAccountant": "string",
  "mediator": "string",
  "allowed": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "transportationMethod": "string",
  "vehicle": true,
  "brand": "string",
  "licensePlate": "string",
  "contract": "string",
  "contractDate": "2019-08-24",
  "additionalData": "string",
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "account": "string",
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/materialsmovement',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/documents/materialsmovement',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/documents/materialsmovement', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/documents/materialsmovement', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/materialsmovement");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/documents/materialsmovement", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/documents/materialsmovement`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "printSalePriceType": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "chiefAccountant": "string",
  "mediator": "string",
  "allowed": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "transportationMethod": "string",
  "vehicle": true,
  "brand": "string",
  "licensePlate": "string",
  "contract": "string",
  "contractDate": "2019-08-24",
  "additionalData": "string",
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "account": "string",
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_materialsmovement-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[MaterialsMovement](#schemamaterialsmovement)|false|none|

> Example responses

> 201 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"storageOutput":"string","storageInput":"string","printSalePriceType":"string","analytic1":"string","analytic2":"string","comment":"string","chiefAccountant":"string","mediator":"string","allowed":"string","bookNumber":"string","bookPage":0,"bookLine":0,"taxExportType":"string","taxInvoiceSeries":"string","taxInvoiceNumber":"string","submissionDate":"2019-08-24","transportationMethod":"string","vehicle":true,"brand":"string","licensePlate":"string","contract":"string","contractDate":"2019-08-24","additionalData":"string","materialsList":[{"id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"amount":0.1,"account":"string","rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "printSalePriceType": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "chiefAccountant": "string",
  "mediator": "string",
  "allowed": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "transportationMethod": "string",
  "vehicle": true,
  "brand": "string",
  "licensePlate": "string",
  "contract": "string",
  "contractDate": "2019-08-24",
  "additionalData": "string",
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "account": "string",
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_materialsmovement-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[MaterialsMovement](#schemamaterialsmovement)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="accountant-public-api-memorialorder">MemorialOrder</h1>

## get__v1_documents_memorialorder_{isn}

> Code samples

```shell
# You can also use wget
curl -X GET /accountant/v1/documents/memorialorder/{isn} \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /accountant/v1/documents/memorialorder/{isn} HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/memorialorder/{isn}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/accountant/v1/documents/memorialorder/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/accountant/v1/documents/memorialorder/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/accountant/v1/documents/memorialorder/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/memorialorder/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/accountant/v1/documents/memorialorder/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/documents/memorialorder/{isn}`

<h3 id="get__v1_documents_memorialorder_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"amount":0.1,"currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"previousDayExchangeRate":true,"analytic1":"string","analytic2":"string","comment":"string","transactionsList":[{"debitAccount":"string","debitPartner":"string","debitAnalytic1":"string","debitAnalytic2":"string","debitCurrency":"string","creditAccount":"string","creditPartner":"string","creditAnalytic1":"string","creditAnalytic2":"string","creditCurrency":"string","currencyAmount":0.1,"amount":0.1,"comment":"string"}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "amount": 0.1,
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "previousDayExchangeRate": true,
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "transactionsList": [
    {
      "debitAccount": "string",
      "debitPartner": "string",
      "debitAnalytic1": "string",
      "debitAnalytic2": "string",
      "debitCurrency": "string",
      "creditAccount": "string",
      "creditPartner": "string",
      "creditAnalytic1": "string",
      "creditAnalytic2": "string",
      "creditCurrency": "string",
      "currencyAmount": 0.1,
      "amount": 0.1,
      "comment": "string"
    }
  ]
}
```

<h3 id="get__v1_documents_memorialorder_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[MemorialOrder](#schemamemorialorder)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_documents_memorialorder_{isn}

> Code samples

```shell
# You can also use wget
curl -X PUT /accountant/v1/documents/memorialorder/{isn} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /accountant/v1/documents/memorialorder/{isn} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "amount": 0.1,
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "previousDayExchangeRate": true,
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "transactionsList": [
    {
      "debitAccount": "string",
      "debitPartner": "string",
      "debitAnalytic1": "string",
      "debitAnalytic2": "string",
      "debitCurrency": "string",
      "creditAccount": "string",
      "creditPartner": "string",
      "creditAnalytic1": "string",
      "creditAnalytic2": "string",
      "creditCurrency": "string",
      "currencyAmount": 0.1,
      "amount": 0.1,
      "comment": "string"
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/memorialorder/{isn}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/accountant/v1/documents/memorialorder/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/accountant/v1/documents/memorialorder/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/accountant/v1/documents/memorialorder/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/memorialorder/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/accountant/v1/documents/memorialorder/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/documents/memorialorder/{isn}`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "amount": 0.1,
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "previousDayExchangeRate": true,
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "transactionsList": [
    {
      "debitAccount": "string",
      "debitPartner": "string",
      "debitAnalytic1": "string",
      "debitAnalytic2": "string",
      "debitCurrency": "string",
      "creditAccount": "string",
      "creditPartner": "string",
      "creditAnalytic1": "string",
      "creditAnalytic2": "string",
      "creditCurrency": "string",
      "currencyAmount": 0.1,
      "amount": 0.1,
      "comment": "string"
    }
  ]
}
```

<h3 id="put__v1_documents_memorialorder_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[MemorialOrder](#schemamemorialorder)|false|none|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"amount":0.1,"currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"previousDayExchangeRate":true,"analytic1":"string","analytic2":"string","comment":"string","transactionsList":[{"debitAccount":"string","debitPartner":"string","debitAnalytic1":"string","debitAnalytic2":"string","debitCurrency":"string","creditAccount":"string","creditPartner":"string","creditAnalytic1":"string","creditAnalytic2":"string","creditCurrency":"string","currencyAmount":0.1,"amount":0.1,"comment":"string"}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "amount": 0.1,
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "previousDayExchangeRate": true,
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "transactionsList": [
    {
      "debitAccount": "string",
      "debitPartner": "string",
      "debitAnalytic1": "string",
      "debitAnalytic2": "string",
      "debitCurrency": "string",
      "creditAccount": "string",
      "creditPartner": "string",
      "creditAnalytic1": "string",
      "creditAnalytic2": "string",
      "creditCurrency": "string",
      "currencyAmount": 0.1,
      "amount": 0.1,
      "comment": "string"
    }
  ]
}
```

<h3 id="put__v1_documents_memorialorder_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[MemorialOrder](#schemamemorialorder)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_documents_memorialorder_{isn}

> Code samples

```shell
# You can also use wget
curl -X DELETE /accountant/v1/documents/memorialorder/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /accountant/v1/documents/memorialorder/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/memorialorder/{isn}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/accountant/v1/documents/memorialorder/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/accountant/v1/documents/memorialorder/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/accountant/v1/documents/memorialorder/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/memorialorder/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/accountant/v1/documents/memorialorder/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/documents/memorialorder/{isn}`

<h3 id="delete__v1_documents_memorialorder_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_documents_memorialorder_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_documents_memorialorder

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/documents/memorialorder \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/documents/memorialorder HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "amount": 0.1,
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "previousDayExchangeRate": true,
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "transactionsList": [
    {
      "debitAccount": "string",
      "debitPartner": "string",
      "debitAnalytic1": "string",
      "debitAnalytic2": "string",
      "debitCurrency": "string",
      "creditAccount": "string",
      "creditPartner": "string",
      "creditAnalytic1": "string",
      "creditAnalytic2": "string",
      "creditCurrency": "string",
      "currencyAmount": 0.1,
      "amount": 0.1,
      "comment": "string"
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/memorialorder',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/documents/memorialorder',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/documents/memorialorder', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/documents/memorialorder', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/memorialorder");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/documents/memorialorder", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/documents/memorialorder`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "amount": 0.1,
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "previousDayExchangeRate": true,
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "transactionsList": [
    {
      "debitAccount": "string",
      "debitPartner": "string",
      "debitAnalytic1": "string",
      "debitAnalytic2": "string",
      "debitCurrency": "string",
      "creditAccount": "string",
      "creditPartner": "string",
      "creditAnalytic1": "string",
      "creditAnalytic2": "string",
      "creditCurrency": "string",
      "currencyAmount": 0.1,
      "amount": 0.1,
      "comment": "string"
    }
  ]
}
```

<h3 id="post__v1_documents_memorialorder-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[MemorialOrder](#schemamemorialorder)|false|none|

> Example responses

> 201 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"amount":0.1,"currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"previousDayExchangeRate":true,"analytic1":"string","analytic2":"string","comment":"string","transactionsList":[{"debitAccount":"string","debitPartner":"string","debitAnalytic1":"string","debitAnalytic2":"string","debitCurrency":"string","creditAccount":"string","creditPartner":"string","creditAnalytic1":"string","creditAnalytic2":"string","creditCurrency":"string","currencyAmount":0.1,"amount":0.1,"comment":"string"}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "amount": 0.1,
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "previousDayExchangeRate": true,
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "transactionsList": [
    {
      "debitAccount": "string",
      "debitPartner": "string",
      "debitAnalytic1": "string",
      "debitAnalytic2": "string",
      "debitCurrency": "string",
      "creditAccount": "string",
      "creditPartner": "string",
      "creditAnalytic1": "string",
      "creditAnalytic2": "string",
      "creditCurrency": "string",
      "currencyAmount": 0.1,
      "amount": 0.1,
      "comment": "string"
    }
  ]
}
```

<h3 id="post__v1_documents_memorialorder-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[MemorialOrder](#schemamemorialorder)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="accountant-public-api-overheadexpenseallocation">OverheadExpenseAllocation</h1>

## get__v1_documents_overheadexpenseallocation_{isn}

> Code samples

```shell
# You can also use wget
curl -X GET /accountant/v1/documents/overheadexpenseallocation/{isn} \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /accountant/v1/documents/overheadexpenseallocation/{isn} HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/overheadexpenseallocation/{isn}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/accountant/v1/documents/overheadexpenseallocation/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/accountant/v1/documents/overheadexpenseallocation/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/accountant/v1/documents/overheadexpenseallocation/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/overheadexpenseallocation/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/accountant/v1/documents/overheadexpenseallocation/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/documents/overheadexpenseallocation/{isn}`

<h3 id="get__v1_documents_overheadexpenseallocation_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"baseDocument":"ece108bc-8bd2-42b3-a4d2-d8d3cb3977b5","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"previousDayExchangeRate":true,"supplierCode":"string","supplierAccount":"string","prepaymentAccount":"string","vatAccount":"string","analytic1":"string","analytic2":"string","taxExportType":"string","purchaseDocumentNumber":"string","purchaseDocumentDate":"2019-08-24","comment":"string","overheadExpenseType":"string","vatCalculationType":"string","includeVATInCost":true,"vatInclusionMethod":"string","storage":"string","allowEditList":true,"distributionType":"string","distributionBase":"string","amount":0.1,"vatAmount":0.1,"materialsList":[{"id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"inputOrderAmount":0.1,"allocatedAmount":0.1,"account":"string","includeInDistribution":true,"coefficient":0.1,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocument": "ece108bc-8bd2-42b3-a4d2-d8d3cb3977b5",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "previousDayExchangeRate": true,
  "supplierCode": "string",
  "supplierAccount": "string",
  "prepaymentAccount": "string",
  "vatAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "overheadExpenseType": "string",
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "vatInclusionMethod": "string",
  "storage": "string",
  "allowEditList": true,
  "distributionType": "string",
  "distributionBase": "string",
  "amount": 0.1,
  "vatAmount": 0.1,
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "inputOrderAmount": 0.1,
      "allocatedAmount": 0.1,
      "account": "string",
      "includeInDistribution": true,
      "coefficient": 0.1,
      "rowId": 0
    }
  ]
}
```

<h3 id="get__v1_documents_overheadexpenseallocation_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[OverheadExpenseAllocation](#schemaoverheadexpenseallocation)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_documents_overheadexpenseallocation_{isn}

> Code samples

```shell
# You can also use wget
curl -X PUT /accountant/v1/documents/overheadexpenseallocation/{isn} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /accountant/v1/documents/overheadexpenseallocation/{isn} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocument": "ece108bc-8bd2-42b3-a4d2-d8d3cb3977b5",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "previousDayExchangeRate": true,
  "supplierCode": "string",
  "supplierAccount": "string",
  "prepaymentAccount": "string",
  "vatAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "overheadExpenseType": "string",
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "vatInclusionMethod": "string",
  "storage": "string",
  "allowEditList": true,
  "distributionType": "string",
  "distributionBase": "string",
  "amount": 0.1,
  "vatAmount": 0.1,
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "inputOrderAmount": 0.1,
      "allocatedAmount": 0.1,
      "account": "string",
      "includeInDistribution": true,
      "coefficient": 0.1,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/overheadexpenseallocation/{isn}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/accountant/v1/documents/overheadexpenseallocation/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/accountant/v1/documents/overheadexpenseallocation/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/accountant/v1/documents/overheadexpenseallocation/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/overheadexpenseallocation/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/accountant/v1/documents/overheadexpenseallocation/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/documents/overheadexpenseallocation/{isn}`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocument": "ece108bc-8bd2-42b3-a4d2-d8d3cb3977b5",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "previousDayExchangeRate": true,
  "supplierCode": "string",
  "supplierAccount": "string",
  "prepaymentAccount": "string",
  "vatAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "overheadExpenseType": "string",
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "vatInclusionMethod": "string",
  "storage": "string",
  "allowEditList": true,
  "distributionType": "string",
  "distributionBase": "string",
  "amount": 0.1,
  "vatAmount": 0.1,
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "inputOrderAmount": 0.1,
      "allocatedAmount": 0.1,
      "account": "string",
      "includeInDistribution": true,
      "coefficient": 0.1,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_overheadexpenseallocation_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[OverheadExpenseAllocation](#schemaoverheadexpenseallocation)|false|none|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"baseDocument":"ece108bc-8bd2-42b3-a4d2-d8d3cb3977b5","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"previousDayExchangeRate":true,"supplierCode":"string","supplierAccount":"string","prepaymentAccount":"string","vatAccount":"string","analytic1":"string","analytic2":"string","taxExportType":"string","purchaseDocumentNumber":"string","purchaseDocumentDate":"2019-08-24","comment":"string","overheadExpenseType":"string","vatCalculationType":"string","includeVATInCost":true,"vatInclusionMethod":"string","storage":"string","allowEditList":true,"distributionType":"string","distributionBase":"string","amount":0.1,"vatAmount":0.1,"materialsList":[{"id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"inputOrderAmount":0.1,"allocatedAmount":0.1,"account":"string","includeInDistribution":true,"coefficient":0.1,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocument": "ece108bc-8bd2-42b3-a4d2-d8d3cb3977b5",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "previousDayExchangeRate": true,
  "supplierCode": "string",
  "supplierAccount": "string",
  "prepaymentAccount": "string",
  "vatAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "overheadExpenseType": "string",
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "vatInclusionMethod": "string",
  "storage": "string",
  "allowEditList": true,
  "distributionType": "string",
  "distributionBase": "string",
  "amount": 0.1,
  "vatAmount": 0.1,
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "inputOrderAmount": 0.1,
      "allocatedAmount": 0.1,
      "account": "string",
      "includeInDistribution": true,
      "coefficient": 0.1,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_overheadexpenseallocation_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[OverheadExpenseAllocation](#schemaoverheadexpenseallocation)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_documents_overheadexpenseallocation_{isn}

> Code samples

```shell
# You can also use wget
curl -X DELETE /accountant/v1/documents/overheadexpenseallocation/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /accountant/v1/documents/overheadexpenseallocation/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/overheadexpenseallocation/{isn}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/accountant/v1/documents/overheadexpenseallocation/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/accountant/v1/documents/overheadexpenseallocation/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/accountant/v1/documents/overheadexpenseallocation/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/overheadexpenseallocation/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/accountant/v1/documents/overheadexpenseallocation/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/documents/overheadexpenseallocation/{isn}`

<h3 id="delete__v1_documents_overheadexpenseallocation_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_documents_overheadexpenseallocation_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_documents_overheadexpenseallocation

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/documents/overheadexpenseallocation \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/documents/overheadexpenseallocation HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocument": "ece108bc-8bd2-42b3-a4d2-d8d3cb3977b5",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "previousDayExchangeRate": true,
  "supplierCode": "string",
  "supplierAccount": "string",
  "prepaymentAccount": "string",
  "vatAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "overheadExpenseType": "string",
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "vatInclusionMethod": "string",
  "storage": "string",
  "allowEditList": true,
  "distributionType": "string",
  "distributionBase": "string",
  "amount": 0.1,
  "vatAmount": 0.1,
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "inputOrderAmount": 0.1,
      "allocatedAmount": 0.1,
      "account": "string",
      "includeInDistribution": true,
      "coefficient": 0.1,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/overheadexpenseallocation',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/documents/overheadexpenseallocation',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/documents/overheadexpenseallocation', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/documents/overheadexpenseallocation', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/overheadexpenseallocation");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/documents/overheadexpenseallocation", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/documents/overheadexpenseallocation`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocument": "ece108bc-8bd2-42b3-a4d2-d8d3cb3977b5",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "previousDayExchangeRate": true,
  "supplierCode": "string",
  "supplierAccount": "string",
  "prepaymentAccount": "string",
  "vatAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "overheadExpenseType": "string",
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "vatInclusionMethod": "string",
  "storage": "string",
  "allowEditList": true,
  "distributionType": "string",
  "distributionBase": "string",
  "amount": 0.1,
  "vatAmount": 0.1,
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "inputOrderAmount": 0.1,
      "allocatedAmount": 0.1,
      "account": "string",
      "includeInDistribution": true,
      "coefficient": 0.1,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_overheadexpenseallocation-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[OverheadExpenseAllocation](#schemaoverheadexpenseallocation)|false|none|

> Example responses

> 201 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"baseDocument":"ece108bc-8bd2-42b3-a4d2-d8d3cb3977b5","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"previousDayExchangeRate":true,"supplierCode":"string","supplierAccount":"string","prepaymentAccount":"string","vatAccount":"string","analytic1":"string","analytic2":"string","taxExportType":"string","purchaseDocumentNumber":"string","purchaseDocumentDate":"2019-08-24","comment":"string","overheadExpenseType":"string","vatCalculationType":"string","includeVATInCost":true,"vatInclusionMethod":"string","storage":"string","allowEditList":true,"distributionType":"string","distributionBase":"string","amount":0.1,"vatAmount":0.1,"materialsList":[{"id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"inputOrderAmount":0.1,"allocatedAmount":0.1,"account":"string","includeInDistribution":true,"coefficient":0.1,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocument": "ece108bc-8bd2-42b3-a4d2-d8d3cb3977b5",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "previousDayExchangeRate": true,
  "supplierCode": "string",
  "supplierAccount": "string",
  "prepaymentAccount": "string",
  "vatAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "overheadExpenseType": "string",
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "vatInclusionMethod": "string",
  "storage": "string",
  "allowEditList": true,
  "distributionType": "string",
  "distributionBase": "string",
  "amount": 0.1,
  "vatAmount": 0.1,
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "inputOrderAmount": 0.1,
      "allocatedAmount": 0.1,
      "account": "string",
      "includeInDistribution": true,
      "coefficient": 0.1,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_overheadexpenseallocation-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[OverheadExpenseAllocation](#schemaoverheadexpenseallocation)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="accountant-public-api-partners">Partners</h1>

## post__v1_directories_partners_list

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/directories/partners/list \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/directories/partners/list HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "codes": [
    "string"
  ],
  "lastModifiedDate": "2019-08-24T14:15:22Z",
  "group": "string",
  "showAlsoClosed": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/partners/list',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/directories/partners/list',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/directories/partners/list', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/directories/partners/list', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/partners/list");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/directories/partners/list", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/partners/list`

> Body parameter

```json
{
  "pageSize": 0,
  "codes": [
    "string"
  ],
  "lastModifiedDate": "2019-08-24T14:15:22Z",
  "group": "string",
  "showAlsoClosed": true
}
```

<h3 id="post__v1_directories_partners_list-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[PartnerFilters](#schemapartnerfilters)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","fullName":"string","taxCode":"string","group":"string","groupName":"string","vatPayer":true,"legalAddress":"string","businessAddress":"string","managerName":"string","managerPosition":"string","accountantName":"string","accountantPosition":"string","stateRegisterNumber":"string","idDocumentType":"string","passportNumber":"string","socialCardNumber":"string","paymentMainAim":"string","phoneNumber":"string","email":"string","contract":"string","contractDate":"2019-08-24","salesDiscountPercent":0.1,"status":"string","settlementAccount":"string","userName":"string","lastChange":"2019-08-24T14:15:22Z","isClosed":true}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "taxCode": "string",
      "group": "string",
      "groupName": "string",
      "vatPayer": true,
      "legalAddress": "string",
      "businessAddress": "string",
      "managerName": "string",
      "managerPosition": "string",
      "accountantName": "string",
      "accountantPosition": "string",
      "stateRegisterNumber": "string",
      "idDocumentType": "string",
      "passportNumber": "string",
      "socialCardNumber": "string",
      "paymentMainAim": "string",
      "phoneNumber": "string",
      "email": "string",
      "contract": "string",
      "contractDate": "2019-08-24",
      "salesDiscountPercent": 0.1,
      "status": "string",
      "settlementAccount": "string",
      "userName": "string",
      "lastChange": "2019-08-24T14:15:22Z",
      "isClosed": true
    }
  ]
}
```

<h3 id="post__v1_directories_partners_list-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[PartnerRowApiResponse](#schemapartnerrowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_partners_list_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/directories/partners/list/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/directories/partners/list/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/partners/list/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/directories/partners/list/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/directories/partners/list/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/directories/partners/list/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/partners/list/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/directories/partners/list/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/partners/list/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_directories_partners_list_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","fullName":"string","taxCode":"string","group":"string","groupName":"string","vatPayer":true,"legalAddress":"string","businessAddress":"string","managerName":"string","managerPosition":"string","accountantName":"string","accountantPosition":"string","stateRegisterNumber":"string","idDocumentType":"string","passportNumber":"string","socialCardNumber":"string","paymentMainAim":"string","phoneNumber":"string","email":"string","contract":"string","contractDate":"2019-08-24","salesDiscountPercent":0.1,"status":"string","settlementAccount":"string","userName":"string","lastChange":"2019-08-24T14:15:22Z","isClosed":true}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "taxCode": "string",
      "group": "string",
      "groupName": "string",
      "vatPayer": true,
      "legalAddress": "string",
      "businessAddress": "string",
      "managerName": "string",
      "managerPosition": "string",
      "accountantName": "string",
      "accountantPosition": "string",
      "stateRegisterNumber": "string",
      "idDocumentType": "string",
      "passportNumber": "string",
      "socialCardNumber": "string",
      "paymentMainAim": "string",
      "phoneNumber": "string",
      "email": "string",
      "contract": "string",
      "contractDate": "2019-08-24",
      "salesDiscountPercent": 0.1,
      "status": "string",
      "settlementAccount": "string",
      "userName": "string",
      "lastChange": "2019-08-24T14:15:22Z",
      "isClosed": true
    }
  ]
}
```

<h3 id="post__v1_directories_partners_list_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[PartnerRowApiResponse](#schemapartnerrowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## get__v1_directories_partners_{code}

> Code samples

```shell
# You can also use wget
curl -X GET /accountant/v1/directories/partners/{code} \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /accountant/v1/directories/partners/{code} HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/partners/{code}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/accountant/v1/directories/partners/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/accountant/v1/directories/partners/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/accountant/v1/directories/partners/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/partners/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/accountant/v1/directories/partners/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/partners/{code}`

<h3 id="get__v1_directories_partners_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
{"id":0,"code":"string","name":"string","fullName":"string","taxCode":"string","group":"string","vatPayer":true,"legalAddress":"string","businessAddress":"string","managerName":"string","managerPosition":"string","accountantName":"string","accountantPosition":"string","stateRegisterNumber":"string","idDocumentType":"string","passportNumber":"string","socialCardNumber":"string","paymentMainAim":"string","phoneNumber":"string","email":"string","contract":"string","contractDate":"2019-08-24","salesDiscountPercent":0.1,"status":"string","additionalData":"string","shippingMethod":"string","additionalFullName":"string","credentialNumber":"string","credentialDate":"2019-08-24","isClosed":true,"settlementAccounts":[{"account":"string","name":"string","default":true}],"additionalAddresses":[{"name":"string","default":true}]}
```

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "taxCode": "string",
  "group": "string",
  "vatPayer": true,
  "legalAddress": "string",
  "businessAddress": "string",
  "managerName": "string",
  "managerPosition": "string",
  "accountantName": "string",
  "accountantPosition": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "paymentMainAim": "string",
  "phoneNumber": "string",
  "email": "string",
  "contract": "string",
  "contractDate": "2019-08-24",
  "salesDiscountPercent": 0.1,
  "status": "string",
  "additionalData": "string",
  "shippingMethod": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "isClosed": true,
  "settlementAccounts": [
    {
      "account": "string",
      "name": "string",
      "default": true
    }
  ],
  "additionalAddresses": [
    {
      "name": "string",
      "default": true
    }
  ]
}
```

<h3 id="get__v1_directories_partners_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[Partner](#schemapartner)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_directories_partners_{code}

> Code samples

```shell
# You can also use wget
curl -X PUT /accountant/v1/directories/partners/{code} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /accountant/v1/directories/partners/{code} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "taxCode": "string",
  "group": "string",
  "vatPayer": true,
  "legalAddress": "string",
  "businessAddress": "string",
  "managerName": "string",
  "managerPosition": "string",
  "accountantName": "string",
  "accountantPosition": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "paymentMainAim": "string",
  "phoneNumber": "string",
  "email": "string",
  "contract": "string",
  "contractDate": "2019-08-24",
  "salesDiscountPercent": 0.1,
  "status": "string",
  "additionalData": "string",
  "shippingMethod": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "isClosed": true,
  "settlementAccounts": [
    {
      "account": "string",
      "name": "string",
      "default": true
    }
  ],
  "additionalAddresses": [
    {
      "name": "string",
      "default": true
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/partners/{code}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/accountant/v1/directories/partners/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/accountant/v1/directories/partners/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/accountant/v1/directories/partners/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/partners/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/accountant/v1/directories/partners/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/directories/partners/{code}`

> Body parameter

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "taxCode": "string",
  "group": "string",
  "vatPayer": true,
  "legalAddress": "string",
  "businessAddress": "string",
  "managerName": "string",
  "managerPosition": "string",
  "accountantName": "string",
  "accountantPosition": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "paymentMainAim": "string",
  "phoneNumber": "string",
  "email": "string",
  "contract": "string",
  "contractDate": "2019-08-24",
  "salesDiscountPercent": 0.1,
  "status": "string",
  "additionalData": "string",
  "shippingMethod": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "isClosed": true,
  "settlementAccounts": [
    {
      "account": "string",
      "name": "string",
      "default": true
    }
  ],
  "additionalAddresses": [
    {
      "name": "string",
      "default": true
    }
  ]
}
```

<h3 id="put__v1_directories_partners_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Partner](#schemapartner)|false|none|

> Example responses

> 200 Response

```
{"id":0,"code":"string","name":"string","fullName":"string","taxCode":"string","group":"string","vatPayer":true,"legalAddress":"string","businessAddress":"string","managerName":"string","managerPosition":"string","accountantName":"string","accountantPosition":"string","stateRegisterNumber":"string","idDocumentType":"string","passportNumber":"string","socialCardNumber":"string","paymentMainAim":"string","phoneNumber":"string","email":"string","contract":"string","contractDate":"2019-08-24","salesDiscountPercent":0.1,"status":"string","additionalData":"string","shippingMethod":"string","additionalFullName":"string","credentialNumber":"string","credentialDate":"2019-08-24","isClosed":true,"settlementAccounts":[{"account":"string","name":"string","default":true}],"additionalAddresses":[{"name":"string","default":true}]}
```

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "taxCode": "string",
  "group": "string",
  "vatPayer": true,
  "legalAddress": "string",
  "businessAddress": "string",
  "managerName": "string",
  "managerPosition": "string",
  "accountantName": "string",
  "accountantPosition": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "paymentMainAim": "string",
  "phoneNumber": "string",
  "email": "string",
  "contract": "string",
  "contractDate": "2019-08-24",
  "salesDiscountPercent": 0.1,
  "status": "string",
  "additionalData": "string",
  "shippingMethod": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "isClosed": true,
  "settlementAccounts": [
    {
      "account": "string",
      "name": "string",
      "default": true
    }
  ],
  "additionalAddresses": [
    {
      "name": "string",
      "default": true
    }
  ]
}
```

<h3 id="put__v1_directories_partners_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[Partner](#schemapartner)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_directories_partners_{code}

> Code samples

```shell
# You can also use wget
curl -X DELETE /accountant/v1/directories/partners/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /accountant/v1/directories/partners/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/partners/{code}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/accountant/v1/directories/partners/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/accountant/v1/directories/partners/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/accountant/v1/directories/partners/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/partners/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/accountant/v1/directories/partners/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/directories/partners/{code}`

<h3 id="delete__v1_directories_partners_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_directories_partners_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_partners

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/directories/partners \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/directories/partners HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "taxCode": "string",
  "group": "string",
  "vatPayer": true,
  "legalAddress": "string",
  "businessAddress": "string",
  "managerName": "string",
  "managerPosition": "string",
  "accountantName": "string",
  "accountantPosition": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "paymentMainAim": "string",
  "phoneNumber": "string",
  "email": "string",
  "contract": "string",
  "contractDate": "2019-08-24",
  "salesDiscountPercent": 0.1,
  "status": "string",
  "additionalData": "string",
  "shippingMethod": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "isClosed": true,
  "settlementAccounts": [
    {
      "account": "string",
      "name": "string",
      "default": true
    }
  ],
  "additionalAddresses": [
    {
      "name": "string",
      "default": true
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/partners',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/directories/partners',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/directories/partners', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/directories/partners', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/partners");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/directories/partners", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/partners`

> Body parameter

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "taxCode": "string",
  "group": "string",
  "vatPayer": true,
  "legalAddress": "string",
  "businessAddress": "string",
  "managerName": "string",
  "managerPosition": "string",
  "accountantName": "string",
  "accountantPosition": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "paymentMainAim": "string",
  "phoneNumber": "string",
  "email": "string",
  "contract": "string",
  "contractDate": "2019-08-24",
  "salesDiscountPercent": 0.1,
  "status": "string",
  "additionalData": "string",
  "shippingMethod": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "isClosed": true,
  "settlementAccounts": [
    {
      "account": "string",
      "name": "string",
      "default": true
    }
  ],
  "additionalAddresses": [
    {
      "name": "string",
      "default": true
    }
  ]
}
```

<h3 id="post__v1_directories_partners-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Partner](#schemapartner)|false|none|

> Example responses

> 201 Response

```
{"id":0,"code":"string","name":"string","fullName":"string","taxCode":"string","group":"string","vatPayer":true,"legalAddress":"string","businessAddress":"string","managerName":"string","managerPosition":"string","accountantName":"string","accountantPosition":"string","stateRegisterNumber":"string","idDocumentType":"string","passportNumber":"string","socialCardNumber":"string","paymentMainAim":"string","phoneNumber":"string","email":"string","contract":"string","contractDate":"2019-08-24","salesDiscountPercent":0.1,"status":"string","additionalData":"string","shippingMethod":"string","additionalFullName":"string","credentialNumber":"string","credentialDate":"2019-08-24","isClosed":true,"settlementAccounts":[{"account":"string","name":"string","default":true}],"additionalAddresses":[{"name":"string","default":true}]}
```

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "taxCode": "string",
  "group": "string",
  "vatPayer": true,
  "legalAddress": "string",
  "businessAddress": "string",
  "managerName": "string",
  "managerPosition": "string",
  "accountantName": "string",
  "accountantPosition": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "paymentMainAim": "string",
  "phoneNumber": "string",
  "email": "string",
  "contract": "string",
  "contractDate": "2019-08-24",
  "salesDiscountPercent": 0.1,
  "status": "string",
  "additionalData": "string",
  "shippingMethod": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "isClosed": true,
  "settlementAccounts": [
    {
      "account": "string",
      "name": "string",
      "default": true
    }
  ],
  "additionalAddresses": [
    {
      "name": "string",
      "default": true
    }
  ]
}
```

<h3 id="post__v1_directories_partners-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[Partner](#schemapartner)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="accountant-public-api-paymentorder">PaymentOrder</h1>

## get__v1_documents_paymentorder_{isn}

> Code samples

```shell
# You can also use wget
curl -X GET /accountant/v1/documents/paymentorder/{isn} \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /accountant/v1/documents/paymentorder/{isn} HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/paymentorder/{isn}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/accountant/v1/documents/paymentorder/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/accountant/v1/documents/paymentorder/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/accountant/v1/documents/paymentorder/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/paymentorder/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/accountant/v1/documents/paymentorder/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/documents/paymentorder/{isn}`

<h3 id="get__v1_documents_paymentorder_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","transactionDate":"2019-08-24","state":0,"currencyAmount":0.1,"amount":0.1,"paymentAim":"string","payerName":"string","payerTaxCode":"string","taxAreaCode":"string","payerBankAccount":"string","currency":"string","partnerCode":"string","receiverName":"string","receiverTaxCode":"string","receiverLegalStatus":"string","receiverBankAccount":"string","correspondentAccount":"string","cashOutFlowAccount":"string","analytic1":"string","analytic2":"string","forOtherPartner":true,"otherPartnerCode":"string","otherPartnerName":"string","otherPartnerResidence":"string","otherPartnerLegalStatus":"string","otherPartnerTaxCode":"string","otherPartnerPassportData":"string","otherPartnerPassportNumber":"string","otherPartnerSocialCard":"string","otherPartnerAddress":"string"}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "transactionDate": "2019-08-24",
  "state": 0,
  "currencyAmount": 0.1,
  "amount": 0.1,
  "paymentAim": "string",
  "payerName": "string",
  "payerTaxCode": "string",
  "taxAreaCode": "string",
  "payerBankAccount": "string",
  "currency": "string",
  "partnerCode": "string",
  "receiverName": "string",
  "receiverTaxCode": "string",
  "receiverLegalStatus": "string",
  "receiverBankAccount": "string",
  "correspondentAccount": "string",
  "cashOutFlowAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "forOtherPartner": true,
  "otherPartnerCode": "string",
  "otherPartnerName": "string",
  "otherPartnerResidence": "string",
  "otherPartnerLegalStatus": "string",
  "otherPartnerTaxCode": "string",
  "otherPartnerPassportData": "string",
  "otherPartnerPassportNumber": "string",
  "otherPartnerSocialCard": "string",
  "otherPartnerAddress": "string"
}
```

<h3 id="get__v1_documents_paymentorder_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[PaymentOrder](#schemapaymentorder)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_documents_paymentorder_{isn}

> Code samples

```shell
# You can also use wget
curl -X PUT /accountant/v1/documents/paymentorder/{isn} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /accountant/v1/documents/paymentorder/{isn} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "transactionDate": "2019-08-24",
  "state": 0,
  "currencyAmount": 0.1,
  "amount": 0.1,
  "paymentAim": "string",
  "payerName": "string",
  "payerTaxCode": "string",
  "taxAreaCode": "string",
  "payerBankAccount": "string",
  "currency": "string",
  "partnerCode": "string",
  "receiverName": "string",
  "receiverTaxCode": "string",
  "receiverLegalStatus": "string",
  "receiverBankAccount": "string",
  "correspondentAccount": "string",
  "cashOutFlowAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "forOtherPartner": true,
  "otherPartnerCode": "string",
  "otherPartnerName": "string",
  "otherPartnerResidence": "string",
  "otherPartnerLegalStatus": "string",
  "otherPartnerTaxCode": "string",
  "otherPartnerPassportData": "string",
  "otherPartnerPassportNumber": "string",
  "otherPartnerSocialCard": "string",
  "otherPartnerAddress": "string"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/paymentorder/{isn}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/accountant/v1/documents/paymentorder/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/accountant/v1/documents/paymentorder/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/accountant/v1/documents/paymentorder/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/paymentorder/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/accountant/v1/documents/paymentorder/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/documents/paymentorder/{isn}`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "transactionDate": "2019-08-24",
  "state": 0,
  "currencyAmount": 0.1,
  "amount": 0.1,
  "paymentAim": "string",
  "payerName": "string",
  "payerTaxCode": "string",
  "taxAreaCode": "string",
  "payerBankAccount": "string",
  "currency": "string",
  "partnerCode": "string",
  "receiverName": "string",
  "receiverTaxCode": "string",
  "receiverLegalStatus": "string",
  "receiverBankAccount": "string",
  "correspondentAccount": "string",
  "cashOutFlowAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "forOtherPartner": true,
  "otherPartnerCode": "string",
  "otherPartnerName": "string",
  "otherPartnerResidence": "string",
  "otherPartnerLegalStatus": "string",
  "otherPartnerTaxCode": "string",
  "otherPartnerPassportData": "string",
  "otherPartnerPassportNumber": "string",
  "otherPartnerSocialCard": "string",
  "otherPartnerAddress": "string"
}
```

<h3 id="put__v1_documents_paymentorder_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[PaymentOrder](#schemapaymentorder)|false|none|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","transactionDate":"2019-08-24","state":0,"currencyAmount":0.1,"amount":0.1,"paymentAim":"string","payerName":"string","payerTaxCode":"string","taxAreaCode":"string","payerBankAccount":"string","currency":"string","partnerCode":"string","receiverName":"string","receiverTaxCode":"string","receiverLegalStatus":"string","receiverBankAccount":"string","correspondentAccount":"string","cashOutFlowAccount":"string","analytic1":"string","analytic2":"string","forOtherPartner":true,"otherPartnerCode":"string","otherPartnerName":"string","otherPartnerResidence":"string","otherPartnerLegalStatus":"string","otherPartnerTaxCode":"string","otherPartnerPassportData":"string","otherPartnerPassportNumber":"string","otherPartnerSocialCard":"string","otherPartnerAddress":"string"}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "transactionDate": "2019-08-24",
  "state": 0,
  "currencyAmount": 0.1,
  "amount": 0.1,
  "paymentAim": "string",
  "payerName": "string",
  "payerTaxCode": "string",
  "taxAreaCode": "string",
  "payerBankAccount": "string",
  "currency": "string",
  "partnerCode": "string",
  "receiverName": "string",
  "receiverTaxCode": "string",
  "receiverLegalStatus": "string",
  "receiverBankAccount": "string",
  "correspondentAccount": "string",
  "cashOutFlowAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "forOtherPartner": true,
  "otherPartnerCode": "string",
  "otherPartnerName": "string",
  "otherPartnerResidence": "string",
  "otherPartnerLegalStatus": "string",
  "otherPartnerTaxCode": "string",
  "otherPartnerPassportData": "string",
  "otherPartnerPassportNumber": "string",
  "otherPartnerSocialCard": "string",
  "otherPartnerAddress": "string"
}
```

<h3 id="put__v1_documents_paymentorder_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[PaymentOrder](#schemapaymentorder)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_documents_paymentorder_{isn}

> Code samples

```shell
# You can also use wget
curl -X DELETE /accountant/v1/documents/paymentorder/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /accountant/v1/documents/paymentorder/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/paymentorder/{isn}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/accountant/v1/documents/paymentorder/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/accountant/v1/documents/paymentorder/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/accountant/v1/documents/paymentorder/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/paymentorder/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/accountant/v1/documents/paymentorder/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/documents/paymentorder/{isn}`

<h3 id="delete__v1_documents_paymentorder_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_documents_paymentorder_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_documents_paymentorder

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/documents/paymentorder \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/documents/paymentorder HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "transactionDate": "2019-08-24",
  "state": 0,
  "currencyAmount": 0.1,
  "amount": 0.1,
  "paymentAim": "string",
  "payerName": "string",
  "payerTaxCode": "string",
  "taxAreaCode": "string",
  "payerBankAccount": "string",
  "currency": "string",
  "partnerCode": "string",
  "receiverName": "string",
  "receiverTaxCode": "string",
  "receiverLegalStatus": "string",
  "receiverBankAccount": "string",
  "correspondentAccount": "string",
  "cashOutFlowAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "forOtherPartner": true,
  "otherPartnerCode": "string",
  "otherPartnerName": "string",
  "otherPartnerResidence": "string",
  "otherPartnerLegalStatus": "string",
  "otherPartnerTaxCode": "string",
  "otherPartnerPassportData": "string",
  "otherPartnerPassportNumber": "string",
  "otherPartnerSocialCard": "string",
  "otherPartnerAddress": "string"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/paymentorder',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/documents/paymentorder',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/documents/paymentorder', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/documents/paymentorder', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/paymentorder");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/documents/paymentorder", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/documents/paymentorder`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "transactionDate": "2019-08-24",
  "state": 0,
  "currencyAmount": 0.1,
  "amount": 0.1,
  "paymentAim": "string",
  "payerName": "string",
  "payerTaxCode": "string",
  "taxAreaCode": "string",
  "payerBankAccount": "string",
  "currency": "string",
  "partnerCode": "string",
  "receiverName": "string",
  "receiverTaxCode": "string",
  "receiverLegalStatus": "string",
  "receiverBankAccount": "string",
  "correspondentAccount": "string",
  "cashOutFlowAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "forOtherPartner": true,
  "otherPartnerCode": "string",
  "otherPartnerName": "string",
  "otherPartnerResidence": "string",
  "otherPartnerLegalStatus": "string",
  "otherPartnerTaxCode": "string",
  "otherPartnerPassportData": "string",
  "otherPartnerPassportNumber": "string",
  "otherPartnerSocialCard": "string",
  "otherPartnerAddress": "string"
}
```

<h3 id="post__v1_documents_paymentorder-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[PaymentOrder](#schemapaymentorder)|false|none|

> Example responses

> 201 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","transactionDate":"2019-08-24","state":0,"currencyAmount":0.1,"amount":0.1,"paymentAim":"string","payerName":"string","payerTaxCode":"string","taxAreaCode":"string","payerBankAccount":"string","currency":"string","partnerCode":"string","receiverName":"string","receiverTaxCode":"string","receiverLegalStatus":"string","receiverBankAccount":"string","correspondentAccount":"string","cashOutFlowAccount":"string","analytic1":"string","analytic2":"string","forOtherPartner":true,"otherPartnerCode":"string","otherPartnerName":"string","otherPartnerResidence":"string","otherPartnerLegalStatus":"string","otherPartnerTaxCode":"string","otherPartnerPassportData":"string","otherPartnerPassportNumber":"string","otherPartnerSocialCard":"string","otherPartnerAddress":"string"}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "transactionDate": "2019-08-24",
  "state": 0,
  "currencyAmount": 0.1,
  "amount": 0.1,
  "paymentAim": "string",
  "payerName": "string",
  "payerTaxCode": "string",
  "taxAreaCode": "string",
  "payerBankAccount": "string",
  "currency": "string",
  "partnerCode": "string",
  "receiverName": "string",
  "receiverTaxCode": "string",
  "receiverLegalStatus": "string",
  "receiverBankAccount": "string",
  "correspondentAccount": "string",
  "cashOutFlowAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "forOtherPartner": true,
  "otherPartnerCode": "string",
  "otherPartnerName": "string",
  "otherPartnerResidence": "string",
  "otherPartnerLegalStatus": "string",
  "otherPartnerTaxCode": "string",
  "otherPartnerPassportData": "string",
  "otherPartnerPassportNumber": "string",
  "otherPartnerSocialCard": "string",
  "otherPartnerAddress": "string"
}
```

<h3 id="post__v1_documents_paymentorder-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[PaymentOrder](#schemapaymentorder)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="accountant-public-api-reports">Reports</h1>

## post__v1_reports_partnersbalances

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/reports/partnersbalances \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/reports/partnersbalances HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "date": "2019-08-24",
  "partnerGroup": "string",
  "partner": "string",
  "account": "string",
  "currency": "string",
  "reportCurrency": "string",
  "accountsSection": "string",
  "showZeroRows": true,
  "openedByDate": true,
  "subtotals": "string"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/reports/partnersbalances',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/reports/partnersbalances',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/reports/partnersbalances', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/reports/partnersbalances', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/reports/partnersbalances");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/reports/partnersbalances", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/partnersbalances`

> Body parameter

```json
{
  "pageSize": 0,
  "date": "2019-08-24",
  "partnerGroup": "string",
  "partner": "string",
  "account": "string",
  "currency": "string",
  "reportCurrency": "string",
  "accountsSection": "string",
  "showZeroRows": true,
  "openedByDate": true,
  "subtotals": "string"
}
```

<h3 id="post__v1_reports_partnersbalances-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[PartnersBalancesParam](#schemapartnersbalancesparam)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","status":"string","account":"string","accountName":"string","analytic1Code":"string","analytic1Name":"string","analytic2Code":"string","analytic2Name":"string","currency":"string","debitCurrency":0.1,"creditCurrency":0.1,"debitNCC":0.1,"creditNCC":0.1,"outOfBalance":true,"date":"2019-08-24"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "status": "string",
      "account": "string",
      "accountName": "string",
      "analytic1Code": "string",
      "analytic1Name": "string",
      "analytic2Code": "string",
      "analytic2Name": "string",
      "currency": "string",
      "debitCurrency": 0.1,
      "creditCurrency": 0.1,
      "debitNCC": 0.1,
      "creditNCC": 0.1,
      "outOfBalance": true,
      "date": "2019-08-24"
    }
  ]
}
```

<h3 id="post__v1_reports_partnersbalances-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[PartnersBalancesDataRowApiResponse](#schemapartnersbalancesdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_partnersbalances_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/reports/partnersbalances/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/reports/partnersbalances/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/reports/partnersbalances/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/reports/partnersbalances/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/reports/partnersbalances/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/reports/partnersbalances/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/reports/partnersbalances/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/reports/partnersbalances/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/partnersbalances/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_reports_partnersbalances_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","status":"string","account":"string","accountName":"string","analytic1Code":"string","analytic1Name":"string","analytic2Code":"string","analytic2Name":"string","currency":"string","debitCurrency":0.1,"creditCurrency":0.1,"debitNCC":0.1,"creditNCC":0.1,"outOfBalance":true,"date":"2019-08-24"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "status": "string",
      "account": "string",
      "accountName": "string",
      "analytic1Code": "string",
      "analytic1Name": "string",
      "analytic2Code": "string",
      "analytic2Name": "string",
      "currency": "string",
      "debitCurrency": 0.1,
      "creditCurrency": 0.1,
      "debitNCC": 0.1,
      "creditNCC": 0.1,
      "outOfBalance": true,
      "date": "2019-08-24"
    }
  ]
}
```

<h3 id="post__v1_reports_partnersbalances_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[PartnersBalancesDataRowApiResponse](#schemapartnersbalancesdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_transactions

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/reports/transactions \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/reports/transactions HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "debitAccount": "string",
  "creditAccount": "string",
  "accountsANDCondition": true,
  "debitPartner": "string",
  "creditPartner": "string",
  "partnersANDCondition": true,
  "debitAnalytic1": "string",
  "creditAnalytic1": "string",
  "analytics1ANDCondition": true,
  "debitAnalytic2": "string",
  "creditAnalytic2": "string",
  "analytics2ANDCondition": true,
  "debitCurrency": "string",
  "creditCurrency": "string",
  "currenciesANDCondition": true,
  "documentTypes": [
    "string"
  ],
  "showPartners": true,
  "showAnalytics1": true,
  "showAnalytics2": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/reports/transactions',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/reports/transactions',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/reports/transactions', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/reports/transactions', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/reports/transactions");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/reports/transactions", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/transactions`

> Body parameter

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "debitAccount": "string",
  "creditAccount": "string",
  "accountsANDCondition": true,
  "debitPartner": "string",
  "creditPartner": "string",
  "partnersANDCondition": true,
  "debitAnalytic1": "string",
  "creditAnalytic1": "string",
  "analytics1ANDCondition": true,
  "debitAnalytic2": "string",
  "creditAnalytic2": "string",
  "analytics2ANDCondition": true,
  "debitCurrency": "string",
  "creditCurrency": "string",
  "currenciesANDCondition": true,
  "documentTypes": [
    "string"
  ],
  "showPartners": true,
  "showAnalytics1": true,
  "showAnalytics2": true
}
```

<h3 id="post__v1_reports_transactions-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[TransactionsParam](#schematransactionsparam)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","type":0,"typeName":"string","debitAccount":"string","debitAccountType":"string","debitCurrency":"string","debitPartner":"string","debitPartnerName":"string","debitPartnerGroup":"string","debitPartnerTaxCode":"string","debitAnalytic1":"string","debitAnalytic1Name":"string","debitAnalytic2":"string","debitAnalytic2Name":"string","creditAccount":"string","creditAccountType":"string","creditCurrency":"string","creditPartner":"string","creditPartnerName":"string","creditPartnerGroup":"string","creditPartnerTaxCode":"string","creditAnalytic1":"string","creditAnalytic1Name":"string","creditAnalytic2":"string","creditAnalytic2Name":"string","amount":0.1,"currencyAmount":0.1,"comment":"string","userName":"string","systemGenerated":true}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "type": 0,
      "typeName": "string",
      "debitAccount": "string",
      "debitAccountType": "string",
      "debitCurrency": "string",
      "debitPartner": "string",
      "debitPartnerName": "string",
      "debitPartnerGroup": "string",
      "debitPartnerTaxCode": "string",
      "debitAnalytic1": "string",
      "debitAnalytic1Name": "string",
      "debitAnalytic2": "string",
      "debitAnalytic2Name": "string",
      "creditAccount": "string",
      "creditAccountType": "string",
      "creditCurrency": "string",
      "creditPartner": "string",
      "creditPartnerName": "string",
      "creditPartnerGroup": "string",
      "creditPartnerTaxCode": "string",
      "creditAnalytic1": "string",
      "creditAnalytic1Name": "string",
      "creditAnalytic2": "string",
      "creditAnalytic2Name": "string",
      "amount": 0.1,
      "currencyAmount": 0.1,
      "comment": "string",
      "userName": "string",
      "systemGenerated": true
    }
  ]
}
```

<h3 id="post__v1_reports_transactions-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[TransactionsDataRowApiResponse](#schematransactionsdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_transactions_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/reports/transactions/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/reports/transactions/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/reports/transactions/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/reports/transactions/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/reports/transactions/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/reports/transactions/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/reports/transactions/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/reports/transactions/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/transactions/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_reports_transactions_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","type":0,"typeName":"string","debitAccount":"string","debitAccountType":"string","debitCurrency":"string","debitPartner":"string","debitPartnerName":"string","debitPartnerGroup":"string","debitPartnerTaxCode":"string","debitAnalytic1":"string","debitAnalytic1Name":"string","debitAnalytic2":"string","debitAnalytic2Name":"string","creditAccount":"string","creditAccountType":"string","creditCurrency":"string","creditPartner":"string","creditPartnerName":"string","creditPartnerGroup":"string","creditPartnerTaxCode":"string","creditAnalytic1":"string","creditAnalytic1Name":"string","creditAnalytic2":"string","creditAnalytic2Name":"string","amount":0.1,"currencyAmount":0.1,"comment":"string","userName":"string","systemGenerated":true}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "type": 0,
      "typeName": "string",
      "debitAccount": "string",
      "debitAccountType": "string",
      "debitCurrency": "string",
      "debitPartner": "string",
      "debitPartnerName": "string",
      "debitPartnerGroup": "string",
      "debitPartnerTaxCode": "string",
      "debitAnalytic1": "string",
      "debitAnalytic1Name": "string",
      "debitAnalytic2": "string",
      "debitAnalytic2Name": "string",
      "creditAccount": "string",
      "creditAccountType": "string",
      "creditCurrency": "string",
      "creditPartner": "string",
      "creditPartnerName": "string",
      "creditPartnerGroup": "string",
      "creditPartnerTaxCode": "string",
      "creditAnalytic1": "string",
      "creditAnalytic1Name": "string",
      "creditAnalytic2": "string",
      "creditAnalytic2Name": "string",
      "amount": 0.1,
      "currencyAmount": 0.1,
      "comment": "string",
      "userName": "string",
      "systemGenerated": true
    }
  ]
}
```

<h3 id="post__v1_reports_transactions_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[TransactionsDataRowApiResponse](#schematransactionsdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_partnerstransactions

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/reports/partnerstransactions \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/reports/partnerstransactions HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "debitPartnerGroup": "string",
  "creditPartnerGroup": "string",
  "partnersGroupANDCondition": true,
  "debitPartner": "string",
  "creditPartner": "string",
  "partnersANDCondition": true,
  "debitAccount": "string",
  "creditAccount": "string",
  "accountsANDCondition": true,
  "debitCurrency": "string",
  "creditCurrency": "string",
  "currenciesANDCondition": true,
  "documentTypes": [
    "string"
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/reports/partnerstransactions',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/reports/partnerstransactions',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/reports/partnerstransactions', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/reports/partnerstransactions', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/reports/partnerstransactions");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/reports/partnerstransactions", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/partnerstransactions`

> Body parameter

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "debitPartnerGroup": "string",
  "creditPartnerGroup": "string",
  "partnersGroupANDCondition": true,
  "debitPartner": "string",
  "creditPartner": "string",
  "partnersANDCondition": true,
  "debitAccount": "string",
  "creditAccount": "string",
  "accountsANDCondition": true,
  "debitCurrency": "string",
  "creditCurrency": "string",
  "currenciesANDCondition": true,
  "documentTypes": [
    "string"
  ]
}
```

<h3 id="post__v1_reports_partnerstransactions-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[PartnersTransactionsParam](#schemapartnerstransactionsparam)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","type":0,"typeName":"string","debitPartnerGroup":"string","debitPartnerGroupName":"string","debitPartner":"string","debitPartnerName":"string","debitPartnerTaxCode":"string","debitAccount":"string","debitAccountType":"string","debitCurrency":"string","creditPartnerGroup":"string","creditPartnerGroupName":"string","creditPartner":"string","creditPartnerName":"string","creditPartnerTaxCode":"string","creditAccount":"string","creditAccountType":"string","creditCurrency":"string","amount":0.1,"currencyAmount":0.1,"comment":"string","userName":"string","systemGenerated":true}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "type": 0,
      "typeName": "string",
      "debitPartnerGroup": "string",
      "debitPartnerGroupName": "string",
      "debitPartner": "string",
      "debitPartnerName": "string",
      "debitPartnerTaxCode": "string",
      "debitAccount": "string",
      "debitAccountType": "string",
      "debitCurrency": "string",
      "creditPartnerGroup": "string",
      "creditPartnerGroupName": "string",
      "creditPartner": "string",
      "creditPartnerName": "string",
      "creditPartnerTaxCode": "string",
      "creditAccount": "string",
      "creditAccountType": "string",
      "creditCurrency": "string",
      "amount": 0.1,
      "currencyAmount": 0.1,
      "comment": "string",
      "userName": "string",
      "systemGenerated": true
    }
  ]
}
```

<h3 id="post__v1_reports_partnerstransactions-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[PartnersTransactionsDataRowApiResponse](#schemapartnerstransactionsdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_partnerstransactions_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/reports/partnerstransactions/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/reports/partnerstransactions/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/reports/partnerstransactions/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/reports/partnerstransactions/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/reports/partnerstransactions/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/reports/partnerstransactions/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/reports/partnerstransactions/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/reports/partnerstransactions/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/partnerstransactions/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_reports_partnerstransactions_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","type":0,"typeName":"string","debitPartnerGroup":"string","debitPartnerGroupName":"string","debitPartner":"string","debitPartnerName":"string","debitPartnerTaxCode":"string","debitAccount":"string","debitAccountType":"string","debitCurrency":"string","creditPartnerGroup":"string","creditPartnerGroupName":"string","creditPartner":"string","creditPartnerName":"string","creditPartnerTaxCode":"string","creditAccount":"string","creditAccountType":"string","creditCurrency":"string","amount":0.1,"currencyAmount":0.1,"comment":"string","userName":"string","systemGenerated":true}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "type": 0,
      "typeName": "string",
      "debitPartnerGroup": "string",
      "debitPartnerGroupName": "string",
      "debitPartner": "string",
      "debitPartnerName": "string",
      "debitPartnerTaxCode": "string",
      "debitAccount": "string",
      "debitAccountType": "string",
      "debitCurrency": "string",
      "creditPartnerGroup": "string",
      "creditPartnerGroupName": "string",
      "creditPartner": "string",
      "creditPartnerName": "string",
      "creditPartnerTaxCode": "string",
      "creditAccount": "string",
      "creditAccountType": "string",
      "creditCurrency": "string",
      "amount": 0.1,
      "currencyAmount": 0.1,
      "comment": "string",
      "userName": "string",
      "systemGenerated": true
    }
  ]
}
```

<h3 id="post__v1_reports_partnerstransactions_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[PartnersTransactionsDataRowApiResponse](#schemapartnerstransactionsdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_accountsbalances

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/reports/accountsbalances \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/reports/accountsbalances HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "date": "2019-08-24",
  "account": "string",
  "currency": "string",
  "reportCurrency": "string",
  "accountsSection": "string",
  "showOnlyLastLevels": true,
  "showPartners": true,
  "showAnalytics1": true,
  "showAnalytics2": true,
  "showZeroRows": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/reports/accountsbalances',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/reports/accountsbalances',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/reports/accountsbalances', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/reports/accountsbalances', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/reports/accountsbalances");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/reports/accountsbalances", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/accountsbalances`

> Body parameter

```json
{
  "pageSize": 0,
  "date": "2019-08-24",
  "account": "string",
  "currency": "string",
  "reportCurrency": "string",
  "accountsSection": "string",
  "showOnlyLastLevels": true,
  "showPartners": true,
  "showAnalytics1": true,
  "showAnalytics2": true,
  "showZeroRows": true
}
```

<h3 id="post__v1_reports_accountsbalances-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[AccountBalancesParam](#schemaaccountbalancesparam)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"account":"string","currency":"string","name":"string","nameRU":"string","debitCurrencyAmount":0.1,"creditCurrencyAmount":0.1,"debitAmount":0.1,"creditAmount":0.1,"outOfBalance":true,"accountType":"string","leaf":true,"isPartnerAccount":true,"isAnalytic1":true,"isAnalytic2":true,"path":"string","parent":"string","partnerId":0,"partnerCode":"string","partnerName":"string","analytic1Code":"string","analytic1Name":"string","analytic2Code":"string","analytic2Name":"string"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "account": "string",
      "currency": "string",
      "name": "string",
      "nameRU": "string",
      "debitCurrencyAmount": 0.1,
      "creditCurrencyAmount": 0.1,
      "debitAmount": 0.1,
      "creditAmount": 0.1,
      "outOfBalance": true,
      "accountType": "string",
      "leaf": true,
      "isPartnerAccount": true,
      "isAnalytic1": true,
      "isAnalytic2": true,
      "path": "string",
      "parent": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "analytic1Code": "string",
      "analytic1Name": "string",
      "analytic2Code": "string",
      "analytic2Name": "string"
    }
  ]
}
```

<h3 id="post__v1_reports_accountsbalances-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[AccountsBalancesDataRowApiResponse](#schemaaccountsbalancesdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_accountsbalances_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/reports/accountsbalances/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/reports/accountsbalances/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/reports/accountsbalances/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/reports/accountsbalances/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/reports/accountsbalances/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/reports/accountsbalances/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/reports/accountsbalances/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/reports/accountsbalances/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/accountsbalances/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_reports_accountsbalances_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"account":"string","currency":"string","name":"string","nameRU":"string","debitCurrencyAmount":0.1,"creditCurrencyAmount":0.1,"debitAmount":0.1,"creditAmount":0.1,"outOfBalance":true,"accountType":"string","leaf":true,"isPartnerAccount":true,"isAnalytic1":true,"isAnalytic2":true,"path":"string","parent":"string","partnerId":0,"partnerCode":"string","partnerName":"string","analytic1Code":"string","analytic1Name":"string","analytic2Code":"string","analytic2Name":"string"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "account": "string",
      "currency": "string",
      "name": "string",
      "nameRU": "string",
      "debitCurrencyAmount": 0.1,
      "creditCurrencyAmount": 0.1,
      "debitAmount": 0.1,
      "creditAmount": 0.1,
      "outOfBalance": true,
      "accountType": "string",
      "leaf": true,
      "isPartnerAccount": true,
      "isAnalytic1": true,
      "isAnalytic2": true,
      "path": "string",
      "parent": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "analytic1Code": "string",
      "analytic1Name": "string",
      "analytic2Code": "string",
      "analytic2Name": "string"
    }
  ]
}
```

<h3 id="post__v1_reports_accountsbalances_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[AccountsBalancesDataRowApiResponse](#schemaaccountsbalancesdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_accountsturnover

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/reports/accountsturnover \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/reports/accountsturnover HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "account": "string",
  "currency": "string",
  "reportCurrency": "string",
  "accountsSection": "string",
  "showOnlyLastLevels": true,
  "showPartners": true,
  "showAnalytics1": true,
  "showAnalytics2": true,
  "showZeroRows": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/reports/accountsturnover',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/reports/accountsturnover',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/reports/accountsturnover', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/reports/accountsturnover', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/reports/accountsturnover");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/reports/accountsturnover", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/accountsturnover`

> Body parameter

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "account": "string",
  "currency": "string",
  "reportCurrency": "string",
  "accountsSection": "string",
  "showOnlyLastLevels": true,
  "showPartners": true,
  "showAnalytics1": true,
  "showAnalytics2": true,
  "showZeroRows": true
}
```

<h3 id="post__v1_reports_accountsturnover-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[AccountsTurnoverParam](#schemaaccountsturnoverparam)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"account":"string","currency":"string","name":"string","nameRU":"string","partnerId":0,"partnerCode":"string","partnerName":"string","analytic1Code":"string","analytic1Name":"string","analytic2Code":"string","analytic2Name":"string","startDebitCurrencyAmount":0.1,"startCreditCurrencyAmount":0.1,"startDebitAmount":0.1,"startCreditAmount":0.1,"turnoverDebitCurrencyAmount":0.1,"turnoverCreditCurrencyAmount":0.1,"turnoverDebitAmount":0.1,"turnoverCreditAmount":0.1,"endDebitCurrencyAmount":0.1,"endCreditCurrencyAmount":0.1,"endDebitAmount":0.1,"endCreditAmount":0.1,"outOfBalance":true,"accountType":"string","leaf":true,"isPartnerAccount":true,"isAnalytic1":true,"isAnalytic2":true,"path":"string","parent":"string"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "account": "string",
      "currency": "string",
      "name": "string",
      "nameRU": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "analytic1Code": "string",
      "analytic1Name": "string",
      "analytic2Code": "string",
      "analytic2Name": "string",
      "startDebitCurrencyAmount": 0.1,
      "startCreditCurrencyAmount": 0.1,
      "startDebitAmount": 0.1,
      "startCreditAmount": 0.1,
      "turnoverDebitCurrencyAmount": 0.1,
      "turnoverCreditCurrencyAmount": 0.1,
      "turnoverDebitAmount": 0.1,
      "turnoverCreditAmount": 0.1,
      "endDebitCurrencyAmount": 0.1,
      "endCreditCurrencyAmount": 0.1,
      "endDebitAmount": 0.1,
      "endCreditAmount": 0.1,
      "outOfBalance": true,
      "accountType": "string",
      "leaf": true,
      "isPartnerAccount": true,
      "isAnalytic1": true,
      "isAnalytic2": true,
      "path": "string",
      "parent": "string"
    }
  ]
}
```

<h3 id="post__v1_reports_accountsturnover-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[AccountsTurnoverDataRowApiResponse](#schemaaccountsturnoverdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_accountsturnover_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/reports/accountsturnover/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/reports/accountsturnover/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/reports/accountsturnover/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/reports/accountsturnover/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/reports/accountsturnover/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/reports/accountsturnover/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/reports/accountsturnover/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/reports/accountsturnover/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/accountsturnover/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_reports_accountsturnover_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"account":"string","currency":"string","name":"string","nameRU":"string","partnerId":0,"partnerCode":"string","partnerName":"string","analytic1Code":"string","analytic1Name":"string","analytic2Code":"string","analytic2Name":"string","startDebitCurrencyAmount":0.1,"startCreditCurrencyAmount":0.1,"startDebitAmount":0.1,"startCreditAmount":0.1,"turnoverDebitCurrencyAmount":0.1,"turnoverCreditCurrencyAmount":0.1,"turnoverDebitAmount":0.1,"turnoverCreditAmount":0.1,"endDebitCurrencyAmount":0.1,"endCreditCurrencyAmount":0.1,"endDebitAmount":0.1,"endCreditAmount":0.1,"outOfBalance":true,"accountType":"string","leaf":true,"isPartnerAccount":true,"isAnalytic1":true,"isAnalytic2":true,"path":"string","parent":"string"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "account": "string",
      "currency": "string",
      "name": "string",
      "nameRU": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "analytic1Code": "string",
      "analytic1Name": "string",
      "analytic2Code": "string",
      "analytic2Name": "string",
      "startDebitCurrencyAmount": 0.1,
      "startCreditCurrencyAmount": 0.1,
      "startDebitAmount": 0.1,
      "startCreditAmount": 0.1,
      "turnoverDebitCurrencyAmount": 0.1,
      "turnoverCreditCurrencyAmount": 0.1,
      "turnoverDebitAmount": 0.1,
      "turnoverCreditAmount": 0.1,
      "endDebitCurrencyAmount": 0.1,
      "endCreditCurrencyAmount": 0.1,
      "endDebitAmount": 0.1,
      "endCreditAmount": 0.1,
      "outOfBalance": true,
      "accountType": "string",
      "leaf": true,
      "isPartnerAccount": true,
      "isAnalytic1": true,
      "isAnalytic2": true,
      "path": "string",
      "parent": "string"
    }
  ]
}
```

<h3 id="post__v1_reports_accountsturnover_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[AccountsTurnoverDataRowApiResponse](#schemaaccountsturnoverdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_materialsbalances

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/reports/materialsbalances \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/reports/materialsbalances HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "date": "2019-08-24",
  "storage": "string",
  "group": "string",
  "material": "string",
  "showByDifferentAccounts": true,
  "account": "string",
  "showByDifferentParties": true,
  "minimumQuantities": "string",
  "salePrices": [
    "string"
  ],
  "currency": "string",
  "showZeroRows": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/reports/materialsbalances',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/reports/materialsbalances',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/reports/materialsbalances', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/reports/materialsbalances', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/reports/materialsbalances");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/reports/materialsbalances", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/materialsbalances`

> Body parameter

```json
{
  "pageSize": 0,
  "date": "2019-08-24",
  "storage": "string",
  "group": "string",
  "material": "string",
  "showByDifferentAccounts": true,
  "account": "string",
  "showByDifferentParties": true,
  "minimumQuantities": "string",
  "salePrices": [
    "string"
  ],
  "currency": "string",
  "showZeroRows": true
}
```

<h3 id="post__v1_reports_materialsbalances-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[MaterialsBalancesParam](#schemamaterialsbalancesparam)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","storage":"string","storageName":"string","quantity":0.1,"cost":0.1,"costAmount":0.1,"unitVAT":0.1,"vatAmount":0.1,"group":"string","groupName":"string","account":"string","salePrice":0.1,"saleAmount":0.1,"retailPrice":0.1,"retailAmount":0.1,"currency":"string","currencyPrice":0.1,"currencyAmount":0.1,"minimumQuantity":0.1,"variance":0.1,"maximumQuantity":0.1,"orderQuantity":0.1,"orderComment":"string","incomeDate":"2019-08-24","partySupplierId":0,"partySupplierCode":"string","partySupplierName":"string","partySupplierTaxCode":"string","purchasingPrice":0.1,"purchasingPriceWithoutVAT":0.1,"partyDocumentType":"string","partyDocumentNumber":"string","partyBase":"c39df95f-1f9b-4de1-8155-0f24e1c3b455","partyRow":0,"costingMethod":"string","specification":"string"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "storage": "string",
      "storageName": "string",
      "quantity": 0.1,
      "cost": 0.1,
      "costAmount": 0.1,
      "unitVAT": 0.1,
      "vatAmount": 0.1,
      "group": "string",
      "groupName": "string",
      "account": "string",
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "retailPrice": 0.1,
      "retailAmount": 0.1,
      "currency": "string",
      "currencyPrice": 0.1,
      "currencyAmount": 0.1,
      "minimumQuantity": 0.1,
      "variance": 0.1,
      "maximumQuantity": 0.1,
      "orderQuantity": 0.1,
      "orderComment": "string",
      "incomeDate": "2019-08-24",
      "partySupplierId": 0,
      "partySupplierCode": "string",
      "partySupplierName": "string",
      "partySupplierTaxCode": "string",
      "purchasingPrice": 0.1,
      "purchasingPriceWithoutVAT": 0.1,
      "partyDocumentType": "string",
      "partyDocumentNumber": "string",
      "partyBase": "c39df95f-1f9b-4de1-8155-0f24e1c3b455",
      "partyRow": 0,
      "costingMethod": "string",
      "specification": "string"
    }
  ]
}
```

<h3 id="post__v1_reports_materialsbalances-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[MaterialsBalancesDataRowApiResponse](#schemamaterialsbalancesdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_materialsbalances_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/reports/materialsbalances/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/reports/materialsbalances/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/reports/materialsbalances/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/reports/materialsbalances/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/reports/materialsbalances/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/reports/materialsbalances/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/reports/materialsbalances/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/reports/materialsbalances/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/materialsbalances/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_reports_materialsbalances_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","storage":"string","storageName":"string","quantity":0.1,"cost":0.1,"costAmount":0.1,"unitVAT":0.1,"vatAmount":0.1,"group":"string","groupName":"string","account":"string","salePrice":0.1,"saleAmount":0.1,"retailPrice":0.1,"retailAmount":0.1,"currency":"string","currencyPrice":0.1,"currencyAmount":0.1,"minimumQuantity":0.1,"variance":0.1,"maximumQuantity":0.1,"orderQuantity":0.1,"orderComment":"string","incomeDate":"2019-08-24","partySupplierId":0,"partySupplierCode":"string","partySupplierName":"string","partySupplierTaxCode":"string","purchasingPrice":0.1,"purchasingPriceWithoutVAT":0.1,"partyDocumentType":"string","partyDocumentNumber":"string","partyBase":"c39df95f-1f9b-4de1-8155-0f24e1c3b455","partyRow":0,"costingMethod":"string","specification":"string"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "storage": "string",
      "storageName": "string",
      "quantity": 0.1,
      "cost": 0.1,
      "costAmount": 0.1,
      "unitVAT": 0.1,
      "vatAmount": 0.1,
      "group": "string",
      "groupName": "string",
      "account": "string",
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "retailPrice": 0.1,
      "retailAmount": 0.1,
      "currency": "string",
      "currencyPrice": 0.1,
      "currencyAmount": 0.1,
      "minimumQuantity": 0.1,
      "variance": 0.1,
      "maximumQuantity": 0.1,
      "orderQuantity": 0.1,
      "orderComment": "string",
      "incomeDate": "2019-08-24",
      "partySupplierId": 0,
      "partySupplierCode": "string",
      "partySupplierName": "string",
      "partySupplierTaxCode": "string",
      "purchasingPrice": 0.1,
      "purchasingPriceWithoutVAT": 0.1,
      "partyDocumentType": "string",
      "partyDocumentNumber": "string",
      "partyBase": "c39df95f-1f9b-4de1-8155-0f24e1c3b455",
      "partyRow": 0,
      "costingMethod": "string",
      "specification": "string"
    }
  ]
}
```

<h3 id="post__v1_reports_materialsbalances_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[MaterialsBalancesDataRowApiResponse](#schemamaterialsbalancesdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_materialsoperationsjournal

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/reports/materialsoperationsjournal \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/reports/materialsoperationsjournal HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "storage": "string",
  "materialGroup": "string",
  "material": "string",
  "account": "string",
  "partner": "string",
  "operationTypes": "string",
  "showParties": true,
  "currency": "string",
  "showCurrencies": true,
  "showSalePrice": true,
  "showVATAmounts": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/reports/materialsoperationsjournal',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/reports/materialsoperationsjournal',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/reports/materialsoperationsjournal', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/reports/materialsoperationsjournal', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/reports/materialsoperationsjournal");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/reports/materialsoperationsjournal", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/materialsoperationsjournal`

> Body parameter

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "storage": "string",
  "materialGroup": "string",
  "material": "string",
  "account": "string",
  "partner": "string",
  "operationTypes": "string",
  "showParties": true,
  "currency": "string",
  "showCurrencies": true,
  "showSalePrice": true,
  "showVATAmounts": true
}
```

<h3 id="post__v1_reports_materialsoperationsjournal-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[MaterialsOperationsParam](#schemamaterialsoperationsparam)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","documentType":0,"operationType":"string","operationName":"string","inputOutput":"string","storage":"string","storageName":"string","materialId":0,"materialCode":"string","materialName":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","account":"string","correspondingObject":"string","correspondingObjectName":"string","analytic1":"string","analytic2":"string","cost":0.1,"quantity":0.1,"costAmount":0.1,"costVATAmount":0.1,"unitVAT":0.1,"currency":"string","currencyCost":0.1,"salePrice":0.1,"saleAmount":0.1,"saleVATPrice":0.1,"saleVATAmount":0.1,"salePriceCurrency":0.1,"saleAmountCurrency":0.1,"comment":"string","group":"string","groupName":"string","specification":"string","cpaClassifier":"string","barcode":"string","vat":true,"fullName":"string","incomeDate":"2019-08-24","partySupplierId":0,"partySupplierCode":"string","partySupplierName":"string","partyDocumentNumber":"string","partyDocumentType":0,"partyDocumentTypeName":"string","partyPurchasingPrice":0.1,"partyPurchasingPriceWithoutVAT":0.1}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "documentType": 0,
      "operationType": "string",
      "operationName": "string",
      "inputOutput": "string",
      "storage": "string",
      "storageName": "string",
      "materialId": 0,
      "materialCode": "string",
      "materialName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "account": "string",
      "correspondingObject": "string",
      "correspondingObjectName": "string",
      "analytic1": "string",
      "analytic2": "string",
      "cost": 0.1,
      "quantity": 0.1,
      "costAmount": 0.1,
      "costVATAmount": 0.1,
      "unitVAT": 0.1,
      "currency": "string",
      "currencyCost": 0.1,
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "saleVATPrice": 0.1,
      "saleVATAmount": 0.1,
      "salePriceCurrency": 0.1,
      "saleAmountCurrency": 0.1,
      "comment": "string",
      "group": "string",
      "groupName": "string",
      "specification": "string",
      "cpaClassifier": "string",
      "barcode": "string",
      "vat": true,
      "fullName": "string",
      "incomeDate": "2019-08-24",
      "partySupplierId": 0,
      "partySupplierCode": "string",
      "partySupplierName": "string",
      "partyDocumentNumber": "string",
      "partyDocumentType": 0,
      "partyDocumentTypeName": "string",
      "partyPurchasingPrice": 0.1,
      "partyPurchasingPriceWithoutVAT": 0.1
    }
  ]
}
```

<h3 id="post__v1_reports_materialsoperationsjournal-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[MaterialsOperationsDataRowApiResponse](#schemamaterialsoperationsdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_materialsoperationsjournal_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/reports/materialsoperationsjournal/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/reports/materialsoperationsjournal/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/reports/materialsoperationsjournal/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/reports/materialsoperationsjournal/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/reports/materialsoperationsjournal/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/reports/materialsoperationsjournal/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/reports/materialsoperationsjournal/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/reports/materialsoperationsjournal/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/materialsoperationsjournal/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_reports_materialsoperationsjournal_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","documentType":0,"operationType":"string","operationName":"string","inputOutput":"string","storage":"string","storageName":"string","materialId":0,"materialCode":"string","materialName":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","account":"string","correspondingObject":"string","correspondingObjectName":"string","analytic1":"string","analytic2":"string","cost":0.1,"quantity":0.1,"costAmount":0.1,"costVATAmount":0.1,"unitVAT":0.1,"currency":"string","currencyCost":0.1,"salePrice":0.1,"saleAmount":0.1,"saleVATPrice":0.1,"saleVATAmount":0.1,"salePriceCurrency":0.1,"saleAmountCurrency":0.1,"comment":"string","group":"string","groupName":"string","specification":"string","cpaClassifier":"string","barcode":"string","vat":true,"fullName":"string","incomeDate":"2019-08-24","partySupplierId":0,"partySupplierCode":"string","partySupplierName":"string","partyDocumentNumber":"string","partyDocumentType":0,"partyDocumentTypeName":"string","partyPurchasingPrice":0.1,"partyPurchasingPriceWithoutVAT":0.1}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "documentType": 0,
      "operationType": "string",
      "operationName": "string",
      "inputOutput": "string",
      "storage": "string",
      "storageName": "string",
      "materialId": 0,
      "materialCode": "string",
      "materialName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "account": "string",
      "correspondingObject": "string",
      "correspondingObjectName": "string",
      "analytic1": "string",
      "analytic2": "string",
      "cost": 0.1,
      "quantity": 0.1,
      "costAmount": 0.1,
      "costVATAmount": 0.1,
      "unitVAT": 0.1,
      "currency": "string",
      "currencyCost": 0.1,
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "saleVATPrice": 0.1,
      "saleVATAmount": 0.1,
      "salePriceCurrency": 0.1,
      "saleAmountCurrency": 0.1,
      "comment": "string",
      "group": "string",
      "groupName": "string",
      "specification": "string",
      "cpaClassifier": "string",
      "barcode": "string",
      "vat": true,
      "fullName": "string",
      "incomeDate": "2019-08-24",
      "partySupplierId": 0,
      "partySupplierCode": "string",
      "partySupplierName": "string",
      "partyDocumentNumber": "string",
      "partyDocumentType": 0,
      "partyDocumentTypeName": "string",
      "partyPurchasingPrice": 0.1,
      "partyPurchasingPriceWithoutVAT": 0.1
    }
  ]
}
```

<h3 id="post__v1_reports_materialsoperationsjournal_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[MaterialsOperationsDataRowApiResponse](#schemamaterialsoperationsdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_storageinputordersandreceivedservices

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/reports/storageinputordersandreceivedservices \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/reports/storageinputordersandreceivedservices HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "documentType": "string",
  "itemCode": "string",
  "documentState": "string"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/reports/storageinputordersandreceivedservices',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/reports/storageinputordersandreceivedservices',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/reports/storageinputordersandreceivedservices', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/reports/storageinputordersandreceivedservices', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/reports/storageinputordersandreceivedservices");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/reports/storageinputordersandreceivedservices", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/storageinputordersandreceivedservices`

> Body parameter

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "documentType": "string",
  "itemCode": "string",
  "documentState": "string"
}
```

<h3 id="post__v1_reports_storageinputordersandreceivedservices-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[StorageInputOrdersAndReceivedServicesParam](#schemastorageinputordersandreceivedservicesparam)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","itemCode":"string","itemName":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","supplierCode":"string","supplierName":"string","supplierTaxCode":"string","quantity":0.1,"currency":"string","price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"vat":true,"account":"string","cpaClassifier":"string","comment":"string","documentState":0,"documentStateName":"string"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "itemCode": "string",
      "itemName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "supplierCode": "string",
      "supplierName": "string",
      "supplierTaxCode": "string",
      "quantity": 0.1,
      "currency": "string",
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "account": "string",
      "cpaClassifier": "string",
      "comment": "string",
      "documentState": 0,
      "documentStateName": "string"
    }
  ]
}
```

<h3 id="post__v1_reports_storageinputordersandreceivedservices-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[StorageInputOrdersAndReceivedServicesDataRowApiResponse](#schemastorageinputordersandreceivedservicesdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_storageinputordersandreceivedservices_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/reports/storageinputordersandreceivedservices/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/reports/storageinputordersandreceivedservices/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/reports/storageinputordersandreceivedservices/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/reports/storageinputordersandreceivedservices/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/reports/storageinputordersandreceivedservices/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/reports/storageinputordersandreceivedservices/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/reports/storageinputordersandreceivedservices/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/reports/storageinputordersandreceivedservices/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/storageinputordersandreceivedservices/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_reports_storageinputordersandreceivedservices_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","itemCode":"string","itemName":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","supplierCode":"string","supplierName":"string","supplierTaxCode":"string","quantity":0.1,"currency":"string","price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"vat":true,"account":"string","cpaClassifier":"string","comment":"string","documentState":0,"documentStateName":"string"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "itemCode": "string",
      "itemName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "supplierCode": "string",
      "supplierName": "string",
      "supplierTaxCode": "string",
      "quantity": 0.1,
      "currency": "string",
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "account": "string",
      "cpaClassifier": "string",
      "comment": "string",
      "documentState": 0,
      "documentStateName": "string"
    }
  ]
}
```

<h3 id="post__v1_reports_storageinputordersandreceivedservices_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[StorageInputOrdersAndReceivedServicesDataRowApiResponse](#schemastorageinputordersandreceivedservicesdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="accountant-public-api-retailsale">RetailSale</h1>

## get__v1_documents_retailsale_{isn}

> Code samples

```shell
# You can also use wget
curl -X GET /accountant/v1/documents/retailsale/{isn} \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /accountant/v1/documents/retailsale/{isn} HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/retailsale/{isn}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/accountant/v1/documents/retailsale/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/accountant/v1/documents/retailsale/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/accountant/v1/documents/retailsale/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/retailsale/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/accountant/v1/documents/retailsale/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/documents/retailsale/{isn}`

<h3 id="get__v1_documents_retailsale_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","ecrCheckNumber":"string","state":0,"customer":"string","printExpenseConfirmingCheck":true,"contract":"string","contractDate":"2019-08-24","cashDesk":"string","customerAccount":"string","receivedPrepaymentAccount":"string","vatAccount":"string","environmentalFeeAccount":"string","nonCashTransactionAccount":"string","analytic1":"string","analytic2":"string","taxExportType":"string","taxInvoiceSeries":"string","taxInvoiceNumber":"string","submissionDate":"2019-08-24","comment":"string","vatCalculationType":"string","dealType":"string","storage":"string","discountPercent":0.1,"nonCashAmount":0.1,"useECRPos":true,"prepaymentAmount":0.1,"vatAmount":0.1,"totalAmount":0.1,"supplierSettlementAccount":"string","supplierManagerPosition":"string","supplierManagerName":"string","supplierAccountantPosition":"string","supplierAccountantName":"string","customerName":"string","customerLegalAddress":"string","customerBusinessAddress":"string","customerSettlementAccount":"string","customerTaxCode":"string","customerManagerPosition":"string","customerManagerName":"string","customerAccountantPosition":"string","customerAccountantName":"string","stateRegisterNumber":"string","idDocumentType":"string","passportNumber":"string","socialCardNumber":"string","citizenOfRA":true,"socialExpensesType":"string","socialExpenseSocialCard":"string","socialExpenseCitizenName":"string","socialExpenseIdentityDocument":"string","socialExpenseSerialNumber":"string","itemList":[{"type":"string","storage":"string","id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"environmentalFeePercent":0.1,"environmentalFeeAmount":0.1,"vat":true,"dealType":"string","expenseAccount":"string","incomeAccount":"string","markingList":["string"],"rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "ecrCheckNumber": "string",
  "state": 0,
  "customer": "string",
  "printExpenseConfirmingCheck": true,
  "contract": "string",
  "contractDate": "2019-08-24",
  "cashDesk": "string",
  "customerAccount": "string",
  "receivedPrepaymentAccount": "string",
  "vatAccount": "string",
  "environmentalFeeAccount": "string",
  "nonCashTransactionAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "dealType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "nonCashAmount": 0.1,
  "useECRPos": true,
  "prepaymentAmount": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "citizenOfRA": true,
  "socialExpensesType": "string",
  "socialExpenseSocialCard": "string",
  "socialExpenseCitizenName": "string",
  "socialExpenseIdentityDocument": "string",
  "socialExpenseSerialNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "expenseAccount": "string",
      "incomeAccount": "string",
      "markingList": [
        "string"
      ],
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="get__v1_documents_retailsale_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[RetailSale](#schemaretailsale)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_documents_retailsale_{isn}

> Code samples

```shell
# You can also use wget
curl -X PUT /accountant/v1/documents/retailsale/{isn} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /accountant/v1/documents/retailsale/{isn} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "ecrCheckNumber": "string",
  "state": 0,
  "customer": "string",
  "printExpenseConfirmingCheck": true,
  "contract": "string",
  "contractDate": "2019-08-24",
  "cashDesk": "string",
  "customerAccount": "string",
  "receivedPrepaymentAccount": "string",
  "vatAccount": "string",
  "environmentalFeeAccount": "string",
  "nonCashTransactionAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "dealType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "nonCashAmount": 0.1,
  "useECRPos": true,
  "prepaymentAmount": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "citizenOfRA": true,
  "socialExpensesType": "string",
  "socialExpenseSocialCard": "string",
  "socialExpenseCitizenName": "string",
  "socialExpenseIdentityDocument": "string",
  "socialExpenseSerialNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "expenseAccount": "string",
      "incomeAccount": "string",
      "markingList": [
        "string"
      ],
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/retailsale/{isn}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/accountant/v1/documents/retailsale/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/accountant/v1/documents/retailsale/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/accountant/v1/documents/retailsale/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/retailsale/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/accountant/v1/documents/retailsale/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/documents/retailsale/{isn}`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "ecrCheckNumber": "string",
  "state": 0,
  "customer": "string",
  "printExpenseConfirmingCheck": true,
  "contract": "string",
  "contractDate": "2019-08-24",
  "cashDesk": "string",
  "customerAccount": "string",
  "receivedPrepaymentAccount": "string",
  "vatAccount": "string",
  "environmentalFeeAccount": "string",
  "nonCashTransactionAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "dealType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "nonCashAmount": 0.1,
  "useECRPos": true,
  "prepaymentAmount": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "citizenOfRA": true,
  "socialExpensesType": "string",
  "socialExpenseSocialCard": "string",
  "socialExpenseCitizenName": "string",
  "socialExpenseIdentityDocument": "string",
  "socialExpenseSerialNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "expenseAccount": "string",
      "incomeAccount": "string",
      "markingList": [
        "string"
      ],
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_retailsale_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[RetailSale](#schemaretailsale)|false|none|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","ecrCheckNumber":"string","state":0,"customer":"string","printExpenseConfirmingCheck":true,"contract":"string","contractDate":"2019-08-24","cashDesk":"string","customerAccount":"string","receivedPrepaymentAccount":"string","vatAccount":"string","environmentalFeeAccount":"string","nonCashTransactionAccount":"string","analytic1":"string","analytic2":"string","taxExportType":"string","taxInvoiceSeries":"string","taxInvoiceNumber":"string","submissionDate":"2019-08-24","comment":"string","vatCalculationType":"string","dealType":"string","storage":"string","discountPercent":0.1,"nonCashAmount":0.1,"useECRPos":true,"prepaymentAmount":0.1,"vatAmount":0.1,"totalAmount":0.1,"supplierSettlementAccount":"string","supplierManagerPosition":"string","supplierManagerName":"string","supplierAccountantPosition":"string","supplierAccountantName":"string","customerName":"string","customerLegalAddress":"string","customerBusinessAddress":"string","customerSettlementAccount":"string","customerTaxCode":"string","customerManagerPosition":"string","customerManagerName":"string","customerAccountantPosition":"string","customerAccountantName":"string","stateRegisterNumber":"string","idDocumentType":"string","passportNumber":"string","socialCardNumber":"string","citizenOfRA":true,"socialExpensesType":"string","socialExpenseSocialCard":"string","socialExpenseCitizenName":"string","socialExpenseIdentityDocument":"string","socialExpenseSerialNumber":"string","itemList":[{"type":"string","storage":"string","id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"environmentalFeePercent":0.1,"environmentalFeeAmount":0.1,"vat":true,"dealType":"string","expenseAccount":"string","incomeAccount":"string","markingList":["string"],"rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "ecrCheckNumber": "string",
  "state": 0,
  "customer": "string",
  "printExpenseConfirmingCheck": true,
  "contract": "string",
  "contractDate": "2019-08-24",
  "cashDesk": "string",
  "customerAccount": "string",
  "receivedPrepaymentAccount": "string",
  "vatAccount": "string",
  "environmentalFeeAccount": "string",
  "nonCashTransactionAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "dealType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "nonCashAmount": 0.1,
  "useECRPos": true,
  "prepaymentAmount": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "citizenOfRA": true,
  "socialExpensesType": "string",
  "socialExpenseSocialCard": "string",
  "socialExpenseCitizenName": "string",
  "socialExpenseIdentityDocument": "string",
  "socialExpenseSerialNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "expenseAccount": "string",
      "incomeAccount": "string",
      "markingList": [
        "string"
      ],
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_retailsale_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[RetailSale](#schemaretailsale)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_documents_retailsale_{isn}

> Code samples

```shell
# You can also use wget
curl -X DELETE /accountant/v1/documents/retailsale/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /accountant/v1/documents/retailsale/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/retailsale/{isn}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/accountant/v1/documents/retailsale/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/accountant/v1/documents/retailsale/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/accountant/v1/documents/retailsale/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/retailsale/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/accountant/v1/documents/retailsale/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/documents/retailsale/{isn}`

<h3 id="delete__v1_documents_retailsale_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_documents_retailsale_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_documents_retailsale

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/documents/retailsale \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/documents/retailsale HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "ecrCheckNumber": "string",
  "state": 0,
  "customer": "string",
  "printExpenseConfirmingCheck": true,
  "contract": "string",
  "contractDate": "2019-08-24",
  "cashDesk": "string",
  "customerAccount": "string",
  "receivedPrepaymentAccount": "string",
  "vatAccount": "string",
  "environmentalFeeAccount": "string",
  "nonCashTransactionAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "dealType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "nonCashAmount": 0.1,
  "useECRPos": true,
  "prepaymentAmount": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "citizenOfRA": true,
  "socialExpensesType": "string",
  "socialExpenseSocialCard": "string",
  "socialExpenseCitizenName": "string",
  "socialExpenseIdentityDocument": "string",
  "socialExpenseSerialNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "expenseAccount": "string",
      "incomeAccount": "string",
      "markingList": [
        "string"
      ],
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/retailsale',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/documents/retailsale',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/documents/retailsale', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/documents/retailsale', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/retailsale");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/documents/retailsale", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/documents/retailsale`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "ecrCheckNumber": "string",
  "state": 0,
  "customer": "string",
  "printExpenseConfirmingCheck": true,
  "contract": "string",
  "contractDate": "2019-08-24",
  "cashDesk": "string",
  "customerAccount": "string",
  "receivedPrepaymentAccount": "string",
  "vatAccount": "string",
  "environmentalFeeAccount": "string",
  "nonCashTransactionAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "dealType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "nonCashAmount": 0.1,
  "useECRPos": true,
  "prepaymentAmount": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "citizenOfRA": true,
  "socialExpensesType": "string",
  "socialExpenseSocialCard": "string",
  "socialExpenseCitizenName": "string",
  "socialExpenseIdentityDocument": "string",
  "socialExpenseSerialNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "expenseAccount": "string",
      "incomeAccount": "string",
      "markingList": [
        "string"
      ],
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_retailsale-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[RetailSale](#schemaretailsale)|false|none|

> Example responses

> 201 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","ecrCheckNumber":"string","state":0,"customer":"string","printExpenseConfirmingCheck":true,"contract":"string","contractDate":"2019-08-24","cashDesk":"string","customerAccount":"string","receivedPrepaymentAccount":"string","vatAccount":"string","environmentalFeeAccount":"string","nonCashTransactionAccount":"string","analytic1":"string","analytic2":"string","taxExportType":"string","taxInvoiceSeries":"string","taxInvoiceNumber":"string","submissionDate":"2019-08-24","comment":"string","vatCalculationType":"string","dealType":"string","storage":"string","discountPercent":0.1,"nonCashAmount":0.1,"useECRPos":true,"prepaymentAmount":0.1,"vatAmount":0.1,"totalAmount":0.1,"supplierSettlementAccount":"string","supplierManagerPosition":"string","supplierManagerName":"string","supplierAccountantPosition":"string","supplierAccountantName":"string","customerName":"string","customerLegalAddress":"string","customerBusinessAddress":"string","customerSettlementAccount":"string","customerTaxCode":"string","customerManagerPosition":"string","customerManagerName":"string","customerAccountantPosition":"string","customerAccountantName":"string","stateRegisterNumber":"string","idDocumentType":"string","passportNumber":"string","socialCardNumber":"string","citizenOfRA":true,"socialExpensesType":"string","socialExpenseSocialCard":"string","socialExpenseCitizenName":"string","socialExpenseIdentityDocument":"string","socialExpenseSerialNumber":"string","itemList":[{"type":"string","storage":"string","id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"environmentalFeePercent":0.1,"environmentalFeeAmount":0.1,"vat":true,"dealType":"string","expenseAccount":"string","incomeAccount":"string","markingList":["string"],"rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "ecrCheckNumber": "string",
  "state": 0,
  "customer": "string",
  "printExpenseConfirmingCheck": true,
  "contract": "string",
  "contractDate": "2019-08-24",
  "cashDesk": "string",
  "customerAccount": "string",
  "receivedPrepaymentAccount": "string",
  "vatAccount": "string",
  "environmentalFeeAccount": "string",
  "nonCashTransactionAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "dealType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "nonCashAmount": 0.1,
  "useECRPos": true,
  "prepaymentAmount": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "citizenOfRA": true,
  "socialExpensesType": "string",
  "socialExpenseSocialCard": "string",
  "socialExpenseCitizenName": "string",
  "socialExpenseIdentityDocument": "string",
  "socialExpenseSerialNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "expenseAccount": "string",
      "incomeAccount": "string",
      "markingList": [
        "string"
      ],
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_retailsale-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[RetailSale](#schemaretailsale)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="accountant-public-api-services">Services</h1>

## post__v1_directories_services_list

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/directories/services/list \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/directories/services/list HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "codes": [
    "string"
  ],
  "lastModifiedDate": "2019-08-24T14:15:22Z",
  "showAlsoClosed": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/services/list',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/directories/services/list',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/directories/services/list', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/directories/services/list', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/services/list");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/directories/services/list", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/services/list`

> Body parameter

```json
{
  "pageSize": 0,
  "codes": [
    "string"
  ],
  "lastModifiedDate": "2019-08-24T14:15:22Z",
  "showAlsoClosed": true
}
```

<h3 id="post__v1_directories_services_list-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[ServiceFilters](#schemaservicefilters)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","fullName":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","cpaClassifier":"string","account":"string","revenueAccount":"string","retailRevenueAccount":"string","revenueAdjustmentAccount":"string","wholePrice":0.1,"retailPrice":0.1,"barcode":"string","vat":true,"lastModifierName":"string","lastModifyDate":"2019-08-24T14:15:22Z","isClosed":true}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "cpaClassifier": "string",
      "account": "string",
      "revenueAccount": "string",
      "retailRevenueAccount": "string",
      "revenueAdjustmentAccount": "string",
      "wholePrice": 0.1,
      "retailPrice": 0.1,
      "barcode": "string",
      "vat": true,
      "lastModifierName": "string",
      "lastModifyDate": "2019-08-24T14:15:22Z",
      "isClosed": true
    }
  ]
}
```

<h3 id="post__v1_directories_services_list-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[ServiceRowApiResponse](#schemaservicerowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_services_list_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/directories/services/list/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/directories/services/list/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/services/list/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/directories/services/list/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/directories/services/list/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/directories/services/list/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/services/list/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/directories/services/list/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/services/list/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_directories_services_list_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","fullName":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","cpaClassifier":"string","account":"string","revenueAccount":"string","retailRevenueAccount":"string","revenueAdjustmentAccount":"string","wholePrice":0.1,"retailPrice":0.1,"barcode":"string","vat":true,"lastModifierName":"string","lastModifyDate":"2019-08-24T14:15:22Z","isClosed":true}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "cpaClassifier": "string",
      "account": "string",
      "revenueAccount": "string",
      "retailRevenueAccount": "string",
      "revenueAdjustmentAccount": "string",
      "wholePrice": 0.1,
      "retailPrice": 0.1,
      "barcode": "string",
      "vat": true,
      "lastModifierName": "string",
      "lastModifyDate": "2019-08-24T14:15:22Z",
      "isClosed": true
    }
  ]
}
```

<h3 id="post__v1_directories_services_list_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[ServiceRowApiResponse](#schemaservicerowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## get__v1_directories_services_{code}

> Code samples

```shell
# You can also use wget
curl -X GET /accountant/v1/directories/services/{code} \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /accountant/v1/directories/services/{code} HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/services/{code}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/accountant/v1/directories/services/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/accountant/v1/directories/services/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/accountant/v1/directories/services/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/services/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/accountant/v1/directories/services/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/services/{code}`

<h3 id="get__v1_directories_services_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
{"id":0,"code":"string","name":"string","fullName":"string","unitMeasure":"string","unitMeasureName":"string","unitMeasureAbbreviation":"string","cpaClassifier":"string","account":"string","revenueAccount":"string","retailRevenueAccount":"string","revenueAdjustmentAccount":"string","wholePrice":0.1,"retailPrice":0.1,"currency":"string","currencyPrice":0.1,"barcode":"string","vat":true,"isClosed":true}
```

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "cpaClassifier": "string",
  "account": "string",
  "revenueAccount": "string",
  "retailRevenueAccount": "string",
  "revenueAdjustmentAccount": "string",
  "wholePrice": 0.1,
  "retailPrice": 0.1,
  "currency": "string",
  "currencyPrice": 0.1,
  "barcode": "string",
  "vat": true,
  "isClosed": true
}
```

<h3 id="get__v1_directories_services_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[Service](#schemaservice)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_directories_services_{code}

> Code samples

```shell
# You can also use wget
curl -X PUT /accountant/v1/directories/services/{code} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /accountant/v1/directories/services/{code} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "cpaClassifier": "string",
  "account": "string",
  "revenueAccount": "string",
  "retailRevenueAccount": "string",
  "revenueAdjustmentAccount": "string",
  "wholePrice": 0.1,
  "retailPrice": 0.1,
  "currency": "string",
  "currencyPrice": 0.1,
  "barcode": "string",
  "vat": true,
  "isClosed": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/services/{code}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/accountant/v1/directories/services/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/accountant/v1/directories/services/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/accountant/v1/directories/services/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/services/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/accountant/v1/directories/services/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/directories/services/{code}`

> Body parameter

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "cpaClassifier": "string",
  "account": "string",
  "revenueAccount": "string",
  "retailRevenueAccount": "string",
  "revenueAdjustmentAccount": "string",
  "wholePrice": 0.1,
  "retailPrice": 0.1,
  "currency": "string",
  "currencyPrice": 0.1,
  "barcode": "string",
  "vat": true,
  "isClosed": true
}
```

<h3 id="put__v1_directories_services_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Service](#schemaservice)|false|none|

> Example responses

> 200 Response

```
{"id":0,"code":"string","name":"string","fullName":"string","unitMeasure":"string","unitMeasureName":"string","unitMeasureAbbreviation":"string","cpaClassifier":"string","account":"string","revenueAccount":"string","retailRevenueAccount":"string","revenueAdjustmentAccount":"string","wholePrice":0.1,"retailPrice":0.1,"currency":"string","currencyPrice":0.1,"barcode":"string","vat":true,"isClosed":true}
```

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "cpaClassifier": "string",
  "account": "string",
  "revenueAccount": "string",
  "retailRevenueAccount": "string",
  "revenueAdjustmentAccount": "string",
  "wholePrice": 0.1,
  "retailPrice": 0.1,
  "currency": "string",
  "currencyPrice": 0.1,
  "barcode": "string",
  "vat": true,
  "isClosed": true
}
```

<h3 id="put__v1_directories_services_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[Service](#schemaservice)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_directories_services_{code}

> Code samples

```shell
# You can also use wget
curl -X DELETE /accountant/v1/directories/services/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /accountant/v1/directories/services/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/services/{code}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/accountant/v1/directories/services/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/accountant/v1/directories/services/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/accountant/v1/directories/services/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/services/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/accountant/v1/directories/services/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/directories/services/{code}`

<h3 id="delete__v1_directories_services_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_directories_services_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_services

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/directories/services \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/directories/services HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "cpaClassifier": "string",
  "account": "string",
  "revenueAccount": "string",
  "retailRevenueAccount": "string",
  "revenueAdjustmentAccount": "string",
  "wholePrice": 0.1,
  "retailPrice": 0.1,
  "currency": "string",
  "currencyPrice": 0.1,
  "barcode": "string",
  "vat": true,
  "isClosed": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/services',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/directories/services',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/directories/services', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/directories/services', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/services");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/directories/services", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/services`

> Body parameter

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "cpaClassifier": "string",
  "account": "string",
  "revenueAccount": "string",
  "retailRevenueAccount": "string",
  "revenueAdjustmentAccount": "string",
  "wholePrice": 0.1,
  "retailPrice": 0.1,
  "currency": "string",
  "currencyPrice": 0.1,
  "barcode": "string",
  "vat": true,
  "isClosed": true
}
```

<h3 id="post__v1_directories_services-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Service](#schemaservice)|false|none|

> Example responses

> 201 Response

```
{"id":0,"code":"string","name":"string","fullName":"string","unitMeasure":"string","unitMeasureName":"string","unitMeasureAbbreviation":"string","cpaClassifier":"string","account":"string","revenueAccount":"string","retailRevenueAccount":"string","revenueAdjustmentAccount":"string","wholePrice":0.1,"retailPrice":0.1,"currency":"string","currencyPrice":0.1,"barcode":"string","vat":true,"isClosed":true}
```

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "cpaClassifier": "string",
  "account": "string",
  "revenueAccount": "string",
  "retailRevenueAccount": "string",
  "revenueAdjustmentAccount": "string",
  "wholePrice": 0.1,
  "retailPrice": 0.1,
  "currency": "string",
  "currencyPrice": 0.1,
  "barcode": "string",
  "vat": true,
  "isClosed": true
}
```

<h3 id="post__v1_directories_services-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[Service](#schemaservice)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="accountant-public-api-storageinputorder">StorageInputOrder</h1>

## get__v1_documents_storageinputorder_{isn}

> Code samples

```shell
# You can also use wget
curl -X GET /accountant/v1/documents/storageinputorder/{isn} \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /accountant/v1/documents/storageinputorder/{isn} HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/storageinputorder/{isn}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/accountant/v1/documents/storageinputorder/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/accountant/v1/documents/storageinputorder/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/accountant/v1/documents/storageinputorder/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/storageinputorder/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/accountant/v1/documents/storageinputorder/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/documents/storageinputorder/{isn}`

<h3 id="get__v1_documents_storageinputorder_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"storage":"string","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"supplierCode":"string","supplierName":"string","supplierAccount":"string","prepaymentAccount":"string","analytic1":"string","analytic2":"string","taxExportType":"string","purchaseDocumentNumber":"string","purchaseDocumentDate":"2019-08-24","comment":"string","purchasingType":"string","vatCalculationType":"string","includeVATInCost":true,"vatInclusionMethod":"string","discountPercent":0.1,"vatAmount":0.1,"totalAmount":0.1,"supplierLegalAddress":"string","supplierBusinessAddress":"string","supplierSettlementAccount":"string","supplierTaxCode":"string","supplierManagerPosition":"string","supplierManagerName":"string","supplierAccountantPosition":"string","supplierAccountantName":"string","letterOfAttorney":"string","mediator":"string","vehicle":"string","chiefAccountant":"string","allowed":"string","accepted":"string","transportationDocumentNumber":"string","transportationDocumentDate":"2019-08-24","materialsList":[{"id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"vat":true,"account":"string","cpaClassifier":"string","rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "supplierCode": "string",
  "supplierName": "string",
  "supplierAccount": "string",
  "prepaymentAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "purchasingType": "string",
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "vatInclusionMethod": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccountant": "string",
  "allowed": "string",
  "accepted": "string",
  "transportationDocumentNumber": "string",
  "transportationDocumentDate": "2019-08-24",
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "account": "string",
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="get__v1_documents_storageinputorder_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[StorageInputOrder](#schemastorageinputorder)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_documents_storageinputorder_{isn}

> Code samples

```shell
# You can also use wget
curl -X PUT /accountant/v1/documents/storageinputorder/{isn} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /accountant/v1/documents/storageinputorder/{isn} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "supplierCode": "string",
  "supplierName": "string",
  "supplierAccount": "string",
  "prepaymentAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "purchasingType": "string",
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "vatInclusionMethod": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccountant": "string",
  "allowed": "string",
  "accepted": "string",
  "transportationDocumentNumber": "string",
  "transportationDocumentDate": "2019-08-24",
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "account": "string",
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/storageinputorder/{isn}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/accountant/v1/documents/storageinputorder/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/accountant/v1/documents/storageinputorder/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/accountant/v1/documents/storageinputorder/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/storageinputorder/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/accountant/v1/documents/storageinputorder/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/documents/storageinputorder/{isn}`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "supplierCode": "string",
  "supplierName": "string",
  "supplierAccount": "string",
  "prepaymentAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "purchasingType": "string",
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "vatInclusionMethod": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccountant": "string",
  "allowed": "string",
  "accepted": "string",
  "transportationDocumentNumber": "string",
  "transportationDocumentDate": "2019-08-24",
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "account": "string",
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_storageinputorder_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[StorageInputOrder](#schemastorageinputorder)|false|none|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"storage":"string","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"supplierCode":"string","supplierName":"string","supplierAccount":"string","prepaymentAccount":"string","analytic1":"string","analytic2":"string","taxExportType":"string","purchaseDocumentNumber":"string","purchaseDocumentDate":"2019-08-24","comment":"string","purchasingType":"string","vatCalculationType":"string","includeVATInCost":true,"vatInclusionMethod":"string","discountPercent":0.1,"vatAmount":0.1,"totalAmount":0.1,"supplierLegalAddress":"string","supplierBusinessAddress":"string","supplierSettlementAccount":"string","supplierTaxCode":"string","supplierManagerPosition":"string","supplierManagerName":"string","supplierAccountantPosition":"string","supplierAccountantName":"string","letterOfAttorney":"string","mediator":"string","vehicle":"string","chiefAccountant":"string","allowed":"string","accepted":"string","transportationDocumentNumber":"string","transportationDocumentDate":"2019-08-24","materialsList":[{"id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"vat":true,"account":"string","cpaClassifier":"string","rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "supplierCode": "string",
  "supplierName": "string",
  "supplierAccount": "string",
  "prepaymentAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "purchasingType": "string",
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "vatInclusionMethod": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccountant": "string",
  "allowed": "string",
  "accepted": "string",
  "transportationDocumentNumber": "string",
  "transportationDocumentDate": "2019-08-24",
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "account": "string",
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_storageinputorder_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[StorageInputOrder](#schemastorageinputorder)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_documents_storageinputorder_{isn}

> Code samples

```shell
# You can also use wget
curl -X DELETE /accountant/v1/documents/storageinputorder/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /accountant/v1/documents/storageinputorder/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/storageinputorder/{isn}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/accountant/v1/documents/storageinputorder/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/accountant/v1/documents/storageinputorder/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/accountant/v1/documents/storageinputorder/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/storageinputorder/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/accountant/v1/documents/storageinputorder/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/documents/storageinputorder/{isn}`

<h3 id="delete__v1_documents_storageinputorder_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_documents_storageinputorder_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_documents_storageinputorder

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/documents/storageinputorder \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/documents/storageinputorder HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "supplierCode": "string",
  "supplierName": "string",
  "supplierAccount": "string",
  "prepaymentAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "purchasingType": "string",
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "vatInclusionMethod": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccountant": "string",
  "allowed": "string",
  "accepted": "string",
  "transportationDocumentNumber": "string",
  "transportationDocumentDate": "2019-08-24",
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "account": "string",
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/storageinputorder',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/documents/storageinputorder',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/documents/storageinputorder', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/documents/storageinputorder', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/storageinputorder");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/documents/storageinputorder", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/documents/storageinputorder`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "supplierCode": "string",
  "supplierName": "string",
  "supplierAccount": "string",
  "prepaymentAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "purchasingType": "string",
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "vatInclusionMethod": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccountant": "string",
  "allowed": "string",
  "accepted": "string",
  "transportationDocumentNumber": "string",
  "transportationDocumentDate": "2019-08-24",
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "account": "string",
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_storageinputorder-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[StorageInputOrder](#schemastorageinputorder)|false|none|

> Example responses

> 201 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"storage":"string","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"supplierCode":"string","supplierName":"string","supplierAccount":"string","prepaymentAccount":"string","analytic1":"string","analytic2":"string","taxExportType":"string","purchaseDocumentNumber":"string","purchaseDocumentDate":"2019-08-24","comment":"string","purchasingType":"string","vatCalculationType":"string","includeVATInCost":true,"vatInclusionMethod":"string","discountPercent":0.1,"vatAmount":0.1,"totalAmount":0.1,"supplierLegalAddress":"string","supplierBusinessAddress":"string","supplierSettlementAccount":"string","supplierTaxCode":"string","supplierManagerPosition":"string","supplierManagerName":"string","supplierAccountantPosition":"string","supplierAccountantName":"string","letterOfAttorney":"string","mediator":"string","vehicle":"string","chiefAccountant":"string","allowed":"string","accepted":"string","transportationDocumentNumber":"string","transportationDocumentDate":"2019-08-24","materialsList":[{"id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"vat":true,"account":"string","cpaClassifier":"string","rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "supplierCode": "string",
  "supplierName": "string",
  "supplierAccount": "string",
  "prepaymentAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "purchasingType": "string",
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "vatInclusionMethod": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccountant": "string",
  "allowed": "string",
  "accepted": "string",
  "transportationDocumentNumber": "string",
  "transportationDocumentDate": "2019-08-24",
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "account": "string",
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_storageinputorder-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[StorageInputOrder](#schemastorageinputorder)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="accountant-public-api-storageoutputorder">StorageOutputOrder</h1>

## get__v1_documents_storageoutputorder_{isn}

> Code samples

```shell
# You can also use wget
curl -X GET /accountant/v1/documents/storageoutputorder/{isn} \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /accountant/v1/documents/storageoutputorder/{isn} HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/storageoutputorder/{isn}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/accountant/v1/documents/storageoutputorder/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/accountant/v1/documents/storageoutputorder/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/accountant/v1/documents/storageoutputorder/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/storageoutputorder/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/accountant/v1/documents/storageoutputorder/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/documents/storageoutputorder/{isn}`

<h3 id="get__v1_documents_storageoutputorder_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"storage":"string","expenseAccount":"string","analytic1":"string","analytic2":"string","comment":"string","letterOfAttorney":"string","mediator":"string","vehicle":"string","chiefAccountant":"string","allowed":"string","requested":"string","totalAmount":0.1,"materialsList":[{"id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"amount":0.1,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "expenseAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccountant": "string",
  "allowed": "string",
  "requested": "string",
  "totalAmount": 0.1,
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "rowId": 0
    }
  ]
}
```

<h3 id="get__v1_documents_storageoutputorder_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[StorageOutputOrder](#schemastorageoutputorder)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_documents_storageoutputorder_{isn}

> Code samples

```shell
# You can also use wget
curl -X PUT /accountant/v1/documents/storageoutputorder/{isn} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /accountant/v1/documents/storageoutputorder/{isn} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "expenseAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccountant": "string",
  "allowed": "string",
  "requested": "string",
  "totalAmount": 0.1,
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/storageoutputorder/{isn}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/accountant/v1/documents/storageoutputorder/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/accountant/v1/documents/storageoutputorder/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/accountant/v1/documents/storageoutputorder/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/storageoutputorder/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/accountant/v1/documents/storageoutputorder/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/documents/storageoutputorder/{isn}`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "expenseAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccountant": "string",
  "allowed": "string",
  "requested": "string",
  "totalAmount": 0.1,
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_storageoutputorder_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[StorageOutputOrder](#schemastorageoutputorder)|false|none|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"storage":"string","expenseAccount":"string","analytic1":"string","analytic2":"string","comment":"string","letterOfAttorney":"string","mediator":"string","vehicle":"string","chiefAccountant":"string","allowed":"string","requested":"string","totalAmount":0.1,"materialsList":[{"id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"amount":0.1,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "expenseAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccountant": "string",
  "allowed": "string",
  "requested": "string",
  "totalAmount": 0.1,
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_storageoutputorder_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[StorageOutputOrder](#schemastorageoutputorder)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_documents_storageoutputorder_{isn}

> Code samples

```shell
# You can also use wget
curl -X DELETE /accountant/v1/documents/storageoutputorder/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /accountant/v1/documents/storageoutputorder/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/storageoutputorder/{isn}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/accountant/v1/documents/storageoutputorder/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/accountant/v1/documents/storageoutputorder/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/accountant/v1/documents/storageoutputorder/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/storageoutputorder/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/accountant/v1/documents/storageoutputorder/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/documents/storageoutputorder/{isn}`

<h3 id="delete__v1_documents_storageoutputorder_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_documents_storageoutputorder_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_documents_storageoutputorder

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/documents/storageoutputorder \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/documents/storageoutputorder HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "expenseAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccountant": "string",
  "allowed": "string",
  "requested": "string",
  "totalAmount": 0.1,
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/storageoutputorder',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/documents/storageoutputorder',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/documents/storageoutputorder', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/documents/storageoutputorder', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/storageoutputorder");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/documents/storageoutputorder", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/documents/storageoutputorder`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "expenseAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccountant": "string",
  "allowed": "string",
  "requested": "string",
  "totalAmount": 0.1,
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_storageoutputorder-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[StorageOutputOrder](#schemastorageoutputorder)|false|none|

> Example responses

> 201 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"storage":"string","expenseAccount":"string","analytic1":"string","analytic2":"string","comment":"string","letterOfAttorney":"string","mediator":"string","vehicle":"string","chiefAccountant":"string","allowed":"string","requested":"string","totalAmount":0.1,"materialsList":[{"id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"amount":0.1,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "expenseAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccountant": "string",
  "allowed": "string",
  "requested": "string",
  "totalAmount": 0.1,
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_storageoutputorder-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[StorageOutputOrder](#schemastorageoutputorder)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="accountant-public-api-storages">Storages</h1>

## get__v1_directories_storages

> Code samples

```shell
# You can also use wget
curl -X GET /accountant/v1/directories/storages \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /accountant/v1/directories/storages HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/storages',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/accountant/v1/directories/storages',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/accountant/v1/directories/storages', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/accountant/v1/directories/storages', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/storages");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/accountant/v1/directories/storages", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/storages`

<h3 id="get__v1_directories_storages-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|showAlsoClosed|query|boolean|false|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
[{"code":"string","name":"string","stockkeeper":"string","address":"string","isClosed":true}]
```

```json
[
  {
    "code": "string",
    "name": "string",
    "stockkeeper": "string",
    "address": "string",
    "isClosed": true
  }
]
```

<h3 id="get__v1_directories_storages-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<h3 id="get__v1_directories_storages-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[Storage](#schemastorage)]|false|none|none|
|» code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|» name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|» stockkeeper|string¦null|false|none|hy-AM: Պահեստապետ | en-US: Stockkeeper | ru-RU: Заведующий складом|
|» address|string¦null|false|none|hy-AM: Հասցե | en-US: Address | ru-RU: Адрес|
|» isClosed|boolean¦null|false|none|hy-AM: Փակված | en-US: Closed | ru-RU: Закрыто|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_storages

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/directories/storages \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/directories/storages HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "code": "string",
  "name": "string",
  "stockkeeper": "string",
  "address": "string",
  "isClosed": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/storages',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/directories/storages',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/directories/storages', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/directories/storages', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/storages");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/directories/storages", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/storages`

> Body parameter

```json
{
  "code": "string",
  "name": "string",
  "stockkeeper": "string",
  "address": "string",
  "isClosed": true
}
```

<h3 id="post__v1_directories_storages-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Storage](#schemastorage)|false|none|

> Example responses

> 201 Response

```
{"code":"string","name":"string","stockkeeper":"string","address":"string","isClosed":true}
```

```json
{
  "code": "string",
  "name": "string",
  "stockkeeper": "string",
  "address": "string",
  "isClosed": true
}
```

<h3 id="post__v1_directories_storages-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[Storage](#schemastorage)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## get__v1_directories_storages_{code}

> Code samples

```shell
# You can also use wget
curl -X GET /accountant/v1/directories/storages/{code} \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /accountant/v1/directories/storages/{code} HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/storages/{code}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/accountant/v1/directories/storages/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/accountant/v1/directories/storages/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/accountant/v1/directories/storages/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/storages/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/accountant/v1/directories/storages/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/storages/{code}`

<h3 id="get__v1_directories_storages_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
{"code":"string","name":"string","stockkeeper":"string","address":"string","isClosed":true}
```

```json
{
  "code": "string",
  "name": "string",
  "stockkeeper": "string",
  "address": "string",
  "isClosed": true
}
```

<h3 id="get__v1_directories_storages_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[Storage](#schemastorage)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_directories_storages_{code}

> Code samples

```shell
# You can also use wget
curl -X PUT /accountant/v1/directories/storages/{code} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /accountant/v1/directories/storages/{code} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "code": "string",
  "name": "string",
  "stockkeeper": "string",
  "address": "string",
  "isClosed": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/storages/{code}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/accountant/v1/directories/storages/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/accountant/v1/directories/storages/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/accountant/v1/directories/storages/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/storages/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/accountant/v1/directories/storages/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/directories/storages/{code}`

> Body parameter

```json
{
  "code": "string",
  "name": "string",
  "stockkeeper": "string",
  "address": "string",
  "isClosed": true
}
```

<h3 id="put__v1_directories_storages_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Storage](#schemastorage)|false|none|

> Example responses

> 200 Response

```
{"code":"string","name":"string","stockkeeper":"string","address":"string","isClosed":true}
```

```json
{
  "code": "string",
  "name": "string",
  "stockkeeper": "string",
  "address": "string",
  "isClosed": true
}
```

<h3 id="put__v1_directories_storages_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[Storage](#schemastorage)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_directories_storages_{code}

> Code samples

```shell
# You can also use wget
curl -X DELETE /accountant/v1/directories/storages/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /accountant/v1/directories/storages/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/directories/storages/{code}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/accountant/v1/directories/storages/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/accountant/v1/directories/storages/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/accountant/v1/directories/storages/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/directories/storages/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/accountant/v1/directories/storages/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/directories/storages/{code}`

<h3 id="delete__v1_directories_storages_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_directories_storages_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="accountant-public-api-transferinvoice">TransferInvoice</h1>

## get__v1_documents_transferinvoice_{isn}

> Code samples

```shell
# You can also use wget
curl -X GET /accountant/v1/documents/transferinvoice/{isn} \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /accountant/v1/documents/transferinvoice/{isn} HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/transferinvoice/{isn}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/accountant/v1/documents/transferinvoice/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/accountant/v1/documents/transferinvoice/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/accountant/v1/documents/transferinvoice/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/transferinvoice/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/accountant/v1/documents/transferinvoice/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/documents/transferinvoice/{isn}`

<h3 id="get__v1_documents_transferinvoice_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","customer":"string","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"state":0,"contract":"string","contractDate":"2019-08-24","comment":"string","vatCalculationType":"string","storage":"string","discountPercent":0.1,"vatAmount":0.1,"totalAmount":0.1,"supplierBusinessAddress":"string","supplierSettlementAccount":"string","supplierManagerPosition":"string","supplierManagerName":"string","supplierAccountantPosition":"string","supplierAccountantName":"string","customerName":"string","customerLegalAddress":"string","customerBusinessAddress":"string","customerSettlementAccount":"string","customerTaxCode":"string","customerManagerPosition":"string","customerManagerName":"string","customerAccountantPosition":"string","customerAccountantName":"string","stateRegisterNumber":"string","passportNumber":"string","itemList":[{"type":"string","storage":"string","id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"vat":true,"rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "state": 0,
  "contract": "string",
  "contractDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="get__v1_documents_transferinvoice_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[TransferInvoice](#schematransferinvoice)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_documents_transferinvoice_{isn}

> Code samples

```shell
# You can also use wget
curl -X PUT /accountant/v1/documents/transferinvoice/{isn} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /accountant/v1/documents/transferinvoice/{isn} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "state": 0,
  "contract": "string",
  "contractDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/transferinvoice/{isn}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/accountant/v1/documents/transferinvoice/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/accountant/v1/documents/transferinvoice/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/accountant/v1/documents/transferinvoice/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/transferinvoice/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/accountant/v1/documents/transferinvoice/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/documents/transferinvoice/{isn}`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "state": 0,
  "contract": "string",
  "contractDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_transferinvoice_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[TransferInvoice](#schematransferinvoice)|false|none|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","customer":"string","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"state":0,"contract":"string","contractDate":"2019-08-24","comment":"string","vatCalculationType":"string","storage":"string","discountPercent":0.1,"vatAmount":0.1,"totalAmount":0.1,"supplierBusinessAddress":"string","supplierSettlementAccount":"string","supplierManagerPosition":"string","supplierManagerName":"string","supplierAccountantPosition":"string","supplierAccountantName":"string","customerName":"string","customerLegalAddress":"string","customerBusinessAddress":"string","customerSettlementAccount":"string","customerTaxCode":"string","customerManagerPosition":"string","customerManagerName":"string","customerAccountantPosition":"string","customerAccountantName":"string","stateRegisterNumber":"string","passportNumber":"string","itemList":[{"type":"string","storage":"string","id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"vat":true,"rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "state": 0,
  "contract": "string",
  "contractDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_transferinvoice_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[TransferInvoice](#schematransferinvoice)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_documents_transferinvoice_{isn}

> Code samples

```shell
# You can also use wget
curl -X DELETE /accountant/v1/documents/transferinvoice/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /accountant/v1/documents/transferinvoice/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/transferinvoice/{isn}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/accountant/v1/documents/transferinvoice/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/accountant/v1/documents/transferinvoice/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/accountant/v1/documents/transferinvoice/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/transferinvoice/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/accountant/v1/documents/transferinvoice/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/documents/transferinvoice/{isn}`

<h3 id="delete__v1_documents_transferinvoice_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_documents_transferinvoice_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_documents_transferinvoice

> Code samples

```shell
# You can also use wget
curl -X POST /accountant/v1/documents/transferinvoice \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /accountant/v1/documents/transferinvoice HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "state": 0,
  "contract": "string",
  "contractDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/accountant/v1/documents/transferinvoice',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/accountant/v1/documents/transferinvoice',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/accountant/v1/documents/transferinvoice', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/accountant/v1/documents/transferinvoice', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/v1/documents/transferinvoice");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/accountant/v1/documents/transferinvoice", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/documents/transferinvoice`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "state": 0,
  "contract": "string",
  "contractDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_transferinvoice-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[TransferInvoice](#schematransferinvoice)|false|none|

> Example responses

> 201 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","customer":"string","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"state":0,"contract":"string","contractDate":"2019-08-24","comment":"string","vatCalculationType":"string","storage":"string","discountPercent":0.1,"vatAmount":0.1,"totalAmount":0.1,"supplierBusinessAddress":"string","supplierSettlementAccount":"string","supplierManagerPosition":"string","supplierManagerName":"string","supplierAccountantPosition":"string","supplierAccountantName":"string","customerName":"string","customerLegalAddress":"string","customerBusinessAddress":"string","customerSettlementAccount":"string","customerTaxCode":"string","customerManagerPosition":"string","customerManagerName":"string","customerAccountantPosition":"string","customerAccountantName":"string","stateRegisterNumber":"string","passportNumber":"string","itemList":[{"type":"string","storage":"string","id":0,"code":"string","name":"string","unitAbbreviation":"string","quantity":0.1,"price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"vat":true,"rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "state": 0,
  "contract": "string",
  "contractDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_transferinvoice-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[TransferInvoice](#schematransferinvoice)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="accountant-public-api-version">Version</h1>

## get__api_Version

> Code samples

```shell
# You can also use wget
curl -X GET /accountant/api/Version \
  -H 'Accept: text/plain'

```

```http
GET /accountant/api/Version HTTP/1.1

Accept: text/plain

```

```javascript

const headers = {
  'Accept':'text/plain'
};

fetch('/accountant/api/Version',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain'
}

result = RestClient.get '/accountant/api/Version',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain'
}

r = requests.get('/accountant/api/Version', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/accountant/api/Version', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/accountant/api/Version");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/accountant/api/Version", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /api/Version`

> Example responses

> 200 Response

```
"string"
```

```json
"string"
```

<h3 id="get__api_version-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|string|

<aside class="success">
This operation does not require authentication
</aside>

# Schemas

<h2 id="tocS_AccountBalancesParam">AccountBalancesParam</h2>
<!-- backwards compatibility -->
<a id="schemaaccountbalancesparam"></a>
<a id="schema_AccountBalancesParam"></a>
<a id="tocSaccountbalancesparam"></a>
<a id="tocsaccountbalancesparam"></a>

```json
{
  "pageSize": 0,
  "date": "2019-08-24",
  "account": "string",
  "currency": "string",
  "reportCurrency": "string",
  "accountsSection": "string",
  "showOnlyLastLevels": true,
  "showPartners": true,
  "showAnalytics1": true,
  "showAnalytics2": true,
  "showZeroRows": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|hy-AM:  էջ  | en-US:  page | ru-RU: страница|
|date|string(date)|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|currency|string¦null|false|none|hy-AM: Արժույթ | en-US: Currency | ru-RU: Валюта|
|reportCurrency|string¦null|false|none|hy-AM: Հաշվետվության արժույթ | en-US: Report currency | ru-RU: Валюта отчета|
|accountsSection|string¦null|false|none|hy-AM: Հաշվի պատկանելիության բաժին | en-US: Accounts section | ru-RU: Раздел счета|
|showOnlyLastLevels|boolean|false|none|hy-AM: Ցույց տալ միայն վերջին մակարդակի հաշիվները | en-US: Show only last levels accounts | ru-RU: Показать счета последнего уровня|
|showPartners|boolean|false|none|hy-AM: Ցույց տալ գործընկերներին | en-US: Show the partners | ru-RU: Показать данные по партнерам|
|showAnalytics1|boolean|false|none|hy-AM: Ցույց տալ անալիտիկ խումբ 1 | en-US: Show the analytical dim. 1 | ru-RU: Показать аналитическая группа 1|
|showAnalytics2|boolean|false|none|hy-AM: Ցույց տալ անալիտիկ խումբ 2 | en-US: Show the analytical dim. 2 | ru-RU: Показать аналитическая группа 2|
|showZeroRows|boolean|false|none|hy-AM: Ցույց տալ զրոյական տողերը | en-US: Show zero rows | ru-RU: Показать нулевые строки|

<h2 id="tocS_AccountsBalancesDataRow">AccountsBalancesDataRow</h2>
<!-- backwards compatibility -->
<a id="schemaaccountsbalancesdatarow"></a>
<a id="schema_AccountsBalancesDataRow"></a>
<a id="tocSaccountsbalancesdatarow"></a>
<a id="tocsaccountsbalancesdatarow"></a>

```json
{
  "account": "string",
  "currency": "string",
  "name": "string",
  "nameRU": "string",
  "debitCurrencyAmount": 0.1,
  "creditCurrencyAmount": 0.1,
  "debitAmount": 0.1,
  "creditAmount": 0.1,
  "outOfBalance": true,
  "accountType": "string",
  "leaf": true,
  "isPartnerAccount": true,
  "isAnalytic1": true,
  "isAnalytic2": true,
  "path": "string",
  "parent": "string",
  "partnerId": 0,
  "partnerCode": "string",
  "partnerName": "string",
  "analytic1Code": "string",
  "analytic1Name": "string",
  "analytic2Code": "string",
  "analytic2Name": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|currency|string¦null|false|none|hy-AM: Արժույթ | en-US: Currency | ru-RU: Валюта|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|nameRU|string¦null|false|none|hy-AM: Անվանում (ռուսերեն) | en-US: Name (russian) | ru-RU: Наименование (русский)|
|debitCurrencyAmount|number(double)¦null|false|none|hy-AM: Դեբետ արժ. | en-US: Debit curr. | ru-RU: Дебет валюта|
|creditCurrencyAmount|number(double)¦null|false|none|hy-AM: Կրեդիտ արժ. | en-US: Credit curr. | ru-RU: Кредит валюта|
|debitAmount|number(double)|false|none|hy-AM: Դեբետ դրամով | en-US: Debit in Dram | ru-RU: Дебет в драмах|
|creditAmount|number(double)|false|none|hy-AM: Կրեդիտ դրամով | en-US: Credit in Dram | ru-RU: Кредит в драмах|
|outOfBalance|boolean|false|none|hy-AM: Արտահաշվ. | en-US: Out of bal. | ru-RU: Забалан.|
|accountType|string¦null|false|none|hy-AM: Հաշվի տեսակ | en-US: Invoice type | ru-RU: Вид счета|
|leaf|boolean|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|isPartnerAccount|boolean|false|none|hy-AM: Գործընկ. | en-US: Partner | ru-RU: Партн.|
|isAnalytic1|boolean|false|none|hy-AM: Ան.խումբ 1 | en-US: An. dimension 1 | ru-RU: Ан.группа 1|
|isAnalytic2|boolean|false|none|hy-AM: Ան.խումբ 2 | en-US: An. dimension 2 | ru-RU: Ан.группа 2|
|path|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|parent|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|partnerId|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|partnerCode|string¦null|false|none|hy-AM: Գործընկ. | en-US: Partner | ru-RU: Партн.|
|partnerName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|analytic1Code|string¦null|false|none|hy-AM: Ան.խումբ 1 | en-US: An. dimension 1 | ru-RU: Ан.группа 1|
|analytic1Name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|analytic2Code|string¦null|false|none|hy-AM: Ան.խումբ 2 | en-US: An. dimension 2 | ru-RU: Ан.группа 2|
|analytic2Name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|

<h2 id="tocS_AccountsBalancesDataRowApiResponse">AccountsBalancesDataRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemaaccountsbalancesdatarowapiresponse"></a>
<a id="schema_AccountsBalancesDataRowApiResponse"></a>
<a id="tocSaccountsbalancesdatarowapiresponse"></a>
<a id="tocsaccountsbalancesdatarowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "account": "string",
      "currency": "string",
      "name": "string",
      "nameRU": "string",
      "debitCurrencyAmount": 0.1,
      "creditCurrencyAmount": 0.1,
      "debitAmount": 0.1,
      "creditAmount": 0.1,
      "outOfBalance": true,
      "accountType": "string",
      "leaf": true,
      "isPartnerAccount": true,
      "isAnalytic1": true,
      "isAnalytic2": true,
      "path": "string",
      "parent": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "analytic1Code": "string",
      "analytic1Name": "string",
      "analytic2Code": "string",
      "analytic2Name": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[AccountsBalancesDataRow](#schemaaccountsbalancesdatarow)]¦null|false|none|none|

<h2 id="tocS_AccountsTurnoverDataRow">AccountsTurnoverDataRow</h2>
<!-- backwards compatibility -->
<a id="schemaaccountsturnoverdatarow"></a>
<a id="schema_AccountsTurnoverDataRow"></a>
<a id="tocSaccountsturnoverdatarow"></a>
<a id="tocsaccountsturnoverdatarow"></a>

```json
{
  "account": "string",
  "currency": "string",
  "name": "string",
  "nameRU": "string",
  "partnerId": 0,
  "partnerCode": "string",
  "partnerName": "string",
  "analytic1Code": "string",
  "analytic1Name": "string",
  "analytic2Code": "string",
  "analytic2Name": "string",
  "startDebitCurrencyAmount": 0.1,
  "startCreditCurrencyAmount": 0.1,
  "startDebitAmount": 0.1,
  "startCreditAmount": 0.1,
  "turnoverDebitCurrencyAmount": 0.1,
  "turnoverCreditCurrencyAmount": 0.1,
  "turnoverDebitAmount": 0.1,
  "turnoverCreditAmount": 0.1,
  "endDebitCurrencyAmount": 0.1,
  "endCreditCurrencyAmount": 0.1,
  "endDebitAmount": 0.1,
  "endCreditAmount": 0.1,
  "outOfBalance": true,
  "accountType": "string",
  "leaf": true,
  "isPartnerAccount": true,
  "isAnalytic1": true,
  "isAnalytic2": true,
  "path": "string",
  "parent": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|currency|string¦null|false|none|hy-AM: Արժույթ | en-US: Currency | ru-RU: Валюта|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|nameRU|string¦null|false|none|hy-AM: Անվանում (ռուսերեն) | en-US: Name (russian) | ru-RU: Наименование (русский)|
|partnerId|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|partnerCode|string¦null|false|none|hy-AM: Գործընկ. | en-US: Partner | ru-RU: Партн.|
|partnerName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|analytic1Code|string¦null|false|none|hy-AM: Ան.խումբ 1 | en-US: An. dimension 1 | ru-RU: Ан.группа 1|
|analytic1Name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|analytic2Code|string¦null|false|none|hy-AM: Ան.խումբ 2 | en-US: An. dimension 2 | ru-RU: Ан.группа 2|
|analytic2Name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|startDebitCurrencyAmount|number(double)¦null|false|none|hy-AM: Սկզբ. մն. դեբետ արժ. | en-US: Starting Db. bal. in Curr. | ru-RU: Нач. остаток дебетовый вал.|
|startCreditCurrencyAmount|number(double)¦null|false|none|hy-AM: Սկզբ. մն. կրեդիտ արժ. | en-US: Starting Cr. bal. in Curr. | ru-RU: Нач. остаток кредитовый вал.|
|startDebitAmount|number(double)|false|none|hy-AM: Սկզբ. մն. դեբետ դրամով | en-US: Beginning Db. bal. in Dram | ru-RU: Нач. остаток дебетовый драм.|
|startCreditAmount|number(double)|false|none|hy-AM: Սկզբ. մն. կրեդիտ դրամով | en-US: Beginning Cr. bal. in Dram | ru-RU: Нач. остаток кредитовый драм.|
|turnoverDebitCurrencyAmount|number(double)¦null|false|none|hy-AM: Շրջ. դեբետ արժ. | en-US: Turnover Db. in Curr. | ru-RU: Оборот дебетовый вал.|
|turnoverCreditCurrencyAmount|number(double)¦null|false|none|hy-AM: Շրջ. կրեդիտ արժ. | en-US: Turnover Cr. in Curr. | ru-RU: Оборот кредитовый вал.|
|turnoverDebitAmount|number(double)|false|none|hy-AM: Շրջ. դեբետ դրամով | en-US: Turnover Db. in Dram | ru-RU: Оборот дебетовый драм.|
|turnoverCreditAmount|number(double)|false|none|hy-AM: Շրջ. կրեդիտ դրամով | en-US: Turnover Cr. in Dram | ru-RU: Оборот кредитовый драм.|
|endDebitCurrencyAmount|number(double)¦null|false|none|hy-AM: Վերջ. մն. դեբետ արժ. | en-US: Ending Db. bal. in Curr. | ru-RU: Конечн. остаток дебетовый вал.|
|endCreditCurrencyAmount|number(double)¦null|false|none|hy-AM: Վերջ. մն. կրեդիտ արժ. | en-US: Ending Cr. bal. in Curr. | ru-RU: Конечн. остаток кредитовый вал.|
|endDebitAmount|number(double)|false|none|hy-AM: Վերջ. մն. դեբետ դրամով | en-US: Ending Db. bal. in Dram | ru-RU: Конечн. остаток дебетовый драм.|
|endCreditAmount|number(double)|false|none|hy-AM: Վերջ. մն. կրեդիտ դրամով | en-US: Ending Cr. bal. in Dram | ru-RU: Конечн. остаток кредитовый драм.|
|outOfBalance|boolean|false|none|hy-AM: Արտահաշվ. | en-US: Out of bal. | ru-RU: Забалан.|
|accountType|string¦null|false|none|hy-AM: Հաշվի տեսակ | en-US: Invoice type | ru-RU: Вид счета|
|leaf|boolean|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|isPartnerAccount|boolean|false|none|hy-AM: Գործընկ. | en-US: Partner | ru-RU: Партн.|
|isAnalytic1|boolean|false|none|hy-AM: Ան.խումբ 1 | en-US: An. dimension 1 | ru-RU: Ан.группа 1|
|isAnalytic2|boolean|false|none|hy-AM: Ան.խումբ 2 | en-US: An. dimension 2 | ru-RU: Ан.группа 2|
|path|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|parent|string¦null|false|none|hy-AM: Կուտակիչ | en-US: Parent | ru-RU: Родитель|

<h2 id="tocS_AccountsTurnoverDataRowApiResponse">AccountsTurnoverDataRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemaaccountsturnoverdatarowapiresponse"></a>
<a id="schema_AccountsTurnoverDataRowApiResponse"></a>
<a id="tocSaccountsturnoverdatarowapiresponse"></a>
<a id="tocsaccountsturnoverdatarowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "account": "string",
      "currency": "string",
      "name": "string",
      "nameRU": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "analytic1Code": "string",
      "analytic1Name": "string",
      "analytic2Code": "string",
      "analytic2Name": "string",
      "startDebitCurrencyAmount": 0.1,
      "startCreditCurrencyAmount": 0.1,
      "startDebitAmount": 0.1,
      "startCreditAmount": 0.1,
      "turnoverDebitCurrencyAmount": 0.1,
      "turnoverCreditCurrencyAmount": 0.1,
      "turnoverDebitAmount": 0.1,
      "turnoverCreditAmount": 0.1,
      "endDebitCurrencyAmount": 0.1,
      "endCreditCurrencyAmount": 0.1,
      "endDebitAmount": 0.1,
      "endCreditAmount": 0.1,
      "outOfBalance": true,
      "accountType": "string",
      "leaf": true,
      "isPartnerAccount": true,
      "isAnalytic1": true,
      "isAnalytic2": true,
      "path": "string",
      "parent": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[AccountsTurnoverDataRow](#schemaaccountsturnoverdatarow)]¦null|false|none|none|

<h2 id="tocS_AccountsTurnoverParam">AccountsTurnoverParam</h2>
<!-- backwards compatibility -->
<a id="schemaaccountsturnoverparam"></a>
<a id="schema_AccountsTurnoverParam"></a>
<a id="tocSaccountsturnoverparam"></a>
<a id="tocsaccountsturnoverparam"></a>

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "account": "string",
  "currency": "string",
  "reportCurrency": "string",
  "accountsSection": "string",
  "showOnlyLastLevels": true,
  "showPartners": true,
  "showAnalytics1": true,
  "showAnalytics2": true,
  "showZeroRows": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|hy-AM:  էջ  | en-US:  page | ru-RU: страница|
|startDate|string(date)|false|none|hy-AM: Ժամանակահատվածի սկիզբ | en-US: Period begin | ru-RU: Начало периода|
|endDate|string(date)|false|none|hy-AM: Ժամանակահատվածի վերջ | en-US: Period end | ru-RU: Конец периода|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|currency|string¦null|false|none|hy-AM: Արժույթ | en-US: Currency | ru-RU: Валюта|
|reportCurrency|string¦null|false|none|hy-AM: Հաշվետվության արժույթ | en-US: Report currency | ru-RU: Валюта отчета|
|accountsSection|string¦null|false|none|hy-AM: Հաշվի պատկանելիության բաժին | en-US: Accounts section | ru-RU: Раздел счета|
|showOnlyLastLevels|boolean|false|none|hy-AM: Ցույց տալ միայն վերջին մակարդակի հաշիվները | en-US: Show only last levels accounts | ru-RU: Показать счета последнего уровня|
|showPartners|boolean|false|none|hy-AM: Ցույց տալ գործընկերներին | en-US: Show the partners | ru-RU: Показать данные по партнерам|
|showAnalytics1|boolean|false|none|hy-AM: Ցույց տալ անալիտիկ խումբ 1 | en-US: Show the analytical dim. 1 | ru-RU: Показать аналитическая группа 1|
|showAnalytics2|boolean|false|none|hy-AM: Ցույց տալ անալիտիկ խումբ 2 | en-US: Show the analytical dim. 2 | ru-RU: Показать аналитическая группа 2|
|showZeroRows|boolean|false|none|hy-AM: Ցույց տալ զրոյական տողերը | en-US: Show zero rows | ru-RU: Показать нулевые строки|

<h2 id="tocS_AllDocumentsJournalDataRow">AllDocumentsJournalDataRow</h2>
<!-- backwards compatibility -->
<a id="schemaalldocumentsjournaldatarow"></a>
<a id="schema_AllDocumentsJournalDataRow"></a>
<a id="tocSalldocumentsjournaldatarow"></a>
<a id="tocsalldocumentsjournaldatarow"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "dayOrderNumber": 0,
  "documentNumber": "string",
  "type": 0,
  "typeName": "string",
  "currency": "string",
  "amount": 0.1,
  "state": 0,
  "stateName": "string",
  "partnerId": 0,
  "partnerCode": "string",
  "partnerName": "string",
  "employeeCode": "string",
  "employeeName": "string",
  "comment": "string",
  "userName": "string",
  "lastChange": "2019-08-24T14:15:22Z"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|dayOrderNumber|integer(int32)|false|none|hy-AM: Օրվա հ/հ | en-US: Day order number  | ru-RU: п/н дня|
|documentNumber|string¦null|false|none|hy-AM: Փաստաթղթի N | en-US: Document N | ru-RU: Номер док.|
|type|integer(int32)|false|none|hy-AM: Փաստաթղթի տեսակ | en-US: Document type | ru-RU: Вид документа|
|typeName|string¦null|false|none|hy-AM: Փաստաթղթի տեսակ | en-US: Document type | ru-RU: Вид документа|
|currency|string¦null|false|none|hy-AM: Արժույթ | en-US: Currency | ru-RU: Валюта|
|amount|number(double)|false|none|hy-AM: Գումար | en-US: Amount | ru-RU: Сумма|
|state|integer(int32)|false|none|hy-AM: Փաստաթղթի վիճակ | en-US: Document state | ru-RU: Статус документа|
|stateName|string¦null|false|none|hy-AM: Վիճակ | en-US: State | ru-RU: Состояние|
|partnerId|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|partnerCode|string¦null|false|none|hy-AM: Գործընկեր | en-US: Partner | ru-RU: Партнер|
|partnerName|string¦null|false|none|hy-AM: Գործընկերոջ անվանում | en-US: Partner name | ru-RU: Наименование партнера|
|employeeCode|string¦null|false|none|hy-AM: Աշխատակից | en-US: Employee | ru-RU: Сотрудник|
|employeeName|string¦null|false|none|hy-AM: Աշխատակցի անվանում | en-US: Employee name | ru-RU: Наименование сотрудника|
|comment|string¦null|false|none|hy-AM: Մեկնաբանություն | en-US: Comment | ru-RU: Комментарий|
|userName|string¦null|false|none|hy-AM: Օգտագործող | en-US: User name | ru-RU: Пользователь|
|lastChange|string(date-time)|false|none|hy-AM: Վերջին խմբագրման ամսաթիվ | en-US: Last modification date | ru-RU: Дата последнего изменения|

<h2 id="tocS_AllDocumentsJournalDataRowApiResponse">AllDocumentsJournalDataRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemaalldocumentsjournaldatarowapiresponse"></a>
<a id="schema_AllDocumentsJournalDataRowApiResponse"></a>
<a id="tocSalldocumentsjournaldatarowapiresponse"></a>
<a id="tocsalldocumentsjournaldatarowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "dayOrderNumber": 0,
      "documentNumber": "string",
      "type": 0,
      "typeName": "string",
      "currency": "string",
      "amount": 0.1,
      "state": 0,
      "stateName": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "employeeCode": "string",
      "employeeName": "string",
      "comment": "string",
      "userName": "string",
      "lastChange": "2019-08-24T14:15:22Z"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[AllDocumentsJournalDataRow](#schemaalldocumentsjournaldatarow)]¦null|false|none|none|

<h2 id="tocS_AllDocumentsJournalParam">AllDocumentsJournalParam</h2>
<!-- backwards compatibility -->
<a id="schemaalldocumentsjournalparam"></a>
<a id="schema_AllDocumentsJournalParam"></a>
<a id="tocSalldocumentsjournalparam"></a>
<a id="tocsalldocumentsjournalparam"></a>

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "documentTypes": [
    "string"
  ],
  "currency": "string",
  "partner": "string",
  "employee": "string",
  "material": "string",
  "inventoryNumber": "string",
  "documentState": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|hy-AM:  էջ  | en-US:  page | ru-RU: страница|
|startDate|string(date)|false|none|hy-AM: Ժամանակահատվածի սկիզբ | en-US: Period begin | ru-RU: Начало периода|
|endDate|string(date)|false|none|hy-AM: Ժամանակահատվածի վերջ | en-US: Period end | ru-RU: Конец периода|
|documentTypes|[string]¦null|false|none|hy-AM: Փաստաթղթի տեսակ | en-US: Document type | ru-RU: Вид документа|
|currency|string¦null|false|none|hy-AM: Արժույթ | en-US: Currency | ru-RU: Валюта|
|partner|string¦null|false|none|hy-AM: Գործընկեր | en-US: Partner | ru-RU: Партнер|
|employee|string¦null|false|none|hy-AM: Աշխատակից | en-US: Employee | ru-RU: Сотрудник|
|material|string¦null|false|none|hy-AM: Նյութական արժեք | en-US: Material | ru-RU: Товарно-материальная ценность|
|inventoryNumber|string¦null|false|none|hy-AM: Գույքային համար | en-US: Inventory number | ru-RU: Инвентарный номер|
|documentState|string¦null|false|none|hy-AM: Վիճակ | en-US: State | ru-RU: Состояние|

<h2 id="tocS_ECRChecksJournalDataRow">ECRChecksJournalDataRow</h2>
<!-- backwards compatibility -->
<a id="schemaecrchecksjournaldatarow"></a>
<a id="schema_ECRChecksJournalDataRow"></a>
<a id="tocSecrchecksjournaldatarow"></a>
<a id="tocsecrchecksjournaldatarow"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "ecrCheckNumber": "string",
  "type": 0,
  "typeName": "string",
  "amount": 0.1,
  "cashAmount": 0.1,
  "nonCashAmount": 0.1,
  "prepaymentAmount": 0.1,
  "receivablesAmount": 0.1,
  "state": 0,
  "stateName": "string",
  "cashDesk": "string",
  "partnerId": 0,
  "partnerCode": "string",
  "partnerName": "string",
  "partnerTaxCode": "string",
  "comment": "string",
  "userName": "string",
  "lastChange": "2019-08-24T14:15:22Z"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|documentNumber|string¦null|false|none|hy-AM: Փաստաթղթի N | en-US: Document N | ru-RU: Номер док.|
|ecrCheckNumber|string¦null|false|none|none|
|type|integer(int32)|false|none|hy-AM: Տեսակ | en-US: Type | ru-RU: Вид|
|typeName|string¦null|false|none|hy-AM: Տեսակ | en-US: Type | ru-RU: Вид|
|amount|number(double)|false|none|hy-AM: Գումար | en-US: Amount | ru-RU: Сумма|
|cashAmount|number(double)|false|none|hy-AM: Կանխիկ | en-US: Cash | ru-RU: Наличные|
|nonCashAmount|number(double)|false|none|hy-AM: Անկանխիկ | en-US: Non-cash | ru-RU: Безнал.|
|prepaymentAmount|number(double)|false|none|hy-AM: Կանխավճարով մարում | en-US: Prepayment | ru-RU: Оплата авансом|
|receivablesAmount|number(double)|false|none|hy-AM: Դեբիտորական պարտք | en-US: Receivables | ru-RU: Дебиторская задолженность|
|state|integer(int32)|false|none|hy-AM: Վիճակ | en-US: State | ru-RU: Состояние|
|stateName|string¦null|false|none|hy-AM: Վիճակ | en-US: State | ru-RU: Состояние|
|cashDesk|string¦null|false|none|hy-AM: Դրամարկղ | en-US: Cash | ru-RU: Касса|
|partnerId|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|partnerCode|string¦null|false|none|hy-AM: Գործընկեր | en-US: Partner | ru-RU: Партнер|
|partnerName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|partnerTaxCode|string¦null|false|none|hy-AM: ՀՎՀՀ | en-US: Taxpayer’s ID | ru-RU: ИНН код|
|comment|string¦null|false|none|hy-AM: Մեկնաբանություն | en-US: Comment | ru-RU: Комментарий|
|userName|string¦null|false|none|hy-AM: Օգտագործող | en-US: User name | ru-RU: Пользователь|
|lastChange|string(date-time)|false|none|hy-AM: Վերջին փոփոխություն | en-US: Last change | ru-RU: Последнее изменение|

<h2 id="tocS_ECRChecksJournalDataRowApiResponse">ECRChecksJournalDataRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemaecrchecksjournaldatarowapiresponse"></a>
<a id="schema_ECRChecksJournalDataRowApiResponse"></a>
<a id="tocSecrchecksjournaldatarowapiresponse"></a>
<a id="tocsecrchecksjournaldatarowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "ecrCheckNumber": "string",
      "type": 0,
      "typeName": "string",
      "amount": 0.1,
      "cashAmount": 0.1,
      "nonCashAmount": 0.1,
      "prepaymentAmount": 0.1,
      "receivablesAmount": 0.1,
      "state": 0,
      "stateName": "string",
      "cashDesk": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "partnerTaxCode": "string",
      "comment": "string",
      "userName": "string",
      "lastChange": "2019-08-24T14:15:22Z"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[ECRChecksJournalDataRow](#schemaecrchecksjournaldatarow)]¦null|false|none|none|

<h2 id="tocS_ECRChecksJournalParam">ECRChecksJournalParam</h2>
<!-- backwards compatibility -->
<a id="schemaecrchecksjournalparam"></a>
<a id="schema_ECRChecksJournalParam"></a>
<a id="tocSecrchecksjournalparam"></a>
<a id="tocsecrchecksjournalparam"></a>

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "documentTypes": [
    "string"
  ],
  "partner": "string",
  "cashDesk": "string",
  "showPayments": true,
  "showOutputAmountsAsNegatives": true,
  "documentState": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|hy-AM:  էջ  | en-US:  page | ru-RU: страница|
|startDate|string(date)|false|none|hy-AM: Ժամանակահատվածի սկիզբ | en-US: Period begin | ru-RU: Начало периода|
|endDate|string(date)|false|none|hy-AM: Ժամանակահատվածի վերջ | en-US: Period end | ru-RU: Конец периода|
|documentTypes|[string]¦null|false|none|hy-AM: Տեսակ | en-US: Type | ru-RU: Вид|
|partner|string¦null|false|none|hy-AM: Գործընկեր | en-US: Partner | ru-RU: Партнер|
|cashDesk|string¦null|false|none|hy-AM: Դրամարկղ | en-US: Cash | ru-RU: Касса|
|showPayments|boolean|false|none|hy-AM: Ցույց տալ գումարի բացվածքը | en-US: Show payments | ru-RU: Показать оплаты|
|showOutputAmountsAsNegatives|boolean|false|none|hy-AM: Ցույց տալ ելքերի գումարները բացասական | en-US: Show output amounts as negatives | ru-RU: Показывать суммы расходов негативными|
|documentState|string¦null|false|none|hy-AM: Վիճակ | en-US: State | ru-RU: Состояние|

<h2 id="tocS_Employee">Employee</h2>
<!-- backwards compatibility -->
<a id="schemaemployee"></a>
<a id="schema_Employee"></a>
<a id="tocSemployee"></a>
<a id="tocsemployee"></a>

```json
{
  "id": 0,
  "code": "string",
  "fullName": "string",
  "departmentCode": "string",
  "positionCode": "string",
  "positionStartDate": "2019-08-24",
  "professionCode": "string",
  "genderCode": "string",
  "birthDate": "2019-08-24",
  "contractTypeCode": "string",
  "defaultAccrual": "string",
  "defaultTimeSheet": "string",
  "employmentStartDate": "2019-08-24",
  "employmentOrderNumber": "string",
  "dateOfDismissal": "2019-08-24",
  "dismissalOrderNumber": "string",
  "raCitizen": true,
  "calculateIncomeTax": true,
  "reducePensionFromIncomeTax": true,
  "salaryAccount": "string",
  "partnerCode": "string",
  "tradeUnionDuesPercent": 0.1,
  "participationStatus": "string",
  "employerPercent": 0.1,
  "employerAmount": 0.1,
  "stampFeeType": "string",
  "insuranceFeeType": "string",
  "insuranceFeeDate": "2019-08-24",
  "registrationPlaceRA": true,
  "registrationRegion": "string",
  "registrationCommunity": "string",
  "registrationCity": "string",
  "registrationStreet": "string",
  "registrationHouse": "string",
  "registrationApartment": "string",
  "registrationSameAsResidence": true,
  "placeResidenceRA": true,
  "residenceRegion": "string",
  "residenceCommunity": "string",
  "residenceLocation": "string",
  "residenceCity": "string",
  "residenceStreet": "string",
  "residenceHouse": "string",
  "residenceApartment": "string",
  "residenceCountry": "string",
  "addressLine1": "string",
  "addressLine2": "string",
  "addressLine3": "string",
  "postalCode": "string",
  "bankAccount": "string",
  "socialCardNumber": "string",
  "identificationDocumentType": "string",
  "passport": "string",
  "passportIssueDate": "2019-08-24",
  "passportIssuedBy": "string",
  "nationality": "string",
  "otherDocumentNumber": "string",
  "phone": "string",
  "mobilePhone": "string",
  "email": "string",
  "languages": "string",
  "maritalStatus": "string",
  "education": "string",
  "institute": "string",
  "educationStartDate": "2019-08-24",
  "educationEndDate": "2019-08-24",
  "educationCertificateNumber": "string",
  "militaryServiceDescription": "string",
  "militaryServiceStartDate": "2019-08-24",
  "militaryServiceEndDate": "2019-08-24",
  "familyMember1Type": "string",
  "familyMember1FullName": "string",
  "familyMember2Type": "string",
  "familyMember2FullName": "string",
  "familyMember3Type": "string",
  "familyMember3FullName": "string",
  "familyMember4Type": "string",
  "familyMember4FullName": "string",
  "accrualsDeductions": [
    {
      "date": "2019-08-24",
      "code": "string",
      "name": "string",
      "amount": 0.1,
      "default": true
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|fullName|string¦null|false|none|hy-AM: Ազգանուն, անուն, հայրանուն | en-US: Full name | ru-RU: Фамилия, имя, отчество|
|departmentCode|string¦null|false|none|hy-AM: Ստորաբաժանում | en-US: Department | ru-RU: Подразделение|
|positionCode|string¦null|false|none|hy-AM: Պաշտոն | en-US: Position | ru-RU: Должность|
|positionStartDate|string(date)¦null|false|none|hy-AM: Պաշտոնի սկիզբ | en-US: Position start | ru-RU: Принят на должность с|
|professionCode|string¦null|false|none|hy-AM: Մասնագիտություն | en-US: Profession | ru-RU: Профессия|
|genderCode|string¦null|false|none|hy-AM: Սեռ | en-US: Gender | ru-RU: Пол|
|birthDate|string(date)¦null|false|none|hy-AM: Ծննդյան ամսաթիվ | en-US: Birth date | ru-RU: Дата рождения|
|contractTypeCode|string¦null|false|none|hy-AM: Պայմանագրի տեսակ | en-US: Contract type | ru-RU: Тип договора|
|defaultAccrual|string¦null|false|none|hy-AM: Հիմնական հավելում | en-US: Default accrual | ru-RU: Основное начисление|
|defaultTimeSheet|string¦null|false|none|hy-AM: Հիմնական աշխատանքի գրաֆիկ | en-US: Default timesheet | ru-RU: Основной рабочий график|
|employmentStartDate|string(date)¦null|false|none|hy-AM: Ընդունման ամսաթիվ | en-US: Employment start date | ru-RU: Дата приема на работу|
|employmentOrderNumber|string¦null|false|none|hy-AM: Աշխ. ընդունման հրամանի N | en-US: N of employment order | ru-RU: Номер приказа о приеме на работу|
|dateOfDismissal|string(date)¦null|false|none|hy-AM: Ազատման ամսաթիվ | en-US: Date of dismissal | ru-RU: Дата увольнения|
|dismissalOrderNumber|string¦null|false|none|hy-AM: Աշխ. ազատման հրամանի N | en-US: N of dismissal order | ru-RU: Номер приказа на увольнение|
|raCitizen|boolean¦null|false|none|none|
|calculateIncomeTax|boolean¦null|false|none|hy-AM: Եկամտային հարկը պահվում է | en-US: Calculate income tax | ru-RU: Облагается подоходным налогом|
|reducePensionFromIncomeTax|boolean¦null|false|none|hy-AM: Նվազեցնել կուտակայինի գումարը եկամտային հարկից | en-US: Deduct employee's funded pension amount from the income tax. | ru-RU: Уменьшить подоход. налог на сумму накоп. пенс. взноса|
|salaryAccount|string¦null|false|none|hy-AM: Աշխատավարձի գծով հաշվարկների հաշիվ | en-US: Salary payable | ru-RU: Счет расчета по оплате труда|
|partnerCode|string¦null|false|none|hy-AM: Ֆիզ. անձ (գործընկեր) | en-US: Individual (partner) | ru-RU: Физическое лицо(партнер)|
|tradeUnionDuesPercent|number(double)¦null|false|none|hy-AM: Արհմիութենական անդամավճարի տոկոս | en-US: Trade union dues percent | ru-RU: Процент профсоюзного взноса|
|participationStatus|string¦null|false|none|hy-AM: Մասնակցության կարգավիճակ | en-US: Participation Status | ru-RU: Статус участия|
|employerPercent|number(double)¦null|false|none|hy-AM: Գործատուի կողմից վճարվող տոկոս/գումար | en-US: Employer paid percent/summa | ru-RU: Процент/сумма уплачиваемая работодателем|
|employerAmount|number(double)¦null|false|none|hy-AM: Գործատուի կողմից վճարվող տոկոս/գումար | en-US: Employer paid percent/summa | ru-RU: Процент/сумма уплачиваемая работодателем|
|stampFeeType|string¦null|false|none|hy-AM: Դրոշմանիշային վճար | en-US: Stamp fee | ru-RU: Гербовый сбор|
|insuranceFeeType|string¦null|false|none|hy-AM: Ապահովագրավճար | en-US: Insurance fee | ru-RU: Страховая плата|
|insuranceFeeDate|string(date)¦null|false|none|hy-AM: Կարգավիճակի սկիզբ | en-US: Status start date | ru-RU: Дата начала статуса|
|registrationPlaceRA|boolean¦null|false|none|hy-AM: Հաշվառման վայրը ՀՀ | en-US: Place of registration in RA | ru-RU: Адрес регистрации РА|
|registrationRegion|string¦null|false|none|hy-AM: Մարզ | en-US: Region | ru-RU: Регион|
|registrationCommunity|string¦null|false|none|hy-AM: Համայնք | en-US: Community | ru-RU: Район|
|registrationCity|string¦null|false|none|hy-AM: Քաղաք, ավան, գյուղ | en-US: City, village | ru-RU: Город, поселение, село|
|registrationStreet|string¦null|false|none|hy-AM: Փողոց, տուն/շենք, բնակարան | en-US: Street, house/building, apartment | ru-RU: Улица, дом/здание, квартира|
|registrationHouse|string¦null|false|none|hy-AM: Փողոց, տուն/շենք, բնակարան | en-US: Street, house/building, apartment | ru-RU: Улица, дом/здание, квартира|
|registrationApartment|string¦null|false|none|hy-AM: Փողոց, տուն/շենք, բնակարան | en-US: Street, house/building, apartment | ru-RU: Улица, дом/здание, квартира|
|registrationSameAsResidence|boolean¦null|false|none|hy-AM: Բն. վայրը նույնն է հաշվ. վայրի հետ | en-US: Place of residence is the same with registration place | ru-RU: Регистрация по месту жительства|
|placeResidenceRA|boolean¦null|false|none|hy-AM: Բնակության վայրը ՀՀ | en-US: Place of residence is RA | ru-RU: Место проживания РА|
|residenceRegion|string¦null|false|none|hy-AM: Մարզ | en-US: Region | ru-RU: Регион|
|residenceCommunity|string¦null|false|none|hy-AM: Համայնք | en-US: Community | ru-RU: Район|
|residenceLocation|string¦null|false|none|hy-AM: Բնակավայր | en-US: Location | ru-RU: Населенный пункт|
|residenceCity|string¦null|false|none|hy-AM: Քաղաք, ավան, գյուղ | en-US: City, village | ru-RU: Город, поселение, село|
|residenceStreet|string¦null|false|none|hy-AM: Փողոց, տուն/շենք, բնակարան | en-US: Street, house/building, apartment | ru-RU: Улица, дом/здание, квартира|
|residenceHouse|string¦null|false|none|hy-AM: Փողոց, տուն/շենք, բնակարան | en-US: Street, house/building, apartment | ru-RU: Улица, дом/здание, квартира|
|residenceApartment|string¦null|false|none|hy-AM: Փողոց, տուն/շենք, բնակարան | en-US: Street, house/building, apartment | ru-RU: Улица, дом/здание, квартира|
|residenceCountry|string¦null|false|none|hy-AM: Երկիր | en-US: Country | ru-RU: Страна|
|addressLine1|string¦null|false|none|hy-AM: Հասցեատող 1,2,3 | en-US: AddressLine 1,2,3 | ru-RU: Адрес 1,2,3|
|addressLine2|string¦null|false|none|hy-AM: Հասցեատող 1,2,3 | en-US: AddressLine 1,2,3 | ru-RU: Адрес 1,2,3|
|addressLine3|string¦null|false|none|hy-AM: Հասցեատող 1,2,3 | en-US: AddressLine 1,2,3 | ru-RU: Адрес 1,2,3|
|postalCode|string¦null|false|none|hy-AM: Փոստի N | en-US: Postal N | ru-RU: Номер почты|
|bankAccount|string¦null|false|none|hy-AM: Աշխատակցի հաշիվը բանկում | en-US: Employee bank account | ru-RU: Банковский счет сотрудника|
|socialCardNumber|string¦null|false|none|hy-AM: Հանրային ծառայությունների համարանիշ | en-US: Social card number | ru-RU: Номер социальной карты|
|identificationDocumentType|string¦null|false|none|hy-AM: Անձը հաստատող փաստաթուղթ | en-US: Identification document | ru-RU: Документ, удостоверяющий личность|
|passport|string¦null|false|none|hy-AM: Անձնագրի համար | en-US: Passport N | ru-RU: Номер паспорта|
|passportIssueDate|string(date)¦null|false|none|hy-AM: Տրման ամսաթիվ | en-US: Date issued | ru-RU: Дата выдачи|
|passportIssuedBy|string¦null|false|none|hy-AM: Ում կողմից է տրվել | en-US: Authority | ru-RU: Кем выдан (код подразд.)|
|nationality|string¦null|false|none|hy-AM: Ազգություն | en-US: Nationality | ru-RU: Национальность|
|otherDocumentNumber|string¦null|false|none|hy-AM: Այլ փաստաթղթի համար | en-US: Other document N | ru-RU: Номер прочего документа|
|phone|string¦null|false|none|hy-AM: Հեռախոս | en-US: Phone | ru-RU: Телефон|
|mobilePhone|string¦null|false|none|hy-AM: Բջջային հեռախոս | en-US: Mobile phone | ru-RU: Сотовый телефон|
|email|string¦null|false|none|hy-AM: Էլ. փոստ | en-US: E-Mail | ru-RU: Эл. почта|
|languages|string¦null|false|none|hy-AM: Օտար լեզուներ | en-US: Foreign languages | ru-RU: Иностранные языки|
|maritalStatus|string¦null|false|none|hy-AM: Ընտանեկան դրությունը | en-US: Marital status | ru-RU: Семейное положение|
|education|string¦null|false|none|hy-AM: Կրթություն | en-US: Education | ru-RU: Образование|
|institute|string¦null|false|none|hy-AM: Ուս. հաստատություն | en-US: Educational institution | ru-RU: Учебн. заведение|
|educationStartDate|string(date)¦null|false|none|hy-AM: Ընդունվելու տարին | en-US: Admiss. year | ru-RU: Дата поступления|
|educationEndDate|string(date)¦null|false|none|hy-AM: Ավարտելու կամ հեռանալու տարին | en-US: Graduation year | ru-RU: Год окончания или ухода|
|educationCertificateNumber|string¦null|false|none|hy-AM: Դիպլոմի կամ վկայականի համարը | en-US: Diploma or Certificate number | ru-RU: Номер диплома или сертификата|
|militaryServiceDescription|string¦null|false|none|hy-AM: Նկարագրություն | en-US: Description | ru-RU: Описание|
|militaryServiceStartDate|string(date)¦null|false|none|hy-AM: Սկիզբ | en-US: Start | ru-RU: Начало|
|militaryServiceEndDate|string(date)¦null|false|none|hy-AM: Ավարտ | en-US: End | ru-RU: Конец|
|familyMember1Type|string¦null|false|none|hy-AM: Ընտանիքի անդամ | en-US: Family member | ru-RU: Член семьи|
|familyMember1FullName|string¦null|false|none|hy-AM: Ընտանիքի անդամ | en-US: Family member | ru-RU: Член семьи|
|familyMember2Type|string¦null|false|none|hy-AM: Ընտանիքի անդամ | en-US: Family member | ru-RU: Член семьи|
|familyMember2FullName|string¦null|false|none|hy-AM: Ընտանիքի անդամ | en-US: Family member | ru-RU: Член семьи|
|familyMember3Type|string¦null|false|none|hy-AM: Ընտանիքի անդամ | en-US: Family member | ru-RU: Член семьи|
|familyMember3FullName|string¦null|false|none|hy-AM: Ընտանիքի անդամ | en-US: Family member | ru-RU: Член семьи|
|familyMember4Type|string¦null|false|none|hy-AM: Ընտանիքի անդամ | en-US: Family member | ru-RU: Член семьи|
|familyMember4FullName|string¦null|false|none|hy-AM: Ընտանիքի անդամ | en-US: Family member | ru-RU: Член семьи|
|accrualsDeductions|[[EmployeeFeeHoldRow](#schemaemployeefeeholdrow)]¦null|false|none|hy-AM: Հավելում/պահումներ | en-US: Accrual/deductions | ru-RU: Начисления/удержания|

<h2 id="tocS_EmployeeFeeHoldRow">EmployeeFeeHoldRow</h2>
<!-- backwards compatibility -->
<a id="schemaemployeefeeholdrow"></a>
<a id="schema_EmployeeFeeHoldRow"></a>
<a id="tocSemployeefeeholdrow"></a>
<a id="tocsemployeefeeholdrow"></a>

```json
{
  "date": "2019-08-24",
  "code": "string",
  "name": "string",
  "amount": 0.1,
  "default": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|date|string(date)|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|amount|number(double)|false|none|hy-AM: Գումար | en-US: Amount | ru-RU: Сумма|
|default|boolean|false|none|hy-AM: Հիմնական | en-US: Main | ru-RU: Основной|

<h2 id="tocS_EmployeeFilters">EmployeeFilters</h2>
<!-- backwards compatibility -->
<a id="schemaemployeefilters"></a>
<a id="schema_EmployeeFilters"></a>
<a id="tocSemployeefilters"></a>
<a id="tocsemployeefilters"></a>

```json
{
  "pageSize": 0,
  "codes": [
    "string"
  ],
  "lastModifiedDate": "2019-08-24T14:15:22Z"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|hy-AM:  էջ  | en-US:  page | ru-RU: страница|
|codes|[string]¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|lastModifiedDate|string(date-time)¦null|false|none|hy-AM: Վերջին խմբագրման ամսաթիվ | en-US: Last modification date | ru-RU: Дата последнего изменения|

<h2 id="tocS_EmployeeRow">EmployeeRow</h2>
<!-- backwards compatibility -->
<a id="schemaemployeerow"></a>
<a id="schema_EmployeeRow"></a>
<a id="tocSemployeerow"></a>
<a id="tocsemployeerow"></a>

```json
{
  "id": 0,
  "code": "string",
  "fullName": "string",
  "departmentCode": "string",
  "departmentName": "string",
  "positionCode": "string",
  "positionName": "string",
  "positionStartDate": "2019-08-24",
  "defaultTimeSheet": "string",
  "contractTypeCode": "string",
  "contractTypeName": "string",
  "employmentStartDate": "2019-08-24",
  "dateOfDismissal": "2019-08-24",
  "birthDate": "2019-08-24",
  "genderCode": "string",
  "genderName": "string",
  "phone": "string",
  "passport": "string",
  "bankAccount": "string",
  "professionCode": "string",
  "professionName": "string",
  "raCitizen": true,
  "calculateIncomeTax": true,
  "stampFeeType": "string",
  "insuranceFeeType": "string",
  "insuranceFeeDate": "2019-08-24",
  "salaryAccount": "string",
  "partnerCode": "string",
  "partnerName": "string",
  "tradeUnionDuesPercent": 0.1,
  "participationStatus": "string",
  "lastModifierName": "string",
  "lastModifyDate": "2019-08-24T14:15:22Z"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|fullName|string¦null|false|none|hy-AM: Ազգանուն, անուն, հայրանուն | en-US: Full name | ru-RU: Фамилия, имя, отчество|
|departmentCode|string¦null|false|none|hy-AM: Ստորաբաժանում | en-US: Department | ru-RU: Подразделение|
|departmentName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|positionCode|string¦null|false|none|hy-AM: Պաշտոն | en-US: Position | ru-RU: Должность|
|positionName|string¦null|false|none|hy-AM: Պաշտոն | en-US: Position | ru-RU: Должность|
|positionStartDate|string(date)¦null|false|none|hy-AM: Պաշտոնի սկիզբ | en-US: Position start | ru-RU: Принят на должность с|
|defaultTimeSheet|string¦null|false|none|hy-AM: Հիմնական աշխատանքի գրաֆիկ | en-US: Default timesheet | ru-RU: Основной рабочий график|
|contractTypeCode|string¦null|false|none|hy-AM: Պայմանագրի տեսակ | en-US: Contract type | ru-RU: Тип договора|
|contractTypeName|string¦null|false|none|hy-AM: Պայմանագրի տեսակ | en-US: Contract type | ru-RU: Тип договора|
|employmentStartDate|string(date)¦null|false|none|hy-AM: Ընդունման ամսաթիվ | en-US: Employment start date | ru-RU: Дата приема на работу|
|dateOfDismissal|string(date)¦null|false|none|hy-AM: Ազատման ամսաթիվ | en-US: Date of dismissal | ru-RU: Дата увольнения|
|birthDate|string(date)¦null|false|none|hy-AM: Ծննդյան ամսաթիվ | en-US: Birth date | ru-RU: Дата рождения|
|genderCode|string¦null|false|none|hy-AM: Սեռ | en-US: Gender | ru-RU: Пол|
|genderName|string¦null|false|none|hy-AM: Սեռ | en-US: Gender | ru-RU: Пол|
|phone|string¦null|false|none|hy-AM: Հեռախոս | en-US: Phone | ru-RU: Телефон|
|passport|string¦null|false|none|hy-AM: Անձնագրի համար | en-US: Passport N | ru-RU: Номер паспорта|
|bankAccount|string¦null|false|none|hy-AM: Աշխատակցի հաշիվը բանկում | en-US: Employee bank account | ru-RU: Банковский счет сотрудника|
|professionCode|string¦null|false|none|hy-AM: Մասնագիտություն | en-US: Profession | ru-RU: Профессия|
|professionName|string¦null|false|none|hy-AM: Մասնագիտություն | en-US: Profession | ru-RU: Профессия|
|raCitizen|boolean|false|none|none|
|calculateIncomeTax|boolean|false|none|hy-AM: Եկամտային հարկը պահվում է | en-US: Calculate income tax | ru-RU: Облагается подоходным налогом|
|stampFeeType|string¦null|false|none|hy-AM: Դրոշմանիշային վճար | en-US: Stamp fee | ru-RU: Гербовый сбор|
|insuranceFeeType|string¦null|false|none|hy-AM: Ապահովագրավճար | en-US: Insurance fee | ru-RU: Страховая плата|
|insuranceFeeDate|string(date)¦null|false|none|hy-AM: Կարգավիճակի սկիզբ | en-US: Status start date | ru-RU: Дата начала статуса|
|salaryAccount|string¦null|false|none|hy-AM: Աշխատավարձի գծով հաշվարկների հաշիվ | en-US: Salary payable | ru-RU: Счет расчета по оплате труда|
|partnerCode|string¦null|false|none|hy-AM: Գործընկեր | en-US: Partner | ru-RU: Партнер|
|partnerName|string¦null|false|none|hy-AM: Գործընկերոջ անվանում | en-US: Partner name | ru-RU: Наименование партнера|
|tradeUnionDuesPercent|number(double)|false|none|hy-AM: Արհմիութենական անդամավճարի տոկոս | en-US: Trade union dues percent | ru-RU: Процент профсоюзного взноса|
|participationStatus|string¦null|false|none|hy-AM: Մասնակցության կարգավիճակ | en-US: Participation Status | ru-RU: Статус участия|
|lastModifierName|string¦null|false|none|hy-AM: Օգտագործող | en-US: User name | ru-RU: Пользователь|
|lastModifyDate|string(date-time)¦null|false|none|hy-AM: Վերջին փոփոխություն | en-US: Last change | ru-RU: Последнее изменение|

<h2 id="tocS_EmployeeRowApiResponse">EmployeeRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemaemployeerowapiresponse"></a>
<a id="schema_EmployeeRowApiResponse"></a>
<a id="tocSemployeerowapiresponse"></a>
<a id="tocsemployeerowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "fullName": "string",
      "departmentCode": "string",
      "departmentName": "string",
      "positionCode": "string",
      "positionName": "string",
      "positionStartDate": "2019-08-24",
      "defaultTimeSheet": "string",
      "contractTypeCode": "string",
      "contractTypeName": "string",
      "employmentStartDate": "2019-08-24",
      "dateOfDismissal": "2019-08-24",
      "birthDate": "2019-08-24",
      "genderCode": "string",
      "genderName": "string",
      "phone": "string",
      "passport": "string",
      "bankAccount": "string",
      "professionCode": "string",
      "professionName": "string",
      "raCitizen": true,
      "calculateIncomeTax": true,
      "stampFeeType": "string",
      "insuranceFeeType": "string",
      "insuranceFeeDate": "2019-08-24",
      "salaryAccount": "string",
      "partnerCode": "string",
      "partnerName": "string",
      "tradeUnionDuesPercent": 0.1,
      "participationStatus": "string",
      "lastModifierName": "string",
      "lastModifyDate": "2019-08-24T14:15:22Z"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[EmployeeRow](#schemaemployeerow)]¦null|false|none|none|

<h2 id="tocS_Invoice">Invoice</h2>
<!-- backwards compatibility -->
<a id="schemainvoice"></a>
<a id="schema_Invoice"></a>
<a id="tocSinvoice"></a>
<a id="tocsinvoice"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "state": 0,
  "contract": "string",
  "contractDate": "2019-08-24",
  "customerAccount": "string",
  "receivedPrepaymentAccount": "string",
  "vatAccount": "string",
  "environmentalFeeAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "dealType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "supplierAdditionalData": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "customerAdditionalData": "string",
  "shippingMethod": "string",
  "citizenOfRA": true,
  "socialExpensesType": "string",
  "socialExpenseSocialCard": "string",
  "socialExpenseCitizenName": "string",
  "socialExpenseIdentityDocument": "string",
  "socialExpenseSerialNumber": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "baseECRCheckNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "expenseAccount": "string",
      "incomeAccount": "string",
      "markingList": [
        "string"
      ],
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)¦null|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|documentNumber|string¦null|false|none|hy-AM: Փաստաթղթի N | en-US: Document N | ru-RU: Номер док.|
|customer|string¦null|false|none|hy-AM: Գնորդ | en-US: Customer | ru-RU: Покупатель|
|currency|string¦null|false|none|hy-AM: Արժույթ | en-US: Currency | ru-RU: Валюта|
|currencyExchangeRate|number(double)|false|none|hy-AM: Արտարժույթի փոխարժեք | en-US: Currency exchange rate | ru-RU: Курс валюты|
|currencyExchangeBase|number(double)|false|none|hy-AM: Արտարժույթի փոխարժեք | en-US: Currency exchange rate | ru-RU: Курс валюты|
|state|integer(int32)|false|none|hy-AM: Վիճակ | en-US: State | ru-RU: Состояние|
|contract|string¦null|false|none|hy-AM: Պայմանագիր | en-US: Contract | ru-RU: Договор|
|contractDate|string(date)¦null|false|none|hy-AM: Պայմանագրի ամսաթիվը | en-US: Contract date | ru-RU: Дата договора|
|customerAccount|string¦null|false|none|hy-AM: Գնորդի հաշիվ | en-US: Customer account | ru-RU: Счет покупателя|
|receivedPrepaymentAccount|string¦null|false|none|hy-AM: Ստացված կանխավճարի հաշիվ | en-US: Received prepayment account | ru-RU: Счет авансов полученных|
|vatAccount|string¦null|false|none|none|
|environmentalFeeAccount|string¦null|false|none|hy-AM: Բնապահ. հարկի կրեդիտային հաշիվ | en-US: Environmental fees' credit account | ru-RU: Кредитовый счет эко. налога|
|analytic1|string¦null|false|none|hy-AM: Անալիտիկ խումբ 1 | en-US: Analytical dimension 1 | ru-RU: Аналитическая группа 1|
|analytic2|string¦null|false|none|hy-AM: Անալիտիկ խումբ 2 | en-US: Analytical dimension 2 | ru-RU: Аналитическая группа 2|
|bookNumber|string¦null|false|none|hy-AM: Առաքողի գրանցման գրքի N | en-US: Distributor entries book N | ru-RU: N книги регистрации отправителя|
|bookPage|integer(int32)|false|none|hy-AM: էջի N | en-US: page N | ru-RU: N страницы|
|bookLine|integer(int32)|false|none|hy-AM: Տողի N | en-US: line N | ru-RU: N строки|
|taxExportType|string¦null|false|none|hy-AM: Դուրս գրման եղանակ | en-US: Electronic/Paper | ru-RU: Метод выписки|
|taxInvoiceSeries|string¦null|false|none|hy-AM: Սերիա | en-US: Serial | ru-RU: Серия|
|taxInvoiceNumber|string¦null|false|none|hy-AM: Համար | en-US: Number | ru-RU: Номер|
|submissionDate|string(date)¦null|false|none|hy-AM: Դուրս գրման ամսաթիվ | en-US: Submission date | ru-RU: От|
|comment|string¦null|false|none|hy-AM: Մեկնաբանություն | en-US: Comment | ru-RU: Комментарий|
|vatCalculationType|string¦null|false|none|none|
|dealType|string¦null|false|none|hy-AM: Գործարքի տեսակ | en-US: Deal type | ru-RU: Тип сделки|
|storage|string¦null|false|none|hy-AM: Պահեստ | en-US: Storage | ru-RU: Склад|
|discountPercent|number(double)|false|none|hy-AM: Զեղչի տոկոս | en-US: Discount percent | ru-RU: Процент скидки|
|vatAmount|number(double)|false|none|none|
|totalAmount|number(double)|false|none|hy-AM: Ընդհանուր գումար | en-US: Total amount | ru-RU: Общая сумма|
|supplierBusinessAddress|string¦null|false|none|hy-AM: Գործ. հասցե | en-US: Bus. address | ru-RU: Фактический адрес|
|supplierSettlementAccount|string¦null|false|none|hy-AM: Հաշվարկային հաշիվ | en-US: Settlement account | ru-RU: Банковский счет|
|supplierManagerPosition|string¦null|false|none|hy-AM: Ղեկավարի պաշտոն | en-US: Manager position | ru-RU: Должность руководителя|
|supplierManagerName|string¦null|false|none|hy-AM: Ղեկավարի Ա.Ա.Հ. | en-US: Manager first name, last name | ru-RU: ФИО руководителя|
|supplierAccountantPosition|string¦null|false|none|hy-AM: Հաշվապահի պաշտոն | en-US: Accountant position | ru-RU: Должность главного бухгалтера|
|supplierAccountantName|string¦null|false|none|hy-AM: Հաշվապահի Ա.Ա.Հ. | en-US: Accountant first name, last name | ru-RU: ФИО главного бухгалтера|
|supplierAdditionalData|string¦null|false|none|hy-AM: Լրացուցիչ տվյալներ | en-US: Additional data | ru-RU: Дополнительная информация|
|customerName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|customerLegalAddress|string¦null|false|none|hy-AM: Իրավ. հասցե | en-US: Legal address | ru-RU: Юридический адрес|
|customerBusinessAddress|string¦null|false|none|hy-AM: Գործ. հասցե | en-US: Bus. address | ru-RU: Фактический адрес|
|customerSettlementAccount|string¦null|false|none|hy-AM: Հաշվարկային հաշիվ | en-US: Settlement account | ru-RU: Банковский счет|
|customerTaxCode|string¦null|false|none|hy-AM: ՀՎՀՀ | en-US: Taxpayer’s ID | ru-RU: ИНН код|
|customerManagerPosition|string¦null|false|none|hy-AM: Ղեկավարի պաշտոն | en-US: Manager position | ru-RU: Должность руководителя|
|customerManagerName|string¦null|false|none|hy-AM: Ղեկավարի Ա.Ա.Հ. | en-US: Manager first name, last name | ru-RU: ФИО руководителя|
|customerAccountantPosition|string¦null|false|none|hy-AM: Հաշվապահի պաշտոն | en-US: Accountant position | ru-RU: Должность главного бухгалтера|
|customerAccountantName|string¦null|false|none|hy-AM: Հաշվապահի Ա.Ա.Հ. | en-US: Accountant first name, last name | ru-RU: ФИО главного бухгалтера|
|stateRegisterNumber|string¦null|false|none|hy-AM: Ա/Ձ-ի պետ. գրանց. վկ. N | en-US: S/P state regist. N | ru-RU: Гос. рег. номер ИП|
|idDocumentType|string¦null|false|none|hy-AM: Անձը հաստատող փաստաթուղթ | en-US: Identification document | ru-RU: Документ, удостоверяющий личность|
|passportNumber|string¦null|false|none|hy-AM: Անձնագրի համար | en-US: Passport N | ru-RU: Номер паспорта|
|socialCardNumber|string¦null|false|none|hy-AM: Հանրային ծառայությունների համարանիշ | en-US: Social card number | ru-RU: Номер социальной карты|
|customerAdditionalData|string¦null|false|none|hy-AM: Լրացուցիչ տվյալներ | en-US: Additional data | ru-RU: Дополнительная информация|
|shippingMethod|string¦null|false|none|hy-AM: Ապր. առաքման եղանակը | en-US: Shipping method | ru-RU: Способ доставки товаров|
|citizenOfRA|boolean|false|none|hy-AM: Սոցիալական ծախս կատարած ՀՀ քաղաքացի | en-US: Citizen of RA, who carried made expenses | ru-RU: Гражданин РА, осуществивший социальные расходы|
|socialExpensesType|string¦null|false|none|hy-AM: Սոցիալական ծախսի տեսակ | en-US: Type of social expenses | ru-RU: Тип социальных расходов|
|socialExpenseSocialCard|string¦null|false|none|hy-AM: ՀԾՀ/ՀԾՀ չունենալու վերաբերյալ տեղեկանք | en-US: Soc. card/certificate of absence of soc. card | ru-RU: Соц. карта/свидетельство об отсутствии соц. карты|
|socialExpenseCitizenName|string¦null|false|none|hy-AM: Անուն, ազգանուն | en-US: First name, last name | ru-RU: Имя, фамилия|
|socialExpenseIdentityDocument|string¦null|false|none|hy-AM: Անձը հաստատող փաստաթուղթ | en-US: Identification document | ru-RU: Документ, удостоверяющий личность|
|socialExpenseSerialNumber|string¦null|false|none|hy-AM: Սերիա և/կամ համար | en-US: Series and/or number | ru-RU: Серия и/или номер|
|additionalFullName|string¦null|false|none|hy-AM: Ազգանուն, անուն, հայրանուն | en-US: Full name | ru-RU: Фамилия, имя, отчество|
|credentialNumber|string¦null|false|none|hy-AM: Լիազորագրի համար | en-US: Credential number | ru-RU: Номер доверенности|
|credentialDate|string(date)¦null|false|none|hy-AM: Լիազորագրի ամսաթիվ | en-US: Credential date | ru-RU: Дата доверенности|
|baseECRCheckNumber|string¦null|false|none|hy-AM: Հիմք ՀԴՄ կտրոնի համար | en-US: Base ECR check number | ru-RU: Основание для чека ККМ|
|itemList|[[InvoiceSpecificationRow](#schemainvoicespecificationrow)]¦null|false|none|hy-AM: Անվանացուցակ | en-US: Items list | ru-RU: Список товаров и услуг|

<h2 id="tocS_InvoiceDocumentsJournalDataRow">InvoiceDocumentsJournalDataRow</h2>
<!-- backwards compatibility -->
<a id="schemainvoicedocumentsjournaldatarow"></a>
<a id="schema_InvoiceDocumentsJournalDataRow"></a>
<a id="tocSinvoicedocumentsjournaldatarow"></a>
<a id="tocsinvoicedocumentsjournaldatarow"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "type": 0,
  "typeName": "string",
  "submissionDate": "2019-08-24",
  "taxSerialNumber": "string",
  "currency": "string",
  "amount": 0.1,
  "vatType": "string",
  "vatTypeName": "string",
  "state": 0,
  "stateName": "string",
  "partnerId": 0,
  "partnerCode": "string",
  "partnerName": "string",
  "partnerTaxCode": "string",
  "partnerStatus": "string",
  "comment": "string",
  "taxExportType": "string",
  "userName": "string",
  "lastChange": "2019-08-24T14:15:22Z"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|documentNumber|string¦null|false|none|hy-AM: Փաստաթղթի N | en-US: Document N | ru-RU: Номер док.|
|type|integer(int32)|false|none|hy-AM: Տեսակ | en-US: Type | ru-RU: Вид|
|typeName|string¦null|false|none|hy-AM: Տեսակ | en-US: Type | ru-RU: Вид|
|submissionDate|string(date)¦null|false|none|hy-AM: Դուրս գրման ամսաթիվ | en-US: Submission date | ru-RU: От|
|taxSerialNumber|string¦null|false|none|hy-AM: Սերիա և համար | en-US: Tax serial number | ru-RU: Серия и номер|
|currency|string¦null|false|none|hy-AM: Արժույթ | en-US: Currency | ru-RU: Валюта|
|amount|number(double)|false|none|hy-AM: Գումար | en-US: Amount | ru-RU: Сумма|
|vatType|string¦null|false|none|none|
|vatTypeName|string¦null|false|none|none|
|state|integer(int32)|false|none|hy-AM: Փաստաթղթի վիճակ | en-US: Document state | ru-RU: Статус документа|
|stateName|string¦null|false|none|hy-AM: Վիճակ | en-US: State | ru-RU: Состояние|
|partnerId|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|partnerCode|string¦null|false|none|hy-AM: Գործընկեր | en-US: Partner | ru-RU: Партнер|
|partnerName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|partnerTaxCode|string¦null|false|none|hy-AM: ՀՎՀՀ | en-US: Taxpayer’s ID | ru-RU: ИНН код|
|partnerStatus|string¦null|false|none|hy-AM: Կարգավիճակ | en-US: Status | ru-RU: Статус|
|comment|string¦null|false|none|hy-AM: Մեկնաբանություն | en-US: Comment | ru-RU: Комментарий|
|taxExportType|string¦null|false|none|hy-AM: Դուրս գրման եղանակ | en-US: Electronic/Paper | ru-RU: Метод выписки|
|userName|string¦null|false|none|hy-AM: Օգտագործող | en-US: User name | ru-RU: Пользователь|
|lastChange|string(date-time)|false|none|hy-AM: Վերջին խմբագրման ամսաթիվ | en-US: Last modification date | ru-RU: Дата последнего изменения|

<h2 id="tocS_InvoiceDocumentsJournalDataRowApiResponse">InvoiceDocumentsJournalDataRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemainvoicedocumentsjournaldatarowapiresponse"></a>
<a id="schema_InvoiceDocumentsJournalDataRowApiResponse"></a>
<a id="tocSinvoicedocumentsjournaldatarowapiresponse"></a>
<a id="tocsinvoicedocumentsjournaldatarowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "type": 0,
      "typeName": "string",
      "submissionDate": "2019-08-24",
      "taxSerialNumber": "string",
      "currency": "string",
      "amount": 0.1,
      "vatType": "string",
      "vatTypeName": "string",
      "state": 0,
      "stateName": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "partnerTaxCode": "string",
      "partnerStatus": "string",
      "comment": "string",
      "taxExportType": "string",
      "userName": "string",
      "lastChange": "2019-08-24T14:15:22Z"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[InvoiceDocumentsJournalDataRow](#schemainvoicedocumentsjournaldatarow)]¦null|false|none|none|

<h2 id="tocS_InvoiceDocumentsJournalParam">InvoiceDocumentsJournalParam</h2>
<!-- backwards compatibility -->
<a id="schemainvoicedocumentsjournalparam"></a>
<a id="schema_InvoiceDocumentsJournalParam"></a>
<a id="tocSinvoicedocumentsjournalparam"></a>
<a id="tocsinvoicedocumentsjournalparam"></a>

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "documentTypes": [
    "string"
  ],
  "currency": "string",
  "partner": "string",
  "showOutputAmountsAsNegatives": true,
  "documentState": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|hy-AM:  էջ  | en-US:  page | ru-RU: страница|
|startDate|string(date)|true|none|hy-AM: Ժամանակահատվածի սկիզբ | en-US: Period begin | ru-RU: Начало периода|
|endDate|string(date)|true|none|hy-AM: Ժամանակահատվածի վերջ | en-US: Period end | ru-RU: Конец периода|
|documentTypes|[string]¦null|false|none|hy-AM: Փաստաթղթի տեսակ | en-US: Document type | ru-RU: Вид документа|
|currency|string¦null|false|none|hy-AM: Արժույթ | en-US: Currency | ru-RU: Валюта|
|partner|string¦null|false|none|hy-AM: Գործընկեր | en-US: Partner | ru-RU: Партнер|
|showOutputAmountsAsNegatives|boolean|false|none|hy-AM: Ցույց տալ ելքերի գումարները բացասական | en-US: Show output amounts as negatives | ru-RU: Показывать суммы расходов негативными|
|documentState|string¦null|false|none|hy-AM: Վիճակ | en-US: State | ru-RU: Состояние|

<h2 id="tocS_InvoiceSpecificationRow">InvoiceSpecificationRow</h2>
<!-- backwards compatibility -->
<a id="schemainvoicespecificationrow"></a>
<a id="schema_InvoiceSpecificationRow"></a>
<a id="tocSinvoicespecificationrow"></a>
<a id="tocsinvoicespecificationrow"></a>

```json
{
  "type": "string",
  "storage": "string",
  "id": 0,
  "code": "string",
  "name": "string",
  "unitAbbreviation": "string",
  "quantity": 0.1,
  "price": 0.1,
  "discountPercent": 0.1,
  "discountedPrice": 0.1,
  "amount": 0.1,
  "environmentalFeePercent": 0.1,
  "environmentalFeeAmount": 0.1,
  "vat": true,
  "dealType": "string",
  "expenseAccount": "string",
  "incomeAccount": "string",
  "markingList": [
    "string"
  ],
  "cpaClassifier": "string",
  "rowNumber": 0,
  "rowId": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|string¦null|false|none|hy-AM: Տեսակ | en-US: Type | ru-RU: Вид|
|storage|string¦null|false|none|hy-AM: Պահեստ | en-US: Storage | ru-RU: Склад|
|id|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|unitAbbreviation|string¦null|false|none|hy-AM: Միավոր | en-US: Unit | ru-RU: Единица|
|quantity|number(double)|false|none|hy-AM: Քանակ | en-US: Quantity | ru-RU: Количество|
|price|number(double)|false|none|hy-AM: Գին | en-US: Price | ru-RU: Цена|
|discountPercent|number(double)¦null|false|none|hy-AM: Զեղչի տոկոս | en-US: Discount percent | ru-RU: Процент скидки|
|discountedPrice|number(double)¦null|false|none|hy-AM: Զեղչված գին | en-US: Discounted price | ru-RU: Цена со скидкой|
|amount|number(double)¦null|false|none|hy-AM: Գումար | en-US: Amount | ru-RU: Сумма|
|environmentalFeePercent|number(double)|false|none|hy-AM: Այդ թվում բն. հրկ. (%) | en-US: Env. fee (%) | ru-RU: Включая % эко. налога|
|environmentalFeeAmount|number(double)|false|none|hy-AM: Այդ թվում բն. հրկ. գումար | en-US: Env. fee amount | ru-RU: Включая сумму эко. налога|
|vat|boolean¦null|false|none|none|
|dealType|string¦null|false|none|hy-AM: Գործարքի տեսակ | en-US: Deal type | ru-RU: Тип сделки|
|expenseAccount|string¦null|false|none|hy-AM: Ծախսի հաշիվ | en-US: Expense account | ru-RU: Счет расходов|
|incomeAccount|string¦null|false|none|hy-AM: Հասույթի հաշիվ | en-US: Income account | ru-RU: Счет дохода|
|markingList|[string]¦null|false|none|hy-AM: Դրոշմավորում | en-US: Marking | ru-RU: Маркировка|
|cpaClassifier|string¦null|false|none|none|
|rowNumber|integer(int32)|false|none|hy-AM: Տողի N | en-US: line N | ru-RU: N строки|
|rowId|integer(int32)|false|none|hy-AM: Տողի ID | en-US: Line ID | ru-RU: ID линии|

<h2 id="tocS_Material">Material</h2>
<!-- backwards compatibility -->
<a id="schemamaterial"></a>
<a id="schema_Material"></a>
<a id="tocSmaterial"></a>
<a id="tocsmaterial"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "group": "string",
  "cpaClassifier": "string",
  "account": "string",
  "wholePrice": 0.1,
  "retailPrice": 0.1,
  "currency": "string",
  "currencyPrice": 0.1,
  "specification": "string",
  "barcode": "string",
  "externalCode": "string",
  "costingMethod": "string",
  "aoeCoefficient": 0.1,
  "discountPercent": 0.1,
  "environmentalFeePercent": 0.1,
  "minimumQuantity": 0.1,
  "maximumQuantity": 0.1,
  "vat": true,
  "revenueAccount": "string",
  "retailRevenueAccount": "string",
  "expenseAccount": "string",
  "revenueAdjustmentAccount": "string",
  "isClosed": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|fullName|string¦null|false|none|hy-AM: Լրիվ անվանում | en-US: Full name | ru-RU: Полное наименование|
|unitMeasure|string¦null|false|none|hy-AM: Չափման միավոր | en-US: Unit of measure | ru-RU: Единица измерения|
|unitMeasureName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|unitMeasureAbbreviation|string¦null|false|none|hy-AM: Չափման միավոր | en-US: Unit of measure | ru-RU: Единица измерения|
|group|string¦null|false|none|hy-AM: Խումբ | en-US: Group | ru-RU: Группа|
|cpaClassifier|string¦null|false|none|none|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|wholePrice|number(double)¦null|false|none|hy-AM: Մեծածախ գին դրամով | en-US: Whole price in drams | ru-RU: Оптовая цена в драмах|
|retailPrice|number(double)¦null|false|none|hy-AM: Մանրածախ գին դրամով | en-US: Retail price in drams | ru-RU: Розничная цена в драмах|
|currency|string¦null|false|none|hy-AM: Արտարժույթ | en-US: Currency | ru-RU: Валюта|
|currencyPrice|number(double)¦null|false|none|hy-AM: Մեծածախ գին արտարժութային | en-US: Whole price in currency | ru-RU: Оптовая цена в валюте|
|specification|string¦null|false|none|hy-AM: Բնութագիր | en-US: Specification | ru-RU: Характеристика|
|barcode|string¦null|false|none|hy-AM: Գծիկավոր կոդ | en-US: Barcode | ru-RU: Штрихкод|
|externalCode|string¦null|false|none|hy-AM: Արտաքին կոդ | en-US: External code | ru-RU: Внешний код|
|costingMethod|string¦null|false|none|hy-AM: Հաշվառման մեթոդ | en-US: Costing  method | ru-RU: Метод списания|
|aoeCoefficient|number(double)¦null|false|none|none|
|discountPercent|number(double)¦null|false|none|hy-AM: Զեղչ | en-US: Discount | ru-RU: Скидка|
|environmentalFeePercent|number(double)¦null|false|none|hy-AM: Բնապահպանական հարկի % | en-US: Environmental fee (%) | ru-RU: % экологического налога|
|minimumQuantity|number(double)¦null|false|none|hy-AM: Նվազագույն քանակ (min) | en-US: Minimum quantity | ru-RU: Минимальное количество (min)|
|maximumQuantity|number(double)¦null|false|none|hy-AM: Առավելագույն քանակ (max) | en-US: Maximal quantity (max) | ru-RU: Максимальное количество (max)|
|vat|boolean¦null|false|none|none|
|revenueAccount|string¦null|false|none|hy-AM: Վաճառքից հասույթի հաշիվ | en-US: Revenue account | ru-RU: Счет доходов при опт. продаже|
|retailRevenueAccount|string¦null|false|none|hy-AM: Մանրածախ վաճառքից հասույթի հաշիվ | en-US: Retail revenue account | ru-RU: Счет доходов при розничной продаже|
|expenseAccount|string¦null|false|none|hy-AM: Վաճառքից ծախսի հաշիվ | en-US: Expense account | ru-RU: Счет расходов при опт. продаже|
|revenueAdjustmentAccount|string¦null|false|none|hy-AM: ՆԱ վաճառքից վերադարձի հասույթի ճշգրտում | en-US: Adjustment of income from materials sales returns | ru-RU: Корректировка выручки реализации при возврате ТМЦ|
|isClosed|boolean¦null|false|none|hy-AM: Փակված | en-US: Closed | ru-RU: Закрыто|

<h2 id="tocS_MaterialFilters">MaterialFilters</h2>
<!-- backwards compatibility -->
<a id="schemamaterialfilters"></a>
<a id="schema_MaterialFilters"></a>
<a id="tocSmaterialfilters"></a>
<a id="tocsmaterialfilters"></a>

```json
{
  "pageSize": 0,
  "codes": [
    "string"
  ],
  "lastModifiedDate": "2019-08-24T14:15:22Z",
  "group": "string",
  "showAlsoClosed": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|hy-AM:  էջ  | en-US:  page | ru-RU: страница|
|codes|[string]¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|lastModifiedDate|string(date-time)¦null|false|none|hy-AM: Վերջին խմբագրման ամսաթիվ | en-US: Last modification date | ru-RU: Дата последнего изменения|
|group|string¦null|false|none|hy-AM: Խումբ | en-US: Group | ru-RU: Группа|
|showAlsoClosed|boolean|false|none|hy-AM: Ցույց տալ նաև փակվածները | en-US: Show also closed | ru-RU: Показать также закрытые|

<h2 id="tocS_MaterialRow">MaterialRow</h2>
<!-- backwards compatibility -->
<a id="schemamaterialrow"></a>
<a id="schema_MaterialRow"></a>
<a id="tocSmaterialrow"></a>
<a id="tocsmaterialrow"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unitMeasure": "string",
  "unitMeasureAbbreviation": "string",
  "group": "string",
  "cpaClassifier": "string",
  "account": "string",
  "wholePrice": 0.1,
  "retailPrice": 0.1,
  "specification": "string",
  "barcode": "string",
  "externalCode": "string",
  "costingMethod": "string",
  "aoeCoefficient": 0.1,
  "discountPercent": 0.1,
  "environmentalFeePercent": 0.1,
  "minimumQuantity": 0.1,
  "maximumQuantity": 0.1,
  "vat": true,
  "revenueAccount": "string",
  "retailRevenueAccount": "string",
  "expenseAccount": "string",
  "revenueAdjustmentAccount": "string",
  "lastModifierName": "string",
  "lastModifyDate": "2019-08-24T14:15:22Z",
  "isClosed": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|fullName|string¦null|false|none|hy-AM: Լրիվ անվանում | en-US: Full name | ru-RU: Полное наименование|
|unitMeasure|string¦null|false|none|hy-AM: Չափման միավոր | en-US: Unit of measure | ru-RU: Единица измерения|
|unitMeasureAbbreviation|string¦null|false|none|hy-AM: Չափման միավոր | en-US: Unit of measure | ru-RU: Единица измерения|
|group|string¦null|false|none|hy-AM: Խումբ | en-US: Group | ru-RU: Группа|
|cpaClassifier|string¦null|false|none|none|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|wholePrice|number(double)|false|none|hy-AM: Մեծածախ գին դրամով | en-US: Whole price in drams | ru-RU: Оптовая цена в драмах|
|retailPrice|number(double)|false|none|hy-AM: Մանրածախ գին դրամով | en-US: Retail price in drams | ru-RU: Розничная цена в драмах|
|specification|string¦null|false|none|hy-AM: Բնութագիր | en-US: Specification | ru-RU: Характеристика|
|barcode|string¦null|false|none|hy-AM: Գծիկավոր կոդ | en-US: Barcode | ru-RU: Штрихкод|
|externalCode|string¦null|false|none|hy-AM: Արտաքին կոդ | en-US: External code | ru-RU: Внешний код|
|costingMethod|string¦null|false|none|hy-AM: Հաշվառման մեթոդ | en-US: Costing  method | ru-RU: Метод списания|
|aoeCoefficient|number(double)|false|none|none|
|discountPercent|number(double)|false|none|hy-AM: Զեղչ | en-US: Discount | ru-RU: Скидка|
|environmentalFeePercent|number(double)|false|none|hy-AM: Բնապահպանական հարկի % | en-US: Environmental fee (%) | ru-RU: % экологического налога|
|minimumQuantity|number(double)|false|none|hy-AM: Նվազագույն քանակ (min) | en-US: Minimum quantity | ru-RU: Минимальное количество (min)|
|maximumQuantity|number(double)|false|none|hy-AM: Առավելագույն քանակ (max) | en-US: Maximal quantity (max) | ru-RU: Максимальное количество (max)|
|vat|boolean|false|none|none|
|revenueAccount|string¦null|false|none|hy-AM: Վաճառքից հասույթի հաշիվ | en-US: Revenue account | ru-RU: Счет доходов при опт. продаже|
|retailRevenueAccount|string¦null|false|none|hy-AM: Մանրածախ վաճառքից հասույթի հաշիվ | en-US: Retail revenue account | ru-RU: Счет доходов при розничной продаже|
|expenseAccount|string¦null|false|none|hy-AM: Վաճառքից ծախսի հաշիվ | en-US: Expense account | ru-RU: Счет расходов при опт. продаже|
|revenueAdjustmentAccount|string¦null|false|none|hy-AM: ՆԱ վաճառքից վերադարձի հասույթի ճշգրտում | en-US: Adjustment of income from materials sales returns | ru-RU: Корректировка выручки реализации при возврате ТМЦ|
|lastModifierName|string¦null|false|none|hy-AM: Օգտագործող | en-US: User name | ru-RU: Пользователь|
|lastModifyDate|string(date-time)¦null|false|none|hy-AM: Վերջին փոփոխություն | en-US: Last change | ru-RU: Последнее изменение|
|isClosed|boolean|false|none|hy-AM: Փակված | en-US: Closed | ru-RU: Закрыто|

<h2 id="tocS_MaterialRowApiResponse">MaterialRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemamaterialrowapiresponse"></a>
<a id="schema_MaterialRowApiResponse"></a>
<a id="tocSmaterialrowapiresponse"></a>
<a id="tocsmaterialrowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "group": "string",
      "cpaClassifier": "string",
      "account": "string",
      "wholePrice": 0.1,
      "retailPrice": 0.1,
      "specification": "string",
      "barcode": "string",
      "externalCode": "string",
      "costingMethod": "string",
      "aoeCoefficient": 0.1,
      "discountPercent": 0.1,
      "environmentalFeePercent": 0.1,
      "minimumQuantity": 0.1,
      "maximumQuantity": 0.1,
      "vat": true,
      "revenueAccount": "string",
      "retailRevenueAccount": "string",
      "expenseAccount": "string",
      "revenueAdjustmentAccount": "string",
      "lastModifierName": "string",
      "lastModifyDate": "2019-08-24T14:15:22Z",
      "isClosed": true
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[MaterialRow](#schemamaterialrow)]¦null|false|none|none|

<h2 id="tocS_MaterialsBalancesDataRow">MaterialsBalancesDataRow</h2>
<!-- backwards compatibility -->
<a id="schemamaterialsbalancesdatarow"></a>
<a id="schema_MaterialsBalancesDataRow"></a>
<a id="tocSmaterialsbalancesdatarow"></a>
<a id="tocsmaterialsbalancesdatarow"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "unitMeasure": "string",
  "unitMeasureAbbreviation": "string",
  "storage": "string",
  "storageName": "string",
  "quantity": 0.1,
  "cost": 0.1,
  "costAmount": 0.1,
  "unitVAT": 0.1,
  "vatAmount": 0.1,
  "group": "string",
  "groupName": "string",
  "account": "string",
  "salePrice": 0.1,
  "saleAmount": 0.1,
  "retailPrice": 0.1,
  "retailAmount": 0.1,
  "currency": "string",
  "currencyPrice": 0.1,
  "currencyAmount": 0.1,
  "minimumQuantity": 0.1,
  "variance": 0.1,
  "maximumQuantity": 0.1,
  "orderQuantity": 0.1,
  "orderComment": "string",
  "incomeDate": "2019-08-24",
  "partySupplierId": 0,
  "partySupplierCode": "string",
  "partySupplierName": "string",
  "partySupplierTaxCode": "string",
  "purchasingPrice": 0.1,
  "purchasingPriceWithoutVAT": 0.1,
  "partyDocumentType": "string",
  "partyDocumentNumber": "string",
  "partyBase": "c39df95f-1f9b-4de1-8155-0f24e1c3b455",
  "partyRow": 0,
  "costingMethod": "string",
  "specification": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|unitMeasure|string¦null|false|none|hy-AM: Չափման միավոր | en-US: Unit of measure | ru-RU: Единица измерения|
|unitMeasureAbbreviation|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|storage|string¦null|false|none|hy-AM: Պահեստ | en-US: Storage | ru-RU: Склад|
|storageName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|quantity|number(double)|false|none|hy-AM: Մնացորդ | en-US: Balance | ru-RU: Остаток|
|cost|number(double)|false|none|hy-AM: Գին դրամով | en-US: Price in drams | ru-RU: Цена в драмах|
|costAmount|number(double)|false|none|hy-AM: Գումար | en-US: Amount | ru-RU: Сумма|
|unitVAT|number(double)|false|none|hy-AM: Միավորի ԱԱՀ | en-US: Unit VAT | ru-RU: НДС единицы|
|vatAmount|number(double)|false|none|none|
|group|string¦null|false|none|hy-AM: Խումբ | en-US: Group | ru-RU: Группа|
|groupName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|salePrice|number(double)|false|none|hy-AM: Վաճառքի գին | en-US: Sale price | ru-RU: Цена продажи|
|saleAmount|number(double)|false|none|hy-AM: Վաճառքի գումար | en-US: Sale amount | ru-RU: Сумма продажи|
|retailPrice|number(double)|false|none|hy-AM: Մանրածախ վաճառքի գին | en-US: Retail price | ru-RU: Розничная цена|
|retailAmount|number(double)|false|none|hy-AM: Մանրածախ վաճառքի գումար | en-US: Retail amount | ru-RU: Розничная цена|
|currency|string¦null|false|none|hy-AM: Արժույթ | en-US: Currency | ru-RU: Валюта|
|currencyPrice|number(double)|false|none|hy-AM: Վաճառքի գին արժ. | en-US: Sale price in curr. | ru-RU: Цена продажи вал.|
|currencyAmount|number(double)|false|none|hy-AM: Վաճառքի գումար արժ. | en-US: Sale amount in curr. | ru-RU: Сумма продажи вал.|
|minimumQuantity|number(double)|false|none|hy-AM: Նվազագույն քանակ (min) | en-US: Minimum quantity | ru-RU: Минимальное количество (min)|
|variance|number(double)|false|none|hy-AM: Շեղում | en-US: Variance | ru-RU: Отклонение|
|maximumQuantity|number(double)|false|none|hy-AM: Առավելագույն քանակ (max) | en-US: Maximal quantity (max) | ru-RU: Максимальное количество (max)|
|orderQuantity|number(double)|false|none|hy-AM: Պատվիրման քանակ | en-US: Order quantity | ru-RU: Количество заказа|
|orderComment|string¦null|false|none|hy-AM: Մեկնաբանություն | en-US: Comment | ru-RU: Комментарий|
|incomeDate|string(date)¦null|false|none|hy-AM: Մուտքի ա/թ | en-US: Income date | ru-RU: Дата прихода|
|partySupplierId|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|partySupplierCode|string¦null|false|none|hy-AM: Մատակարար | en-US: Supplier | ru-RU: Поставщик|
|partySupplierName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|partySupplierTaxCode|string¦null|false|none|hy-AM: Մատակարարի ՀՎՀՀ | en-US: Supplier tax code | ru-RU: ИНН код поставщика|
|purchasingPrice|number(double)|false|none|hy-AM: Ձեռքբերման գին | en-US: Purchasing price | ru-RU: Цена покупки|
|purchasingPriceWithoutVAT|number(double)|false|none|hy-AM: Ձեռքբերման գին | en-US: Purchasing price | ru-RU: Цена покупки|
|partyDocumentType|string¦null|false|none|hy-AM: Փաստաթղթի տեսակ | en-US: Document type | ru-RU: Вид документа|
|partyDocumentNumber|string¦null|false|none|hy-AM: Փաստաթղթի N | en-US: Document N | ru-RU: Номер док.|
|partyBase|string(uuid)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|partyRow|integer(int32)|false|none|hy-AM: Տողի N | en-US: line N | ru-RU: N строки|
|costingMethod|string¦null|false|none|hy-AM: Հաշվառման մեթոդ | en-US: Costing  method | ru-RU: Метод списания|
|specification|string¦null|false|none|hy-AM: Բնութագիր | en-US: Specification | ru-RU: Характеристика|

<h2 id="tocS_MaterialsBalancesDataRowApiResponse">MaterialsBalancesDataRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemamaterialsbalancesdatarowapiresponse"></a>
<a id="schema_MaterialsBalancesDataRowApiResponse"></a>
<a id="tocSmaterialsbalancesdatarowapiresponse"></a>
<a id="tocsmaterialsbalancesdatarowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "storage": "string",
      "storageName": "string",
      "quantity": 0.1,
      "cost": 0.1,
      "costAmount": 0.1,
      "unitVAT": 0.1,
      "vatAmount": 0.1,
      "group": "string",
      "groupName": "string",
      "account": "string",
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "retailPrice": 0.1,
      "retailAmount": 0.1,
      "currency": "string",
      "currencyPrice": 0.1,
      "currencyAmount": 0.1,
      "minimumQuantity": 0.1,
      "variance": 0.1,
      "maximumQuantity": 0.1,
      "orderQuantity": 0.1,
      "orderComment": "string",
      "incomeDate": "2019-08-24",
      "partySupplierId": 0,
      "partySupplierCode": "string",
      "partySupplierName": "string",
      "partySupplierTaxCode": "string",
      "purchasingPrice": 0.1,
      "purchasingPriceWithoutVAT": 0.1,
      "partyDocumentType": "string",
      "partyDocumentNumber": "string",
      "partyBase": "c39df95f-1f9b-4de1-8155-0f24e1c3b455",
      "partyRow": 0,
      "costingMethod": "string",
      "specification": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[MaterialsBalancesDataRow](#schemamaterialsbalancesdatarow)]¦null|false|none|none|

<h2 id="tocS_MaterialsBalancesParam">MaterialsBalancesParam</h2>
<!-- backwards compatibility -->
<a id="schemamaterialsbalancesparam"></a>
<a id="schema_MaterialsBalancesParam"></a>
<a id="tocSmaterialsbalancesparam"></a>
<a id="tocsmaterialsbalancesparam"></a>

```json
{
  "pageSize": 0,
  "date": "2019-08-24",
  "storage": "string",
  "group": "string",
  "material": "string",
  "showByDifferentAccounts": true,
  "account": "string",
  "showByDifferentParties": true,
  "minimumQuantities": "string",
  "salePrices": [
    "string"
  ],
  "currency": "string",
  "showZeroRows": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|hy-AM:  էջ  | en-US:  page | ru-RU: страница|
|date|string(date)|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|storage|string¦null|false|none|hy-AM: Պահեստ | en-US: Storage | ru-RU: Склад|
|group|string¦null|false|none|hy-AM: Նյութական արժեքների խումբ | en-US: Materials group | ru-RU: Группа ТМЦ|
|material|string¦null|false|none|hy-AM: Նյութական արժեք | en-US: Material | ru-RU: Товарно-материальная ценность|
|showByDifferentAccounts|boolean|false|none|hy-AM: Ըստ տարբեր հաշիվների | en-US: By different accounts | ru-RU: Детализировать по счетам|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|showByDifferentParties|boolean|false|none|hy-AM: Ըստ տարբեր խմբաքանակների | en-US: By different batches | ru-RU: Детализировать по партиям|
|minimumQuantities|string¦null|false|none|hy-AM: Նվազագույն քանակներ | en-US: Minimum quantities | ru-RU: Минимальные количества|
|salePrices|[string]¦null|false|none|hy-AM: Ցույց տալ վաճառքի գինը | en-US: Show sale price | ru-RU: Показать цена продажи|
|currency|string¦null|false|none|hy-AM: Արտարժույթ | en-US: Currency | ru-RU: Валюта|
|showZeroRows|boolean|false|none|hy-AM: Ցույց տալ զրոյական տողերը | en-US: Show zero rows | ru-RU: Показать нулевые строки|

<h2 id="tocS_MaterialsKitting">MaterialsKitting</h2>
<!-- backwards compatibility -->
<a id="schemamaterialskitting"></a>
<a id="schema_MaterialsKitting"></a>
<a id="tocSmaterialskitting"></a>
<a id="tocsmaterialskitting"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "kit": "string",
  "quantity": 0.1,
  "account": "string",
  "transitAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "kitComponents": [
    {
      "id": 0,
      "type": "string",
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "account": "string",
      "rowId": 0
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)¦null|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|documentNumber|string¦null|false|none|hy-AM: Փաստաթղթի N | en-US: Document N | ru-RU: Номер док.|
|state|integer(int32)|false|none|hy-AM: Վիճակ | en-US: State | ru-RU: Состояние|
|storageOutput|string¦null|false|none|hy-AM: Պահեստ ելքի | en-US: Storage output | ru-RU: Из склада|
|storageInput|string¦null|false|none|hy-AM: Պահեստ մուտքի | en-US: Storage input | ru-RU: В склад|
|kit|string¦null|false|none|hy-AM: Կոմպլեկտ | en-US: Kit | ru-RU: Комплект|
|quantity|number(double)|false|none|hy-AM: Քանակ | en-US: Quantity | ru-RU: Количество|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|transitAccount|string¦null|false|none|hy-AM: Տարանցիկ հաշիվ | en-US: Transit account | ru-RU: Транзитный счет|
|analytic1|string¦null|false|none|hy-AM: Անալիտիկ խումբ 1 | en-US: Analytical dimension 1 | ru-RU: Аналитическая группа 1|
|analytic2|string¦null|false|none|hy-AM: Անալիտիկ խումբ 2 | en-US: Analytical dimension 2 | ru-RU: Аналитическая группа 2|
|comment|string¦null|false|none|hy-AM: Մեկնաբանություն | en-US: Comment | ru-RU: Комментарий|
|kitComponents|[[MaterialsKittingSpecificationRow](#schemamaterialskittingspecificationrow)]¦null|false|none|hy-AM: Կոմպլեկտների բաղադրամասեր | en-US: Kit's components | ru-RU: Комплектующие|

<h2 id="tocS_MaterialsKittingSpecificationRow">MaterialsKittingSpecificationRow</h2>
<!-- backwards compatibility -->
<a id="schemamaterialskittingspecificationrow"></a>
<a id="schema_MaterialsKittingSpecificationRow"></a>
<a id="tocSmaterialskittingspecificationrow"></a>
<a id="tocsmaterialskittingspecificationrow"></a>

```json
{
  "id": 0,
  "type": "string",
  "code": "string",
  "name": "string",
  "unitAbbreviation": "string",
  "quantity": 0.1,
  "amount": 0.1,
  "account": "string",
  "rowId": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|type|string¦null|false|none|hy-AM: Տեսակ | en-US: Type | ru-RU: Вид|
|code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|unitAbbreviation|string¦null|false|none|hy-AM: Միավոր | en-US: Unit | ru-RU: Единица|
|quantity|number(double)|false|none|hy-AM: Քանակ | en-US: Quantity | ru-RU: Количество|
|amount|number(double)|false|none|hy-AM: Գումար | en-US: Amount | ru-RU: Сумма|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|rowId|integer(int32)|false|none|hy-AM: Տողի ID | en-US: Line ID | ru-RU: ID линии|

<h2 id="tocS_MaterialsMovement">MaterialsMovement</h2>
<!-- backwards compatibility -->
<a id="schemamaterialsmovement"></a>
<a id="schema_MaterialsMovement"></a>
<a id="tocSmaterialsmovement"></a>
<a id="tocsmaterialsmovement"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "printSalePriceType": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "chiefAccountant": "string",
  "mediator": "string",
  "allowed": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "transportationMethod": "string",
  "vehicle": true,
  "brand": "string",
  "licensePlate": "string",
  "contract": "string",
  "contractDate": "2019-08-24",
  "additionalData": "string",
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "account": "string",
      "rowId": 0
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)¦null|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|documentNumber|string¦null|false|none|hy-AM: Փաստաթղթի N | en-US: Document N | ru-RU: Номер док.|
|state|integer(int32)|false|none|hy-AM: Վիճակ | en-US: State | ru-RU: Состояние|
|storageOutput|string¦null|false|none|hy-AM: Պահեստ ելքի | en-US: Storage output | ru-RU: Из склада|
|storageInput|string¦null|false|none|hy-AM: Պահեստ մուտքի | en-US: Storage input | ru-RU: В склад|
|printSalePriceType|string¦null|false|none|hy-AM: Տպել վաճառքի գներով | en-US: Print the sale prices | ru-RU: Печатать по продажным ценам|
|analytic1|string¦null|false|none|hy-AM: Անալիտիկ խումբ 1 | en-US: Analytical dimension 1 | ru-RU: Аналитическая группа 1|
|analytic2|string¦null|false|none|hy-AM: Անալիտիկ խումբ 2 | en-US: Analytical dimension 2 | ru-RU: Аналитическая группа 2|
|comment|string¦null|false|none|hy-AM: Մեկնաբանություն | en-US: Comment | ru-RU: Комментарий|
|chiefAccountant|string¦null|false|none|hy-AM: Գլխավոր հաշվապահ | en-US: Chief accountant | ru-RU: Главный бухгалтер|
|mediator|string¦null|false|none|hy-AM: Միջնորդ | en-US: Mediator | ru-RU: Посредник|
|allowed|string¦null|false|none|hy-AM: Թույլատրեց | en-US: Allowed | ru-RU: Разрешил|
|bookNumber|string¦null|false|none|hy-AM: Առաքողի գրանցման գրքի N | en-US: Distributor entries book N | ru-RU: N книги регистрации отправителя|
|bookPage|integer(int32)|false|none|hy-AM: էջի N | en-US: page N | ru-RU: N страницы|
|bookLine|integer(int32)|false|none|hy-AM: Տողի N | en-US: line N | ru-RU: N строки|
|taxExportType|string¦null|false|none|hy-AM: Դուրս գրման եղանակ | en-US: Electronic/Paper | ru-RU: Метод выписки|
|taxInvoiceSeries|string¦null|false|none|hy-AM: Սերիա | en-US: Serial | ru-RU: Серия|
|taxInvoiceNumber|string¦null|false|none|hy-AM: Համար | en-US: Number | ru-RU: Номер|
|submissionDate|string(date)¦null|false|none|hy-AM: Դուրս գրման ամսաթիվ | en-US: Submission date | ru-RU: От|
|transportationMethod|string¦null|false|none|hy-AM: Տեղափոխման եղանակ | en-US: Transportation method | ru-RU: Метод переноса|
|vehicle|boolean|false|none|hy-AM: Ավտոտրանսպորտային միջոց | en-US: Vehicle | ru-RU: Транспортное средство|
|brand|string¦null|false|none|hy-AM: Մակնիշ | en-US: Brand | ru-RU: Марка|
|licensePlate|string¦null|false|none|hy-AM: Պետհամարանիշ | en-US: License plate | ru-RU: Гос номер|
|contract|string¦null|false|none|hy-AM: Պայմանագիր | en-US: Contract | ru-RU: Договор|
|contractDate|string(date)¦null|false|none|hy-AM: Պայմանագրի ամսաթիվը | en-US: Contract date | ru-RU: Дата договора|
|additionalData|string¦null|false|none|hy-AM: Լրացուցիչ տվյալներ | en-US: Additional data | ru-RU: Дополнительная информация|
|materialsList|[[MaterialsMovementSpecificationRow](#schemamaterialsmovementspecificationrow)]¦null|false|none|hy-AM: Նյութական արժեքների ցուցակ | en-US: Materials list | ru-RU: Список ТМЦ|

<h2 id="tocS_MaterialsMovementSpecificationRow">MaterialsMovementSpecificationRow</h2>
<!-- backwards compatibility -->
<a id="schemamaterialsmovementspecificationrow"></a>
<a id="schema_MaterialsMovementSpecificationRow"></a>
<a id="tocSmaterialsmovementspecificationrow"></a>
<a id="tocsmaterialsmovementspecificationrow"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "unitAbbreviation": "string",
  "quantity": 0.1,
  "amount": 0.1,
  "account": "string",
  "rowId": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|unitAbbreviation|string¦null|false|none|hy-AM: Միավոր | en-US: Unit | ru-RU: Единица|
|quantity|number(double)|false|none|hy-AM: Քանակ | en-US: Quantity | ru-RU: Количество|
|amount|number(double)|false|none|hy-AM: Գումար | en-US: Amount | ru-RU: Сумма|
|account|string¦null|false|none|hy-AM: Հաշիվ մուտքի | en-US: Account of input | ru-RU: Счет поступлений|
|rowId|integer(int32)|false|none|hy-AM: Տողի ID | en-US: Line ID | ru-RU: ID линии|

<h2 id="tocS_MaterialsOperationsDataRow">MaterialsOperationsDataRow</h2>
<!-- backwards compatibility -->
<a id="schemamaterialsoperationsdatarow"></a>
<a id="schema_MaterialsOperationsDataRow"></a>
<a id="tocSmaterialsoperationsdatarow"></a>
<a id="tocsmaterialsoperationsdatarow"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "documentType": 0,
  "operationType": "string",
  "operationName": "string",
  "inputOutput": "string",
  "storage": "string",
  "storageName": "string",
  "materialId": 0,
  "materialCode": "string",
  "materialName": "string",
  "unitMeasure": "string",
  "unitMeasureAbbreviation": "string",
  "account": "string",
  "correspondingObject": "string",
  "correspondingObjectName": "string",
  "analytic1": "string",
  "analytic2": "string",
  "cost": 0.1,
  "quantity": 0.1,
  "costAmount": 0.1,
  "costVATAmount": 0.1,
  "unitVAT": 0.1,
  "currency": "string",
  "currencyCost": 0.1,
  "salePrice": 0.1,
  "saleAmount": 0.1,
  "saleVATPrice": 0.1,
  "saleVATAmount": 0.1,
  "salePriceCurrency": 0.1,
  "saleAmountCurrency": 0.1,
  "comment": "string",
  "group": "string",
  "groupName": "string",
  "specification": "string",
  "cpaClassifier": "string",
  "barcode": "string",
  "vat": true,
  "fullName": "string",
  "incomeDate": "2019-08-24",
  "partySupplierId": 0,
  "partySupplierCode": "string",
  "partySupplierName": "string",
  "partyDocumentNumber": "string",
  "partyDocumentType": 0,
  "partyDocumentTypeName": "string",
  "partyPurchasingPrice": 0.1,
  "partyPurchasingPriceWithoutVAT": 0.1
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|documentNumber|string¦null|false|none|hy-AM: Փաստաթղթի N | en-US: Document N | ru-RU: Номер док.|
|documentType|integer(int32)|false|none|hy-AM: Փաստաթղթի տեսակ | en-US: Document type | ru-RU: Вид документа|
|operationType|string¦null|false|none|hy-AM: Գործողության տեսակ | en-US: Operation type | ru-RU: Вид операции|
|operationName|string¦null|false|none|hy-AM: Գործողության տեսակ | en-US: Operation type | ru-RU: Вид операции|
|inputOutput|string¦null|false|none|hy-AM: Մուտք\ելք | en-US: Input\output | ru-RU: Приход\расход|
|storage|string¦null|false|none|hy-AM: Պահեստ | en-US: Storage | ru-RU: Склад|
|storageName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|materialId|integer(int32)|false|none|none|
|materialCode|string¦null|false|none|hy-AM: Նյութական արժեք | en-US: Material | ru-RU: Товарно-материальная ценность|
|materialName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|unitMeasure|string¦null|false|none|hy-AM: Միավոր | en-US: Unit | ru-RU: Единица|
|unitMeasureAbbreviation|string¦null|false|none|hy-AM: Չափման միավոր | en-US: Unit of measure | ru-RU: Единица измерения|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|correspondingObject|string¦null|false|none|hy-AM: Թղթակից օբյեկտ | en-US: Corresponding object | ru-RU: Корр. объект|
|correspondingObjectName|string¦null|false|none|hy-AM: Թղթակից օբյեկտի անվանում | en-US: Corresponding object name | ru-RU: Наименование корр. объекта|
|analytic1|string¦null|false|none|hy-AM: Ան.խումբ 1 | en-US: An. dimension 1 | ru-RU: Ан.группа 1|
|analytic2|string¦null|false|none|hy-AM: Ան.խումբ 2 | en-US: An. dimension 2 | ru-RU: Ан.группа 2|
|cost|number(double)|false|none|hy-AM: Գին դրամով | en-US: Price in drams | ru-RU: Цена в драмах|
|quantity|number(double)|false|none|hy-AM: Քանակ | en-US: Quantity | ru-RU: Количество|
|costAmount|number(double)|false|none|hy-AM: Ինքնարժեքի գումար | en-US: Prime cost amount | ru-RU: Сумма себестоимости|
|costVATAmount|number(double)|false|none|hy-AM: Ինքնարժեքի գումարի ԱԱՀ | en-US: VAT of cost’s amount | ru-RU: НДС себестоимости|
|unitVAT|number(double)|false|none|hy-AM: Միավորի ԱԱՀ | en-US: Unit VAT | ru-RU: НДС единицы|
|currency|string¦null|false|none|hy-AM: Արժույթ | en-US: Currency | ru-RU: Валюта|
|currencyCost|number(double)|false|none|hy-AM: Մուտքի գին արտ. | en-US: Input price in curr. | ru-RU: Цена поступления вал.|
|salePrice|number(double)|false|none|hy-AM: Վաճառքի գին | en-US: Sale price | ru-RU: Цена продажи|
|saleAmount|number(double)|false|none|hy-AM: Վաճառքի գումար | en-US: Sale amount | ru-RU: Сумма продажи|
|saleVATPrice|number(double)|false|none|hy-AM: Վաճառքի գնի ԱԱՀ | en-US: Sales price VAT | ru-RU: НДС продажной цены|
|saleVATAmount|number(double)|false|none|hy-AM: Վաճառքի գումարի ԱԱՀ | en-US: VAT of sale’s amount | ru-RU: Сумма НДС при продаже|
|salePriceCurrency|number(double)|false|none|hy-AM: Վաճառքի գին արժ. | en-US: Sale price in curr. | ru-RU: Цена продажи вал.|
|saleAmountCurrency|number(double)|false|none|hy-AM: Վաճառքի գումար արժ. | en-US: Sale amount in curr. | ru-RU: Сумма продажи вал.|
|comment|string¦null|false|none|hy-AM: Մեկնաբանություն | en-US: Comment | ru-RU: Комментарий|
|group|string¦null|false|none|hy-AM: Խումբ | en-US: Group | ru-RU: Группа|
|groupName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|specification|string¦null|false|none|hy-AM: Բնութագիր | en-US: Specification | ru-RU: Характеристика|
|cpaClassifier|string¦null|false|none|none|
|barcode|string¦null|false|none|hy-AM: Գծիկավոր կոդ | en-US: Barcode | ru-RU: Штрихкод|
|vat|boolean|false|none|none|
|fullName|string¦null|false|none|hy-AM: Լրիվ անվանում | en-US: Full name | ru-RU: Полное наименование|
|incomeDate|string(date)¦null|false|none|hy-AM: Մուտքի ա/թ | en-US: Income date | ru-RU: Дата прихода|
|partySupplierId|integer(int32)|false|none|none|
|partySupplierCode|string¦null|false|none|hy-AM: Մատակարար | en-US: Supplier | ru-RU: Поставщик|
|partySupplierName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|partyDocumentNumber|string¦null|false|none|hy-AM: Փաստաթղթի N | en-US: Document N | ru-RU: Номер док.|
|partyDocumentType|integer(int32)|false|none|hy-AM: Փաստաթղթի տեսակ | en-US: Document type | ru-RU: Вид документа|
|partyDocumentTypeName|string¦null|false|none|hy-AM: Փաստաթղթի տեսակ | en-US: Document type | ru-RU: Вид документа|
|partyPurchasingPrice|number(double)|false|none|hy-AM: Ձեռքբերման գին | en-US: Purchasing price | ru-RU: Цена покупки|
|partyPurchasingPriceWithoutVAT|number(double)|false|none|hy-AM: Ձեռքբերման գին | en-US: Purchasing price | ru-RU: Цена покупки|

<h2 id="tocS_MaterialsOperationsDataRowApiResponse">MaterialsOperationsDataRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemamaterialsoperationsdatarowapiresponse"></a>
<a id="schema_MaterialsOperationsDataRowApiResponse"></a>
<a id="tocSmaterialsoperationsdatarowapiresponse"></a>
<a id="tocsmaterialsoperationsdatarowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "documentType": 0,
      "operationType": "string",
      "operationName": "string",
      "inputOutput": "string",
      "storage": "string",
      "storageName": "string",
      "materialId": 0,
      "materialCode": "string",
      "materialName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "account": "string",
      "correspondingObject": "string",
      "correspondingObjectName": "string",
      "analytic1": "string",
      "analytic2": "string",
      "cost": 0.1,
      "quantity": 0.1,
      "costAmount": 0.1,
      "costVATAmount": 0.1,
      "unitVAT": 0.1,
      "currency": "string",
      "currencyCost": 0.1,
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "saleVATPrice": 0.1,
      "saleVATAmount": 0.1,
      "salePriceCurrency": 0.1,
      "saleAmountCurrency": 0.1,
      "comment": "string",
      "group": "string",
      "groupName": "string",
      "specification": "string",
      "cpaClassifier": "string",
      "barcode": "string",
      "vat": true,
      "fullName": "string",
      "incomeDate": "2019-08-24",
      "partySupplierId": 0,
      "partySupplierCode": "string",
      "partySupplierName": "string",
      "partyDocumentNumber": "string",
      "partyDocumentType": 0,
      "partyDocumentTypeName": "string",
      "partyPurchasingPrice": 0.1,
      "partyPurchasingPriceWithoutVAT": 0.1
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[MaterialsOperationsDataRow](#schemamaterialsoperationsdatarow)]¦null|false|none|none|

<h2 id="tocS_MaterialsOperationsParam">MaterialsOperationsParam</h2>
<!-- backwards compatibility -->
<a id="schemamaterialsoperationsparam"></a>
<a id="schema_MaterialsOperationsParam"></a>
<a id="tocSmaterialsoperationsparam"></a>
<a id="tocsmaterialsoperationsparam"></a>

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "storage": "string",
  "materialGroup": "string",
  "material": "string",
  "account": "string",
  "partner": "string",
  "operationTypes": "string",
  "showParties": true,
  "currency": "string",
  "showCurrencies": true,
  "showSalePrice": true,
  "showVATAmounts": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|hy-AM:  էջ  | en-US:  page | ru-RU: страница|
|startDate|string(date)|false|none|hy-AM: Ժամանակահատվածի սկիզբ | en-US: Period begin | ru-RU: Начало периода|
|endDate|string(date)|false|none|hy-AM: Ժամանակահատվածի վերջ | en-US: Period end | ru-RU: Конец периода|
|storage|string¦null|false|none|hy-AM: Պահեստ | en-US: Storage | ru-RU: Склад|
|materialGroup|string¦null|false|none|hy-AM: Նյութական արժեքների խումբ | en-US: Materials group | ru-RU: Группа ТМЦ|
|material|string¦null|false|none|hy-AM: Նյութական արժեք | en-US: Material | ru-RU: Товарно-материальная ценность|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|partner|string¦null|false|none|hy-AM: Գործընկեր | en-US: Partner | ru-RU: Партнер|
|operationTypes|string¦null|false|none|hy-AM: Գործողության տեսակ | en-US: Operation type | ru-RU: Вид операции|
|showParties|boolean|false|none|hy-AM: Ըստ տարբեր խմբաքանակների | en-US: By different batches | ru-RU: Детализировать по партиям|
|currency|string¦null|false|none|hy-AM: Արտարժույթ | en-US: Currency | ru-RU: Валюта|
|showCurrencies|boolean|false|none|hy-AM: Ցույց տալ արտարժույթները | en-US: Show currencies | ru-RU: Показать валюты|
|showSalePrice|boolean|false|none|hy-AM: Ցույց տալ վաճառքի գինը | en-US: Show sale price | ru-RU: Показать цена продажи|
|showVATAmounts|boolean|false|none|hy-AM: Ցույց տալ ԱԱՀ-ի գումարները | en-US: Show VAT amounts | ru-RU: Показать суммы НДС|

<h2 id="tocS_MemorialOrder">MemorialOrder</h2>
<!-- backwards compatibility -->
<a id="schemamemorialorder"></a>
<a id="schema_MemorialOrder"></a>
<a id="tocSmemorialorder"></a>
<a id="tocsmemorialorder"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "amount": 0.1,
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "previousDayExchangeRate": true,
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "transactionsList": [
    {
      "debitAccount": "string",
      "debitPartner": "string",
      "debitAnalytic1": "string",
      "debitAnalytic2": "string",
      "debitCurrency": "string",
      "creditAccount": "string",
      "creditPartner": "string",
      "creditAnalytic1": "string",
      "creditAnalytic2": "string",
      "creditCurrency": "string",
      "currencyAmount": 0.1,
      "amount": 0.1,
      "comment": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)¦null|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|documentNumber|string¦null|false|none|hy-AM: Փաստաթղթի N | en-US: Document N | ru-RU: Номер док.|
|state|integer(int32)|false|none|hy-AM: Վիճակ | en-US: State | ru-RU: Состояние|
|amount|number(double)|false|none|hy-AM: Գումար | en-US: Amount | ru-RU: Сумма|
|currency|string¦null|false|none|hy-AM: Արժույթ | en-US: Currency | ru-RU: Валюта|
|currencyExchangeRate|number(double)|false|none|hy-AM: Արտարժույթի փոխարժեք | en-US: Currency exchange rate | ru-RU: Курс валюты|
|currencyExchangeBase|number(double)|false|none|hy-AM: Արտարժույթի փոխարժեք | en-US: Currency exchange rate | ru-RU: Курс валюты|
|previousDayExchangeRate|boolean|false|none|hy-AM: Նախորդ օրվա փոխարժեքը | en-US: Previous day exchange rate | ru-RU: Курс валюты предыдущего дня|
|analytic1|string¦null|false|none|hy-AM: Անալիտիկ խումբ 1 | en-US: Analytical dimension 1 | ru-RU: Аналитическая группа 1|
|analytic2|string¦null|false|none|hy-AM: Անալիտիկ խումբ 2 | en-US: Analytical dimension 2 | ru-RU: Аналитическая группа 2|
|comment|string¦null|false|none|hy-AM: Մեկնաբանություն | en-US: Comment | ru-RU: Комментарий|
|transactionsList|[[MemorialOrderSpecificationRow](#schemamemorialorderspecificationrow)]¦null|false|none|hy-AM: Գործարք | en-US: Operation | ru-RU: Проводка|

<h2 id="tocS_MemorialOrderSpecificationRow">MemorialOrderSpecificationRow</h2>
<!-- backwards compatibility -->
<a id="schemamemorialorderspecificationrow"></a>
<a id="schema_MemorialOrderSpecificationRow"></a>
<a id="tocSmemorialorderspecificationrow"></a>
<a id="tocsmemorialorderspecificationrow"></a>

```json
{
  "debitAccount": "string",
  "debitPartner": "string",
  "debitAnalytic1": "string",
  "debitAnalytic2": "string",
  "debitCurrency": "string",
  "creditAccount": "string",
  "creditPartner": "string",
  "creditAnalytic1": "string",
  "creditAnalytic2": "string",
  "creditCurrency": "string",
  "currencyAmount": 0.1,
  "amount": 0.1,
  "comment": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|debitAccount|string¦null|false|none|hy-AM: Դեբետ | en-US: Debit | ru-RU: Дебет|
|debitPartner|string¦null|false|none|hy-AM: Դեբետ գործ. | en-US: Debit part. | ru-RU: Дебет партн.|
|debitAnalytic1|string¦null|false|none|hy-AM: Անալիտիկ խումբ 1 | en-US: Analytical dimension 1 | ru-RU: Аналитическая группа 1|
|debitAnalytic2|string¦null|false|none|hy-AM: Անալիտիկ խումբ 2 | en-US: Analytical dimension 2 | ru-RU: Аналитическая группа 2|
|debitCurrency|string¦null|false|none|hy-AM: Դեբետ արժ. | en-US: Debit curr. | ru-RU: Дебет валюта|
|creditAccount|string¦null|false|none|hy-AM: Կրեդիտ | en-US: Credit | ru-RU: Кредит|
|creditPartner|string¦null|false|none|hy-AM: Կրեդիտ գործ. | en-US: Credit part. | ru-RU: Кредит партн.|
|creditAnalytic1|string¦null|false|none|hy-AM: Անալիտիկ խումբ 1 | en-US: Analytical dimension 1 | ru-RU: Аналитическая группа 1|
|creditAnalytic2|string¦null|false|none|hy-AM: Անալիտիկ խումբ 2 | en-US: Analytical dimension 2 | ru-RU: Аналитическая группа 2|
|creditCurrency|string¦null|false|none|hy-AM: Կրեդիտ արժ. | en-US: Credit curr. | ru-RU: Кредит валюта|
|currencyAmount|number(double)|false|none|hy-AM: Գումար արժ. | en-US: Amount in curr. | ru-RU: Сумма в валюте|
|amount|number(double)|false|none|hy-AM: Գումար դրամով | en-US: Amount in Dram | ru-RU: Сумма в драмах|
|comment|string¦null|false|none|hy-AM: Մեկնաբանություն | en-US: Comment | ru-RU: Комментарий|

<h2 id="tocS_NextPageRequest">NextPageRequest</h2>
<!-- backwards compatibility -->
<a id="schemanextpagerequest"></a>
<a id="schema_NextPageRequest"></a>
<a id="tocSnextpagerequest"></a>
<a id="tocsnextpagerequest"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|close|boolean|false|none|none|

<h2 id="tocS_OverheadExpenseAllocation">OverheadExpenseAllocation</h2>
<!-- backwards compatibility -->
<a id="schemaoverheadexpenseallocation"></a>
<a id="schema_OverheadExpenseAllocation"></a>
<a id="tocSoverheadexpenseallocation"></a>
<a id="tocsoverheadexpenseallocation"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocument": "ece108bc-8bd2-42b3-a4d2-d8d3cb3977b5",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "previousDayExchangeRate": true,
  "supplierCode": "string",
  "supplierAccount": "string",
  "prepaymentAccount": "string",
  "vatAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "overheadExpenseType": "string",
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "vatInclusionMethod": "string",
  "storage": "string",
  "allowEditList": true,
  "distributionType": "string",
  "distributionBase": "string",
  "amount": 0.1,
  "vatAmount": 0.1,
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "inputOrderAmount": 0.1,
      "allocatedAmount": 0.1,
      "account": "string",
      "includeInDistribution": true,
      "coefficient": 0.1,
      "rowId": 0
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)¦null|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|documentNumber|string¦null|false|none|hy-AM: Փաստաթղթի N | en-US: Document N | ru-RU: Номер док.|
|state|integer(int32)|false|none|hy-AM: Վիճակ | en-US: State | ru-RU: Состояние|
|baseDocument|string(uuid)|false|none|hy-AM: Հիմք փաստաթուղթ | en-US: Base document | ru-RU: Документ основания|
|currency|string¦null|false|none|hy-AM: Արժույթ | en-US: Currency | ru-RU: Валюта|
|currencyExchangeRate|number(double)|false|none|hy-AM: Արտարժույթի փոխարժեք | en-US: Currency exchange rate | ru-RU: Курс валюты|
|currencyExchangeBase|number(double)|false|none|hy-AM: Արտարժույթի փոխարժեք | en-US: Currency exchange rate | ru-RU: Курс валюты|
|previousDayExchangeRate|boolean|false|none|hy-AM: Նախորդ օրվա փոխարժեքը | en-US: Previous day exchange rate | ru-RU: Курс валюты предыдущего дня|
|supplierCode|string¦null|false|none|hy-AM: Մատակարար | en-US: Supplier | ru-RU: Поставщик|
|supplierAccount|string¦null|false|none|hy-AM: Մատակարարի հաշիվ | en-US: Supplier account | ru-RU: Счет поставщика|
|prepaymentAccount|string¦null|false|none|hy-AM: Տրված կանխավճարի հաշիվ | en-US: Prepayment account | ru-RU: Счет авансов выданных|
|vatAccount|string¦null|false|none|none|
|analytic1|string¦null|false|none|hy-AM: Անալիտիկ խումբ 1 | en-US: Analytical dimension 1 | ru-RU: Аналитическая группа 1|
|analytic2|string¦null|false|none|hy-AM: Անալիտիկ խումբ 2 | en-US: Analytical dimension 2 | ru-RU: Аналитическая группа 2|
|taxExportType|string¦null|false|none|hy-AM: Դուրս գրման եղանակ | en-US: Electronic/Paper | ru-RU: Метод выписки|
|purchaseDocumentNumber|string¦null|false|none|hy-AM: Ձեռքբերման փաստաթղթի N | en-US: Purchase document N | ru-RU: Номер документа приобретения|
|purchaseDocumentDate|string(date)¦null|false|none|hy-AM: ա/թ. | en-US: Date | ru-RU: Дата|
|comment|string¦null|false|none|hy-AM: Մեկնաբանություն | en-US: Comment | ru-RU: Комментарий|
|overheadExpenseType|string¦null|false|none|hy-AM: Հավելյալ ծախսի ձեռք բերման տեսակ | en-US: Overhead expenses obtaining type | ru-RU: Вид приобретения дополнительного расхода|
|vatCalculationType|string¦null|false|none|none|
|includeVATInCost|boolean|false|none|hy-AM: Ներառել ԱԱՀ-ն ինքնարժեքի մեջ | en-US: Include VAT in cost | ru-RU: НДС включить в себестоимость|
|vatInclusionMethod|string¦null|false|none|none|
|storage|string¦null|false|none|hy-AM: Պահեստ | en-US: Storage | ru-RU: Склад|
|allowEditList|boolean|false|none|hy-AM: Թույլատրել ցուցակի խմբագրումը | en-US: Allow edit list | ru-RU: Разрешить изменение списка|
|distributionType|string¦null|false|none|hy-AM: Բաշխման ձև | en-US: Distribution type | ru-RU: Вид распределения|
|distributionBase|string¦null|false|none|hy-AM: Բաշխման հիմք | en-US: Distribution base | ru-RU: База распределения|
|amount|number(double)|false|none|hy-AM: Գումար | en-US: Amount | ru-RU: Сумма|
|vatAmount|number(double)|false|none|none|
|materialsList|[[OverheadExpenseAllocationSpecificationRow](#schemaoverheadexpenseallocationspecificationrow)]¦null|false|none|hy-AM: Նյութական արժեքների ցուցակ | en-US: Materials list | ru-RU: Список ТМЦ|

<h2 id="tocS_OverheadExpenseAllocationSpecificationRow">OverheadExpenseAllocationSpecificationRow</h2>
<!-- backwards compatibility -->
<a id="schemaoverheadexpenseallocationspecificationrow"></a>
<a id="schema_OverheadExpenseAllocationSpecificationRow"></a>
<a id="tocSoverheadexpenseallocationspecificationrow"></a>
<a id="tocsoverheadexpenseallocationspecificationrow"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "unitAbbreviation": "string",
  "quantity": 0.1,
  "inputOrderAmount": 0.1,
  "allocatedAmount": 0.1,
  "account": "string",
  "includeInDistribution": true,
  "coefficient": 0.1,
  "rowId": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|unitAbbreviation|string¦null|false|none|hy-AM: Միավոր | en-US: Unit | ru-RU: Единица|
|quantity|number(double)|false|none|hy-AM: Քանակ | en-US: Quantity | ru-RU: Количество|
|inputOrderAmount|number(double)|false|none|hy-AM: ՊՄՕ գումար դրամով | en-US: Input order amount | ru-RU: Сумма ПСО в драмах|
|allocatedAmount|number(double)|false|none|hy-AM: Բաշխված գումար դրամով | en-US: Allocated amount | ru-RU: Распределенная сумма в драмах|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|includeInDistribution|boolean|false|none|none|
|coefficient|number(double)|false|none|hy-AM: ՀԾԲ գործակից | en-US: AOE coefficient | ru-RU: Коэфф. распределения доп. расходов|
|rowId|integer(int32)|false|none|hy-AM: Տողի ID | en-US: Line ID | ru-RU: ID линии|

<h2 id="tocS_Partner">Partner</h2>
<!-- backwards compatibility -->
<a id="schemapartner"></a>
<a id="schema_Partner"></a>
<a id="tocSpartner"></a>
<a id="tocspartner"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "taxCode": "string",
  "group": "string",
  "vatPayer": true,
  "legalAddress": "string",
  "businessAddress": "string",
  "managerName": "string",
  "managerPosition": "string",
  "accountantName": "string",
  "accountantPosition": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "paymentMainAim": "string",
  "phoneNumber": "string",
  "email": "string",
  "contract": "string",
  "contractDate": "2019-08-24",
  "salesDiscountPercent": 0.1,
  "status": "string",
  "additionalData": "string",
  "shippingMethod": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "isClosed": true,
  "settlementAccounts": [
    {
      "account": "string",
      "name": "string",
      "default": true
    }
  ],
  "additionalAddresses": [
    {
      "name": "string",
      "default": true
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|fullName|string¦null|false|none|hy-AM: Լրիվ անվանում | en-US: Full name | ru-RU: Полное наименование|
|taxCode|string¦null|false|none|hy-AM: ՀՎՀՀ | en-US: Taxpayer’s ID | ru-RU: ИНН код|
|group|string¦null|false|none|hy-AM: Խումբ | en-US: Group | ru-RU: Группа|
|vatPayer|boolean¦null|false|none|none|
|legalAddress|string¦null|false|none|hy-AM: Իրավ. հասցե | en-US: Legal address | ru-RU: Юридический адрес|
|businessAddress|string¦null|false|none|hy-AM: Գործ. հասցե | en-US: Bus. address | ru-RU: Фактический адрес|
|managerName|string¦null|false|none|hy-AM: Ղեկավարի Ա.Ա.Հ. | en-US: Manager first name, last name | ru-RU: ФИО руководителя|
|managerPosition|string¦null|false|none|hy-AM: Ղեկավարի պաշտոն | en-US: Manager position | ru-RU: Должность руководителя|
|accountantName|string¦null|false|none|hy-AM: Հաշվապահի Ա.Ա.Հ. | en-US: Accountant first name, last name | ru-RU: ФИО главного бухгалтера|
|accountantPosition|string¦null|false|none|hy-AM: Հաշվապահի պաշտոն | en-US: Accountant position | ru-RU: Должность главного бухгалтера|
|stateRegisterNumber|string¦null|false|none|hy-AM: Ա/Ձ-ի պետ. գրանց. վկ. N | en-US: S/P state regist. N | ru-RU: Гос. рег. номер ИП|
|idDocumentType|string¦null|false|none|hy-AM: Անձը հաստատող փաստաթուղթ | en-US: Identification document | ru-RU: Документ, удостоверяющий личность|
|passportNumber|string¦null|false|none|hy-AM: Անձնագրի համար | en-US: Passport N | ru-RU: Номер паспорта|
|socialCardNumber|string¦null|false|none|hy-AM: Հանրային ծառայությունների համարանիշ | en-US: Social card number | ru-RU: Номер социальной карты|
|paymentMainAim|string¦null|false|none|hy-AM: Վճարման հիմնական նպատակ | en-US: Payment main aim | ru-RU: Основное назначение платежа|
|phoneNumber|string¦null|false|none|hy-AM: Հեռախոսահամար | en-US: Phone number | ru-RU: Номер телефона|
|email|string¦null|false|none|hy-AM: Էլ. փոստ | en-US: E-Mail | ru-RU: Эл. почта|
|contract|string¦null|false|none|hy-AM: Պայմանագիր | en-US: Contract | ru-RU: Договор|
|contractDate|string(date)¦null|false|none|hy-AM: Պայմանագրի ամսաթիվը | en-US: Contract date | ru-RU: Дата договора|
|salesDiscountPercent|number(double)¦null|false|none|hy-AM: Վաճառքի զեղչի տոկոս | en-US: Sales discount percent | ru-RU: Процент скидки при продаже|
|status|string¦null|false|none|hy-AM: Կարգավիճակ | en-US: Status | ru-RU: Статус|
|additionalData|string¦null|false|none|hy-AM: Լրացուցիչ տվյալներ | en-US: Additional data | ru-RU: Дополнительная информация|
|shippingMethod|string¦null|false|none|hy-AM: Ապր. առաքման եղանակը | en-US: Shipping method | ru-RU: Способ доставки товаров|
|additionalFullName|string¦null|false|none|hy-AM: Ազգանուն, անուն, հայրանուն | en-US: Full name | ru-RU: Фамилия, имя, отчество|
|credentialNumber|string¦null|false|none|hy-AM: Լիազորագրի համար | en-US: Credential number | ru-RU: Номер доверенности|
|credentialDate|string(date)¦null|false|none|hy-AM: Լիազորագրի ամսաթիվ | en-US: Credential date | ru-RU: Дата доверенности|
|isClosed|boolean¦null|false|none|hy-AM: Փակված | en-US: Closed | ru-RU: Закрыто|
|settlementAccounts|[[PartnerSettlementAccountRow](#schemapartnersettlementaccountrow)]¦null|false|none|hy-AM: Հաշվարկային հաշիվներ | en-US: Settlement accounts | ru-RU: Банковские счета|
|additionalAddresses|[[PartnerBusinessAddressRow](#schemapartnerbusinessaddressrow)]¦null|false|none|hy-AM: Գործունեության հասցե | en-US: Business address | ru-RU: Адрес места деятельности|

<h2 id="tocS_PartnerBusinessAddressRow">PartnerBusinessAddressRow</h2>
<!-- backwards compatibility -->
<a id="schemapartnerbusinessaddressrow"></a>
<a id="schema_PartnerBusinessAddressRow"></a>
<a id="tocSpartnerbusinessaddressrow"></a>
<a id="tocspartnerbusinessaddressrow"></a>

```json
{
  "name": "string",
  "default": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|hy-AM: Գործ. հասցե | en-US: Bus. address | ru-RU: Фактический адрес|
|default|boolean|false|none|hy-AM: Հիմնական | en-US: Default | ru-RU: Основной|

<h2 id="tocS_PartnerFilters">PartnerFilters</h2>
<!-- backwards compatibility -->
<a id="schemapartnerfilters"></a>
<a id="schema_PartnerFilters"></a>
<a id="tocSpartnerfilters"></a>
<a id="tocspartnerfilters"></a>

```json
{
  "pageSize": 0,
  "codes": [
    "string"
  ],
  "lastModifiedDate": "2019-08-24T14:15:22Z",
  "group": "string",
  "showAlsoClosed": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|hy-AM:  էջ  | en-US:  page | ru-RU: страница|
|codes|[string]¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|lastModifiedDate|string(date-time)¦null|false|none|hy-AM: Վերջին խմբագրման ամսաթիվ | en-US: Last modification date | ru-RU: Дата последнего изменения|
|group|string¦null|false|none|hy-AM: Խումբ | en-US: Group | ru-RU: Группа|
|showAlsoClosed|boolean|false|none|hy-AM: Ցույց տալ նաև փակվածները | en-US: Show also closed | ru-RU: Показать также закрытые|

<h2 id="tocS_PartnerRow">PartnerRow</h2>
<!-- backwards compatibility -->
<a id="schemapartnerrow"></a>
<a id="schema_PartnerRow"></a>
<a id="tocSpartnerrow"></a>
<a id="tocspartnerrow"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "taxCode": "string",
  "group": "string",
  "groupName": "string",
  "vatPayer": true,
  "legalAddress": "string",
  "businessAddress": "string",
  "managerName": "string",
  "managerPosition": "string",
  "accountantName": "string",
  "accountantPosition": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "paymentMainAim": "string",
  "phoneNumber": "string",
  "email": "string",
  "contract": "string",
  "contractDate": "2019-08-24",
  "salesDiscountPercent": 0.1,
  "status": "string",
  "settlementAccount": "string",
  "userName": "string",
  "lastChange": "2019-08-24T14:15:22Z",
  "isClosed": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|fullName|string¦null|false|none|hy-AM: Լրիվ անվանում | en-US: Full name | ru-RU: Полное наименование|
|taxCode|string¦null|false|none|hy-AM: ՀՎՀՀ | en-US: Taxpayer’s ID | ru-RU: ИНН код|
|group|string¦null|false|none|hy-AM: Խումբ | en-US: Group | ru-RU: Группа|
|groupName|string¦null|false|none|hy-AM: Խմբի անվանում | en-US: Group name | ru-RU: Наименование группы|
|vatPayer|boolean|false|none|none|
|legalAddress|string¦null|false|none|hy-AM: Իրավ. հասցե | en-US: Legal address | ru-RU: Юридический адрес|
|businessAddress|string¦null|false|none|hy-AM: Գործ. հասցե | en-US: Bus. address | ru-RU: Фактический адрес|
|managerName|string¦null|false|none|hy-AM: Ղեկավարի Ա.Ա.Հ. | en-US: Manager first name, last name | ru-RU: ФИО руководителя|
|managerPosition|string¦null|false|none|hy-AM: Ղեկավարի պաշտոն | en-US: Manager position | ru-RU: Должность руководителя|
|accountantName|string¦null|false|none|hy-AM: Հաշվապահի Ա.Ա.Հ. | en-US: Accountant first name, last name | ru-RU: ФИО главного бухгалтера|
|accountantPosition|string¦null|false|none|hy-AM: Հաշվապահի պաշտոն | en-US: Accountant position | ru-RU: Должность главного бухгалтера|
|stateRegisterNumber|string¦null|false|none|hy-AM: Ա/Ձ-ի պետ. գրանց. վկ. N | en-US: S/P state regist. N | ru-RU: Гос. рег. номер ИП|
|idDocumentType|string¦null|false|none|hy-AM: Անձը հաստատող փաստաթղթի տեսակ | en-US: ID document type | ru-RU: Документ, удостоверяющий личность|
|passportNumber|string¦null|false|none|hy-AM: Անձնագրի համար | en-US: Passport N | ru-RU: Номер паспорта|
|socialCardNumber|string¦null|false|none|hy-AM: Հանրային ծառայությունների համարանիշ | en-US: Social card number | ru-RU: Номер социальной карты|
|paymentMainAim|string¦null|false|none|hy-AM: Վճարման հիմնական նպատակ | en-US: Payment main aim | ru-RU: Основное назначение платежа|
|phoneNumber|string¦null|false|none|hy-AM: Հեռախոսահամար | en-US: Phone number | ru-RU: Номер телефона|
|email|string¦null|false|none|hy-AM: Էլ. փոստ | en-US: E-Mail | ru-RU: Эл. почта|
|contract|string¦null|false|none|hy-AM: Պայմանագիր | en-US: Contract | ru-RU: Договор|
|contractDate|string(date)¦null|false|none|hy-AM: Պայմանագրի ամսաթիվը | en-US: Contract date | ru-RU: Дата договора|
|salesDiscountPercent|number(double)|false|none|hy-AM: Վաճառքի զեղչի տոկոս | en-US: Sales discount percent | ru-RU: Процент скидки при продаже|
|status|string¦null|false|none|hy-AM: Կարգավիճակ | en-US: Status | ru-RU: Статус|
|settlementAccount|string¦null|false|none|hy-AM: Հաշվարկային հաշիվ | en-US: Settlement account | ru-RU: Банковский счет|
|userName|string¦null|false|none|hy-AM: Օգտագործող | en-US: User name | ru-RU: Пользователь|
|lastChange|string(date-time)¦null|false|none|hy-AM: Վերջին փոփոխություն | en-US: Last change | ru-RU: Последнее изменение|
|isClosed|boolean|false|none|hy-AM: Փակված | en-US: Closed | ru-RU: Закрыто|

<h2 id="tocS_PartnerRowApiResponse">PartnerRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemapartnerrowapiresponse"></a>
<a id="schema_PartnerRowApiResponse"></a>
<a id="tocSpartnerrowapiresponse"></a>
<a id="tocspartnerrowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "taxCode": "string",
      "group": "string",
      "groupName": "string",
      "vatPayer": true,
      "legalAddress": "string",
      "businessAddress": "string",
      "managerName": "string",
      "managerPosition": "string",
      "accountantName": "string",
      "accountantPosition": "string",
      "stateRegisterNumber": "string",
      "idDocumentType": "string",
      "passportNumber": "string",
      "socialCardNumber": "string",
      "paymentMainAim": "string",
      "phoneNumber": "string",
      "email": "string",
      "contract": "string",
      "contractDate": "2019-08-24",
      "salesDiscountPercent": 0.1,
      "status": "string",
      "settlementAccount": "string",
      "userName": "string",
      "lastChange": "2019-08-24T14:15:22Z",
      "isClosed": true
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[PartnerRow](#schemapartnerrow)]¦null|false|none|none|

<h2 id="tocS_PartnerSettlementAccountRow">PartnerSettlementAccountRow</h2>
<!-- backwards compatibility -->
<a id="schemapartnersettlementaccountrow"></a>
<a id="schema_PartnerSettlementAccountRow"></a>
<a id="tocSpartnersettlementaccountrow"></a>
<a id="tocspartnersettlementaccountrow"></a>

```json
{
  "account": "string",
  "name": "string",
  "default": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|default|boolean|false|none|hy-AM: Հիմնական | en-US: Default | ru-RU: Основной|

<h2 id="tocS_PartnersBalancesDataRow">PartnersBalancesDataRow</h2>
<!-- backwards compatibility -->
<a id="schemapartnersbalancesdatarow"></a>
<a id="schema_PartnersBalancesDataRow"></a>
<a id="tocSpartnersbalancesdatarow"></a>
<a id="tocspartnersbalancesdatarow"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "status": "string",
  "account": "string",
  "accountName": "string",
  "analytic1Code": "string",
  "analytic1Name": "string",
  "analytic2Code": "string",
  "analytic2Name": "string",
  "currency": "string",
  "debitCurrency": 0.1,
  "creditCurrency": 0.1,
  "debitNCC": 0.1,
  "creditNCC": 0.1,
  "outOfBalance": true,
  "date": "2019-08-24"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|code|string¦null|false|none|hy-AM: Գործընկեր | en-US: Partner | ru-RU: Партнер|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|status|string¦null|false|none|hy-AM: Կարգավիճակ | en-US: Status | ru-RU: Статус|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|accountName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|analytic1Code|string¦null|false|none|hy-AM: Ան.խումբ 1 | en-US: An. dimension 1 | ru-RU: Ан.группа 1|
|analytic1Name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|analytic2Code|string¦null|false|none|hy-AM: Ան.խումբ 2 | en-US: An. dimension 2 | ru-RU: Ан.группа 2|
|analytic2Name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|currency|string¦null|false|none|hy-AM: Արժույթ | en-US: Currency | ru-RU: Валюта|
|debitCurrency|number(double)|false|none|hy-AM: Դեբետ արժ. | en-US: Debit curr. | ru-RU: Дебет валюта|
|creditCurrency|number(double)|false|none|hy-AM: Կրեդիտ արժ. | en-US: Credit curr. | ru-RU: Кредит валюта|
|debitNCC|number(double)|false|none|hy-AM: Դեբետ դրամով | en-US: Debit in Dram | ru-RU: Дебет в драмах|
|creditNCC|number(double)|false|none|hy-AM: Կրեդիտ դրամով | en-US: Credit in Dram | ru-RU: Кредит в драмах|
|outOfBalance|boolean|false|none|hy-AM: Արտահաշվ. | en-US: Out of bal. | ru-RU: Забалан.|
|date|string(date)|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|

<h2 id="tocS_PartnersBalancesDataRowApiResponse">PartnersBalancesDataRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemapartnersbalancesdatarowapiresponse"></a>
<a id="schema_PartnersBalancesDataRowApiResponse"></a>
<a id="tocSpartnersbalancesdatarowapiresponse"></a>
<a id="tocspartnersbalancesdatarowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "status": "string",
      "account": "string",
      "accountName": "string",
      "analytic1Code": "string",
      "analytic1Name": "string",
      "analytic2Code": "string",
      "analytic2Name": "string",
      "currency": "string",
      "debitCurrency": 0.1,
      "creditCurrency": 0.1,
      "debitNCC": 0.1,
      "creditNCC": 0.1,
      "outOfBalance": true,
      "date": "2019-08-24"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[PartnersBalancesDataRow](#schemapartnersbalancesdatarow)]¦null|false|none|none|

<h2 id="tocS_PartnersBalancesParam">PartnersBalancesParam</h2>
<!-- backwards compatibility -->
<a id="schemapartnersbalancesparam"></a>
<a id="schema_PartnersBalancesParam"></a>
<a id="tocSpartnersbalancesparam"></a>
<a id="tocspartnersbalancesparam"></a>

```json
{
  "pageSize": 0,
  "date": "2019-08-24",
  "partnerGroup": "string",
  "partner": "string",
  "account": "string",
  "currency": "string",
  "reportCurrency": "string",
  "accountsSection": "string",
  "showZeroRows": true,
  "openedByDate": true,
  "subtotals": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|hy-AM:  էջ  | en-US:  page | ru-RU: страница|
|date|string(date)|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|partnerGroup|string¦null|false|none|hy-AM: Գործընկերների խումբ | en-US: Partners group | ru-RU: Группа партнеров|
|partner|string¦null|false|none|hy-AM: Գործընկեր | en-US: Partner | ru-RU: Партнер|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|currency|string¦null|false|none|hy-AM: Արժույթ | en-US: Currency | ru-RU: Валюта|
|reportCurrency|string¦null|false|none|hy-AM: Հաշվետվության արժույթ | en-US: Report currency | ru-RU: Валюта отчета|
|accountsSection|string¦null|false|none|hy-AM: Հաշվի պատկանելիության բաժին | en-US: Accounts section | ru-RU: Раздел счета|
|showZeroRows|boolean|false|none|hy-AM: Ցույց տալ զրոյական տողերը | en-US: Show zero rows | ru-RU: Показать нулевые строки|
|openedByDate|boolean|false|none|hy-AM: Ցույց տալ բացված ըստ ամսաթվերի | en-US: Opened by date | ru-RU: Показать открытые по датам|
|subtotals|string¦null|false|none|hy-AM: Նշված տողեր | en-US: Selected rows | ru-RU: Помеченные строки|

<h2 id="tocS_PartnersTransactionsDataRow">PartnersTransactionsDataRow</h2>
<!-- backwards compatibility -->
<a id="schemapartnerstransactionsdatarow"></a>
<a id="schema_PartnersTransactionsDataRow"></a>
<a id="tocSpartnerstransactionsdatarow"></a>
<a id="tocspartnerstransactionsdatarow"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "type": 0,
  "typeName": "string",
  "debitPartnerGroup": "string",
  "debitPartnerGroupName": "string",
  "debitPartner": "string",
  "debitPartnerName": "string",
  "debitPartnerTaxCode": "string",
  "debitAccount": "string",
  "debitAccountType": "string",
  "debitCurrency": "string",
  "creditPartnerGroup": "string",
  "creditPartnerGroupName": "string",
  "creditPartner": "string",
  "creditPartnerName": "string",
  "creditPartnerTaxCode": "string",
  "creditAccount": "string",
  "creditAccountType": "string",
  "creditCurrency": "string",
  "amount": 0.1,
  "currencyAmount": 0.1,
  "comment": "string",
  "userName": "string",
  "systemGenerated": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|documentNumber|string¦null|false|none|hy-AM: Փաստաթղթի N | en-US: Document N | ru-RU: Номер док.|
|type|integer(int32)|false|none|hy-AM: Տեսակ | en-US: Type | ru-RU: Вид|
|typeName|string¦null|false|none|hy-AM: Տեսակ | en-US: Type | ru-RU: Вид|
|debitPartnerGroup|string¦null|false|none|hy-AM: Դեբետ-խումբ | en-US: Debit-group | ru-RU: Дебет-группа|
|debitPartnerGroupName|string¦null|false|none|hy-AM: Դեբետ-խմբի անվանում | en-US: Debit group name | ru-RU: Дебет-группа наименование|
|debitPartner|string¦null|false|none|hy-AM: Դեբետ-կոդ | en-US: Debit-code | ru-RU: Дебет-код|
|debitPartnerName|string¦null|false|none|hy-AM: Դեբետ-անվանում | en-US: Debit-name | ru-RU: Дебет-наименование|
|debitPartnerTaxCode|string¦null|false|none|hy-AM: Դեբետ-ՀՎՀՀ | en-US: Debit - Taxpayer’s ID | ru-RU: Дебет-ИНН|
|debitAccount|string¦null|false|none|hy-AM: Դեբետ-հաշիվ | en-US: Debit-account | ru-RU: Дебет-счет|
|debitAccountType|string¦null|false|none|hy-AM: Հաշվի տեսակ | en-US: Invoice type | ru-RU: Вид счета|
|debitCurrency|string¦null|false|none|hy-AM: Դեբետ արժ. | en-US: Debit curr. | ru-RU: Дебет валюта|
|creditPartnerGroup|string¦null|false|none|hy-AM: Կրեդիտ-խումբ | en-US: Credit-group | ru-RU: Кредит-группа|
|creditPartnerGroupName|string¦null|false|none|hy-AM: Կրեդիտ-խմբի անվանում | en-US: Crebit group name | ru-RU: Наименования кредит-группа|
|creditPartner|string¦null|false|none|hy-AM: Կրեդիտ-կոդ | en-US: Credit-code | ru-RU: Кредит-код|
|creditPartnerName|string¦null|false|none|hy-AM: Կրեդիտ-անվանում | en-US: Credit-name | ru-RU: Кредит-наименование|
|creditPartnerTaxCode|string¦null|false|none|hy-AM: Կրեդիտ-ՀՎՀՀ | en-US: Credit - Taxpayer’s ID | ru-RU: Кредит-ИНН|
|creditAccount|string¦null|false|none|hy-AM: Կրեդիտ-հաշիվ | en-US: Credit-account | ru-RU: Кредит-счет|
|creditAccountType|string¦null|false|none|hy-AM: Հաշվի տեսակ | en-US: Invoice type | ru-RU: Вид счета|
|creditCurrency|string¦null|false|none|hy-AM: Կրեդիտ արժ. | en-US: Credit curr. | ru-RU: Кредит валюта|
|amount|number(double)|false|none|hy-AM: Գումար դրամով | en-US: Amount in Dram | ru-RU: Сумма в драмах|
|currencyAmount|number(double)|false|none|hy-AM: Գումար արժ. | en-US: Amount in curr. | ru-RU: Сумма в валюте|
|comment|string¦null|false|none|hy-AM: Մեկնաբանություն | en-US: Comment | ru-RU: Комментарий|
|userName|string¦null|false|none|hy-AM: Օգտագործող | en-US: User name | ru-RU: Пользователь|
|systemGenerated|boolean|false|none|hy-AM: Համակարգային | en-US: System | ru-RU: Системный|

<h2 id="tocS_PartnersTransactionsDataRowApiResponse">PartnersTransactionsDataRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemapartnerstransactionsdatarowapiresponse"></a>
<a id="schema_PartnersTransactionsDataRowApiResponse"></a>
<a id="tocSpartnerstransactionsdatarowapiresponse"></a>
<a id="tocspartnerstransactionsdatarowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "type": 0,
      "typeName": "string",
      "debitPartnerGroup": "string",
      "debitPartnerGroupName": "string",
      "debitPartner": "string",
      "debitPartnerName": "string",
      "debitPartnerTaxCode": "string",
      "debitAccount": "string",
      "debitAccountType": "string",
      "debitCurrency": "string",
      "creditPartnerGroup": "string",
      "creditPartnerGroupName": "string",
      "creditPartner": "string",
      "creditPartnerName": "string",
      "creditPartnerTaxCode": "string",
      "creditAccount": "string",
      "creditAccountType": "string",
      "creditCurrency": "string",
      "amount": 0.1,
      "currencyAmount": 0.1,
      "comment": "string",
      "userName": "string",
      "systemGenerated": true
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[PartnersTransactionsDataRow](#schemapartnerstransactionsdatarow)]¦null|false|none|none|

<h2 id="tocS_PartnersTransactionsParam">PartnersTransactionsParam</h2>
<!-- backwards compatibility -->
<a id="schemapartnerstransactionsparam"></a>
<a id="schema_PartnersTransactionsParam"></a>
<a id="tocSpartnerstransactionsparam"></a>
<a id="tocspartnerstransactionsparam"></a>

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "debitPartnerGroup": "string",
  "creditPartnerGroup": "string",
  "partnersGroupANDCondition": true,
  "debitPartner": "string",
  "creditPartner": "string",
  "partnersANDCondition": true,
  "debitAccount": "string",
  "creditAccount": "string",
  "accountsANDCondition": true,
  "debitCurrency": "string",
  "creditCurrency": "string",
  "currenciesANDCondition": true,
  "documentTypes": [
    "string"
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|hy-AM:  էջ  | en-US:  page | ru-RU: страница|
|startDate|string(date)|false|none|hy-AM: Ժամանակահատվածի սկիզբ | en-US: Period begin | ru-RU: Начало периода|
|endDate|string(date)|false|none|hy-AM: Ժամանակահատվածի վերջ | en-US: Period end | ru-RU: Конец периода|
|debitPartnerGroup|string¦null|false|none|hy-AM: Դեբետ-խումբ | en-US: Debit-group | ru-RU: Дебет-группа|
|creditPartnerGroup|string¦null|false|none|hy-AM: Կրեդիտ-խումբ | en-US: Credit-group | ru-RU: Кредит-группа|
|partnersGroupANDCondition|boolean|false|none|hy-AM: և | en-US: and | ru-RU: и|
|debitPartner|string¦null|false|none|hy-AM: Դեբետ գործ. | en-US: Debit part. | ru-RU: Дебет партн.|
|creditPartner|string¦null|false|none|hy-AM: Կրեդիտ գործ. | en-US: Credit part. | ru-RU: Кредит партн.|
|partnersANDCondition|boolean|false|none|hy-AM: և | en-US: and | ru-RU: и|
|debitAccount|string¦null|false|none|hy-AM: Դեբետ-հաշիվ | en-US: Debit-account | ru-RU: Дебет-счет|
|creditAccount|string¦null|false|none|hy-AM: Կրեդիտ-հաշիվ | en-US: Credit-account | ru-RU: Кредит-счет|
|accountsANDCondition|boolean|false|none|hy-AM: և | en-US: and | ru-RU: и|
|debitCurrency|string¦null|false|none|hy-AM: Դեբետ արժ. | en-US: Debit curr. | ru-RU: Дебет валюта|
|creditCurrency|string¦null|false|none|hy-AM: Կրեդիտ արժ. | en-US: Credit curr. | ru-RU: Кредит валюта|
|currenciesANDCondition|boolean|false|none|hy-AM: և | en-US: and | ru-RU: и|
|documentTypes|[string]¦null|false|none|hy-AM: Փաստաթղթի տեսակ | en-US: Document type | ru-RU: Вид документа|

<h2 id="tocS_PaymentOrder">PaymentOrder</h2>
<!-- backwards compatibility -->
<a id="schemapaymentorder"></a>
<a id="schema_PaymentOrder"></a>
<a id="tocSpaymentorder"></a>
<a id="tocspaymentorder"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "transactionDate": "2019-08-24",
  "state": 0,
  "currencyAmount": 0.1,
  "amount": 0.1,
  "paymentAim": "string",
  "payerName": "string",
  "payerTaxCode": "string",
  "taxAreaCode": "string",
  "payerBankAccount": "string",
  "currency": "string",
  "partnerCode": "string",
  "receiverName": "string",
  "receiverTaxCode": "string",
  "receiverLegalStatus": "string",
  "receiverBankAccount": "string",
  "correspondentAccount": "string",
  "cashOutFlowAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "forOtherPartner": true,
  "otherPartnerCode": "string",
  "otherPartnerName": "string",
  "otherPartnerResidence": "string",
  "otherPartnerLegalStatus": "string",
  "otherPartnerTaxCode": "string",
  "otherPartnerPassportData": "string",
  "otherPartnerPassportNumber": "string",
  "otherPartnerSocialCard": "string",
  "otherPartnerAddress": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)¦null|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|documentNumber|string¦null|false|none|hy-AM: Փաստաթղթի N | en-US: Document N | ru-RU: Номер док.|
|transactionDate|string(date)¦null|false|none|hy-AM: Ձևակերպման ամսաթիվ | en-US: Transaction date | ru-RU: Дата проводки|
|state|integer(int32)|false|none|hy-AM: Վիճակ | en-US: State | ru-RU: Состояние|
|currencyAmount|number(double)|false|none|hy-AM: Գումար արժ. | en-US: Amount in curr. | ru-RU: Сумма в валюте|
|amount|number(double)|false|none|hy-AM: Գումար դրամով | en-US: Amount in Dram | ru-RU: Сумма в драмах|
|paymentAim|string¦null|false|none|hy-AM: Վճարման նպատակ  | en-US: Payment aim | ru-RU: Назначение платежа|
|payerName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|payerTaxCode|string¦null|false|none|hy-AM: ՀՎՀՀ | en-US: Taxpayer’s ID | ru-RU: ИНН код|
|taxAreaCode|string¦null|false|none|hy-AM: Հարկային տարածքի կոդ | en-US: Tax area code | ru-RU: Код региональной налоговой службы|
|payerBankAccount|string¦null|false|none|hy-AM: հաշիվ.N  | en-US: Account N | ru-RU: Сч. N|
|currency|string¦null|false|none|hy-AM: Արժույթ | en-US: Currency | ru-RU: Валюта|
|partnerCode|string¦null|false|none|hy-AM: Գործընկեր | en-US: Partner | ru-RU: Партнер|
|receiverName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|receiverTaxCode|string¦null|false|none|hy-AM: ՀՎՀՀ | en-US: Taxpayer’s ID | ru-RU: ИНН код|
|receiverLegalStatus|string¦null|false|none|hy-AM: Իրավ. կարգավիճակ | en-US: Legal status | ru-RU: Юр. статус|
|receiverBankAccount|string¦null|false|none|hy-AM: հաշիվ.N  | en-US: Account N | ru-RU: Сч. N|
|correspondentAccount|string¦null|false|none|hy-AM: Թղթակցող հաշիվ | en-US: Corr. account | ru-RU: Корр. счет|
|cashOutFlowAccount|string¦null|false|none|hy-AM: Դրամ. արտ. հաշիվ | en-US: Cash out. acc. | ru-RU: Счет выб. ДС|
|analytic1|string¦null|false|none|hy-AM: Անալիտիկ խումբ 1 | en-US: Analytical dimension 1 | ru-RU: Аналитическая группа 1|
|analytic2|string¦null|false|none|hy-AM: Անալիտիկ խումբ 2 | en-US: Analytical dimension 2 | ru-RU: Аналитическая группа 2|
|forOtherPartner|boolean|false|none|hy-AM: Այլ հաճախորդ | en-US: Third party | ru-RU: Другой клиент|
|otherPartnerCode|string¦null|false|none|hy-AM: Գործընկեր | en-US: Partner | ru-RU: Партнер|
|otherPartnerName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|otherPartnerResidence|string¦null|false|none|hy-AM: Ռեզիդենտություն | en-US: Residence | ru-RU: Резидентность|
|otherPartnerLegalStatus|string¦null|false|none|hy-AM: Իրավ. կարգավիճակ | en-US: Legal status | ru-RU: Юр. статус|
|otherPartnerTaxCode|string¦null|false|none|hy-AM: ՀՎՀՀ | en-US: Taxpayer’s ID | ru-RU: ИНН код|
|otherPartnerPassportData|string¦null|false|none|hy-AM: Անձնագրի տեսակ | en-US: Passport Data | ru-RU: Тип паспорта|
|otherPartnerPassportNumber|string¦null|false|none|hy-AM: Անձնագրի համար | en-US: Passport N | ru-RU: Номер паспорта|
|otherPartnerSocialCard|string¦null|false|none|hy-AM: Սոցիալական քարտ | en-US: Social card | ru-RU: Социальная карта|
|otherPartnerAddress|string¦null|false|none|hy-AM: Հասցե | en-US: Address | ru-RU: Адрес|

<h2 id="tocS_RetailSale">RetailSale</h2>
<!-- backwards compatibility -->
<a id="schemaretailsale"></a>
<a id="schema_RetailSale"></a>
<a id="tocSretailsale"></a>
<a id="tocsretailsale"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "ecrCheckNumber": "string",
  "state": 0,
  "customer": "string",
  "printExpenseConfirmingCheck": true,
  "contract": "string",
  "contractDate": "2019-08-24",
  "cashDesk": "string",
  "customerAccount": "string",
  "receivedPrepaymentAccount": "string",
  "vatAccount": "string",
  "environmentalFeeAccount": "string",
  "nonCashTransactionAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "dealType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "nonCashAmount": 0.1,
  "useECRPos": true,
  "prepaymentAmount": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "socialCardNumber": "string",
  "citizenOfRA": true,
  "socialExpensesType": "string",
  "socialExpenseSocialCard": "string",
  "socialExpenseCitizenName": "string",
  "socialExpenseIdentityDocument": "string",
  "socialExpenseSerialNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "expenseAccount": "string",
      "incomeAccount": "string",
      "markingList": [
        "string"
      ],
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)¦null|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|documentNumber|string¦null|false|none|hy-AM: Փաստաթղթի N | en-US: Document N | ru-RU: Номер док.|
|ecrCheckNumber|string¦null|false|none|none|
|state|integer(int32)|false|none|hy-AM: Վիճակ | en-US: State | ru-RU: Состояние|
|customer|string¦null|false|none|hy-AM: Գնորդ | en-US: Customer | ru-RU: Покупатель|
|printExpenseConfirmingCheck|boolean|false|none|hy-AM: Տպել ծախս հիմնավորող ՀԴՄԿ | en-US: Print expense confirming check | ru-RU: Печать чека ККМ подтвер. расходы|
|contract|string¦null|false|none|hy-AM: Պայմանագիր | en-US: Contract | ru-RU: Договор|
|contractDate|string(date)¦null|false|none|hy-AM: Պայմանագրի ամսաթիվը | en-US: Contract date | ru-RU: Дата договора|
|cashDesk|string¦null|false|none|hy-AM: Դրամարկղ | en-US: Cash | ru-RU: Касса|
|customerAccount|string¦null|false|none|hy-AM: Գնորդի հաշիվ | en-US: Customer account | ru-RU: Счет покупателя|
|receivedPrepaymentAccount|string¦null|false|none|hy-AM: Ստացված կանխավճարի հաշիվ | en-US: Received prepayment account | ru-RU: Счет авансов полученных|
|vatAccount|string¦null|false|none|none|
|environmentalFeeAccount|string¦null|false|none|hy-AM: Բնապահ. հարկի կրեդիտային հաշիվ | en-US: Environmental fees' credit account | ru-RU: Кредитовый счет эко. налога|
|nonCashTransactionAccount|string¦null|false|none|hy-AM: Անկանխիկ գործարքների հաշիվ | en-US: Non-cash transaction’s account | ru-RU: Счет безналичных расчетов|
|analytic1|string¦null|false|none|hy-AM: Անալիտիկ խումբ 1 | en-US: Analytical dimension 1 | ru-RU: Аналитическая группа 1|
|analytic2|string¦null|false|none|hy-AM: Անալիտիկ խումբ 2 | en-US: Analytical dimension 2 | ru-RU: Аналитическая группа 2|
|taxExportType|string¦null|false|none|hy-AM: Դուրս գրման եղանակ | en-US: Electronic/Paper | ru-RU: Метод выписки|
|taxInvoiceSeries|string¦null|false|none|hy-AM: Սերիա | en-US: Serial | ru-RU: Серия|
|taxInvoiceNumber|string¦null|false|none|hy-AM: Համար | en-US: Number | ru-RU: Номер|
|submissionDate|string(date)¦null|false|none|hy-AM: Դուրս գրման ամսաթիվ | en-US: Submission date | ru-RU: От|
|comment|string¦null|false|none|hy-AM: Մեկնաբանություն | en-US: Comment | ru-RU: Комментарий|
|vatCalculationType|string¦null|false|none|none|
|dealType|string¦null|false|none|hy-AM: Գործարքի տեսակ | en-US: Deal type | ru-RU: Тип сделки|
|storage|string¦null|false|none|hy-AM: Պահեստ | en-US: Storage | ru-RU: Склад|
|discountPercent|number(double)|false|none|hy-AM: Զեղչի տոկոս | en-US: Discount percent | ru-RU: Процент скидки|
|nonCashAmount|number(double)|false|none|hy-AM: Անկանխիկ գումար | en-US: Non-cash amount | ru-RU: Безналичная сумма|
|useECRPos|boolean|false|none|hy-AM: Օգտագործել ՀԴՄ-ի POS-ը | en-US: Use ECR POS | ru-RU: Использовать POS ККМ|
|prepaymentAmount|number(double)|false|none|hy-AM: Կանխավճարի օգտագործում | en-US: Use of prepayment | ru-RU: Использование аванса|
|vatAmount|number(double)|false|none|none|
|totalAmount|number(double)|false|none|hy-AM: Ընդհանուր գումար | en-US: Total amount | ru-RU: Общая сумма|
|supplierSettlementAccount|string¦null|false|none|hy-AM: Հաշվարկային հաշիվ | en-US: Settlement account | ru-RU: Банковский счет|
|supplierManagerPosition|string¦null|false|none|hy-AM: Ղեկավարի պաշտոն | en-US: Manager position | ru-RU: Должность руководителя|
|supplierManagerName|string¦null|false|none|hy-AM: Ղեկավարի Ա.Ա.Հ. | en-US: Manager first name, last name | ru-RU: ФИО руководителя|
|supplierAccountantPosition|string¦null|false|none|hy-AM: Հաշվապահի պաշտոն | en-US: Accountant position | ru-RU: Должность главного бухгалтера|
|supplierAccountantName|string¦null|false|none|hy-AM: Հաշվապահի Ա.Ա.Հ. | en-US: Accountant first name, last name | ru-RU: ФИО главного бухгалтера|
|customerName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|customerLegalAddress|string¦null|false|none|hy-AM: Իրավ. հասցե | en-US: Legal address | ru-RU: Юридический адрес|
|customerBusinessAddress|string¦null|false|none|hy-AM: Գործ. հասցե | en-US: Bus. address | ru-RU: Фактический адрес|
|customerSettlementAccount|string¦null|false|none|hy-AM: Հաշվարկային հաշիվ | en-US: Settlement account | ru-RU: Банковский счет|
|customerTaxCode|string¦null|false|none|hy-AM: ՀՎՀՀ | en-US: Taxpayer’s ID | ru-RU: ИНН код|
|customerManagerPosition|string¦null|false|none|hy-AM: Ղեկավարի պաշտոն | en-US: Manager position | ru-RU: Должность руководителя|
|customerManagerName|string¦null|false|none|hy-AM: Ղեկավարի Ա.Ա.Հ. | en-US: Manager first name, last name | ru-RU: ФИО руководителя|
|customerAccountantPosition|string¦null|false|none|hy-AM: Հաշվապահի պաշտոն | en-US: Accountant position | ru-RU: Должность главного бухгалтера|
|customerAccountantName|string¦null|false|none|hy-AM: Հաշվապահի Ա.Ա.Հ. | en-US: Accountant first name, last name | ru-RU: ФИО главного бухгалтера|
|stateRegisterNumber|string¦null|false|none|hy-AM: Ա/Ձ-ի պետ. գրանց. վկ. N | en-US: S/P state regist. N | ru-RU: Гос. рег. номер ИП|
|idDocumentType|string¦null|false|none|hy-AM: Անձը հաստատող փաստաթուղթ | en-US: Identification document | ru-RU: Документ, удостоверяющий личность|
|passportNumber|string¦null|false|none|hy-AM: Անձնագրի համար | en-US: Passport N | ru-RU: Номер паспорта|
|socialCardNumber|string¦null|false|none|hy-AM: Հանրային ծառայությունների համարանիշ | en-US: Social card number | ru-RU: Номер социальной карты|
|citizenOfRA|boolean|false|none|hy-AM: Սոցիալական ծախս կատարած ՀՀ քաղաքացի | en-US: Citizen of RA, who carried made expenses | ru-RU: Гражданин РА, осуществивший социальные расходы|
|socialExpensesType|string¦null|false|none|hy-AM: Սոցիալական ծախսի տեսակ | en-US: Type of social expenses | ru-RU: Тип социальных расходов|
|socialExpenseSocialCard|string¦null|false|none|hy-AM: ՀԾՀ/ՀԾՀ չունենալու վերաբերյալ տեղեկանք | en-US: Soc. card/certificate of absence of soc. card | ru-RU: Соц. карта/свидетельство об отсутствии соц. карты|
|socialExpenseCitizenName|string¦null|false|none|hy-AM: Անուն, ազգանուն | en-US: First name, last name | ru-RU: Имя, фамилия|
|socialExpenseIdentityDocument|string¦null|false|none|hy-AM: Անձը հաստատող փաստաթուղթ | en-US: Identification document | ru-RU: Документ, удостоверяющий личность|
|socialExpenseSerialNumber|string¦null|false|none|hy-AM: Սերիա և/կամ համար | en-US: Series and/or number | ru-RU: Серия и/или номер|
|itemList|[[RetailSaleSpecificationRow](#schemaretailsalespecificationrow)]¦null|false|none|hy-AM: Անվանացուցակ | en-US: Items list | ru-RU: Список товаров и услуг|

<h2 id="tocS_RetailSaleSpecificationRow">RetailSaleSpecificationRow</h2>
<!-- backwards compatibility -->
<a id="schemaretailsalespecificationrow"></a>
<a id="schema_RetailSaleSpecificationRow"></a>
<a id="tocSretailsalespecificationrow"></a>
<a id="tocsretailsalespecificationrow"></a>

```json
{
  "type": "string",
  "storage": "string",
  "id": 0,
  "code": "string",
  "name": "string",
  "unitAbbreviation": "string",
  "quantity": 0.1,
  "price": 0.1,
  "discountPercent": 0.1,
  "discountedPrice": 0.1,
  "amount": 0.1,
  "environmentalFeePercent": 0.1,
  "environmentalFeeAmount": 0.1,
  "vat": true,
  "dealType": "string",
  "expenseAccount": "string",
  "incomeAccount": "string",
  "markingList": [
    "string"
  ],
  "rowNumber": 0,
  "rowId": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|string¦null|false|none|hy-AM: Տեսակ | en-US: Type | ru-RU: Вид|
|storage|string¦null|false|none|hy-AM: Պահեստ | en-US: Storage | ru-RU: Склад|
|id|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|unitAbbreviation|string¦null|false|none|hy-AM: Միավոր | en-US: Unit | ru-RU: Единица|
|quantity|number(double)|false|none|hy-AM: Քանակ | en-US: Quantity | ru-RU: Количество|
|price|number(double)|false|none|hy-AM: Գին | en-US: Price | ru-RU: Цена|
|discountPercent|number(double)¦null|false|none|hy-AM: Զեղչի տոկոս | en-US: Discount percent | ru-RU: Процент скидки|
|discountedPrice|number(double)¦null|false|none|hy-AM: Զեղչված գին | en-US: Discounted price | ru-RU: Цена со скидкой|
|amount|number(double)¦null|false|none|hy-AM: Գումար | en-US: Amount | ru-RU: Сумма|
|environmentalFeePercent|number(double)|false|none|hy-AM: Այդ թվում բն. հրկ. (%) | en-US: Env. fee (%) | ru-RU: Включая % эко. налога|
|environmentalFeeAmount|number(double)|false|none|hy-AM: Այդ թվում բն. հրկ. գումար | en-US: Env. fee amount | ru-RU: Включая сумму эко. налога|
|vat|boolean¦null|false|none|none|
|dealType|string¦null|false|none|hy-AM: Գործարքի տեսակ | en-US: Deal type | ru-RU: Тип сделки|
|expenseAccount|string¦null|false|none|hy-AM: Ծախսի հաշիվ | en-US: Expense account | ru-RU: Счет расходов|
|incomeAccount|string¦null|false|none|hy-AM: Հասույթի հաշիվ | en-US: Income account | ru-RU: Счет дохода|
|markingList|[string]¦null|false|none|hy-AM: Դրոշմավորում | en-US: Marking | ru-RU: Маркировка|
|rowNumber|integer(int32)|false|none|hy-AM: Տողի N | en-US: line N | ru-RU: N строки|
|rowId|integer(int32)|false|none|hy-AM: Տողի ID | en-US: Line ID | ru-RU: ID линии|

<h2 id="tocS_Service">Service</h2>
<!-- backwards compatibility -->
<a id="schemaservice"></a>
<a id="schema_Service"></a>
<a id="tocSservice"></a>
<a id="tocsservice"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "cpaClassifier": "string",
  "account": "string",
  "revenueAccount": "string",
  "retailRevenueAccount": "string",
  "revenueAdjustmentAccount": "string",
  "wholePrice": 0.1,
  "retailPrice": 0.1,
  "currency": "string",
  "currencyPrice": 0.1,
  "barcode": "string",
  "vat": true,
  "isClosed": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|fullName|string¦null|false|none|hy-AM: Լրիվ անվանում | en-US: Full name | ru-RU: Полное наименование|
|unitMeasure|string¦null|false|none|hy-AM: Չափման միավոր | en-US: Unit of measure | ru-RU: Единица измерения|
|unitMeasureName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|unitMeasureAbbreviation|string¦null|false|none|hy-AM: Չափման միավոր | en-US: Unit of measure | ru-RU: Единица измерения|
|cpaClassifier|string¦null|false|none|none|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|revenueAccount|string¦null|false|none|hy-AM: Վաճառքից հասույթի հաշիվ | en-US: Revenue account | ru-RU: Счет доходов при опт. продаже|
|retailRevenueAccount|string¦null|false|none|hy-AM: Մանրածախ վաճառքից հասույթի հաշիվ | en-US: Retail revenue account | ru-RU: Счет доходов при розничной продаже|
|revenueAdjustmentAccount|string¦null|false|none|hy-AM: Վաճառքից հետ վերադարձի հասույթի ճշգրտում | en-US: Revenue adjustment account for Sales Return | ru-RU: Корректировка выручки реализации при возврате ТМЦ|
|wholePrice|number(double)¦null|false|none|hy-AM: Մեծածախ գին դրամով | en-US: Whole price in drams | ru-RU: Оптовая цена в драмах|
|retailPrice|number(double)¦null|false|none|hy-AM: Մանրածախ գին դրամով | en-US: Retail price in drams | ru-RU: Розничная цена в драмах|
|currency|string¦null|false|none|hy-AM: Արտարժույթ | en-US: Currency | ru-RU: Валюта|
|currencyPrice|number(double)¦null|false|none|hy-AM: Մեծածախ գին արտարժութային | en-US: Whole price in currency | ru-RU: Оптовая цена в валюте|
|barcode|string¦null|false|none|hy-AM: Գծիկավոր կոդ | en-US: Barcode | ru-RU: Штрихкод|
|vat|boolean¦null|false|none|none|
|isClosed|boolean¦null|false|none|hy-AM: Փակված | en-US: Closed | ru-RU: Закрыто|

<h2 id="tocS_ServiceFilters">ServiceFilters</h2>
<!-- backwards compatibility -->
<a id="schemaservicefilters"></a>
<a id="schema_ServiceFilters"></a>
<a id="tocSservicefilters"></a>
<a id="tocsservicefilters"></a>

```json
{
  "pageSize": 0,
  "codes": [
    "string"
  ],
  "lastModifiedDate": "2019-08-24T14:15:22Z",
  "showAlsoClosed": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|hy-AM:  էջ  | en-US:  page | ru-RU: страница|
|codes|[string]¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|lastModifiedDate|string(date-time)¦null|false|none|hy-AM: Վերջին խմբագրման ամսաթիվ | en-US: Last modification date | ru-RU: Дата последнего изменения|
|showAlsoClosed|boolean|false|none|hy-AM: Ցույց տալ նաև փակվածները | en-US: Show also closed | ru-RU: Показать также закрытые|

<h2 id="tocS_ServiceRow">ServiceRow</h2>
<!-- backwards compatibility -->
<a id="schemaservicerow"></a>
<a id="schema_ServiceRow"></a>
<a id="tocSservicerow"></a>
<a id="tocsservicerow"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unitMeasure": "string",
  "unitMeasureAbbreviation": "string",
  "cpaClassifier": "string",
  "account": "string",
  "revenueAccount": "string",
  "retailRevenueAccount": "string",
  "revenueAdjustmentAccount": "string",
  "wholePrice": 0.1,
  "retailPrice": 0.1,
  "barcode": "string",
  "vat": true,
  "lastModifierName": "string",
  "lastModifyDate": "2019-08-24T14:15:22Z",
  "isClosed": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|fullName|string¦null|false|none|hy-AM: Լրիվ անվանում | en-US: Full name | ru-RU: Полное наименование|
|unitMeasure|string¦null|false|none|hy-AM: Միավոր | en-US: Unit | ru-RU: Единица|
|unitMeasureAbbreviation|string¦null|false|none|hy-AM: Չափման միավոր | en-US: Unit of measure | ru-RU: Единица измерения|
|cpaClassifier|string¦null|false|none|none|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|revenueAccount|string¦null|false|none|hy-AM: Վաճառքից հասույթի հաշիվ | en-US: Revenue account | ru-RU: Счет доходов при опт. продаже|
|retailRevenueAccount|string¦null|false|none|hy-AM: Մանրածախ վաճառքից հասույթի հաշիվ | en-US: Retail revenue account | ru-RU: Счет доходов при розничной продаже|
|revenueAdjustmentAccount|string¦null|false|none|hy-AM: Վաճառքից հետ վերադարձի հասույթի ճշգրտում | en-US: Revenue adjustment account for Sales Return | ru-RU: Корректировка выручки реализации при возврате ТМЦ|
|wholePrice|number(double)|false|none|hy-AM: Մեծածախ գին դրամով | en-US: Whole price in drams | ru-RU: Оптовая цена в драмах|
|retailPrice|number(double)|false|none|hy-AM: Մանրածախ գին դրամով | en-US: Retail price in drams | ru-RU: Розничная цена в драмах|
|barcode|string¦null|false|none|hy-AM: Գծիկավոր կոդ | en-US: Barcode | ru-RU: Штрихкод|
|vat|boolean¦null|false|none|none|
|lastModifierName|string¦null|false|none|hy-AM: Օգտագործող | en-US: User name | ru-RU: Пользователь|
|lastModifyDate|string(date-time)¦null|false|none|hy-AM: Վերջին փոփոխություն | en-US: Last change | ru-RU: Последнее изменение|
|isClosed|boolean|false|none|hy-AM: Փակված | en-US: Closed | ru-RU: Закрыто|

<h2 id="tocS_ServiceRowApiResponse">ServiceRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemaservicerowapiresponse"></a>
<a id="schema_ServiceRowApiResponse"></a>
<a id="tocSservicerowapiresponse"></a>
<a id="tocsservicerowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "cpaClassifier": "string",
      "account": "string",
      "revenueAccount": "string",
      "retailRevenueAccount": "string",
      "revenueAdjustmentAccount": "string",
      "wholePrice": 0.1,
      "retailPrice": 0.1,
      "barcode": "string",
      "vat": true,
      "lastModifierName": "string",
      "lastModifyDate": "2019-08-24T14:15:22Z",
      "isClosed": true
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[ServiceRow](#schemaservicerow)]¦null|false|none|none|

<h2 id="tocS_Storage">Storage</h2>
<!-- backwards compatibility -->
<a id="schemastorage"></a>
<a id="schema_Storage"></a>
<a id="tocSstorage"></a>
<a id="tocsstorage"></a>

```json
{
  "code": "string",
  "name": "string",
  "stockkeeper": "string",
  "address": "string",
  "isClosed": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|stockkeeper|string¦null|false|none|hy-AM: Պահեստապետ | en-US: Stockkeeper | ru-RU: Заведующий складом|
|address|string¦null|false|none|hy-AM: Հասցե | en-US: Address | ru-RU: Адрес|
|isClosed|boolean¦null|false|none|hy-AM: Փակված | en-US: Closed | ru-RU: Закрыто|

<h2 id="tocS_StorageInputOrder">StorageInputOrder</h2>
<!-- backwards compatibility -->
<a id="schemastorageinputorder"></a>
<a id="schema_StorageInputOrder"></a>
<a id="tocSstorageinputorder"></a>
<a id="tocsstorageinputorder"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "supplierCode": "string",
  "supplierName": "string",
  "supplierAccount": "string",
  "prepaymentAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "taxExportType": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "purchasingType": "string",
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "vatInclusionMethod": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccountant": "string",
  "allowed": "string",
  "accepted": "string",
  "transportationDocumentNumber": "string",
  "transportationDocumentDate": "2019-08-24",
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "account": "string",
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)¦null|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|documentNumber|string¦null|false|none|hy-AM: Փաստաթղթի N | en-US: Document N | ru-RU: Номер док.|
|state|integer(int32)|false|none|hy-AM: Վիճակ | en-US: State | ru-RU: Состояние|
|storage|string¦null|false|none|hy-AM: Պահեստ | en-US: Storage | ru-RU: Склад|
|currency|string¦null|false|none|hy-AM: Արժույթ | en-US: Currency | ru-RU: Валюта|
|currencyExchangeRate|number(double)|false|none|hy-AM: Արտարժույթի փոխարժեք | en-US: Currency exchange rate | ru-RU: Курс валюты|
|currencyExchangeBase|number(double)|false|none|hy-AM: Արտարժույթի փոխարժեք | en-US: Currency exchange rate | ru-RU: Курс валюты|
|supplierCode|string¦null|false|none|hy-AM: Մատակարար | en-US: Supplier | ru-RU: Поставщик|
|supplierName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|supplierAccount|string¦null|false|none|hy-AM: Մատակարարի հաշիվ | en-US: Supplier account | ru-RU: Счет поставщика|
|prepaymentAccount|string¦null|false|none|hy-AM: Տրված կանխավճարի հաշիվ | en-US: Prepayment account | ru-RU: Счет авансов выданных|
|analytic1|string¦null|false|none|hy-AM: Անալիտիկ խումբ 1 | en-US: Analytical dimension 1 | ru-RU: Аналитическая группа 1|
|analytic2|string¦null|false|none|hy-AM: Անալիտիկ խումբ 2 | en-US: Analytical dimension 2 | ru-RU: Аналитическая группа 2|
|taxExportType|string¦null|false|none|hy-AM: Դուրս գրման եղանակ | en-US: Electronic/Paper | ru-RU: Метод выписки|
|purchaseDocumentNumber|string¦null|false|none|hy-AM: Ձեռքբերման փաստաթղթի N | en-US: Purchase document N | ru-RU: Номер документа приобретения|
|purchaseDocumentDate|string(date)¦null|false|none|hy-AM: ա/թ. | en-US: Date | ru-RU: Дата|
|comment|string¦null|false|none|hy-AM: Մեկնաբանություն | en-US: Comment | ru-RU: Комментарий|
|purchasingType|string¦null|false|none|hy-AM: ՆԱ-ի ձեռք բերման տեսակ | en-US: Materials purchasing type | ru-RU: Вид поступления ТМЦ|
|vatCalculationType|string¦null|false|none|none|
|includeVATInCost|boolean|false|none|hy-AM: Ներառել ԱԱՀ-ն ինքնարժեքի մեջ | en-US: Include VAT in cost | ru-RU: НДС включить в себестоимость|
|vatInclusionMethod|string¦null|false|none|none|
|discountPercent|number(double)|false|none|hy-AM: Զեղչի տոկոս | en-US: Discount percent | ru-RU: Процент скидки|
|vatAmount|number(double)|false|none|none|
|totalAmount|number(double)|false|none|hy-AM: Ընդհանուր գումար | en-US: Total amount | ru-RU: Общая сумма|
|supplierLegalAddress|string¦null|false|none|hy-AM: Իրավ. հասցե | en-US: Legal address | ru-RU: Юридический адрес|
|supplierBusinessAddress|string¦null|false|none|hy-AM: Գործ. հասցե | en-US: Bus. address | ru-RU: Фактический адрес|
|supplierSettlementAccount|string¦null|false|none|hy-AM: Հաշվարկային հաշիվ | en-US: Settlement account | ru-RU: Банковский счет|
|supplierTaxCode|string¦null|false|none|hy-AM: ՀՎՀՀ | en-US: Taxpayer’s ID | ru-RU: ИНН код|
|supplierManagerPosition|string¦null|false|none|hy-AM: Ղեկավարի պաշտոն | en-US: Manager position | ru-RU: Должность руководителя|
|supplierManagerName|string¦null|false|none|hy-AM: Ղեկավարի Ա.Ա.Հ. | en-US: Manager first name, last name | ru-RU: ФИО руководителя|
|supplierAccountantPosition|string¦null|false|none|hy-AM: Հաշվապահի պաշտոն | en-US: Accountant position | ru-RU: Должность главного бухгалтера|
|supplierAccountantName|string¦null|false|none|hy-AM: Հաշվապահի Ա.Ա.Հ. | en-US: Accountant first name, last name | ru-RU: ФИО главного бухгалтера|
|letterOfAttorney|string¦null|false|none|hy-AM: Լիազորագիր | en-US: Letter of attorney | ru-RU: Доверенность|
|mediator|string¦null|false|none|hy-AM: Միջնորդ | en-US: Mediator | ru-RU: Посредник|
|vehicle|string¦null|false|none|hy-AM: Ավտ/Բեռնարկղ | en-US: Vehicle | ru-RU: Авт/Контейнер|
|chiefAccountant|string¦null|false|none|hy-AM: Գլխավոր հաշվապահ | en-US: Chief accountant | ru-RU: Главный бухгалтер|
|allowed|string¦null|false|none|hy-AM: Թույլատրեց | en-US: Allowed | ru-RU: Разрешил|
|accepted|string¦null|false|none|hy-AM: Ընդունեց | en-US: Accepted | ru-RU: Принял|
|transportationDocumentNumber|string¦null|false|none|hy-AM: Տրանսպորտային փաստաթղթի N | en-US: Transportation document N | ru-RU: Транспортный документ N|
|transportationDocumentDate|string(date)¦null|false|none|hy-AM: ա/թ. | en-US: Date | ru-RU: Дата|
|materialsList|[[StorageInputOrderSpecificationRow](#schemastorageinputorderspecificationrow)]¦null|false|none|hy-AM: Նյութական արժեքների ցուցակ | en-US: Materials list | ru-RU: Список ТМЦ|

<h2 id="tocS_StorageInputOrderSpecificationRow">StorageInputOrderSpecificationRow</h2>
<!-- backwards compatibility -->
<a id="schemastorageinputorderspecificationrow"></a>
<a id="schema_StorageInputOrderSpecificationRow"></a>
<a id="tocSstorageinputorderspecificationrow"></a>
<a id="tocsstorageinputorderspecificationrow"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "unitAbbreviation": "string",
  "quantity": 0.1,
  "price": 0.1,
  "discountPercent": 0.1,
  "discountedPrice": 0.1,
  "amount": 0.1,
  "vat": true,
  "account": "string",
  "cpaClassifier": "string",
  "rowNumber": 0,
  "rowId": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|unitAbbreviation|string¦null|false|none|hy-AM: Միավոր | en-US: Unit | ru-RU: Единица|
|quantity|number(double)|false|none|hy-AM: Քանակ | en-US: Quantity | ru-RU: Количество|
|price|number(double)|false|none|hy-AM: Գին | en-US: Price | ru-RU: Цена|
|discountPercent|number(double)¦null|false|none|hy-AM: Զեղչի տոկոս | en-US: Discount percent | ru-RU: Процент скидки|
|discountedPrice|number(double)¦null|false|none|hy-AM: Զեղչված գին | en-US: Discounted price | ru-RU: Цена со скидкой|
|amount|number(double)¦null|false|none|hy-AM: Գումար | en-US: Amount | ru-RU: Сумма|
|vat|boolean¦null|false|none|none|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|cpaClassifier|string¦null|false|none|none|
|rowNumber|integer(int32)|false|none|hy-AM: Տողի N | en-US: line N | ru-RU: N строки|
|rowId|integer(int32)|false|none|hy-AM: Տողի ID | en-US: Line ID | ru-RU: ID линии|

<h2 id="tocS_StorageInputOrdersAndReceivedServicesDataRow">StorageInputOrdersAndReceivedServicesDataRow</h2>
<!-- backwards compatibility -->
<a id="schemastorageinputordersandreceivedservicesdatarow"></a>
<a id="schema_StorageInputOrdersAndReceivedServicesDataRow"></a>
<a id="tocSstorageinputordersandreceivedservicesdatarow"></a>
<a id="tocsstorageinputordersandreceivedservicesdatarow"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "itemCode": "string",
  "itemName": "string",
  "unitMeasure": "string",
  "unitMeasureAbbreviation": "string",
  "supplierCode": "string",
  "supplierName": "string",
  "supplierTaxCode": "string",
  "quantity": 0.1,
  "currency": "string",
  "price": 0.1,
  "discountPercent": 0.1,
  "discountedPrice": 0.1,
  "amount": 0.1,
  "vat": true,
  "account": "string",
  "cpaClassifier": "string",
  "comment": "string",
  "documentState": 0,
  "documentStateName": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|documentNumber|string¦null|false|none|hy-AM: Փաստաթղթի N | en-US: Document N | ru-RU: Номер док.|
|itemCode|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|itemName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|unitMeasure|string¦null|false|none|hy-AM: Միավոր | en-US: Unit | ru-RU: Единица|
|unitMeasureAbbreviation|string¦null|false|none|hy-AM: Չափման միավոր | en-US: Unit of measure | ru-RU: Единица измерения|
|supplierCode|string¦null|false|none|hy-AM: Մատակարար | en-US: Supplier | ru-RU: Поставщик|
|supplierName|string¦null|false|none|hy-AM: Մատակարարի անվանում | en-US: Supplier name | ru-RU: Наименование поставщика|
|supplierTaxCode|string¦null|false|none|hy-AM: Մատակարարի ՀՎՀՀ | en-US: Supplier tax code | ru-RU: ИНН код поставщика|
|quantity|number(double)|false|none|hy-AM: Քանակ | en-US: Quantity | ru-RU: Количество|
|currency|string¦null|false|none|hy-AM: Արժույթ | en-US: Currency | ru-RU: Валюта|
|price|number(double)|false|none|hy-AM: Գին | en-US: Price | ru-RU: Цена|
|discountPercent|number(double)|false|none|hy-AM: Զեղչի տոկոս | en-US: Discount percent | ru-RU: Процент скидки|
|discountedPrice|number(double)|false|none|hy-AM: Զեղչված գին | en-US: Discounted price | ru-RU: Цена со скидкой|
|amount|number(double)|false|none|hy-AM: Գումար | en-US: Amount | ru-RU: Сумма|
|vat|boolean|false|none|none|
|account|string¦null|false|none|hy-AM: Հաշիվ | en-US: Account | ru-RU: Счет|
|cpaClassifier|string¦null|false|none|none|
|comment|string¦null|false|none|hy-AM: Մեկնաբանություն | en-US: Comment | ru-RU: Комментарий|
|documentState|integer(int32)|false|none|hy-AM: Փաստաթղթի վիճակ | en-US: Document state | ru-RU: Статус документа|
|documentStateName|string¦null|false|none|hy-AM: Փաստաթղթի վիճակ | en-US: Document state | ru-RU: Статус документа|

<h2 id="tocS_StorageInputOrdersAndReceivedServicesDataRowApiResponse">StorageInputOrdersAndReceivedServicesDataRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemastorageinputordersandreceivedservicesdatarowapiresponse"></a>
<a id="schema_StorageInputOrdersAndReceivedServicesDataRowApiResponse"></a>
<a id="tocSstorageinputordersandreceivedservicesdatarowapiresponse"></a>
<a id="tocsstorageinputordersandreceivedservicesdatarowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "itemCode": "string",
      "itemName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "supplierCode": "string",
      "supplierName": "string",
      "supplierTaxCode": "string",
      "quantity": 0.1,
      "currency": "string",
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "account": "string",
      "cpaClassifier": "string",
      "comment": "string",
      "documentState": 0,
      "documentStateName": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[StorageInputOrdersAndReceivedServicesDataRow](#schemastorageinputordersandreceivedservicesdatarow)]¦null|false|none|none|

<h2 id="tocS_StorageInputOrdersAndReceivedServicesParam">StorageInputOrdersAndReceivedServicesParam</h2>
<!-- backwards compatibility -->
<a id="schemastorageinputordersandreceivedservicesparam"></a>
<a id="schema_StorageInputOrdersAndReceivedServicesParam"></a>
<a id="tocSstorageinputordersandreceivedservicesparam"></a>
<a id="tocsstorageinputordersandreceivedservicesparam"></a>

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "documentType": "string",
  "itemCode": "string",
  "documentState": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|hy-AM:  էջ  | en-US:  page | ru-RU: страница|
|startDate|string(date)|false|none|hy-AM: Ժամանակահատվածի սկիզբ | en-US: Period begin | ru-RU: Начало периода|
|endDate|string(date)|false|none|hy-AM: Ժամանակահատվածի վերջ | en-US: Period end | ru-RU: Конец периода|
|documentType|string¦null|false|none|hy-AM: Փաստաթղթի տեսակ | en-US: Document type | ru-RU: Вид документа|
|itemCode|string¦null|false|none|hy-AM: Նյութական արժեք կամ ծառայություն | en-US: Material or service | ru-RU: ТМЦ или услуга|
|documentState|string¦null|false|none|hy-AM: Փաստաթղթի վիճակ | en-US: Document state | ru-RU: Статус документа|

<h2 id="tocS_StorageOutputOrder">StorageOutputOrder</h2>
<!-- backwards compatibility -->
<a id="schemastorageoutputorder"></a>
<a id="schema_StorageOutputOrder"></a>
<a id="tocSstorageoutputorder"></a>
<a id="tocsstorageoutputorder"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "expenseAccount": "string",
  "analytic1": "string",
  "analytic2": "string",
  "comment": "string",
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccountant": "string",
  "allowed": "string",
  "requested": "string",
  "totalAmount": 0.1,
  "materialsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "amount": 0.1,
      "rowId": 0
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)¦null|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|documentNumber|string¦null|false|none|hy-AM: Փաստաթղթի N | en-US: Document N | ru-RU: Номер док.|
|state|integer(int32)|false|none|hy-AM: Վիճակ | en-US: State | ru-RU: Состояние|
|storage|string¦null|false|none|hy-AM: Պահեստ | en-US: Storage | ru-RU: Склад|
|expenseAccount|string¦null|false|none|hy-AM: Ծախսի հաշիվ | en-US: Expense account | ru-RU: Счет расходов|
|analytic1|string¦null|false|none|hy-AM: Անալիտիկ խումբ 1 | en-US: Analytical dimension 1 | ru-RU: Аналитическая группа 1|
|analytic2|string¦null|false|none|hy-AM: Անալիտիկ խումբ 2 | en-US: Analytical dimension 2 | ru-RU: Аналитическая группа 2|
|comment|string¦null|false|none|hy-AM: Մեկնաբանություն | en-US: Comment | ru-RU: Комментарий|
|letterOfAttorney|string¦null|false|none|hy-AM: Լիազորագիր | en-US: Letter of attorney | ru-RU: Доверенность|
|mediator|string¦null|false|none|hy-AM: Միջնորդ | en-US: Mediator | ru-RU: Посредник|
|vehicle|string¦null|false|none|hy-AM: Ավտ/Բեռնարկղ | en-US: Vehicle | ru-RU: Авт/Контейнер|
|chiefAccountant|string¦null|false|none|hy-AM: Գլխավոր հաշվապահ | en-US: Chief accountant | ru-RU: Главный бухгалтер|
|allowed|string¦null|false|none|hy-AM: Թույլատրեց | en-US: Allowed | ru-RU: Разрешил|
|requested|string¦null|false|none|hy-AM: Պահանջել է | en-US: Requested | ru-RU: По требованию|
|totalAmount|number(double)|false|none|hy-AM: Ընդհանուր գումար | en-US: Total amount | ru-RU: Общая сумма|
|materialsList|[[StorageOutputOrderSpecificationRow](#schemastorageoutputorderspecificationrow)]¦null|false|none|hy-AM: Նյութական արժեքների ցուցակ | en-US: Materials list | ru-RU: Список ТМЦ|

<h2 id="tocS_StorageOutputOrderSpecificationRow">StorageOutputOrderSpecificationRow</h2>
<!-- backwards compatibility -->
<a id="schemastorageoutputorderspecificationrow"></a>
<a id="schema_StorageOutputOrderSpecificationRow"></a>
<a id="tocSstorageoutputorderspecificationrow"></a>
<a id="tocsstorageoutputorderspecificationrow"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "unitAbbreviation": "string",
  "quantity": 0.1,
  "amount": 0.1,
  "rowId": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|unitAbbreviation|string¦null|false|none|hy-AM: Միավոր | en-US: Unit | ru-RU: Единица|
|quantity|number(double)|false|none|hy-AM: Քանակ | en-US: Quantity | ru-RU: Количество|
|amount|number(double)|false|none|hy-AM: Գումար | en-US: Amount | ru-RU: Сумма|
|rowId|integer(int32)|false|none|hy-AM: Տողի ID | en-US: Line ID | ru-RU: ID линии|

<h2 id="tocS_TransactionsDataRow">TransactionsDataRow</h2>
<!-- backwards compatibility -->
<a id="schematransactionsdatarow"></a>
<a id="schema_TransactionsDataRow"></a>
<a id="tocStransactionsdatarow"></a>
<a id="tocstransactionsdatarow"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "type": 0,
  "typeName": "string",
  "debitAccount": "string",
  "debitAccountType": "string",
  "debitCurrency": "string",
  "debitPartner": "string",
  "debitPartnerName": "string",
  "debitPartnerGroup": "string",
  "debitPartnerTaxCode": "string",
  "debitAnalytic1": "string",
  "debitAnalytic1Name": "string",
  "debitAnalytic2": "string",
  "debitAnalytic2Name": "string",
  "creditAccount": "string",
  "creditAccountType": "string",
  "creditCurrency": "string",
  "creditPartner": "string",
  "creditPartnerName": "string",
  "creditPartnerGroup": "string",
  "creditPartnerTaxCode": "string",
  "creditAnalytic1": "string",
  "creditAnalytic1Name": "string",
  "creditAnalytic2": "string",
  "creditAnalytic2Name": "string",
  "amount": 0.1,
  "currencyAmount": 0.1,
  "comment": "string",
  "userName": "string",
  "systemGenerated": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|documentNumber|string¦null|false|none|hy-AM: Փաստաթղթի N | en-US: Document N | ru-RU: Номер док.|
|type|integer(int32)|false|none|hy-AM: Տեսակ | en-US: Type | ru-RU: Вид|
|typeName|string¦null|false|none|hy-AM: Տեսակ | en-US: Type | ru-RU: Вид|
|debitAccount|string¦null|false|none|hy-AM: Դեբետ | en-US: Debit | ru-RU: Дебет|
|debitAccountType|string¦null|false|none|hy-AM: Հաշվի տեսակ | en-US: Invoice type | ru-RU: Вид счета|
|debitCurrency|string¦null|false|none|hy-AM: Դեբետ արժ. | en-US: Debit curr. | ru-RU: Дебет валюта|
|debitPartner|string¦null|false|none|hy-AM: Դեբետ գործ. | en-US: Debit part. | ru-RU: Дебет партн.|
|debitPartnerName|string¦null|false|none|hy-AM: Դեբետ-անվանում | en-US: Debit-name | ru-RU: Дебет-наименование|
|debitPartnerGroup|string¦null|false|none|hy-AM: Դեբետ-խումբ | en-US: Debit-group | ru-RU: Дебет-группа|
|debitPartnerTaxCode|string¦null|false|none|hy-AM: Դեբետ-ՀՎՀՀ | en-US: Debit - Taxpayer’s ID | ru-RU: Дебет-ИНН|
|debitAnalytic1|string¦null|false|none|hy-AM: Անալիտիկ խումբ 1 | en-US: Analytical dimension 1 | ru-RU: Аналитическая группа 1|
|debitAnalytic1Name|string¦null|false|none|hy-AM: Անալիտիկ խումբ 1 | en-US: Analytical dimension 1 | ru-RU: Аналитическая группа 1|
|debitAnalytic2|string¦null|false|none|hy-AM: Անալիտիկ խումբ 2 | en-US: Analytical dimension 2 | ru-RU: Аналитическая группа 2|
|debitAnalytic2Name|string¦null|false|none|hy-AM: Անալիտիկ խումբ 2 | en-US: Analytical dimension 2 | ru-RU: Аналитическая группа 2|
|creditAccount|string¦null|false|none|hy-AM: Կրեդիտ | en-US: Credit | ru-RU: Кредит|
|creditAccountType|string¦null|false|none|hy-AM: Հաշվի տեսակ | en-US: Invoice type | ru-RU: Вид счета|
|creditCurrency|string¦null|false|none|hy-AM: Կրեդիտ արժ. | en-US: Credit curr. | ru-RU: Кредит валюта|
|creditPartner|string¦null|false|none|hy-AM: Կրեդիտ գործ. | en-US: Credit part. | ru-RU: Кредит партн.|
|creditPartnerName|string¦null|false|none|hy-AM: Կրեդիտ-անվանում | en-US: Credit-name | ru-RU: Кредит-наименование|
|creditPartnerGroup|string¦null|false|none|hy-AM: Կրեդիտ-խումբ | en-US: Credit-group | ru-RU: Кредит-группа|
|creditPartnerTaxCode|string¦null|false|none|hy-AM: Կրեդիտ-ՀՎՀՀ | en-US: Credit - Taxpayer’s ID | ru-RU: Кредит-ИНН|
|creditAnalytic1|string¦null|false|none|hy-AM: Անալիտիկ խումբ 1 | en-US: Analytical dimension 1 | ru-RU: Аналитическая группа 1|
|creditAnalytic1Name|string¦null|false|none|hy-AM: Անալիտիկ խումբ 1 | en-US: Analytical dimension 1 | ru-RU: Аналитическая группа 1|
|creditAnalytic2|string¦null|false|none|hy-AM: Անալիտիկ խումբ 2 | en-US: Analytical dimension 2 | ru-RU: Аналитическая группа 2|
|creditAnalytic2Name|string¦null|false|none|hy-AM: Անալիտիկ խումբ 2 | en-US: Analytical dimension 2 | ru-RU: Аналитическая группа 2|
|amount|number(double)|false|none|hy-AM: Գումար դրամով | en-US: Amount in Dram | ru-RU: Сумма в драмах|
|currencyAmount|number(double)|false|none|hy-AM: Գումար արժ. | en-US: Amount in curr. | ru-RU: Сумма в валюте|
|comment|string¦null|false|none|hy-AM: Մեկնաբանություն | en-US: Comment | ru-RU: Комментарий|
|userName|string¦null|false|none|hy-AM: Օգտագործող | en-US: User name | ru-RU: Пользователь|
|systemGenerated|boolean|false|none|hy-AM: Համակարգային | en-US: System | ru-RU: Системный|

<h2 id="tocS_TransactionsDataRowApiResponse">TransactionsDataRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schematransactionsdatarowapiresponse"></a>
<a id="schema_TransactionsDataRowApiResponse"></a>
<a id="tocStransactionsdatarowapiresponse"></a>
<a id="tocstransactionsdatarowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "type": 0,
      "typeName": "string",
      "debitAccount": "string",
      "debitAccountType": "string",
      "debitCurrency": "string",
      "debitPartner": "string",
      "debitPartnerName": "string",
      "debitPartnerGroup": "string",
      "debitPartnerTaxCode": "string",
      "debitAnalytic1": "string",
      "debitAnalytic1Name": "string",
      "debitAnalytic2": "string",
      "debitAnalytic2Name": "string",
      "creditAccount": "string",
      "creditAccountType": "string",
      "creditCurrency": "string",
      "creditPartner": "string",
      "creditPartnerName": "string",
      "creditPartnerGroup": "string",
      "creditPartnerTaxCode": "string",
      "creditAnalytic1": "string",
      "creditAnalytic1Name": "string",
      "creditAnalytic2": "string",
      "creditAnalytic2Name": "string",
      "amount": 0.1,
      "currencyAmount": 0.1,
      "comment": "string",
      "userName": "string",
      "systemGenerated": true
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[TransactionsDataRow](#schematransactionsdatarow)]¦null|false|none|none|

<h2 id="tocS_TransactionsParam">TransactionsParam</h2>
<!-- backwards compatibility -->
<a id="schematransactionsparam"></a>
<a id="schema_TransactionsParam"></a>
<a id="tocStransactionsparam"></a>
<a id="tocstransactionsparam"></a>

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "debitAccount": "string",
  "creditAccount": "string",
  "accountsANDCondition": true,
  "debitPartner": "string",
  "creditPartner": "string",
  "partnersANDCondition": true,
  "debitAnalytic1": "string",
  "creditAnalytic1": "string",
  "analytics1ANDCondition": true,
  "debitAnalytic2": "string",
  "creditAnalytic2": "string",
  "analytics2ANDCondition": true,
  "debitCurrency": "string",
  "creditCurrency": "string",
  "currenciesANDCondition": true,
  "documentTypes": [
    "string"
  ],
  "showPartners": true,
  "showAnalytics1": true,
  "showAnalytics2": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|hy-AM:  էջ  | en-US:  page | ru-RU: страница|
|startDate|string(date)|false|none|hy-AM: Ժամանակահատվածի սկիզբ | en-US: Period begin | ru-RU: Начало периода|
|endDate|string(date)|false|none|hy-AM: Ժամանակահատվածի վերջ | en-US: Period end | ru-RU: Конец периода|
|debitAccount|string¦null|false|none|hy-AM: Դեբետ | en-US: Debit | ru-RU: Дебет|
|creditAccount|string¦null|false|none|hy-AM: Կրեդիտ | en-US: Credit | ru-RU: Кредит|
|accountsANDCondition|boolean|false|none|hy-AM: և | en-US: and | ru-RU: и|
|debitPartner|string¦null|false|none|hy-AM: Դեբետ գործ. | en-US: Debit part. | ru-RU: Дебет партн.|
|creditPartner|string¦null|false|none|hy-AM: Կրեդիտ գործ. | en-US: Credit part. | ru-RU: Кредит партн.|
|partnersANDCondition|boolean|false|none|hy-AM: և | en-US: and | ru-RU: и|
|debitAnalytic1|string¦null|false|none|hy-AM: Ան.խումբ 1 | en-US: An. dimension 1 | ru-RU: Ан.группа 1|
|creditAnalytic1|string¦null|false|none|hy-AM: Ան.խումբ 1 | en-US: An. dimension 1 | ru-RU: Ан.группа 1|
|analytics1ANDCondition|boolean|false|none|hy-AM: և | en-US: and | ru-RU: и|
|debitAnalytic2|string¦null|false|none|hy-AM: Ան.խումբ 2 | en-US: An. dimension 2 | ru-RU: Ан.группа 2|
|creditAnalytic2|string¦null|false|none|hy-AM: Ան.խումբ 2 | en-US: An. dimension 2 | ru-RU: Ан.группа 2|
|analytics2ANDCondition|boolean|false|none|hy-AM: և | en-US: and | ru-RU: и|
|debitCurrency|string¦null|false|none|hy-AM: Դեբետ արժ. | en-US: Debit curr. | ru-RU: Дебет валюта|
|creditCurrency|string¦null|false|none|hy-AM: Կրեդիտ արժ. | en-US: Credit curr. | ru-RU: Кредит валюта|
|currenciesANDCondition|boolean|false|none|hy-AM: և | en-US: and | ru-RU: и|
|documentTypes|[string]¦null|false|none|hy-AM: Փաստաթղթի տեսակ | en-US: Document type | ru-RU: Вид документа|
|showPartners|boolean|false|none|hy-AM: Ցույց տալ գործընկերներին | en-US: Show the partners | ru-RU: Показать данные по партнерам|
|showAnalytics1|boolean|false|none|hy-AM: Ցույց տալ անալիտիկ խումբ 1 | en-US: Show the analytical dim. 1 | ru-RU: Показать аналитическая группа 1|
|showAnalytics2|boolean|false|none|hy-AM: Ցույց տալ անալիտիկ խումբ 2 | en-US: Show the analytical dim. 2 | ru-RU: Показать аналитическая группа 2|

<h2 id="tocS_TransferInvoice">TransferInvoice</h2>
<!-- backwards compatibility -->
<a id="schematransferinvoice"></a>
<a id="schema_TransferInvoice"></a>
<a id="tocStransferinvoice"></a>
<a id="tocstransferinvoice"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "state": 0,
  "contract": "string",
  "contractDate": "2019-08-24",
  "comment": "string",
  "vatCalculationType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)¦null|false|none|hy-AM: Ամսաթիվ | en-US: Date | ru-RU: Дата|
|documentNumber|string¦null|false|none|hy-AM: Փաստաթղթի N | en-US: Document N | ru-RU: Номер док.|
|customer|string¦null|false|none|hy-AM: Գնորդ | en-US: Customer | ru-RU: Покупатель|
|currency|string¦null|false|none|hy-AM: Արժույթ | en-US: Currency | ru-RU: Валюта|
|currencyExchangeRate|number(double)|false|none|hy-AM: Արտարժույթի փոխարժեք | en-US: Currency exchange rate | ru-RU: Курс валюты|
|currencyExchangeBase|number(double)|false|none|hy-AM: Արտարժույթի փոխարժեք | en-US: Currency exchange rate | ru-RU: Курс валюты|
|state|integer(int32)|false|none|hy-AM: Վիճակ | en-US: State | ru-RU: Состояние|
|contract|string¦null|false|none|hy-AM: Պայմանագիր | en-US: Contract | ru-RU: Договор|
|contractDate|string(date)¦null|false|none|hy-AM: Պայմանագրի ամսաթիվը | en-US: Contract date | ru-RU: Дата договора|
|comment|string¦null|false|none|hy-AM: Մեկնաբանություն | en-US: Comment | ru-RU: Комментарий|
|vatCalculationType|string¦null|false|none|none|
|storage|string¦null|false|none|hy-AM: Պահեստ | en-US: Storage | ru-RU: Склад|
|discountPercent|number(double)|false|none|hy-AM: Զեղչի տոկոս | en-US: Discount percent | ru-RU: Процент скидки|
|vatAmount|number(double)|false|none|none|
|totalAmount|number(double)|false|none|hy-AM: Ընդհանուր գումար | en-US: Total amount | ru-RU: Общая сумма|
|supplierBusinessAddress|string¦null|false|none|hy-AM: Գործ. հասցե | en-US: Bus. address | ru-RU: Фактический адрес|
|supplierSettlementAccount|string¦null|false|none|hy-AM: Հաշվարկային հաշիվ | en-US: Settlement account | ru-RU: Банковский счет|
|supplierManagerPosition|string¦null|false|none|hy-AM: Ղեկավարի պաշտոն | en-US: Manager position | ru-RU: Должность руководителя|
|supplierManagerName|string¦null|false|none|hy-AM: Ղեկավարի Ա.Ա.Հ. | en-US: Manager first name, last name | ru-RU: ФИО руководителя|
|supplierAccountantPosition|string¦null|false|none|hy-AM: Հաշվապահի պաշտոն | en-US: Accountant position | ru-RU: Должность главного бухгалтера|
|supplierAccountantName|string¦null|false|none|hy-AM: Հաշվապահի Ա.Ա.Հ. | en-US: Accountant first name, last name | ru-RU: ФИО главного бухгалтера|
|customerName|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|customerLegalAddress|string¦null|false|none|hy-AM: Իրավ. հասցե | en-US: Legal address | ru-RU: Юридический адрес|
|customerBusinessAddress|string¦null|false|none|hy-AM: Գործ. հասցե | en-US: Bus. address | ru-RU: Фактический адрес|
|customerSettlementAccount|string¦null|false|none|hy-AM: Հաշվարկային հաշիվ | en-US: Settlement account | ru-RU: Банковский счет|
|customerTaxCode|string¦null|false|none|hy-AM: ՀՎՀՀ | en-US: Taxpayer’s ID | ru-RU: ИНН код|
|customerManagerPosition|string¦null|false|none|hy-AM: Ղեկավարի պաշտոն | en-US: Manager position | ru-RU: Должность руководителя|
|customerManagerName|string¦null|false|none|hy-AM: Ղեկավարի Ա.Ա.Հ. | en-US: Manager first name, last name | ru-RU: ФИО руководителя|
|customerAccountantPosition|string¦null|false|none|hy-AM: Հաշվապահի պաշտոն | en-US: Accountant position | ru-RU: Должность главного бухгалтера|
|customerAccountantName|string¦null|false|none|hy-AM: Հաշվապահի Ա.Ա.Հ. | en-US: Accountant first name, last name | ru-RU: ФИО главного бухгалтера|
|stateRegisterNumber|string¦null|false|none|hy-AM: Ա/Ձ-ի պետ. գրանց. վկ. N | en-US: S/P state regist. N | ru-RU: Гос. рег. номер ИП|
|passportNumber|string¦null|false|none|hy-AM: Անձնագրի համար | en-US: Passport N | ru-RU: Номер паспорта|
|itemList|[[TransferInvoiceSpecificationRow](#schematransferinvoicespecificationrow)]¦null|false|none|hy-AM: Անվանացուցակ | en-US: Items list | ru-RU: Список товаров и услуг|

<h2 id="tocS_TransferInvoiceSpecificationRow">TransferInvoiceSpecificationRow</h2>
<!-- backwards compatibility -->
<a id="schematransferinvoicespecificationrow"></a>
<a id="schema_TransferInvoiceSpecificationRow"></a>
<a id="tocStransferinvoicespecificationrow"></a>
<a id="tocstransferinvoicespecificationrow"></a>

```json
{
  "type": "string",
  "storage": "string",
  "id": 0,
  "code": "string",
  "name": "string",
  "unitAbbreviation": "string",
  "quantity": 0.1,
  "price": 0.1,
  "discountPercent": 0.1,
  "discountedPrice": 0.1,
  "amount": 0.1,
  "vat": true,
  "rowNumber": 0,
  "rowId": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|string¦null|false|none|hy-AM: Տեսակ | en-US: Type | ru-RU: Вид|
|storage|string¦null|false|none|hy-AM: Պահեստ | en-US: Storage | ru-RU: Склад|
|id|integer(int32)|false|none|hy-AM: Ներքին համար | en-US: Inner number | ru-RU: Внутренний номер|
|code|string¦null|false|none|hy-AM: Կոդ | en-US: Code | ru-RU: Код|
|name|string¦null|false|none|hy-AM: Անվանում | en-US: Name | ru-RU: Наименование|
|unitAbbreviation|string¦null|false|none|hy-AM: Միավոր | en-US: Unit | ru-RU: Единица|
|quantity|number(double)|false|none|hy-AM: Քանակ | en-US: Quantity | ru-RU: Количество|
|price|number(double)|false|none|hy-AM: Գին | en-US: Price | ru-RU: Цена|
|discountPercent|number(double)¦null|false|none|hy-AM: Զեղչի տոկոս | en-US: Discount percent | ru-RU: Процент скидки|
|discountedPrice|number(double)¦null|false|none|hy-AM: Զեղչված գին | en-US: Discounted price | ru-RU: Цена со скидкой|
|amount|number(double)¦null|false|none|hy-AM: Գումար | en-US: Amount | ru-RU: Сумма|
|vat|boolean¦null|false|none|none|
|rowNumber|integer(int32)|false|none|hy-AM: Տողի N | en-US: line N | ru-RU: N строки|
|rowId|integer(int32)|false|none|hy-AM: Տողի ID | en-US: Line ID | ru-RU: ID линии|

