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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
            LoadDL();

        }
        public void LoadDL()
        {
            string query = " select * from NhaCungCap";
            DataTable data = Class1.Instance.excuteQuery(query);
            dtgncc.DataSource = data;

        }

        private void txtthongtin_Click(object sender, EventArgs e)
        {

        }

        private void dtgncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
            {
                return;

            }
            else
            {
                txtMaNCC.Text = dtgncc.Rows[row].Cells[0].Value.ToString();
                txtTenNhaCC.Text = dtgncc.Rows[row].Cells[1].Value.ToString();
                txtDiaChiNCC.Text = dtgncc.Rows[row].Cells[2].Value.ToString();
                txtSDTNCC.Text = dtgncc.Rows[row].Cells[3].Value.ToString();
                txtgmail.Text = dtgncc.Rows[row].Cells[4].Value.ToString();




            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "" || txtTenNhaCC.Text == "" )
            {
                MessageBox.Show(" vui lòng nhập đủ thông tin");
            }
            else
            {
                string query = " insert into NhaCungCap values(N'" + txtMaNCC.Text + "',N'" + txtTenNhaCC.Text + "',N'" + txtDiaChiNCC.Text + "','" + txtSDTNCC.Text + "','"+txtgmail.Text+"')";
                DataTable data = Class1.Instance.excuteQuery(query);
                LoadDL();
                MessageBox.Show(" Thêm thành công");
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("vui long chon dong can xoa");
            }
            else
            {
                try
                {
                    string query = " delete NhaCungCap where MaNCC='" + txtMaNCC.Text + "'";
                    DataTable data = Class1.Instance.excuteQuery(query);
                    MessageBox.Show(" xóa thanh cong");
                    LoadDL();
                }
                catch
                {
                    MessageBox.Show(" Xóa Thất Bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("vui long chon dong can sua");
            }
            else
            {
                try
                {
                    string query = "update NhaCungCap set TenNhaCC=N'" + txtTenNhaCC.Text + "',ĐiaChiNCC='" + txtDiaChiNCC.Text + "',SDTNCC='" + txtSDTNCC.Text + "',GmailNCC=N'" + txtgmail.Text + "' Where MaNCC='" + txtMaNCC.Text + "'";
                    DataTable data = Class1.Instance.excuteQuery(query);
                    MessageBox.Show(" sua thanh cong");
                    LoadDL();

                }
                catch
                {
                    MessageBox.Show(" Sua That bại");
                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quanliNCC_Load(object sender, EventArgs e)
        {

        }

        private void dtgncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
