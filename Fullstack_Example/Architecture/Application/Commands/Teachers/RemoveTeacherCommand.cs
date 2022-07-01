using Microsoft.EntityFrameworkCore;

namespace Fullstack_Example.Architecture.Application.Commands.TeacherCommands;

public class RemoveTeacherCommand : IRequest<bool>
{
    public int Id { get; set; }
}

public class RemoveTeacherCommandHandler : EntityContext, IRequestHandler<RemoveTeacherCommand, bool>
{
    public RemoveTeacherCommandHandler(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<bool> Handle(RemoveTeacherCommand request, CancellationToken cancellationToken)
    {
        var entity = await dbContext.Teachers.FirstOrDefaultAsync(e => e.Id == request.Id, cancellationToken);
        if (entity == null) return false;

        dbContext.Teachers.Remove(entity);
        await dbContext.SaveChangesAsync(cancellationToken);
        return true;
    }
}

