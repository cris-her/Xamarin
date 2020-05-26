using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace App
{
    public class MyCommand : ICommand
    {
        Action action;
        Func<bool> canExecute;

        public event EventHandler CanExecuteChanged;
        public void ReevaluateCan()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
        
        public MyCommand(Action action) : this(action, ()=> true)
        {
        }

        public MyCommand(Action action, Func<bool> canExecute)
        {
            this.action = action;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute();
        }

        public void Execute(object parameter)
        {
            action();
        }
    }
}
