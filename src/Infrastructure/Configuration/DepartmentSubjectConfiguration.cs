using Core.Entities.Departments;
using Core.Entities.DepartmentSubjects;
using Core.Entities.Subjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public sealed class DepartmentSubjectConfiguration: IEntityTypeConfiguration<DepartmentSubject>
{
    public void Configure(EntityTypeBuilder<DepartmentSubject> builder)
    {
        builder.ToTable("departmentSubjects");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedNever();
        builder.Property(x => x.SubjectId);
        builder.Property(x => x.DepartmentId);




    }
}