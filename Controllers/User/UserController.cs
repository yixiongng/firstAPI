using System.Collections.Generic;
using System.Threading.Tasks;
using IssueTracker.Api.Controllers.User.Store;
using IssueTracker.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Api.Controllers.User
{
    //api/commands
    [Route("api/commands")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserStore _store;

        public UserController(UserStore store)
        {
            _store = store;
        }

        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _store.GetAppCommands();

            return Ok(commandItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _store.GetCommandById(id);
            
            return Ok(commandItem);
        }
        // [HttpPost("get")]
        // public async Task<IActionResult> GetAppCommands([FromBody] Command model)
        // {
        //     var result = await _store.CreateBid(userId, model);

        //     return Ok(result);
        // }
    }
}