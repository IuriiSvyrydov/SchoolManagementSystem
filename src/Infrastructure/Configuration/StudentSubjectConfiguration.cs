using Core.Entities.Students;
using Core.Entities.StudentSubjects;
using Core.Entities.Subjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public sealed class StudentSubjectConfiguration: IEntityTypeConfiguration<StudentSubject>
{
    public void Configure(EntityTypeBuilder<StudentSubject> builder)
    {
        builder.ToTable("studentSubjects");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedNever();
        //builder.HasOne<Student>(x => x.Student)
        //    .WithMany()
        //    .HasForeignKey(x => x.StudentId);
        //builder.HasOne<Subject>(x => x.Subject)
        //    .WithMany()
        //    .HasForeignKey(x => x.SubjectId);
        builder.Property(x => x.SubjectId);
        builder.Property(x => x.StudentId);
    }
}