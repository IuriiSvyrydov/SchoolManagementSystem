using Core.Entities.Students;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class StudentRepository: IStudentRepository
{
    private readonly AppDbContext _context;

    public StudentRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Student>> GetStudentsListAsync()
    {
        return await _context.Students.Include(x=>x.Department).ToListAsync();
    }
}