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
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();
           
        }
      
        public bool kiemtra()
        {
            if (txtTNV.Text == "" || txtLuong.Text == "" || txtCV.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return false;
            }
            else
                return true;
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBanXeDataSet4.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLBanXeDataSet4.NhanVien);

        }
        string manv = "";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    

            private void btnThem_Click(object sender, EventArgs e)
        {

            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //if (manv == "")
            //{
            //    MessageBox.Show("Hãy chọn Nhân Viên cần sửa!");
            //    return;
            //}
            //using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            //{
            //    NhanVien kh = quanli.NhanViens.FirstOrDefault(p => p.MaNV == manv);
            //    //kh.MaPN = txtmaphieunhap.Text;
            //    kh.TenNV = txtTNV.Text;
            //    kh.ChucVu = txtCV.Text;
            //    kh.NgayVaoLam = dateTimePicker1.Value;
            //    kh.Luong = int.Parse(txtLuong.Text);
            //    kh.Gmail = txtGmail.Text;
            //    kh.SDT = int.Parse(txtSDT.Text);
               
            //    quanli.SaveChanges();
            //    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //    frmNhanvien_Load(sender, e);
            //}
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //{
            //    using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            //    {
            //        NhanVien hd = quanli.NhanViens.FirstOrDefault(p => p.MaNV == manv);
            //        if (hd != null)
            //        {
            //            quanli.NhanViens.Remove(hd);
            //            quanli.SaveChanges();
            //            MessageBox.Show("Đã xóa!");
            //            frmNhanvien_Load(sender, e);
            //        }
            //    }
            //}
        }

        private void btnLM_Click(object sender, EventArgs e)
        {
            txtTNV.Text = "";
            txtCV.Text = "";
            txtLuong.Text = "";
            txtGmail.Text = "";
            txtSDT.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (!kiemtra())
            {
                return;
            }
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {

                quanli.insertNV(txtTNV.Text, txtCV.Text, dateTimePicker1.Value, int.Parse(txtLuong.Text), txtGmail.Text, int.Parse(txtSDT.Text));

                quanli.SaveChanges();
                MessageBox.Show("Thêm thành công!");
                frmNhanvien_Load(sender, e);
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (manv == "")
            {
                MessageBox.Show("Hãy chọn Nhân Viên cần sửa!");
                return;
            }
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {
                NhanVien kh = quanli.NhanViens.FirstOrDefault(p => p.MaNV == manv);
                //kh.MaPN = txtmaphieunhap.Text;
                kh.TenNV = txtTNV.Text;
                kh.ChucVu = txtCV.Text;
                kh.NgayVaoLam = dateTimePicker1.Value;
                kh.Luong = int.Parse(txtLuong.Text);
                kh.Gmail = txtGmail.Text;
                kh.SDT = int.Parse(txtSDT.Text);

                quanli.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                frmNhanvien_Load(sender, e);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
                {
                    NhanVien hd = quanli.NhanViens.FirstOrDefault(p => p.MaNV == manv);
                    if (hd != null)
                    {
                        quanli.NhanViens.Remove(hd);
                        quanli.SaveChanges();
                        MessageBox.Show("Đã xóa!");
                        frmNhanvien_Load(sender, e);
                    }
                }
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLM_Click_1(object sender, EventArgs e)
        {
            txtTNV.Text = "";
            txtCV.Text = "";
            txtGmail.Text = "";
            txtLuong.Text = "";
            txtSDT.Text = "";
        }
        public void timkiem(string s)
        {
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())

            {
                dataGridView1.DataSource = quanli.seaching_nv(s);

            }
              
    }

        private void txttk_TextChanged(object sender, EventArgs e)
        {
            timkiem(txttk.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
            {
                return;

            }
            else
            {
                manv = dataGridView1.Rows[row].Cells[0].Value.ToString();
                txtTNV.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                txtCV.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                txtLuong.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
                txtGmail.Text = dataGridView1.Rows[row].Cells[5].Value.ToString();
                txtSDT.Text = dataGridView1.Rows[row].Cells[6].Value.ToString();


            }
        }
    }
  
}
