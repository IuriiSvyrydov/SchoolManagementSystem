using Core.Entities.Students;

namespace Services.Abstracts;

public interface IStudentService
{
    public Task<List<Student>> GetStudentsListAsync();

}