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
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBanXeDataSet11.DanhMuc' table. You can move, or remove it, as needed.
            this.danhMucTableAdapter.Fill(this.qLBanXeDataSet11.DanhMuc);

        }
        public bool kiemtra()
        {
            if (textBox2.Text == "" )
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return false;
            }
            else
                return true;
        }
        string madm = "";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            madm = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLM_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
            {
                return;
            }
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {


                quanli.danhmuc123(textBox2.Text);
                quanli.SaveChanges();
                MessageBox.Show("Thêm thành công!");
                frmDanhMuc_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
                {
                    DanhMuc hd = quanli.DanhMucs.FirstOrDefault(p => p.MaNhom == madm);
                    if (hd != null)
                    {
                        quanli.DanhMucs.Remove(hd);
                        quanli.SaveChanges();
                        MessageBox.Show("Đã xóa!");
                        frmDanhMuc_Load(sender, e);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (madm == "")
            {
                MessageBox.Show("Hãy chọn Danh mục cần sửa!");
                return;
            }
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {
                DanhMuc kh = quanli.DanhMucs.FirstOrDefault(p => p.MaNhom ==madm);
                //kh.MaPN = txtmaphieunhap.Text;
                kh.TenNhom = textBox2.Text;
               

                quanli.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                frmDanhMuc_Load(sender, e);
            }
        }
    }
}
