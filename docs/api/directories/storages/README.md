# Storages API

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_storages.htm)

Storages endpoints map to `StoragesController` in API version `v1`.

## Endpoints

- [List Storages](list.md)
- [Create Storage](create.md)
- [Get Storage](get.md)
- [Update Storage](update.md)
- [Delete Storage](delete.md)

## Base Path

`/accountant/v1/directories/storages`

## `Storage` fields

| Field | Type | Description |
|-------|------|-------------|
| `code` | string | Code |
| `name` | string | Name |
| `stockkeeper` | string | Stockkeeper |
| `address` | string | Address |
| `isClosed` | boolean | Closed |
