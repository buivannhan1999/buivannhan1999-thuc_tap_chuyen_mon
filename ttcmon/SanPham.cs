using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ttcmon
{
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
            LoadDL();
        }
        public void LoadDL()
        {
            string query = " select * from SanPham";
            DataTable data = Connectcs.Instance.excuteQuery(query);
            SANPHAM1.DataSource = data;

        }

        private void SanPham_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("vui long nhap du thong tin");
            }
            else
                //{
                //    if (kiemtra(txtMaSP.Text) == true)
                //    {
                //        MessageBox.Show("ma da ton tai");
                //        return;
                //}
                try
                {
                    string query = "insert into SanPham values (N'" + txtMaSP.Text + "','" + txtTenSP.Text + "','" + txtMN.Text + "','" + txtAnh.Text + "')";
                    DataTable data = Connectcs.Instance.excuteQuery(query);
                    MessageBox.Show("Thêm thanh cong");
                    LoadDL();
                }
                catch
                {
                    MessageBox.Show("Thêm that bai");
                }
        }
        private void SANPHAM1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
            {
                return;
            }
            else
            {
                txtMaSP.Text = SANPHAM1.Rows[row].Cells["MaSP"].Value.ToString();

                txtTenSP.Text = SANPHAM1.Rows[row].Cells["TenSP"].Value.ToString();
                txtMN.Text = SANPHAM1.Rows[row].Cells["MaNhom"].Value.ToString();
                txtAnh.Text = SANPHAM1.Rows[row].Cells["HinhSP"].Value.ToString();

            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("vui long chon dong can sua");
            }
            else
            {
                try
                {
                    string query = "update SanPham set TenSP=N'" + txtTenSP.Text + "',MaNhom='" + txtMN.Text + "',HinhSP='" + txtAnh.Text + "' Where MaSP='" + txtMaSP.Text + "'";
                    DataTable data = Connectcs.Instance.excuteQuery(query);
                    MessageBox.Show(" sua thanh cong");
                    LoadDL();

                }
                catch
                {
                    MessageBox.Show(" Sua That bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txtMaSP.Text == "")
            {
                MessageBox.Show("vui long chon dong can xoa");
            }
            else
            {
                try
                {
                    string query = " delete SanPham where MaSP='" + txtMaSP.Text + "'";
                    DataTable data = Connectcs.Instance.excuteQuery(query);
                    MessageBox.Show(" xóa thanh cong");
                    LoadDL();
                }
                catch
                {
                    MessageBox.Show(" Xóa Thất Bại");
                }
            }
        }
    }
}
