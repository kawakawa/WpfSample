using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WpfSample.Model
{
    public class MainModel
    {
        public MainModel()
        {
         
        }


        //ルール
        //クリック数が10を超えたら、ボタンを非アクティブにする
        public bool IsButttonClickRule(int count)
        {
            if (count < 10) return true;

            //ボタンを非アクティブに変更
            return false;
        }
    }
}
