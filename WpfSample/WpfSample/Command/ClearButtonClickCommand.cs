using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfSample.Command
{
    public class ClearButtonClickCommand : RelayCommand
    {
        public ClearButtonClickCommand(Action<object> exec)
        :base(exec,null){}


        public override bool CanExecute(object parameter)
        {
            if (parameter == null) return false;


            int i;
            if (int.TryParse(parameter.ToString(), out i))
            {
                if (i == 0) return false;
                return i%2 == 0;
            }


            return false;
        }
    }
}
