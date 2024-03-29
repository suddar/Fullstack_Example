﻿using Fullstack_Example.Architecture.Application.Commands.Topics;
using Fullstack_Example.Architecture.Application.Services;
using Fullstack_Example.Architecture.Domain.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NuGet.Protocol;

namespace Fullstack_Example.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {

        private readonly ICommandService _commandService;
        private readonly AppDbContext _dbContext;
        public ApiController(ICommandService handlerService, AppDbContext dbContext)
        {
            _commandService = handlerService;
            _dbContext = dbContext;
        }

        [Authorize]
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Post([FromBody] Command command)
        {
            return Ok(_commandService.Handle(command));
        }
    }
}
