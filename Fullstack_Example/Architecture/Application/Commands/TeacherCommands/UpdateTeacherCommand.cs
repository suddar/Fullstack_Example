using MediatR;
using MediatRExample.Domain;
using MediatRExample.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Fullstack_Example.Architecture.Application.Commands.TeacherCommands;

public class UpdateTeacherCommand : BaseEntityCommand<Teacher>, IRequest<Teacher>
{
    public override Teacher Entity { get; set; }
}

public class UpdateTeacherCommandHandler : IRequestHandler<UpdateTeacherCommand, Teacher>
{
    private readonly AppDbContext _context;

    public UpdateTeacherCommandHandler(AppDbContext dbContext)
    {
        _context = dbContext;
    }

    public async Task<Teacher> Handle(UpdateTeacherCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Teachers.FirstOrDefaultAsync(e => e.Id == request.Entity.Id, cancellationToken);

        if (entity == null) return request.Entity;
        entity = request.Entity;

        await _context.SaveChangesAsync(cancellationToken);
        return entity;
    }
}

