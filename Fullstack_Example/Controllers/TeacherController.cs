using Fullstack_Example.Architecture.Application.Commands.TeacherCommands;
using Fullstack_Example.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fullstack_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : EntityControllerBase
    {
        public TeacherController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("GetTeachers")]
        public async Task<List<Teacher>> GetStudents()
        {
            return await mediator.Send(new GetTeachersCommand());
        }

        [HttpGet("GetTeacherById/{id}")]
        public async Task<ActionResult<Teacher>> GetTeacherById(int id)
        {
            return await mediator.Send(new GetTeacherByIdCommand { Id = id });
        }

        [HttpPost("AddTeacher")]
        public void AddTeacher([FromBody] AddTeacherCommand request)
        {
            Console.WriteLine(JsonConvert.SerializeObject(request));
            mediator.Send(request);
        }

        [HttpPut("UpdateTeacher")]
        public async Task UpdateTeacher([FromBody] UpdateTeacherCommand request)
        {
            await mediator.Send(request);
        }

        [HttpDelete("RemoveTeacher/{id}")]
        public async Task Delete(int id)
        {
            await mediator.Send(new RemoveTeacherCommand { Id = id });
        }
    }
}
