# Materials Groups API

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_materialsgroups.htm)

Materials Groups endpoints map to `MaterialsGroupsController` in API version `v1`.

## Endpoints

- [List Materials Groups](list.md)
- [Create Materials Group](create.md)
- [Get Materials Group](get.md)
- [Update Materials Group](update.md)
- [Delete Materials Group](delete.md)

## Base Path

`/accountant/v1/directories/materialsgroups`

## `MaterialsGroup` fields

| Field | Type | Description |
|-------|------|-------------|
| `code` | string | Code. When omitted on create, the system assigns the next sequential code |
| `name` | string | Name |
| `parent` | string | Parent - code of the group this group is nested under; empty for a top-level group |
| `path` | string | Hierarchy path of the group, maintained by the system (read-only) |

Groups form a tree through `parent`. A material refers to its group through the `group` field
of the [Materials](../materials/README.md) directory.
