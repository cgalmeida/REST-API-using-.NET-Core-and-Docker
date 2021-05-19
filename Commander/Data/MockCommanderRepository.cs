using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepository : ICommanderRepository
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an eff", Line="Boil Water", Platform="Kettle & Pan"},
                new Command{Id=1, HowTo="Cut a Bread", Line="Get a Knife", Platform="Knife & Chopping board"},
                new Command{Id=2, HowTo="Make a cup of tea", Line="Place a teabag in cup", Platform="Kettle & Cup"},
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an eff", Line="Boil Water", Platform="Kettle & Pan"};

        }

    }
}