using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Desafio_Tecnico.ViewModels
{
    public class ViewModelCommand : ICommand
    {
        //private readonly Action<object> _executeAction;
        //private readonly Predicate<object> _canExecuteAction;
        //public ViewModelCommand(Action<object> executeAction)
        //{
        //    _executeAction = executeAction;
        //    _canExecuteAction = null;
        //}
        ////Evento
        //public event EventHandler CanExecuteChanged
        //{
        //    add { CommandManager.RequerySuggested += value; }
        //    remove { CommandManager.RequerySuggested -= value; }
        //}
        ////Metodo
        //public bool CanExecute(object parameter)
        //{
        //    return _canExecuteAction == null ? true : _canExecuteAction(parameter);
        //}
        //public void Execute(object parameter)
        //{
        //    _executeAction(parameter);
        //}
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        public ViewModelCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
