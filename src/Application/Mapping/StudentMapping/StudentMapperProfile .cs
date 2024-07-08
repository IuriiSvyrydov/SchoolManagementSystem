using Application.Features.Students.Responses;
using AutoMapper;
using Core.Entities.Students;

namespace Application.Mapping.StudentMapping;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Student, GetStudentListResponse>()
            .ForMember(dest => dest.DepartmentName, opt
                => opt.MapFrom(src => src.Department.DepartmentName));
    }

}