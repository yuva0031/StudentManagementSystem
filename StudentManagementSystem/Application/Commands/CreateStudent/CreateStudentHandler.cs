using MediatR;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Application.Commands.CreateStudent
{
    public class CreateStudentHandler : IRequestHandler<CreateStudentCommand, int>
    {
        private readonly AppDbContext _context;

        public CreateStudentHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = new Student
            {
                Name = request.Name,
                Course = request.Course,
                Marks = request.Marks
            };

            _context.Students.Add(student);
            await _context.SaveChangesAsync(cancellationToken);

            return student.Id;
        }
    }
}