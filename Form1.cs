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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
            LoadDL();
        }
        public void LoadDL()
        {
            string query = " select * from NhanVien";
            DataTable data = Class1.Instance.excuteQuery(query);
            dtg1.DataSource = data;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == ""||txtTenNV.Text==""||txtluong.Text=="")
            {
                MessageBox.Show(" vui lòng nhập đủ thông tin");
            }
            else
            {
                string query = " insert into NhanVien values(N'" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + txtchucvu.Text + "','" + txtngaylm.Text + "','" + txtluong.Text + "',N'" + txtgmail.Text + "','" + txtdt.Text + "')";
                DataTable data = Class1.Instance.excuteQuery(query);
                LoadDL();
                MessageBox.Show(" Thêm thành công");
            }
           

        }

        private void dtg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("vui long chon dong can sua");
            }
            else
            {
                try
                {
                    string query = "update NhanVien set tenNV=N'" + txtTenNV.Text + "',ChucVu='" + txtchucvu.Text + "',NgayVaoLam='" + txtngaylm.Text + "',Luong=N'" + txtluong.Text + "',Gmail='" + txtgmail.Text + "',SDT='" + txtdt.Text + "' Where MaNV='" + txtMaNV.Text + "'";
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("vui long chon dong can xoa");
            }
            else
            {
                try
                {
                    string query = " delete NhanVien where MaNV='" + txtMaNV.Text + "'";
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
    }
}
