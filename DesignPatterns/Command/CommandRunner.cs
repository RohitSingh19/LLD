using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Command
{
    internal class CommandRunner
    {
        public CommandRunner()
        {
            var editor = new TextEditor();
            var history = new CommandHistory();

            // Create commands
            ICommand addTextCommand1 = new AddTextCommand(editor, "Hello ");
            ICommand addTextCommand2 = new AddTextCommand(editor, "World!");
            ICommand deleteTextCommand = new DeleteTextCommand(editor, 6);

            // Execute commands
            history.ExecuteCommand(addTextCommand1);
            history.ExecuteCommand(addTextCommand2);

            // Undo the last command
            history.UndoLastCommand();

            // Execute a delete command
            history.ExecuteCommand(deleteTextCommand);

            // Undo the delete command
            history.UndoLastCommand();
        }
    }
}
