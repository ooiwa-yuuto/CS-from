using cs_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        testlabel _testLabel;

        Test_Text_Box  _textBox;

        public Form1()
        {
            InitializeComponent();

            //          testbotten testbotten = new testbotten(0,0,100,100);
            //
            //          Controls.Add(testbotten);
            //
            //        InitializeComponent();
            //
            //        testbotten testbotten2 = new testbotten(100,100,100,100);
            //
            //        Controls.Add(testbotten2);

            //      int a = 1;
            //      int b = 10;
            //      int c = 10;
            //      int d = 10;
            //      int e = 10;
            //      while (a <= 10)
            //      {
            //          testbotten testbotten = new testbotten( b, c, c, d);
            //
            //          Controls.Add(testbotten );
            //
            //          a++; b += 10;  c += 10; d += 10; e += 10;
            //
            //      }

            string[] strs = new string[]
            {
               "9",
               "a",
               "b",
               "c",
               "d",
               "e",
               "f",
               "g",
               "h",
               "i"
            };


           for (int i = 0; i < 10; i++)
           {

                string id =  strs[i];

                testbotten testbotten = new testbotten(this,id,(i % 3)*100,(i / 3)*100,100,100);
           
               Controls.Add(testbotten);
               
           }




           _testLabel= new testlabel("ラベルです。", 500, 300, 100, 500);
            Controls.Add(_testLabel);

            _textBox = new Test_Text_Box("ラベルです。", 10, 300, 500, 100);
            Controls.Add(_textBox);



            //Label label = new Label();
            //label.Location = new Point(30, 400);
            //label.Text = "ラベルです";
            //Controls.Add(label);
        }

        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }

    }
}
