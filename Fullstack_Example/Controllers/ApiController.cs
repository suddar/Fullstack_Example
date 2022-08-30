using Fullstack_Example.Architecture.Application.Services;
using Fullstack_Example.Architecture.Domain.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Protocol;

namespace Fullstack_Example.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly ICommandService _commandService;
        private readonly AppDbContext dbContext;
        public ApiController(ICommandService handlerService, AppDbContext dbContext)
        {
            _commandService = handlerService;
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<Topic> Get()
        {
            return dbContext.Topics.ToList();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public object? Post([FromBody] Command command)
        {
            Console.WriteLine(JsonConvert.SerializeObject(command));
            try
            {
                return _commandService.Handle(command);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR " + e);
                return "ERROR";
            }
        }
    }
}
