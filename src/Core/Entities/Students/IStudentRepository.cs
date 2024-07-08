namespace Core.Entities.Students;

public interface IStudentRepository
{
    Task<List<Student>> GetStudentsListAsync();
}