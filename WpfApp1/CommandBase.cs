using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    public class CommandBase : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return DoCanExcute?.Invoke(parameter)==true;
        }

        public void Execute(object? parameter)
        {
            DoExcute?.Invoke(parameter);
        }

        public Func<object, bool> DoCanExcute;
        public Action<object> DoExcute;
    }
}
