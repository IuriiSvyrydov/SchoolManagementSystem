namespace Core.Entities.Departments;

public interface IDepartmentRepository
{
    Task<List<Department>> GetDepartmentListAsync();
}