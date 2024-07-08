using Application.Abstractions.Messaging;
using Application.Features.Students.Responses;
using AutoMapper;
using Core.Abstractions;
using Core.Entities.Students;
using Services.Abstracts;

namespace Application.Features.Students.Queries.Handlers;

public sealed class GetStudentListQueryHandler : IQueryHandler<GetStudentListQuery, List<GetStudentListResponse>>
{
    private readonly IStudentService _service;
    private readonly IMapper _mapper;

    public GetStudentListQueryHandler(IStudentService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    public async Task<Result<List<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
    {
         var studentList = await _service.GetStudentsListAsync();
         var studentMapper = _mapper.Map<List<GetStudentListResponse>>(studentList);
         return (Result<List<GetStudentListResponse>>)Result.Success(studentMapper);
    }
}