using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Core.Entities.Departments;
using Core.Entities.DepartmentSubjects;
using Core.Entities.Students;
using Core.Entities.StudentSubjects;
using Core.Entities.Subjects;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public sealed class AppDbContext: DbContext
{
    public AppDbContext()
    {
        
    }
    public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
    {
        
    }
    public DbSet<Department> Departments { get; set; } = null!;
    public DbSet<DepartmentSubject> DepartmentSubjects { get; set; } = null!;
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<StudentSubject> StudentSubjects { get; set; } = null!;
    public DbSet<Subject> Subjects { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}