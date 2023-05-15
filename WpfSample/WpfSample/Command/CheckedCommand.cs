using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfSample.Command
{
    public class CheckedCommand : RelayCommand
    {
        public CheckedCommand(Action<object> execute)
        :base(execute){}

        public CheckedCommand()
            : base()
        {}

        public override void Execute(object parameter)
        {
            MessageBox.Show("CheckedCommand Exec parameter=" + parameter.ToString());
        }  
    }
}
