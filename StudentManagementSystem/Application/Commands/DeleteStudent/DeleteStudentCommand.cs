using MediatR;

namespace StudentManagementSystem.Application.Commands.DeleteStudent
{
    public record DeleteStudentCommand(int Id) : IRequest<bool>;
}