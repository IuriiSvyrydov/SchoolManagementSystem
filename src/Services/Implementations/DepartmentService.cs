using Core.Entities.Departments;
using Services.Abstracts;

namespace Services.Implementations;

public class DepartmentService: IDepartmentService
{
    private readonly IDepartmentRepository _departmentRepository;

    public DepartmentService(IDepartmentRepository departmentRepository)
    {
        _departmentRepository = departmentRepository;
    }

    public async Task<List<Department>> GetDepartmentListAsync()
    {
        return await _departmentRepository.GetDepartmentListAsync();
    }
}