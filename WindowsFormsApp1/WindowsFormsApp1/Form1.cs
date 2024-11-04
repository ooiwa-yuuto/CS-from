using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
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

            for( int i = 0; i < 10; i++)
            {
                testbotten testbotten = new testbotten(i,(i % 3)*100,(i / 3)*100,100,100);

                Controls.Add(testbotten);
            }



        }
    }
}
