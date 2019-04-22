using CommandPatternApp.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternApp.Invoker
{
    public class Remote
    {
        private ICollection<ICommand> commands;

        public Remote()
        {
            this.commands = new List<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            this.commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach(var command in this.commands)
            {
                command.Execute();
            }

            this.commands.Clear();
        }
    }
}
