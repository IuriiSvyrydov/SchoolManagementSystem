using Application.Abstractions.Messaging;
using Application.Features.Students.Responses;
using Core.Entities.Students;

namespace Application.Features.Students.Queries.Handlers;

public sealed record GetStudentListQuery() : IQuery<List<GetStudentListResponse>>;
