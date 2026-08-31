// Example: create a employee

var client = new EmployeesClient("{your-api-key}");
var created = await client.CreateAsync(new
{
    code = "0001",
    fullName = "Sample Employee",
    departmentCode = "01",
    positionCode = "01",
    employmentStartDate = "2026-01-15",
    salaryAccount = "5270"
});

Console.WriteLine(created);
