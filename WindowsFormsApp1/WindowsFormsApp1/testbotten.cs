using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace WindowsFormsApp1
{
    internal class testbotten : Button
    {
        public testbotten(int id,int x,int y,int widht,int heigth)
        {
            //ClickイベントにOnClick関数を登録
            //ボタンをクリックしたときに登録した関数を実行します
            Click += OnClick;

            //ボタン内に文字を表示させる
            Text = id.ToString();
           

            //ボタンの生成場所を指定
            Location = new Point(x,y);

            //ボタンの大きさ
            Size = new Size(widht,heigth);
        }

        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show(Text);

        }
    }
}
