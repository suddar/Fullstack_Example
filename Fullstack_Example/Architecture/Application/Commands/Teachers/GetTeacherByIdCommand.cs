using Microsoft.EntityFrameworkCore;

namespace Fullstack_Example.Architecture.Application.Commands.TeacherCommands
{
    public class GetTeacherByIdCommand : IRequest<Teacher>
    {
        public int Id { get; set; }
    }

    public class GetTeacherByIdCommandHandler : EntityContext, IRequestHandler<GetTeacherByIdCommand, Teacher>
    {
        public GetTeacherByIdCommandHandler(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Teacher> Handle(GetTeacherByIdCommand request, CancellationToken cancellationToken)
        {
            return await dbContext.Teachers.FirstOrDefaultAsync(e => e.Id == request.Id, cancellationToken) ?? new Teacher();
        }
    }
}
