using Core.Abstractions;
using Core.Entities.DepartmentSubjects;
using Core.Entities.StudentSubjects;

namespace Core.Entities.Subjects;

public sealed class Subject: Entity
{
    private Subject()
    {
        
    }
    public SubjectName SubjectName { get;private set; }
    public DateTime Period { get; set; }
    public List<StudentSubject> StudentSubjects { get; private set; } = new();
    public List<DepartmentSubject> DepartmentSubjects { get; set; } = new();

}