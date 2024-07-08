using Core.Entities.Departments;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class DepartmentRepository: IDepartmentRepository
{
    private readonly AppDbContext _contexct;

    public DepartmentRepository(AppDbContext contexct)
    {
        _contexct = contexct;
    }

    public Task<List<Department>> GetDepartmentListAsync()
    {
        return _contexct.Departments.ToListAsync();
    }
}