namespace ttcm
{
    partial class frmNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txttongtiennhap = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvPN = new System.Windows.Forms.DataGridView();
            this.maPNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapPNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanXeDataSet3 = new ttcm.QLBanXeDataSet3();
            this.txtngaynhap = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHoan = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.phieuNhapTableAdapter = new ttcm.QLBanXeDataSetTableAdapters.PhieuNhapTableAdapter();
            this.phieuNhapTableAdapter1 = new ttcm.QLBanXeDataSet1TableAdapters.PhieuNhapTableAdapter();
            this.qLBanXeDataSet2 = new ttcm.QLBanXeDataSet2();
            this.pHIEUNHAPTableAdapter2 = new ttcm.QLBanXeDataSet2TableAdapters.PHIEUNHAPTableAdapter();
            this.qLBanXeDataSet1 = new ttcm.QLBanXeDataSet1();
            this.pHIEUNHAPTableAdapter3 = new ttcm.QLBanXeDataSet3TableAdapters.PHIEUNHAPTableAdapter();
            this.qLBanXeDataSet = new ttcm.QLBanXeDataSet();
            this.cbncc = new System.Windows.Forms.ComboBox();
            this.cbmanv = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanXeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanXeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanXeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanXeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbmanv);
            this.panel1.Controls.Add(this.cbncc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txttongtiennhap);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txttinhtrang);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.dgvPN);
            this.panel1.Controls.Add(this.txtngaynhap);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnInHD);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnHoan);
            this.panel1.Controls.Add(this.btnGhi);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 308);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(350, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 24);
            this.label3.TabIndex = 72;
            this.label3.Text = "Quản Lí Nhập Hàng";
            // 
            // txttongtiennhap
            // 
            this.txttongtiennhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttongtiennhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongtiennhap.Location = new System.Drawing.Point(385, 120);
            this.txttongtiennhap.Name = "txttongtiennhap";
            this.txttongtiennhap.Size = new System.Drawing.Size(217, 26);
            this.txttongtiennhap.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(256, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 13);
            this.label15.TabIndex = 59;
            this.label15.Text = "Tổng Tiền Nhập";
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttinhtrang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttinhtrang.Location = new System.Drawing.Point(523, 43);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(217, 26);
            this.txttinhtrang.TabIndex = 54;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(425, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 57;
            this.label16.Text = "Tình Trạng";
            // 
            // dgvPN
            // 
            this.dgvPN.AutoGenerateColumns = false;
            this.dgvPN.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dgvPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPNDataGridViewTextBoxColumn,
            this.ngayLapPNDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn,
            this.maNCCDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn});
            this.dgvPN.DataSource = this.pHIEUNHAPBindingSource;
            this.dgvPN.Location = new System.Drawing.Point(23, 158);
            this.dgvPN.Name = "dgvPN";
            this.dgvPN.Size = new System.Drawing.Size(821, 150);
            this.dgvPN.TabIndex = 73;
            this.dgvPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPN_CellClick);
            this.dgvPN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPN_CellContentClick_1);
            // 
            // maPNDataGridViewTextBoxColumn
            // 
            this.maPNDataGridViewTextBoxColumn.DataPropertyName = "MaPN";
            this.maPNDataGridViewTextBoxColumn.FillWeight = 77.12082F;
            this.maPNDataGridViewTextBoxColumn.HeaderText = "MaPN";
            this.maPNDataGridViewTextBoxColumn.Name = "maPNDataGridViewTextBoxColumn";
            // 
            // ngayLapPNDataGridViewTextBoxColumn
            // 
            this.ngayLapPNDataGridViewTextBoxColumn.DataPropertyName = "NgayLapPN";
            this.ngayLapPNDataGridViewTextBoxColumn.FillWeight = 87.96004F;
            this.ngayLapPNDataGridViewTextBoxColumn.HeaderText = "NgayLapPN";
            this.ngayLapPNDataGridViewTextBoxColumn.Name = "ngayLapPNDataGridViewTextBoxColumn";
            this.ngayLapPNDataGridViewTextBoxColumn.Width = 114;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.FillWeight = 97.40605F;
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            this.tongTienDataGridViewTextBoxColumn.Width = 126;
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.FillWeight = 105.6379F;
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            this.tinhTrangDataGridViewTextBoxColumn.Width = 137;
            // 
            // maNCCDataGridViewTextBoxColumn
            // 
            this.maNCCDataGridViewTextBoxColumn.DataPropertyName = "MaNCC";
            this.maNCCDataGridViewTextBoxColumn.FillWeight = 112.8117F;
            this.maNCCDataGridViewTextBoxColumn.HeaderText = "MaNCC";
            this.maNCCDataGridViewTextBoxColumn.Name = "maNCCDataGridViewTextBoxColumn";
            this.maNCCDataGridViewTextBoxColumn.Width = 147;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.FillWeight = 119.0634F;
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 154;
            // 
            // pHIEUNHAPBindingSource
            // 
            this.pHIEUNHAPBindingSource.DataMember = "PHIEUNHAP";
            this.pHIEUNHAPBindingSource.DataSource = this.qLBanXeDataSet3;
            // 
            // qLBanXeDataSet3
            // 
            this.qLBanXeDataSet3.DataSetName = "QLBanXeDataSet3";
            this.qLBanXeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtngaynhap
            // 
            this.txtngaynhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtngaynhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngaynhap.Location = new System.Drawing.Point(523, 88);
            this.txtngaynhap.Name = "txtngaynhap";
            this.txtngaynhap.Size = new System.Drawing.Size(217, 26);
            this.txtngaynhap.TabIndex = 52;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(425, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 55;
            this.label17.Text = "Ngày nhập";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Mã Nhà Cung Cấp";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "Mã Nhân Viên";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(95, 497);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 30);
            this.btnSua.TabIndex = 61;
            this.btnSua.Text = "Sửa (&S)";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnInHD
            // 
            this.btnInHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInHD.Image = ((System.Drawing.Image)(resources.GetObject("btnInHD.Image")));
            this.btnInHD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHD.Location = new System.Drawing.Point(490, 497);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(138, 30);
            this.btnInHD.TabIndex = 65;
            this.btnInHD.Text = "In hóa đơn (&I)";
            this.btnInHD.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(-15, 497);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 30);
            this.btnThem.TabIndex = 60;
            this.btnThem.Text = "Thêm (&M)";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(634, 497);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 30);
            this.btnThoat.TabIndex = 66;
            this.btnThoat.Text = "Thoát (&T)";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHoan
            // 
            this.btnHoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHoan.Image = ((System.Drawing.Image)(resources.GetObject("btnHoan.Image")));
            this.btnHoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoan.Location = new System.Drawing.Point(379, 497);
            this.btnHoan.Name = "btnHoan";
            this.btnHoan.Size = new System.Drawing.Size(105, 30);
            this.btnHoan.TabIndex = 64;
            this.btnHoan.Text = "Hoãn (&H)";
            this.btnHoan.UseVisualStyleBackColor = true;
            // 
            // btnGhi
            // 
            this.btnGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGhi.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.Image")));
            this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGhi.Location = new System.Drawing.Point(286, 497);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(87, 30);
            this.btnGhi.TabIndex = 63;
            this.btnGhi.Text = "Ghi (&G)";
            this.btnGhi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(193, 497);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 30);
            this.btnXoa.TabIndex = 62;
            this.btnXoa.Text = "Xóa (&X)";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(71, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 67;
            this.button1.Text = "Thêm ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(377, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 30);
            this.button2.TabIndex = 69;
            this.button2.Text = "Xóa ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(226, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 30);
            this.button3.TabIndex = 68;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(708, 315);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 30);
            this.button5.TabIndex = 71;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.Location = new System.Drawing.Point(550, 315);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 30);
            this.button7.TabIndex = 70;
            this.button7.Text = "Làm mới";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapTableAdapter1
            // 
            this.phieuNhapTableAdapter1.ClearBeforeFill = true;
            // 
            // qLBanXeDataSet2
            // 
            this.qLBanXeDataSet2.DataSetName = "QLBanXeDataSet2";
            this.qLBanXeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEUNHAPTableAdapter2
            // 
            this.pHIEUNHAPTableAdapter2.ClearBeforeFill = true;
            // 
            // qLBanXeDataSet1
            // 
            this.qLBanXeDataSet1.DataSetName = "QLBanXeDataSet1";
            this.qLBanXeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEUNHAPTableAdapter3
            // 
            this.pHIEUNHAPTableAdapter3.ClearBeforeFill = true;
            // 
            // qLBanXeDataSet
            // 
            this.qLBanXeDataSet.DataSetName = "QLBanXeDataSet";
            this.qLBanXeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbncc
            // 
            this.cbncc.FormattingEnabled = true;
            this.cbncc.Location = new System.Drawing.Point(166, 54);
            this.cbncc.Name = "cbncc";
            this.cbncc.Size = new System.Drawing.Size(134, 21);
            this.cbncc.TabIndex = 74;
            // 
            // cbmanv
            // 
            this.cbmanv.FormattingEnabled = true;
            this.cbmanv.Location = new System.Drawing.Point(167, 98);
            this.cbmanv.Name = "cbmanv";
            this.cbmanv.Size = new System.Drawing.Size(134, 21);
            this.cbmanv.TabIndex = 75;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(931, 347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhapHang";
            this.Text = "quanlinhaphang";
            this.Load += new System.EventHandler(this.quanlinhaphang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanXeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanXeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanXeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanXeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttongtiennhap;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapPNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pHIEUNHAPBindingSource;
        private QLBanXeDataSet3 qLBanXeDataSet3;
        private System.Windows.Forms.DateTimePicker txtngaynhap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHoan;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnXoa;
        private QLBanXeDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private QLBanXeDataSet1TableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter1;
        private QLBanXeDataSet2 qLBanXeDataSet2;
        private QLBanXeDataSet2TableAdapters.PHIEUNHAPTableAdapter pHIEUNHAPTableAdapter2;
        private QLBanXeDataSet1 qLBanXeDataSet1;
        private QLBanXeDataSet3TableAdapters.PHIEUNHAPTableAdapter pHIEUNHAPTableAdapter3;
        private QLBanXeDataSet qLBanXeDataSet;
        private System.Windows.Forms.ComboBox cbmanv;
        private System.Windows.Forms.ComboBox cbncc;
    }
}