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

        Form1 _form1;

        public testbotten(Form1 form1,/*int id*/string id,int x,int y,int widht,int heigth)
        {

            _form1 = form1;

            //ClickイベントにOnClick関数を登録
            //ボタンをクリックしたときに登録した関数を実行します
            Click += OnClick;

            //ボタン内に文字を表示させる
           // Text = id.ToString();
            Text = id;

    //       string[] azu = new string[10];
    //
    //       azu[0] = "a";
    //       azu[1] = "b";
    //       azu[2] = "c";
    //       azu[3] = "d";
    //       azu[4] = "e";
    //       azu[5] = "f";
    //       azu[6] = "g";
    //       azu[7] = "h";
    //       azu[8] = "i";
    //       azu[9] = "j";
    //
    //       Text = azu[id].ToString();

            //ボタンの生成場所を指定
            Location = new Point(x,y);

            //ボタンの大きさ
            Size = new Size(widht,heigth);
        }

        public void OnClick(object sender, EventArgs s)
        {
            _form1.LabelTextUpdate(Text);
        }
    }
}
