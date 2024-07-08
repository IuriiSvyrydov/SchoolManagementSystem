using System.ComponentModel.DataAnnotations.Schema;
using Core.Abstractions;
using Core.Entities.Departments;
using Core.Entities.Students;
using Core.Entities.Subjects;

namespace Core.Entities.DepartmentSubjects;

public sealed class DepartmentSubject: Entity
{
    public Guid DepartmentId { get;private set; }
    public Guid SubjectId { get; private set; }
    public Department? Department { get; private set; }

    public Subject?  Subject { get; private set; }
}