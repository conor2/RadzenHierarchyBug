namespace RadzenHierarchyDemo.Models;

public class DepartmentClass
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<EmployeeClass> Employees { get; set; } = new();
}

public class EmployeeClass
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int DepartmentId { get; set; }
    public List<TaskClass> Tasks { get; set; } = new();
}

public class TaskClass
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public int EmployeeId { get; set; }
}
