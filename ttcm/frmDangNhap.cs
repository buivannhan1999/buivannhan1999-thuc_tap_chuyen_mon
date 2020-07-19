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
    public partial class formdangnhap : Form
    {
        public formdangnhap()
        {
            InitializeComponent();
        }

        private void btnXacNhanLoGin_Click(object sender, EventArgs e)
        {
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {
                TaiKhoan taiKhoan = quanli.TaiKhoans.Where(s => s.TenTaiKhoan == txtTenDangNhap.Text).Where(s => s.MatKhau == txtMatKhau.Text)
                    .FirstOrDefault();
                if(taiKhoan!=null)
                {
                    if(taiKhoan.ID==1)
                    {
                        frmMAIN frmMAIN = new frmMAIN();
                        frmMAIN.ShowDialog();
                    }
                    if (taiKhoan.ID == 2)
                    {
                        frmMAIN frmMAIN = new frmMAIN();
                        frmMAIN.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Khong ton tai tai khoan nay");
                }
            }
        }
    }
}
