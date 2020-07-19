using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ttcm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int _img = 1;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_img == 1)
            {
                pcchinh.Image = ttcm.Properties.Resources._2;
                _img = 2;
            }
            else if (_img == 2)
            {
                pcchinh.Image = ttcm.Properties.Resources._1;
                _img = 3;
            }
            else if (_img == 3)
            {
                pcchinh.Image = ttcm.Properties.Resources._3;
                _img = 4;
            }
            else if (_img == 4)
            {
                pcchinh.Image = ttcm.Properties.Resources._4;
                _img = 5;
            }
            else if (_img == 5)
            {
                pcchinh.Image = ttcm.Properties.Resources._5;
                _img = 6;
            }
            
            else
            {
                pcchinh.Image = ttcm.Properties.Resources._2;
                _img = 2;
            }
        }
    }
}
