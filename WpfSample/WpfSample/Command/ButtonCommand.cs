using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfSample.Command
{
    public class ButtonCommand:RelayCommand
    {
        public ButtonCommand(Action<object> execute)
        :base(execute){}

        //public override void Execute(object parameter)
        //{
        //    MessageBox.Show("hoge");
        //}  
    }
}
