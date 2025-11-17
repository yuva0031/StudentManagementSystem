using MediatR;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Application.Queries.GetAllStudents
{
    public record GetAllStudentsQuery() : IRequest<IEnumerable<Student>>;
}