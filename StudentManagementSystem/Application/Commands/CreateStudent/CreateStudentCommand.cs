using MediatR;

namespace StudentManagementSystem.Application.Commands.CreateStudent
{
    public record CreateStudentCommand(string Name, string Course, int Marks) : IRequest<int>;
}