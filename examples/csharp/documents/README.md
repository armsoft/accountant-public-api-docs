# C# Document Examples

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_documents.htm)

- [`DocumentsClient.cs`](DocumentsClient.cs) — one wrapper covering every document type

Create examples:

- [`create-invoice.cs`](create-invoice.cs) — Invoice
- [`create-retailsale.cs`](create-retailsale.cs) — Retail Sale
- [`create-transferinvoice.cs`](create-transferinvoice.cs) — Transfer Invoice
- [`create-memorialorder.cs`](create-memorialorder.cs) — Memorial Order
- [`create-paymentorder.cs`](create-paymentorder.cs) — Payment Order
- [`create-storageinputorder.cs`](create-storageinputorder.cs) — Storage Input Order
- [`create-storageoutputorder.cs`](create-storageoutputorder.cs) — Storage Output Order
- [`create-materialsmovement.cs`](create-materialsmovement.cs) — Materials Movement
- [`create-materialskitting.cs`](create-materialskitting.cs) — Materials Kitting
- [`create-overheadexpenseallocation.cs`](create-overheadexpenseallocation.cs) — Overhead Expense Allocation
- [`create-receivedservice.cs`](create-receivedservice.cs) — Received Service *(not published yet)*
- [`create-fixedassetacquisition.cs`](create-fixedassetacquisition.cs) — Fixed Asset Acquisition *(not published yet)*
- [`create-fixedassetdisposalact.cs`](create-fixedassetdisposalact.cs) — Fixed Asset Disposal Act *(not published yet)*
- [`create-cashinputorder.cs`](create-cashinputorder.cs) — Cash Input Order *(not published yet)*
- [`create-cashoutputorder.cs`](create-cashoutputorder.cs) — Cash Output Order *(not published yet)*

Read / update / delete:

- [`get-document.cs`](get-document.cs)

Documents are addressed by their `isn` (a UUID) which the create call returns.

See [Documents API](../../../docs/api/documents/README.md) for the endpoint reference.
