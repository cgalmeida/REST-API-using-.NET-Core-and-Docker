using System.Collections.Generic;
using Commander.Models;
using Commander.Data;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{

    //api/comands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepository _repository;
        public CommandsController(ICommanderRepository repository)
        {
            _repository = repository;

        }
        //private readonly MockCommanderRepository _repository = new MockCommanderRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllComands()
        {
            var commandItens = _repository.GetAppCommands();

            return Ok(commandItens);

        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);

            return Ok(commandItem);

        }


    }
}