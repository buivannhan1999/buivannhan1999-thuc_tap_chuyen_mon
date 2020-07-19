namespace ttcm
{
    partial class frmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            this.txtthongtin = new System.Windows.Forms.Label();
            this.txtSDTNCC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiaChiNCC = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtTenNhaCC = new System.Windows.Forms.TextBox();
            this.aaa = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.dtgncc = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ĐiaChiNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GmailNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtgmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgncc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtthongtin
            // 
            this.txtthongtin.AutoSize = true;
            this.txtthongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthongtin.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtthongtin.Location = new System.Drawing.Point(294, 11);
            this.txtthongtin.Name = "txtthongtin";
            this.txtthongtin.Size = new System.Drawing.Size(278, 25);
            this.txtthongtin.TabIndex = 70;
            this.txtthongtin.Text = "Thông Tin Nhà Cung Cấp";
            this.txtthongtin.Click += new System.EventHandler(this.txtthongtin_Click);
            // 
            // txtSDTNCC
            // 
            this.txtSDTNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDTNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTNCC.Location = new System.Drawing.Point(584, 88);
            this.txtSDTNCC.Name = "txtSDTNCC";
            this.txtSDTNCC.Size = new System.Drawing.Size(217, 26);
            this.txtSDTNCC.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(453, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "SĐT:";
            // 
            // txtDiaChiNCC
            // 
            this.txtDiaChiNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiaChiNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiNCC.Location = new System.Drawing.Point(584, 56);
            this.txtDiaChiNCC.Name = "txtDiaChiNCC";
            this.txtDiaChiNCC.Size = new System.Drawing.Size(217, 26);
            this.txtDiaChiNCC.TabIndex = 66;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(408, 52);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(114, 13);
            this.label.TabIndex = 67;
            this.label.Text = "Địa Chỉ Nhà Cung Cấp";
            // 
            // txtTenNhaCC
            // 
            this.txtTenNhaCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNhaCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhaCC.Location = new System.Drawing.Point(160, 93);
            this.txtTenNhaCC.Name = "txtTenNhaCC";
            this.txtTenNhaCC.Size = new System.Drawing.Size(217, 26);
            this.txtTenNhaCC.TabIndex = 64;
            // 
            // aaa
            // 
            this.aaa.AutoSize = true;
            this.aaa.Location = new System.Drawing.Point(27, 101);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(99, 13);
            this.aaa.TabIndex = 65;
            this.aaa.Text = "Tên Nhà Cung Cấp";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(160, 57);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(217, 26);
            this.txtMaNCC.TabIndex = 62;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(27, 60);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(95, 13);
            this.txt.TabIndex = 63;
            this.txt.Text = "Mã Nhà Cung Cấp";
            // 
            // dtgncc
            // 
            this.dtgncc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgncc.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dtgncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgncc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNhaCC,
            this.ĐiaChiNCC,
            this.SDTNCC,
            this.GmailNCC});
            this.dtgncc.Location = new System.Drawing.Point(30, 186);
            this.dtgncc.Name = "dtgncc";
            this.dtgncc.Size = new System.Drawing.Size(757, 116);
            this.dtgncc.TabIndex = 71;
            this.dtgncc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgncc_CellClick);
            this.dtgncc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgncc_CellContentClick);
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "MaNCC";
            this.MaNCC.Name = "MaNCC";
            // 
            // TenNhaCC
            // 
            this.TenNhaCC.DataPropertyName = "TenNhaCC";
            this.TenNhaCC.HeaderText = "TenNCC";
            this.TenNhaCC.Name = "TenNhaCC";
            // 
            // ĐiaChiNCC
            // 
            this.ĐiaChiNCC.DataPropertyName = "ĐiaChiNCC";
            this.ĐiaChiNCC.HeaderText = "DiaChiNCC";
            this.ĐiaChiNCC.Name = "ĐiaChiNCC";
            // 
            // SDTNCC
            // 
            this.SDTNCC.DataPropertyName = "SDTNCC";
            this.SDTNCC.HeaderText = "SDTNCC";
            this.SDTNCC.Name = "SDTNCC";
            // 
            // GmailNCC
            // 
            this.GmailNCC.DataPropertyName = "GmailNCC";
            this.GmailNCC.HeaderText = "Gmail";
            this.GmailNCC.Name = "GmailNCC";
            // 
            // txtgmail
            // 
            this.txtgmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtgmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgmail.Location = new System.Drawing.Point(160, 130);
            this.txtgmail.Name = "txtgmail";
            this.txtgmail.Size = new System.Drawing.Size(217, 26);
            this.txtgmail.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Gmail";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(671, 317);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 33);
            this.btnThoat.TabIndex = 76;
            this.btnThoat.Text = "Thoát ";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(483, 317);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 33);
            this.btnXoa.TabIndex = 74;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(72, 317);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 33);
            this.btnThem.TabIndex = 72;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(283, 317);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 33);
            this.btnSua.TabIndex = 73;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(929, 356);
            this.Controls.Add(this.txtgmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dtgncc);
            this.Controls.Add(this.txtthongtin);
            this.Controls.Add(this.txtSDTNCC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDiaChiNCC);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtTenNhaCC);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhaCungCap";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.quanliNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgncc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtthongtin;
        private System.Windows.Forms.TextBox txtSDTNCC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiaChiNCC;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtTenNhaCC;
        private System.Windows.Forms.Label aaa;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.DataGridView dtgncc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtgmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ĐiaChiNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn GmailNCC;
    }
}