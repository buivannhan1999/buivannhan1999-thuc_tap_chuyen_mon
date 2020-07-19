using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ttcm
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        public bool kiemtra()
        {
            if (txttensp.Text == "" || txtgiaban.Text == "" || txtmanhom.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return false;
            }
            else
                return true;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBanXeDataSet10.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.qLBanXeDataSet10.SanPham);

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
            {
                return;
            }
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {

                quanli.insertSP(txttensp.Text,txtmanhom.Text, int.Parse(txtgiaban.Text),int.Parse(txtslton.Text),ImageToByteArray(pcHinh.Image) );

                quanli.SaveChanges();
                MessageBox.Show("Thêm thành công!");
             frmSanPham_Load(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            // chose the images type
            opf.Filter = "Choose Image(.jpg;.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                // get the image returned by OpenFileDialog 
                pcHinh.Image = Image.FromFile(opf.FileName);
            }
        }
        string masp = "";
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtmasp.Text == "")
            {
                MessageBox.Show("Hãy chọn dòng cần sửa!");
                return;
            }
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {
                SanPham kh = quanli.SanPhams.FirstOrDefault(p => p.MaSP == txtmasp.Text);
               // kh.MaSP = txtmasp.Text;
                kh.TenSP = txttensp.Text;
                kh.MaNhom = txtmanhom.Text;
                kh.GiaBan = int.Parse(txtgiaban.Text);
                kh.SoLuongTon = int.Parse(txtslton.Text);
                kh.HinhAnh = ImageToByteArray(pcHinh.Image);

                quanli.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                frmSanPham_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
                {
                    SanPham hd = quanli.SanPhams.FirstOrDefault(p => p.MaSP == txtmasp.Text);
                    if (hd != null)
                    {
                        quanli.SanPhams.Remove(hd);
                        quanli.SaveChanges();
                        MessageBox.Show("Đã xóa!");
                        frmSanPham_Load(sender, e);
                    }
                }
            }
        }

        private void btnLM_Click(object sender, EventArgs e)
        {
            
        }

        private void dvgsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtmasp.Text = dvgsp.CurrentRow.Cells[0].Value.ToString();
            txttensp.Text = dvgsp.CurrentRow.Cells[1].Value.ToString();
            txtmanhom.Text = dvgsp.CurrentRow.Cells[2].Value.ToString();
            txtgiaban.Text = dvgsp.CurrentRow.Cells[3].Value.ToString();
            txtslton.Text = dvgsp.CurrentRow.Cells[4].Value.ToString();
            //txtgiaban.Text = dvgsp.CurrentRow.Cells[5].Value.ToString();
            MemoryStream ms = new MemoryStream((byte[])dvgsp.CurrentRow.Cells[5].Value);

            pcHinh.Image = Image.FromStream(ms);
        }
    }
}
