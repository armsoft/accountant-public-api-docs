# Journals API

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_journals.htm)

Journals endpoints map to `JournalsController` in API version `v1`. Every journal takes a period
and optional filters, returns paginated rows, and has a matching `/nextpage` call.

## Documentation links

- [All Documents Online docs](https://online.armsoft.am/acc7/rest_api_alldocuments.htm)
- [Invoices Online docs](https://online.armsoft.am/acc7/rest_api_invoices.htm)
- [ECR Checks Online docs](https://online.armsoft.am/acc7/rest_api_ecr_checks.htm)

## Endpoints

- [All Documents](alldocuments.md) / [Next Page](alldocuments-nextpage.md)
- [Invoices](invoices.md) / [Next Page](invoices-nextpage.md)
- [ECR Checks](ecrchecks.md) / [Next Page](ecrchecks-nextpage.md)

## Overview

| Journal | Route | Contents |
|---------|-------|----------|
| [All Documents](alldocuments.md) | `/v1/journals/alldocuments` | Every document registered in the given period, regardless of its type |
| [Invoices](invoices.md) | `/v1/journals/invoices` | Invoice documents (tax invoices and related types) for the given period |
| [ECR Checks](ecrchecks.md) | `/v1/journals/ecrchecks` | Electronic cash register checks for the given period |

## Base Path

`/accountant/v1/journals`
