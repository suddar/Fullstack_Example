namespace Fullstack_Example.Architecture.Application.Commands.TeacherCommands
{
    public class AddTeacherCommand : BaseEntityCommand<Teacher>, IRequest<Teacher>
    {
        public override Teacher Entity { get; set; }
    }

    public class AddTeacherCommandHandler : EntityContext, IRequestHandler<AddTeacherCommand, Teacher>
    {
        public AddTeacherCommandHandler(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Teacher> Handle(AddTeacherCommand request, CancellationToken cancellationToken)
        {
            _ = await dbContext.AddAsync(request.Entity);
            _ = await dbContext.SaveChangesAsync(cancellationToken);
            return request.Entity;
        }
    }
}
