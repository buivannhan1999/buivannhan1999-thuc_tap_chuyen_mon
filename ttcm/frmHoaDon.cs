using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ttcm
{
    public partial class frmHoaDon : Form
    {
        private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QLBanXe;Integrated Security=True";
        public frmHoaDon()
        {
            InitializeComponent();
            LoadDL();
            LoadNV();
            LoadKH();

        }
        public void LoadDL()
        {
            string query = " select * from HoaDon hd, NhanVien nv, KHACHHANG kh where hd.MaNV = nv.MaNV and hd.MaKH = kh.MaKH ";
            DataTable data = Class1.Instance.excuteQuery(query);
            dgvhoadon.AutoGenerateColumns = false;
          //  txtmahd.Enabled = false;
            dgvhoadon.DataSource = data;

        }
        public void LoadNV()
        {
            string query = "select * from NhanVien";
            DataTable nhanvien = Class1.Instance.excuteQuery(query);
            cbtennv.DataSource = nhanvien;
            cbtennv.ValueMember = "MaNV";
            cbtennv.DisplayMember = "MaNV";

        }
        public void LoadKH()
        {
            string query = "select * from KHACHHANG";
            DataTable KHACHHANG = Class1.Instance.excuteQuery(query);
            cbtenkh.DataSource = KHACHHANG;
            cbtenkh.ValueMember = "MaKH";
            cbtenkh.DisplayMember = "MaKH";

        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadDL();
           

        }

        private void dgvhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
            {
                return;

            }
            else
            {
                txtmahd.Text = dgvhoadon.Rows[row].Cells["MaHD"].Value.ToString();
                dtngaylap.Text = dgvhoadon.Rows[row].Cells["NgayLapHD"].Value.ToString();
                txttongtien.Text = dgvhoadon.Rows[row].Cells["TongTien"].Value.ToString();
              //  txttinhtrang.Text = dgvhoadon.Rows[row].Cells["ThanhToan"].Value.ToString();
                cbtennv.Text = dgvhoadon.Rows[row].Cells["MaNV"].Value.ToString();
                cbtenkh.Text = dgvhoadon.Rows[row].Cells["MaKH"].Value.ToString();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string querry = "Insert into HoaDon values (@MaHD,@NgayLapHD,@TongTien,@ThanhToan,@MaNV,@MaKH)";
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@MaHD", txtmahd.Text);

            command.Parameters.AddWithValue("@NgayLapHD", dtngaylap.Value.ToString("yyyy/MM/dd"));
            command.Parameters.AddWithValue("@TongTien", 0);
            command.Parameters.AddWithValue("ThanhToan", false);
            command.Parameters.AddWithValue("@MaNV", cbtennv.SelectedValue.ToString());
            command.Parameters.AddWithValue("@MaKH", cbtenkh.SelectedValue.ToString());
            int a = command.ExecuteNonQuery();
            if(a>0)
            {
                HoaDon_Load(sender, e);
                MessageBox.Show("Thêm Thành Công");
            }
            conn.Close();

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtmahd.Text == "")
            {
                MessageBox.Show("vui long chon dong can xoa");
            }
            else
            {
                try
                {
                    string query = " delete HoaDon where MaHD='" + txtmahd.Text + "'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            // Dua du lieu vao excel
            worksheet.Cells[1, 7] = "Report tat ca Hoa Don " + txttimkiem.Text;
            worksheet.Cells[2, 7] = "Tong tien:" + label8.Text;




            worksheet.Cells[3, 4] = "STT";
            worksheet.Cells[3, 5] = "Ma hoa don";
            worksheet.Cells[3, 6] = "ngay lap ";
            worksheet.Cells[3, 7] = "tong tien";
            worksheet.Cells[3, 8] = "ma nhan vien";
            worksheet.Cells[3, 9] = "ma khach hang";
            for (int i = 0; i < dgvhoadon.RowCount - 1; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    worksheet.Cells[i + 4, 4] = i + 1;
                    worksheet.Cells[i + 4, j + 5] = dgvhoadon.Rows[i].Cells[j].Value;
                }
            }
            
        }
        public void timkiem(string s)
        {
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())

            {
                dgvhoadon.DataSource = quanli.seaching_tongtienthang1(s);

            }

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            timkiem(txttimkiem.Text);
            int tongtien = 0;
            for(int i=0;i<dgvhoadon.RowCount-1;i++)
            {
                tongtien += Convert.ToInt32(dgvhoadon.Rows[i].Cells["TongTien"].Value);

            }


            label8.Text = tongtien.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            this.Show();
            f.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            this.Show();
            f.ShowDialog();
            this.Hide();
        }
    }
}
