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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
            LoadDL();
        }
        
        public void LoadDL()
        {
            string query = " select * from NhanVien";
            DataTable data = Connectcs.Instance.excuteQuery(query);
            dtg1.DataSource = data;

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
            {
                return;
            }
            else
            {
                txtMaNV.Text = dtg1.Rows[row].Cells["MaNV"].Value.ToString();

                txtTenNv.Text = dtg1.Rows[row].Cells["TenNv"].Value.ToString();
                txtChucVu.Text = dtg1.Rows[row].Cells["ChucVu"].Value.ToString();
                txtNgayVaoLam.Text = dtg1.Rows[row].Cells["NgayVaoLam"].Value.ToString();
                txtluong.Text = dtg1.Rows[row].Cells["Luong"].Value.ToString();
                txtgmail.Text = dtg1.Rows[row].Cells["Gmail"].Value.ToString();
                txtSDT.Text = dtg1.Rows[row].Cells["SDT"].Value.ToString();
            }



            }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("vui long nhap du thong tin");
            }
            else
            //{
            //    if (kiemtra(txtMaNV.Text) == true)
            //    {
            //        MessageBox.Show("ma da ton tai");
            //        return;
                //}
                try
                {
                    string query = "insert into NhanVien values (N'"+txtMaNV.Text + "','" + txtTenNv.Text + "','" + txtChucVu.Text + "','" + txtNgayVaoLam.Text +"','"+txtluong.Text+"','"+txtgmail.Text+"','"+txtSDT.Text+"')";
                    DataTable data = Connectcs.Instance.excuteQuery(query);
                    MessageBox.Show("Thêm thanh cong");
                    LoadDL();
                }
                catch
                {
                    MessageBox.Show("Thêm that bai");
                }
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
                    string query = "update NhanVien set tenNv=N'" + txtTenNv.Text + "',ChucVu='" + txtChucVu.Text + "',NgayVaoLam='" + txtNgayVaoLam.Text + "',Luong=N'" + txtluong.Text + "',Gmail='" + txtgmail.Text +"',SDT='" + txtSDT.Text + "' Where MaNV='" + txtMaNV.Text + "'";
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

            if (txtMaNV.Text == "")
            {
                MessageBox.Show("vui long chon dong can xoa");
            }
            else
            {
                try
                {
                    string query = " delete NhanVien where MaNV='" + txtMaNV.Text + "'";
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
