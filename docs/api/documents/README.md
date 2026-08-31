# Documents API

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_documents.htm)

Document endpoints create and maintain accounting documents in the ArmSoft SME Accountant system.

## Online Documentation Links

- [Invoice](https://online.armsoft.am/acc7/rest_api_invoice.htm)
- [Retail Sale](https://online.armsoft.am/acc7/rest_api_retailsale.htm)
- [Transfer Invoice](https://online.armsoft.am/acc7/rest_api_transfer_invoice.htm)
- [Memorial Order](https://online.armsoft.am/acc7/rest_api_memorial_order.htm)
- [Payment Order](https://online.armsoft.am/acc7/rest_api_paymentorder.htm)
- [Storage Input Order](https://online.armsoft.am/acc7/rest_api_storageinputorder.htm)
- [Storage Output Order](https://online.armsoft.am/acc7/rest_api_storageoutputorder.htm)
- [Materials Movement](https://online.armsoft.am/acc7/rest_api_materialsmovement.htm)
- [Materials Kitting](https://online.armsoft.am/acc7/rest_api_materialskitting.htm)
- [Overhead Expense Allocation](https://online.armsoft.am/acc7/rest_api_overheadexpenseallocation.htm)
- [Received Service](https://online.armsoft.am/acc7/rest_api_receivedservice.htm)
- [Fixed Asset Acquisition](https://online.armsoft.am/acc7/rest_api_fixedassetacquisition.htm)
- [Fixed Asset Disposal Act](https://online.armsoft.am/acc7/rest_api_fixedassetdisposalact.htm)
- [Cash Input Order](https://online.armsoft.am/acc7/rest_api_cashinputorder.htm)
- [Cash Output Order](https://online.armsoft.am/acc7/rest_api_cashoutputorder.htm)

## Endpoints

- [Invoice](invoice.md)
- [Retail Sale](retailsale.md)
- [Transfer Invoice](transferinvoice.md)
- [Memorial Order](memorialorder.md)
- [Payment Order](paymentorder.md)
- [Storage Input Order](storageinputorder.md)
- [Storage Output Order](storageoutputorder.md)
- [Materials Movement](materialsmovement.md)
- [Materials Kitting](materialskitting.md)
- [Overhead Expense Allocation](overheadexpenseallocation.md)
- [Received Service](receivedservice.md) — *not published yet*
- [Fixed Asset Acquisition](fixedassetacquisition.md) — *not published yet*
- [Fixed Asset Disposal Act](fixedassetdisposalact.md) — *not published yet*
- [Cash Input Order](cashinputorder.md) — *not published yet*
- [Cash Output Order](cashoutputorder.md) — *not published yet*

## Overview

| Document | Base route | Purpose | Status |
|----------|-----------|---------|--------|
| [Invoice](invoice.md) | `/v1/documents/invoice` | Tax invoices issued to a customer | Published |
| [Retail Sale](retailsale.md) | `/v1/documents/retailsale` | Retail sales registered against a cash desk | Published |
| [Transfer Invoice](transferinvoice.md) | `/v1/documents/transferinvoice` | Transfer invoices (invoices for payment) | Published |
| [Memorial Order](memorialorder.md) | `/v1/documents/memorialorder` | Free-form accounting entries (memorial orders) | Published |
| [Payment Order](paymentorder.md) | `/v1/documents/paymentorder` | Payment orders sent to the bank | Published |
| [Storage Input Order](storageinputorder.md) | `/v1/documents/storageinputorder` | Materials received into a storage | Published |
| [Storage Output Order](storageoutputorder.md) | `/v1/documents/storageoutputorder` | Materials written off from a storage | Published |
| [Materials Movement](materialsmovement.md) | `/v1/documents/materialsmovement` | Materials moved between two storages | Published |
| [Materials Kitting](materialskitting.md) | `/v1/documents/materialskitting` | Assembling a kit from its component materials | Published |
| [Overhead Expense Allocation](overheadexpenseallocation.md) | `/v1/documents/overheadexpenseallocation` | Allocating overhead expenses across received materials | Published |
| [Received Service](receivedservice.md) | `/v1/documents/receivedservice` | Services received from a supplier | Not published yet. |
| [Fixed Asset Acquisition](fixedassetacquisition.md) | `/v1/documents/fixedassetacquisition` | Acquiring a fixed asset and putting it into operation | Not published yet. |
| [Fixed Asset Disposal Act](fixedassetdisposalact.md) | `/v1/documents/fixedassetdisposalact` | Writing fixed assets off the balance sheet | Not published yet. |
| [Cash Input Order](cashinputorder.md) | `/v1/documents/cashinputorder` | Cash received into a cash desk | Not published yet. |
| [Cash Output Order](cashoutputorder.md) | `/v1/documents/cashoutputorder` | Cash paid out of a cash desk | Not published yet. |

## Common shape

Every document type exposes the same four operations:

| Method | Route | Description |
|--------|-------|-------------|
| POST | `/documents/{document}` | Create the document |
| GET | `/documents/{document}/{isn}` | Get the document by ISN |
| PUT | `/documents/{document}/{isn}` | Update the document |
| DELETE | `/documents/{document}/{isn}` | Delete the document |

`isn` is the internal serial number (a UUID) assigned when the document is created; it is the
identifier used by every subsequent call. `state` reports the document state as maintained by
the Accountant system.

## Base Path

`/accountant/v1/documents`
