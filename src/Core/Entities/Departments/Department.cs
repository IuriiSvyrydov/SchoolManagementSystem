using Core.Abstractions;
using Core.Entities.DepartmentSubjects;
using Core.Entities.Students;

namespace Core.Entities.Departments;

public sealed class Department: Entity
{
    public DepartmentName DepartmentName { get;private set; }
    public List<Student> Students { get; private set; } = new();
    public List<DepartmentSubject> DepartmentSubjects { get; private set; } = new();
    private Department()
    {
        
    }
}