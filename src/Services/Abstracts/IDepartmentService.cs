using Core.Entities.Departments;

namespace Services.Abstracts;

public interface IDepartmentService
{
    Task<List<Department>> GetDepartmentListAsync();
}