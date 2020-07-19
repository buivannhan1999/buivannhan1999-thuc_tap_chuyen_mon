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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        void loadchart()
        {
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {
                chart1.DataSource = quanli.dt().ToList();
                chart1.Series["VND"].XValueMember = "thang";
                chart1.Series["VND"].YValueMembers = "tongtien";
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            loadchart();


        }
    }
}
