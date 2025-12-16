namespace RadzenHierarchyDemo.Models;

public record Department(int Id, string Name)
{
    public List<Employee> Employees { get; init; } = new();
}

public record Employee(int Id, string Name, int DepartmentId)
{
    public List<WorkTask> Tasks { get; init; } = new();
}

public record WorkTask(int Id, string Description, int EmployeeId);
