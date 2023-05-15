using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfSample.Command;
using WpfSample.View;

namespace WpfSample.ViewModel
{
    public class MainWindowViewModel:BaseViewModel
    {
        private Model.MainModel _model;
        private readonly View.MainWindow _mainWindow;

        public MainWindowViewModel(Model.MainModel model)
        {
            this._model = model;
            _mainWindow=new MainWindow(this);

        }


        ////アクティブボタンの制御
        private bool _isButtonEnable = true;

        public bool IsButtonEnable
        {
            get { return this._isButtonEnable; }
            set
            {
                this._isButtonEnable = value;
                OnPropertyChanged("IsButtonEnable");
            }
        }

        //アクティブチェックBoxのコマンド
        private CheckedCommand _isCheckedCommand;
        public CheckedCommand IsCheckCommand
        {
            get
            {
                if (_isCheckedCommand == null)
                    _isCheckedCommand = new CheckedCommand();
                return _isCheckedCommand;
            }

        }


        //ボタンカウント値
        private int _clickCount = 0;

        public int ClickCount
        {
            get { return _clickCount; }
            set
            {
                _clickCount = value;
                OnPropertyChanged("ClickCount");
            }
        }


        //カウントアップのボタンコマンド
        private ButtonCommand _buttonClickCommand;
        public ButtonCommand ButtonClickCommand
        {
            get { return _buttonClickCommand ?? (_buttonClickCommand = new ButtonCommand(this.CountUp)); }
        }

        /// <summary>
        /// カウントアップ本体
        /// </summary>
        /// <param name="obj"></param>
        private void CountUp(object obj)
        {
            int i;
            if (int.TryParse(obj.ToString(), out i))
            {
                this.ClickCount = i + 1;
            }
        }


        //クリアボタンのボタンコマンド
        public ClearButtonClickCommand _clearButtonClickCommand;
        public ClearButtonClickCommand ClearButtonClickCommand
        {
            get
            {
                if(_clearButtonClickCommand==null)
                    _clearButtonClickCommand = new ClearButtonClickCommand(this.ClearCount);

                return _clearButtonClickCommand;
            }
        }


        private void ClearCount(object obj)
        {
            this.ClickCount = 0;
        }



        internal void Show()
        {
            _mainWindow.Show();
        }
    }
}
