using Core.Entities.Addresses;
using Core.Entities.Students;

namespace Application.Features.Students.Responses;

public class GetStudentListResponse
{
    public Guid Id { get; set; }
    public string? Name { get;  set; }
    public string? Address { get;  set; }
    public string? DepartmentName { get; set; }
}