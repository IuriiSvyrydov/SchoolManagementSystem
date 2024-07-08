using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Data;

public class DesignSchoolManagementFactory: IDesignTimeDbContextFactory<AppDbContext>
{


    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlServer("Server=REVISION-PC;Database=SchoolManagementDb;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=true;");

        return new AppDbContext(optionsBuilder.Options);
    }
}