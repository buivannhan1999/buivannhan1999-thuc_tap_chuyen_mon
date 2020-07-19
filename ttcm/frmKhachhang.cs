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
    public partial class frmKhachhang : Form
    {
        public frmKhachhang()
        {
            InitializeComponent();
        }
        public bool kiemtra()
        {
            if (txttenkh.Text == "" || txtgmail.Text == "" || txtsdt.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return false;
            }
            else
                return true;
        }

        private void frmKhachhnag_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBanXeDataSet9.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qLBanXeDataSet9.KHACHHANG);
            // TODO: This line of code loads data into the 'qLBanXeDataSet8.KHACHHANG' table. You can move, or remove it, as needed.
           // this.kHACHHANGTableAdapter1.Fill(this.qLBanXeDataSet8.KHACHHANG);
            // TODO: This line of code loads data into the 'qLBanXeDataSet5.KhachHang' table. You can move, or remove it, as needed.
          //  this.khachHangTableAdapter.Fill(this.qLBanXeDataSet5.KhachHang);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
            {
                return;
            }
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {

                quanli.insertKH(txttenkh.Text, dtngaysinh.Value, int.Parse(txtsdt.Text), txtgmail.Text);

                quanli.SaveChanges();
                MessageBox.Show("Thêm thành công!");
                frmKhachhnag_Load(sender, e);
            }
        }
        
        private void dtgkhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Hãy chọn khách hàng cần sửa!");
                return;
            }
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {
                KHACHHANG kh = quanli.KHACHHANGs.FirstOrDefault(p => p.MaKH == txtmakh.Text);

                kh.TenKH = txttenkh.Text;
                kh.NgaySinh = dtngaysinh.Value;
                kh.SDT = int.Parse(txtsdt.Text);
                kh.Gmail = txtgmail.Text;

                quanli.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                frmKhachhnag_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
                {
                    KHACHHANG hd = quanli.KHACHHANGs.FirstOrDefault(p => p.MaKH ==txtmakh.Text);
                    if (hd != null)
                    {
                        quanli.KHACHHANGs.Remove(hd);
                        quanli.SaveChanges();
                        MessageBox.Show("Đã xóa!");
                        frmKhachhnag_Load(sender, e);
                    }
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        string makh="";
        private void dtgkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtmakh.Text = dtgkhachhang.CurrentRow.Cells[0].Value.ToString();
            txttenkh.Text = dtgkhachhang.CurrentRow.Cells[1].Value.ToString();
            dtngaysinh.Value = Convert.ToDateTime(dtgkhachhang.CurrentRow.Cells[2].Value.ToString());
            txtsdt.Text = dtgkhachhang.CurrentRow.Cells[3].Value.ToString();
            txtgmail.Text = dtgkhachhang.CurrentRow.Cells[4].Value.ToString();


        }
    }
}
