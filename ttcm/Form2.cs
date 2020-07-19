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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {
                cbmahd.DataSource = quanli.HOADONs.ToList();
                cbmahd.DisplayMember = "MaHD";
                cbmahd.ValueMember = "MaHD";

                cbmasp.DataSource = quanli.SanPhams.ToList();
                cbmasp.DisplayMember = "MaSP";
                cbmasp.ValueMember = "MaSP";
                dgvhd.AutoGenerateColumns = false;
                dgvhd.DataSource = quanli.cthoadons.ToList();
            }




                    }

        private void dgvhd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbmasp_SelectedIndexChanged(object sender, EventArgs e)
        {
           using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
                {
                SanPham sanPham = quanli.SanPhams.Where(s => s.MaSP == cbmasp.Text).FirstOrDefault();
                if(sanPham !=null)
                {
                    txtdongia.Text = sanPham.GiaBan.ToString();
                }

            }



        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            using (QLBanXeEntities1 quanli = new QLBanXeEntities1())
            {

                quanli.inssertCThoadon(txtmact.Text, cbmahd.Text, cbmasp.Text, Convert.ToInt32(txtsl.Text), Convert.ToInt32(txtthanhtien.Text));
                quanli.update_Hd(cbmahd.Text, Convert.ToInt32(txtthanhtien.Text));
                SanPham sanPham = quanli.SanPhams.Where(s => s.MaSP == cbmasp.Text).FirstOrDefault();
                if(sanPham!=null)
                {
                    sanPham.SoLuongTon -= Convert.ToInt32(txtsl.Text);
                }    
                quanli.SaveChanges();
                MessageBox.Show("Thêm thành công!");
                Form2_Load(sender, e);
            }
        }

        private void txtsl_TextChanged(object sender, EventArgs e)
        {
            if(txtsl.Text!="")
            {
                txtthanhtien.Text = (Convert.ToInt32(txtdongia.Text) * Convert.ToInt32(txtsl.Text)).ToString();


            }
        }

        private void dgvhd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvhd.CurrentRow.Index;
            txtmact.Text = dgvhd.Rows[i].Cells[0].Value.ToString();
            cbmahd.Text = dgvhd.Rows[i].Cells[1].Value.ToString();
            cbmasp.Text = dgvhd.Rows[i].Cells[2].Value.ToString();
          
            txtsl.Text = dgvhd.Rows[i].Cells[3].Value.ToString();
            txtthanhtien.Text = dgvhd.Rows[i].Cells[4].Value.ToString();
            //txtthanhtien.Text = dgvhd.Rows[i].Cells[5].Value.ToString();

        }
    }
}
