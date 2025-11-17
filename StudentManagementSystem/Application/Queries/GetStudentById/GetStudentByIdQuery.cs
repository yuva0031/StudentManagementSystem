using MediatR;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Application.Queries.GetStudentById
{
    public record GetStudentByIdQuery(int Id) : IRequest<Student>;
}