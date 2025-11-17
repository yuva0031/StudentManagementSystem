using MediatR;

namespace StudentManagementSystem.Application.Commands.UpdateStudent
{
    public record UpdateStudentCommand(int Id, string Name, string Course, int Marks) : IRequest<bool>;
}