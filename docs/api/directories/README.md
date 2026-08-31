# Directories API

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_directories.htm)

Directory endpoints expose the master data of the ArmSoft SME Accountant system.

## Available directories

- [Partners](partners/README.md)
- [Materials](materials/README.md)
- [Services](services/README.md)
- [Employees](employees/README.md)
- [Storages](storages/README.md)

## Common shape

Every directory except Storages exposes the same six operations:

| Method | Route | Description |
|--------|-------|-------------|
| POST | `/directories/{directory}/list` | List records with filters |
| POST | `/directories/{directory}/list/nextpage` | Fetch the next page |
| POST | `/directories/{directory}` | Create a record |
| GET | `/directories/{directory}/{code}` | Get a record by code |
| PUT | `/directories/{directory}/{code}` | Update a record |
| DELETE | `/directories/{directory}/{code}` | Delete a record |

Storages returns its full list from `GET /directories/storages` instead, and therefore has no
`/list` or `/nextpage` calls.

## Base Path

`/accountant/v1/directories`
