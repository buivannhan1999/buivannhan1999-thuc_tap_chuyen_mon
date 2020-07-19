namespace ttcm
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnanh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLM = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.pcHinh = new System.Windows.Forms.PictureBox();
            this.txtslton = new System.Windows.Forms.TextBox();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmanhom = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgsp = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhAnhDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanXeDataSet10 = new ttcm.QLBanXeDataSet10();
            this.sanPhamTableAdapter = new ttcm.QLBanXeDataSet10TableAdapters.SanPhamTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanXeDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnanh);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLM);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.pcHinh);
            this.panel1.Controls.Add(this.txtslton);
            this.panel1.Controls.Add(this.txtgiaban);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtmanhom);
            this.panel1.Controls.Add(this.txttensp);
            this.panel1.Controls.Add(this.txtmasp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 235);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnanh
            // 
            this.btnanh.Location = new System.Drawing.Point(702, 161);
            this.btnanh.Name = "btnanh";
            this.btnanh.Size = new System.Drawing.Size(75, 23);
            this.btnanh.TabIndex = 12;
            this.btnanh.Text = "ảnh";
            this.btnanh.UseVisualStyleBackColor = true;
            this.btnanh.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(600, 171);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 30);
            this.btnThoat.TabIndex = 62;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(312, 171);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 30);
            this.btnXoa.TabIndex = 60;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLM
            // 
            this.btnLM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLM.Image = ((System.Drawing.Image)(resources.GetObject("btnLM.Image")));
            this.btnLM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLM.Location = new System.Drawing.Point(463, 171);
            this.btnLM.Name = "btnLM";
            this.btnLM.Size = new System.Drawing.Size(87, 30);
            this.btnLM.TabIndex = 61;
            this.btnLM.Text = "Làm mới";
            this.btnLM.UseVisualStyleBackColor = true;
            this.btnLM.Click += new System.EventHandler(this.btnLM_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(24, 171);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 30);
            this.btnThem.TabIndex = 58;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(153, 171);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 30);
            this.btnSua.TabIndex = 59;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // pcHinh
            // 
            this.pcHinh.Image = global::ttcm.Properties.Resources.aa;
            this.pcHinh.Location = new System.Drawing.Point(600, 13);
            this.pcHinh.Name = "pcHinh";
            this.pcHinh.Size = new System.Drawing.Size(158, 142);
            this.pcHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcHinh.TabIndex = 11;
            this.pcHinh.TabStop = false;
            // 
            // txtslton
            // 
            this.txtslton.Location = new System.Drawing.Point(418, 88);
            this.txtslton.Name = "txtslton";
            this.txtslton.Size = new System.Drawing.Size(100, 20);
            this.txtslton.TabIndex = 9;
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(418, 43);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(100, 20);
            this.txtgiaban.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số Lượng Tồn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giá Bán";
            // 
            // txtmanhom
            // 
            this.txtmanhom.Location = new System.Drawing.Point(140, 135);
            this.txtmanhom.Name = "txtmanhom";
            this.txtmanhom.Size = new System.Drawing.Size(100, 20);
            this.txtmanhom.TabIndex = 5;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(140, 90);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(100, 20);
            this.txttensp.TabIndex = 4;
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(140, 43);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(100, 20);
            this.txtmasp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // dvgsp
            // 
            this.dvgsp.AutoGenerateColumns = false;
            this.dvgsp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgsp.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dvgsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.maNhomDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn,
            this.soLuongTonDataGridViewTextBoxColumn,
            this.hinhAnhDataGridViewImageColumn});
            this.dvgsp.DataSource = this.sanPhamBindingSource;
            this.dvgsp.Location = new System.Drawing.Point(4, 242);
            this.dvgsp.Name = "dvgsp";
            this.dvgsp.Size = new System.Drawing.Size(797, 104);
            this.dvgsp.TabIndex = 63;
            this.dvgsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgsp_CellClick);
            this.dvgsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "MaSP";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            // 
            // maNhomDataGridViewTextBoxColumn
            // 
            this.maNhomDataGridViewTextBoxColumn.DataPropertyName = "MaNhom";
            this.maNhomDataGridViewTextBoxColumn.HeaderText = "MaNhom";
            this.maNhomDataGridViewTextBoxColumn.Name = "maNhomDataGridViewTextBoxColumn";
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            // 
            // soLuongTonDataGridViewTextBoxColumn
            // 
            this.soLuongTonDataGridViewTextBoxColumn.DataPropertyName = "SoLuongTon";
            this.soLuongTonDataGridViewTextBoxColumn.HeaderText = "SoLuongTon";
            this.soLuongTonDataGridViewTextBoxColumn.Name = "soLuongTonDataGridViewTextBoxColumn";
            // 
            // hinhAnhDataGridViewImageColumn
            // 
            this.hinhAnhDataGridViewImageColumn.DataPropertyName = "HinhAnh";
            this.hinhAnhDataGridViewImageColumn.HeaderText = "HinhAnh";
            this.hinhAnhDataGridViewImageColumn.Name = "hinhAnhDataGridViewImageColumn";
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.qLBanXeDataSet10;
            // 
            // qLBanXeDataSet10
            // 
            this.qLBanXeDataSet10.DataSetName = "QLBanXeDataSet10";
            this.qLBanXeDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 25);
            this.label6.TabIndex = 63;
            this.label6.Text = "Thông Tin Sản Phẩm";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(931, 347);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dvgsp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanXeDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtmanhom;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtslton;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pcHinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLM;
        private System.Windows.Forms.DataGridView dvgsp;
        private QLBanXeDataSet10 qLBanXeDataSet10;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private QLBanXeDataSet10TableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn hinhAnhDataGridViewImageColumn;
        private System.Windows.Forms.Button btnanh;
        private System.Windows.Forms.Label label6;
    }
}