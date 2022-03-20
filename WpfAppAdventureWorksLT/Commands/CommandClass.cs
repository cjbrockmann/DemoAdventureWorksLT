using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppAdventureWorksLT.Commands
{
    internal class CommandClass : ICommand
    {

        private Action<object?> WhatToExecute;
        private Func<object?, bool> WhenToExecute;

        public CommandClass(Action<object?> whatToExecute, Func<object?,bool> whenToExecute)
        {
            WhatToExecute = whatToExecute;
            WhenToExecute = whenToExecute; 
        }


        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return WhenToExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            WhatToExecute(parameter);
        }

        public void Refresh()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }

    }
}
