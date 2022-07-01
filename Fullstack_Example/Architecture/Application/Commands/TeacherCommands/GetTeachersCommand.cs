using Microsoft.EntityFrameworkCore;

namespace Fullstack_Example.Architecture.Application.Commands.TeacherCommands;

public class GetTeachersCommand : IRequest<List<Teacher>>
{
    public int Id { get; set; }
}

public class GetTeachersCommandHandler : EntityContext, IRequestHandler<GetTeachersCommand, List<Teacher>>
{
    public GetTeachersCommandHandler(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<List<Teacher>> Handle(GetTeachersCommand request, CancellationToken cancellationToken)
    {
        return await dbContext.Teachers.ToListAsync();
    }
}

