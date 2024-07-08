using Core.Entities.Addresses;
using Core.Entities.Departments;
using Core.Entities.Students;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public sealed class StudentConfiguration: IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("students");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedNever();
        
        builder.Property(x => x.Name).HasConversion(x =>
            x.Value, value => new Name(value));
        builder.Property(x => x.Phone)
            .HasConversion(x => x.Value,
                value => new Phone(value));
        //builder.HasOne(x => x.Department)
        //    .WithMany(x => x.Students)
        //    .HasForeignKey(x => x.DepartmentId);
        builder.Property(x => x.DepartmentId);
        builder.OwnsOne(x => x.Address, 
            options => 
                options.Property(x=>x.City).HasMaxLength(100).HasConversion(x
                    =>x.Value,value=>new City(value)).HasColumnName(nameof(Address.City)));
        builder.OwnsOne(x => x.Address,
            options =>
                options.Property(x => x.Country).HasMaxLength(100).HasConversion(x
                    => x.Value, value => new Country(value)).HasColumnName(nameof(Address.Country)));
        builder.OwnsOne(x => x.Address,
          options =>
              options.Property(x => x.State).HasMaxLength(100).HasConversion(x
                  => x.Value, value => new State(value)).HasColumnName(nameof(Address.State)));
        builder.OwnsOne(x => x.Address,
            options =>
                options.Property(x => x.Street).HasMaxLength(100).HasConversion(x
                    => x.Value, value => new Street(value)).HasColumnName(nameof(Address.Street)));
        builder.OwnsOne(x => x.Address,
            options =>
                options.Property(x => x.ZipCode).HasMaxLength(100).HasConversion(x
                    => x.Value, value => new ZipCode(value)).HasColumnName(nameof(Address.ZipCode)));
    }
}