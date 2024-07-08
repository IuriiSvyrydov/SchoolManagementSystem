using Core.Entities.Departments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public sealed class DepartmentConfiguration: IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.ToTable("departments");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedNever();
        builder.Property(x => x.DepartmentName).HasConversion(x => x.Value, value =>
            new DepartmentName(value));
        //builder.HasMany(x => x.Students)
        //    .WithOne()
        //    .HasForeignKey(x => x.DepartmentId);
        //builder.HasMany(x => x.DepartmentSubjects)
        //    .WithOne().HasForeignKey(x => x.SubjectId);
  

    }
}