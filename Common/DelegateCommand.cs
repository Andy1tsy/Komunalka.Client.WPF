using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Komunalka.Client.WPF.Common
{
    public class DelegateCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _predicate;

        public DelegateCommand(Action<object> execute, Predicate<object> predicate)
        {
            _execute = execute;
            _predicate = predicate;
        }

        public DelegateCommand(Action<object> execute)
        {
            _execute = execute;
            _predicate = p => true;
        }

        public bool CanExecute(object parameter)
        {
            return _predicate?.Invoke(parameter) ?? false;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
