using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Test_Text_Box : TextBox
    {
        public Test_Text_Box(string str, int x, int y, int widht, int heigth)
        {

            //ボタン内に文字を表示させる
            Text = str;


            //ボタンの生成場所を指定
            Location = new Point(x, y);

            //ボタンの大きさ
            Size = new Size(widht, heigth);


        }

        public string TextUpdate(string str)
        {
            string temp = Text;
            Text = str;

            return temp;

        }

    }
}
