namespace ttcm
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLM = new System.Windows.Forms.Button();
            this.dgvhd = new System.Windows.Forms.DataGridView();
            this.Machitiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbmasp = new System.Windows.Forms.ComboBox();
            this.txtmact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbmahd = new System.Windows.Forms.ComboBox();
            this.labeldongia = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(382, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chi Tiết Hóa Đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã Sản Phẩm";
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(538, 75);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(148, 20);
            this.txtsl.TabIndex = 10;
            this.txtsl.TextChanged += new System.EventHandler(this.txtsl_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số Lượng";
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(538, 108);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(148, 20);
            this.txtthanhtien.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Thành Tiền";
            // 
            // btnLM
            // 
            this.btnLM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLM.Image = ((System.Drawing.Image)(resources.GetObject("btnLM.Image")));
            this.btnLM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLM.Location = new System.Drawing.Point(373, 134);
            this.btnLM.Name = "btnLM";
            this.btnLM.Size = new System.Drawing.Size(87, 30);
            this.btnLM.TabIndex = 64;
            this.btnLM.Text = "Lưu";
            this.btnLM.UseVisualStyleBackColor = true;
            // 
            // dgvhd
            // 
            this.dgvhd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhd.BackgroundColor = System.Drawing.Color.Orange;
            this.dgvhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Machitiet,
            this.MaHoadon,
            this.masanpham,
            this.soluong,
            this.tongtien});
            this.dgvhd.Location = new System.Drawing.Point(12, 170);
            this.dgvhd.Name = "dgvhd";
            this.dgvhd.Size = new System.Drawing.Size(878, 165);
            this.dgvhd.TabIndex = 65;
            this.dgvhd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhd_CellClick);
            this.dgvhd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhd_CellContentClick);
            // 
            // Machitiet
            // 
            this.Machitiet.DataPropertyName = "Machitiet";
            this.Machitiet.HeaderText = "Ma chi tiet";
            this.Machitiet.Name = "Machitiet";
            // 
            // MaHoadon
            // 
            this.MaHoadon.DataPropertyName = "MaHoadon";
            this.MaHoadon.HeaderText = "ma hoa don";
            this.MaHoadon.Name = "MaHoadon";
            // 
            // masanpham
            // 
            this.masanpham.DataPropertyName = "masanpham";
            this.masanpham.HeaderText = "ma san pham";
            this.masanpham.Name = "masanpham";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "so luong";
            this.soluong.Name = "soluong";
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "tong tien";
            this.tongtien.Name = "tongtien";
            // 
            // cbmasp
            // 
            this.cbmasp.FormattingEnabled = true;
            this.cbmasp.Location = new System.Drawing.Point(154, 100);
            this.cbmasp.Name = "cbmasp";
            this.cbmasp.Size = new System.Drawing.Size(148, 21);
            this.cbmasp.TabIndex = 66;
            this.cbmasp.SelectedIndexChanged += new System.EventHandler(this.cbmasp_SelectedIndexChanged);
            // 
            // txtmact
            // 
            this.txtmact.Location = new System.Drawing.Point(154, 35);
            this.txtmact.Name = "txtmact";
            this.txtmact.Size = new System.Drawing.Size(145, 20);
            this.txtmact.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Mã Chi Tiết";
            // 
            // cbmahd
            // 
            this.cbmahd.FormattingEnabled = true;
            this.cbmahd.Location = new System.Drawing.Point(154, 67);
            this.cbmahd.Name = "cbmahd";
            this.cbmahd.Size = new System.Drawing.Size(148, 21);
            this.cbmahd.TabIndex = 69;
            // 
            // labeldongia
            // 
            this.labeldongia.AutoSize = true;
            this.labeldongia.Location = new System.Drawing.Point(450, 42);
            this.labeldongia.Name = "labeldongia";
            this.labeldongia.Size = new System.Drawing.Size(46, 13);
            this.labeldongia.TabIndex = 70;
            this.labeldongia.Text = "Đơn Giá";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(538, 42);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(148, 20);
            this.txtdongia.TabIndex = 71;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(154, 134);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 30);
            this.btnThem.TabIndex = 72;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(931, 347);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.labeldongia);
            this.Controls.Add(this.cbmahd);
            this.Controls.Add(this.txtmact);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbmasp);
            this.Controls.Add(this.dgvhd);
            this.Controls.Add(this.btnLM);
            this.Controls.Add(this.txtthanhtien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLM;
        private System.Windows.Forms.DataGridView dgvhd;
        private System.Windows.Forms.ComboBox cbmasp;
        private System.Windows.Forms.TextBox txtmact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbmahd;
        private System.Windows.Forms.Label labeldongia;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machitiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn masanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.Button btnThem;
    }
}