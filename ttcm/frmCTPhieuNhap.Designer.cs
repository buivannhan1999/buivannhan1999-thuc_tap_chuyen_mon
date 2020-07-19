namespace ttcm
{
    partial class frmCTPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTPhieuNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbmaPN = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cbmasp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvctpn = new System.Windows.Forms.DataGridView();
            this.maPNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTPHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanXeDataSet12 = new ttcm.QLBanXeDataSet12();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgianhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cTPHIEUNHAPTableAdapter = new ttcm.QLBanXeDataSet12TableAdapters.CTPHIEUNHAPTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvctpn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPHIEUNHAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanXeDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.cbmaPN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.cbmasp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dgvctpn);
            this.panel1.Controls.Add(this.txtthanhtien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtsoluong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtgianhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 385);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbmaPN
            // 
            this.cbmaPN.FormattingEnabled = true;
            this.cbmaPN.Location = new System.Drawing.Point(188, 45);
            this.cbmaPN.Name = "cbmaPN";
            this.cbmaPN.Size = new System.Drawing.Size(145, 21);
            this.cbmaPN.TabIndex = 76;
            this.cbmaPN.SelectedIndexChanged += new System.EventHandler(this.cbmaPN_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Mã phieu nhap";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(171, 148);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 30);
            this.btnThem.TabIndex = 72;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(485, 148);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 30);
            this.btnXoa.TabIndex = 74;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(331, 148);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 30);
            this.btnSua.TabIndex = 73;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cbmasp
            // 
            this.cbmasp.FormattingEnabled = true;
            this.cbmasp.Location = new System.Drawing.Point(188, 87);
            this.cbmasp.Name = "cbmasp";
            this.cbmasp.Size = new System.Drawing.Size(145, 21);
            this.cbmasp.TabIndex = 71;
            this.cbmasp.SelectedIndexChanged += new System.EventHandler(this.cbmasp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(302, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 25);
            this.label5.TabIndex = 70;
            this.label5.Text = "Chi Tiết Phiếu Nhập";
            // 
            // dgvctpn
            // 
            this.dgvctpn.AutoGenerateColumns = false;
            this.dgvctpn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvctpn.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.dgvctpn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvctpn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPNDataGridViewTextBoxColumn,
            this.maSPDataGridViewTextBoxColumn,
            this.giaNhapDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn});
            this.dgvctpn.DataSource = this.cTPHIEUNHAPBindingSource;
            this.dgvctpn.Location = new System.Drawing.Point(49, 184);
            this.dgvctpn.Name = "dgvctpn";
            this.dgvctpn.Size = new System.Drawing.Size(656, 150);
            this.dgvctpn.TabIndex = 69;
            this.dgvctpn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvctpn_CellClick);
            this.dgvctpn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maPNDataGridViewTextBoxColumn
            // 
            this.maPNDataGridViewTextBoxColumn.DataPropertyName = "MaPN";
            this.maPNDataGridViewTextBoxColumn.HeaderText = "MaPN";
            this.maPNDataGridViewTextBoxColumn.Name = "maPNDataGridViewTextBoxColumn";
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "MaSP";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            // 
            // giaNhapDataGridViewTextBoxColumn
            // 
            this.giaNhapDataGridViewTextBoxColumn.DataPropertyName = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn.HeaderText = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn.Name = "giaNhapDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            // 
            // cTPHIEUNHAPBindingSource
            // 
            this.cTPHIEUNHAPBindingSource.DataMember = "CTPHIEUNHAP";
            this.cTPHIEUNHAPBindingSource.DataSource = this.qLBanXeDataSet12;
            // 
            // qLBanXeDataSet12
            // 
            this.qLBanXeDataSet12.DataSetName = "QLBanXeDataSet12";
            this.qLBanXeDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(560, 122);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(145, 20);
            this.txtthanhtien.TabIndex = 11;
            this.txtthanhtien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thành Tiền";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(560, 80);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(145, 20);
            this.txtsoluong.TabIndex = 9;
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số Lượng";
            // 
            // txtgianhap
            // 
            this.txtgianhap.Location = new System.Drawing.Point(188, 122);
            this.txtgianhap.Name = "txtgianhap";
            this.txtgianhap.Size = new System.Drawing.Size(145, 20);
            this.txtgianhap.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Giá Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // cTPHIEUNHAPTableAdapter
            // 
            this.cTPHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // frmCTPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCTPhieuNhap";
            this.Text = "frmCTphieunhap";
            this.Load += new System.EventHandler(this.frmCTPhieuNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvctpn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPHIEUNHAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanXeDataSet12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgianhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvctpn;
        private QLBanXeDataSet12 qLBanXeDataSet12;
        private System.Windows.Forms.BindingSource cTPHIEUNHAPBindingSource;
        private QLBanXeDataSet12TableAdapters.CTPHIEUNHAPTableAdapter cTPHIEUNHAPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbmasp;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbmaPN;
        private System.Windows.Forms.Label label6;
    }
}