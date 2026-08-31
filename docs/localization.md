# Localization

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api.htm)

The API supports three locales for human-readable display fields (e.g. `typeName`, `groupName`, `stateName`).

## Accept-Language Header

Pass the desired locale in the `Accept-Language` request header:

| Value | Language |
|-------|----------|
| `hy-AM` | Armenian (default) |
| `en-US` | English |
| `ru-RU` | Russian |

**Example:**

```http
POST /directories/materials/list
Accept-Language: en-US
apiKey: {your-api-key}
```

When `Accept-Language` is omitted, the API defaults to `hy-AM`.

> **Note:** Localised fields are display strings only. All code and identifier fields are locale-independent.

## Field labels in the specification

Every property in [`swagger.json`](https://github.com/armsoft/accountant-public-api-docs/blob/main/swagger.json)
carries its Armenian, English and Russian label in the `description`, in the form:

```
hy-AM: Կոդ | en-US: Code | ru-RU: Код
```

The field tables in this documentation show the `en-US` label. Use the specification directly when
you need to render the Armenian or Russian caption for a field.
