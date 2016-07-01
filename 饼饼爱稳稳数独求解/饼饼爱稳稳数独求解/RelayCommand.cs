using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace 饼饼爱稳稳数独求解
{
    class RelayCommand:ICommand
    {
        private Action m_execute;
        private Func<bool> m_canexecute;
        public RelayCommand(Action execute,Func<bool> canexecute)
        {
            m_execute = execute;
            m_canexecute = canexecute;
        }
        public RelayCommand(Action execute)
        {
            m_execute = execute;
        }
        public bool CanExecute(object parameter)
        {
            if (m_canexecute!=null)
            {
                return m_canexecute();
            }
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            m_execute();
        }
        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged!=null)
            {
                this.CanExecuteChanged(this,EventArgs.Empty);
            }
        }
    }
}
