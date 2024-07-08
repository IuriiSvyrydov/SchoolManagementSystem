using Core.Entities.Subjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public sealed class SubjectConfiguration: IEntityTypeConfiguration<Subject>
{
    public void Configure(EntityTypeBuilder<Subject> builder)
    {
        builder.ToTable("subjects");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedNever();
        builder.Property(x => x.SubjectName)
            .HasConversion(x => x.Value, value =>
                new SubjectName(value));
        //builder.HasMany(x => x.StudentSubjects)
        //    .WithOne().HasForeignKey(x => x.StudentId);
        //builder.HasMany(x => x.DepartmentSubjects)
        //    .WithOne().HasForeignKey(x => x.DepartmentId);
        



    }
}