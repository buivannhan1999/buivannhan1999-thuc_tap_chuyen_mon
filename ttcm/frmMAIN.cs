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
    public partial class frmMAIN : Form
    {
        public frmMAIN()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void loadform(object formload)
        {
            if (this.pnMain.Controls.Count > 0)
                this.pnMain.Controls.RemoveAt(0);
            Form fh = formload as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(fh);
            this.pnMain.Tag = fh;
            fh.Opacity = 0;
            fh.Show();
        }

        private void frmMAIN_Load(object sender, EventArgs e)
        {
            loadform(new Form1());
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            loadform(new frmNhanvien());
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            loadform(new frmKhachhang());
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            loadform(new frmNhaCungCap());

        }

        private void btnphieunhap_Click(object sender, EventArgs e)
        {
            loadform(new frmNhapHang());
        }

        private void btndanhmuc_Click(object sender, EventArgs e)
        {
            loadform(new frmDanhMuc());
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            loadform(new frmSanPham());
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            loadform(new frmHoaDon());
        }

        private void btnctpn_Click(object sender, EventArgs e)
        {
            loadform(new frmCTPhieuNhap());
        }

        private void btncthd_Click(object sender, EventArgs e)
        {
            loadform(new Form2());
        }
    }
}
