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
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
            

        }
        

        private void groupHoaDonNhap_Enter(object sender, EventArgs e)
        {

        }

        private void dtgnhaphang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void quanlinhaphang_Load(object sender, EventArgs e)


        {
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {
                cbncc.DataSource = quanli.NhaCungCaps.ToList();
                cbncc.DisplayMember = "MaNCC";
                cbncc.ValueMember = "MaNCC";

                cbmanv.DataSource = quanli.NhanViens.ToList();
                cbmanv.DisplayMember = "MaNV";
                cbmanv.ValueMember = "MaNV";
            }
            // TODO: This line of code loads data into the 'qLBanXeDataSet3.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.pHIEUNHAPTableAdapter3.Fill(this.qLBanXeDataSet3.PHIEUNHAP);
            // TODO: This line of code loads data into the 'qLBanXeDataSet2.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.pHIEUNHAPTableAdapter2.Fill(this.qLBanXeDataSet2.PHIEUNHAP);
            //// TODO: This line of code loads data into the 'qLBanXeDataSet1.PhieuNhap' table. You can move, or remove it, as needed.
            //this.phieuNhapTableAdapter1.Fill(this.qLBanXeDataSet1.PhieuNhap);
            //// TODO: This line of code loads data into the 'qLBanXeDataSet.PhieuNhap' table. You can move, or remove it, as needed.
            //this.phieuNhapTableAdapter.Fill(this.qLBanXeDataSet.PhieuNhap);

        }
        public bool kiemtra()
        {
            if ( txttinhtrang.Text == "" || txttongtiennhap.Text == "" || txtngaynhap.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return false;
            }
            else
                return true;
        }
        string mapn = "";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                    }

        private void dgvPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
            {
                return;
            }
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {

                quanli.INSSERTPN(txtngaynhap.Value, int.Parse(txttongtiennhap.Text), txttinhtrang.Text, cbncc.Text, cbmanv.Text);
                quanli.SaveChanges();
                MessageBox.Show("Thêm!");
               quanlinhaphang_Load (sender, e);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
          // txtngaynhap.Value = "20/2/2019 ";
            cbmanv.Text = "";
            cbncc.Text = "";
            txttinhtrang.Text = "";
            txttongtiennhap.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mapn == "")
            {
                MessageBox.Show("Hãy chọn khách hàng cần sửa!");
                return;
            }
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {
                PHIEUNHAP kh = quanli.PHIEUNHAPs.FirstOrDefault(p => p.MaPN == mapn);
                //kh.MaPN = txtmaphieunhap.Text;
                kh.NgayLapPN =txtngaynhap.Value;
                kh.TongTien =int.Parse( txttongtiennhap.Text);
                kh.TinhTrang = txttinhtrang.Text;
                kh.MaNCC = cbncc.Text;
                kh.MaNV = cbmanv.Text;
                quanli.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                quanlinhaphang_Load(sender, e);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hóa đơn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
                {
                    PHIEUNHAP hd = quanli.PHIEUNHAPs.FirstOrDefault(p => p.MaPN == mapn);
                    if (hd != null)
                    {
                        quanli.PHIEUNHAPs.Remove(hd);
                        quanli.SaveChanges();
                        MessageBox.Show("Đã xóa!");
                        quanlinhaphang_Load(sender, e);
                    }
                }
            }  }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dgvPN_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            cbncc.Text = "";
            cbmanv.Text = "";
            txtngaynhap.Text = "";
            txttinhtrang.Text = "";
            txttongtiennhap.Text = "";

        }

        private void dgvPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mapn = dgvPN.CurrentRow.Cells[0].Value.ToString();
            txtngaynhap.Value = Convert.ToDateTime(dgvPN.CurrentRow.Cells[1].Value.ToString());
            txttongtiennhap.Text = dgvPN.CurrentRow.Cells[2].Value.ToString();
            txttinhtrang.Text = dgvPN.CurrentRow.Cells[3].Value.ToString();
            cbncc.Text = dgvPN.CurrentRow.Cells[4].Value.ToString();
            cbmanv.Text = dgvPN.CurrentRow.Cells[5].Value.ToString();

            // MessageBox.Show(e.ColumnIndex.ToString());
        }
    }
}
