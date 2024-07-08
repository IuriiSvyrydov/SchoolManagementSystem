using Core.Abstractions;
using Core.Entities.Students;
using Core.Entities.Subjects;

namespace Core.Entities.StudentSubjects;

public sealed class StudentSubject: Entity
{
    private StudentSubject()
    {
        
    }
    public Guid SubjectId { get; private set; }
    public Guid StudentId { get; private set; }
    public Student Student { get; private set; }
    public Subject Subject { get; private set; }
    
}