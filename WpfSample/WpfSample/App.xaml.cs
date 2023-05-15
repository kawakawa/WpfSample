﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfSample
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {


        public App()
        {

            var model = new Model.MainModel();

            var vm = new ViewModel.MainWindowViewModel(model);

            vm.Show();



        }

    }
}
