using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Restoran3.Commands
{
    public class MenuCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;


        private Action<object?> _executeMenuCommand;
        private Func<object?, bool> _canExecuteMenuCommand;


        public MenuCommand(Action<object?> executeMenuCommand, Func<object?, bool> canExecuteMenuCommand)
        {
            _executeMenuCommand = executeMenuCommand;
            _canExecuteMenuCommand = canExecuteMenuCommand;

        }

        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object? parameter)
        {
            for (int i = 0; i < _foodItems; i++)
            {

            }
        }
    }
}
