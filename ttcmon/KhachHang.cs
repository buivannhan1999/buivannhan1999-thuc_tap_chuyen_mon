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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
            LoadDL();
        }
        public void LoadDL()
        {
            string query = " select * from KhachHang";
            DataTable data = Connectcs.Instance.excuteQuery(query);
            dtg1.DataSource = data;

        }
        public bool kiemtra(string MaKH)
        {
            string query = "select *from KhachHang where MaKH='" + txtMaKH.Text + "'";
            DataTable data = Connectcs.Instance.excuteQuery(query);
            int dem = 0;
            foreach (DataRow item in data.Rows)
            {
                dem++;
            }
            if (dem > 0)
                return true;
            return false;
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("vui long nhap du thong tin");
            }
            else
            {
                if (kiemtra(txtMaKH.Text) == true)
                {
                    MessageBox.Show("ma da ton tai");
                    return;
                }
                try
                {
                    string query = "insert into KhachHang values (N'"+ txtMaKH.Text + "','" + txtNgaySinh.Text + "','" + txtSDT.Text + "','" + txtMail.Text + "')";
                    DataTable data = Connectcs.Instance.excuteQuery(query);
                    MessageBox.Show("Thêm thanh cong");
                    LoadDL();
                }
                catch
                {
                    MessageBox.Show("Thêm that bai");
                }
            }
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
                txtMaKH.Text = dtg1.Rows[row].Cells["MaKH"].Value.ToString();

                txttenKH.Text = dtg1.Rows[row].Cells["tenKH"].Value.ToString();
                txtNgaySinh.Text = dtg1.Rows[row].Cells["NgaySinh"].Value.ToString();
                txtSDT.Text = dtg1.Rows[row].Cells["SDT"].Value.ToString();
                txtMail.Text = dtg1.Rows[row].Cells["GMailKH"].Value.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("vui long chon dong can sua");
            }
            else
            {
                try
                {
                    string query = "update KhachHang set tenKH=N'" + txttenKH.Text + "',Ngaysinh='" + txtNgaySinh.Text + "',SDT='" + txtSDT.Text + "',GmailKH=N'" + txtMail.Text + "'Where MaKH='" + txtMaKH.Text + "'";
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

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtMaKH.Text == "")
            {
                MessageBox.Show("vui long chon dong can xoa");
            }
            else
            {
                try {
                    string query = " delete KhachHang where MaKH='" + txtMaKH.Text + "'";
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
