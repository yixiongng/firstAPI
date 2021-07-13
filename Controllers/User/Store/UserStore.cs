using System.Collections.Generic;
using IssueTracker.Api.Models;
using Microsoft.Extensions.Logging;

namespace IssueTracker.Api.Controllers.User.Store
{
    public class UserStore
    {
        // private readonly MySqlContext _context;
        // private readonly MySqlContextRead _contextRead;
        private readonly ILogger _logger;
        public UserStore(ILogger<UserStore> logger)
        {
            // _contextRead = contextRead;
            // _context = context;
            _logger = logger;
        }

        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id = 0, HowTo = "Boil an egg",Line = "Boil Water",Platform = "Kettle & Pan"},
                new Command{Id = 1, HowTo = "Cut bread",Line = "Get a knief",Platform = "Knief & chopping board"},
                new Command{Id = 2, HowTo = "Make up a tea",Line = "Place teabag in cup",Platform = "Kettle & cup"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id = 0, HowTo = "Boil an egg",Line = "Boil Water",Platform = "Kettle & Pan"};
        }
        
    }
}