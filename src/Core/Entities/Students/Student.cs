using Core.Abstractions;
using Core.Entities.Addresses;
using Core.Entities.Departments;

namespace Core.Entities.Students;

public sealed class Student : Entity
{
    private Student()
    {
        
    }
    public Name Name { get;private set; }
    public Address Address { get; private set; }
    public Phone Phone { get;private set; }
    public Guid? DepartmentId { get;private set; }
    public  Department Department { get;private set; }


}