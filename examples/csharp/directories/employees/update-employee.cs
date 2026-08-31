// Example: update a employee
// Send the complete object - omitted properties are cleared.

var client = new EmployeesClient("{your-api-key}");
var updated = await client.UpdateAsync("0001", new
{
    code = "0001",
    fullName = "Sample Employee",
    departmentCode = "01",
    positionCode = "01",
    employmentStartDate = "2026-01-15",
    salaryAccount = "5270"
});

Console.WriteLine(updated);
