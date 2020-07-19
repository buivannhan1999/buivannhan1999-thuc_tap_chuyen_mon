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
    public partial class frmCTPhieuNhap : Form
    {
        public frmCTPhieuNhap()
        {
            InitializeComponent();
        }
        public bool kiemtra()
        {
            if (cbmasp.Text == "" || txtgianhap.Text == "" || txtsoluong.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return false;
            }
            else
                return true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCTPhieuNhap_Load(object sender, EventArgs e)

        {
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {
                cbmasp.DataSource = quanli.SanPhams.ToList();
                cbmasp.DisplayMember = "MaSP";
                cbmasp.ValueMember = "MaSP";

                cbmaPN.DataSource = quanli.PHIEUNHAPs.ToList();
                cbmaPN.DisplayMember = "MaPN";
                cbmaPN.ValueMember = "MaPN";
            }

            // TODO: This line of code loads data into the 'qLBanXeDataSet12.CTPHIEUNHAP' table. You can move, or remove it, as needed.
            this.cTPHIEUNHAPTableAdapter.Fill(this.qLBanXeDataSet12.CTPHIEUNHAP);


        }
        string mapn = "";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {

                quanli.insertctphieunhap123(cbmaPN.Text, cbmasp.Text,  int.Parse(txtgianhap.Text),  int.Parse(txtsoluong.Text), int.Parse(txtthanhtien.Text));

                SanPham sanPham = quanli.SanPhams.Where(s => s.MaSP == cbmasp.Text).FirstOrDefault();
                if(sanPham!=null)
                {
                    sanPham.SoLuongTon += int.Parse(txtsoluong.Text);
                }    
              

                quanli.SaveChanges();
                MessageBox.Show("Thêm thành công!");
                frmCTPhieuNhap_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {
                CTPHIEUNHAP hd = quanli.CTPHIEUNHAPs.Where(p => p.MaPN == cbmaPN.Text).Where(p => p.MaSP == cbmasp.Text).FirstOrDefault();
                if (hd != null)
                {
                    quanli.CTPHIEUNHAPs.Remove(hd);
                    quanli.SaveChanges();
                    MessageBox.Show("Đã xóa!");
                    frmCTPhieuNhap_Load(sender, e);
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {
                CTPHIEUNHAP kh = quanli.CTPHIEUNHAPs.Where(p => p.MaPN == cbmaPN.Text).Where(p=>p.MaSP==cbmasp.Text).FirstOrDefault();
                //kh.MaPN = txtmaphieunhap.Text;

                kh.GiaNhap =Convert.ToInt32 (txtgianhap.Text);
                kh.SoLuong = Convert.ToInt32(txtsoluong.Text);
                kh.ThanhTien = Convert.ToInt32(txtthanhtien.Text);

                quanli.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                frmCTPhieuNhap_Load(sender, e);
            }
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            if (txtsoluong.Text != "")
            {
                using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
                {
                    SanPham sanPham = quanli.SanPhams.Where(s => s.MaSP == cbmasp.Text).FirstOrDefault();
                    if(sanPham!=null)
                    {
                        int i = Convert.ToInt32(sanPham.GiaBan) * Convert.ToInt32(txtsoluong.Text);
                        txtthanhtien.Text = i.ToString();



                    }
                   

                }
                   
            }
        }

        private void cbmasp_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {
                SanPham sanPham = quanli.SanPhams.Where(s => s.MaSP == cbmasp.Text).FirstOrDefault();
                if(sanPham !=null)
                {
                    txtgianhap.Text = sanPham.GiaBan.ToString();
                }    
            }    
        }

        private void cbmaPN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvctpn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbmaPN.Text = dgvctpn.CurrentRow.Cells[0].Value.ToString();
            cbmasp.Text = dgvctpn.CurrentRow.Cells[1].Value.ToString();
            txtgianhap.Text = dgvctpn.CurrentRow.Cells[2].Value.ToString();

            txtsoluong.Text = dgvctpn.CurrentRow.Cells[3].Value.ToString();
            txtthanhtien.Text = dgvctpn.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
