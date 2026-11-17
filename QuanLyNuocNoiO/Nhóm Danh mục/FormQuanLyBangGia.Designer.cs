namespace QuanLyNuocNoiO.Nhóm_Danh_mục
{
    partial class FormQuanLyBangGia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBangGia = new System.Windows.Forms.DataGridView();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.dtpNgayApDung = new System.Windows.Forms.DateTimePicker();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtBacDen = new System.Windows.Forms.TextBox();
            this.txtBacTu = new System.Windows.Forms.TextBox();
            this.txtTenBangGia = new System.Windows.Forms.TextBox();
            this.txtMaBangGia = new System.Windows.Forms.TextBox();
            this.lblNgayApDung = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblBacDen = new System.Windows.Forms.Label();
            this.lblBacTu = new System.Windows.Forms.Label();
            this.lblTenBangGia = new System.Windows.Forms.Label();
            this.lblMaBangGia = new System.Windows.Forms.Label();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangGia)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.pnlChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBangGia
            // 
            this.dgvBangGia.AllowUserToAddRows = false;
            this.dgvBangGia.AllowUserToDeleteRows = false;
            this.dgvBangGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBangGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangGia.BackgroundColor = System.Drawing.Color.White;
            this.dgvBangGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBangGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBangGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBangGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBangGia.ColumnHeadersHeight = 35;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBangGia.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBangGia.EnableHeadersVisualStyles = false;
            this.dgvBangGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBangGia.Location = new System.Drawing.Point(16, 15);
            this.dgvBangGia.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBangGia.MultiSelect = false;
            this.dgvBangGia.Name = "dgvBangGia";
            this.dgvBangGia.ReadOnly = true;
            this.dgvBangGia.RowHeadersVisible = false;
            this.dgvBangGia.RowHeadersWidth = 51;
            this.dgvBangGia.RowTemplate.Height = 30;
            this.dgvBangGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangGia.Size = new System.Drawing.Size(747, 647);
            this.dgvBangGia.TabIndex = 3;
            this.dgvBangGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangGia_CellClick_1);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTin.Controls.Add(this.dtpNgayApDung);
            this.grpThongTin.Controls.Add(this.txtDonGia);
            this.grpThongTin.Controls.Add(this.txtBacDen);
            this.grpThongTin.Controls.Add(this.txtBacTu);
            this.grpThongTin.Controls.Add(this.txtTenBangGia);
            this.grpThongTin.Controls.Add(this.txtMaBangGia);
            this.grpThongTin.Controls.Add(this.lblNgayApDung);
            this.grpThongTin.Controls.Add(this.lblDonGia);
            this.grpThongTin.Controls.Add(this.lblBacDen);
            this.grpThongTin.Controls.Add(this.lblBacTu);
            this.grpThongTin.Controls.Add(this.lblTenBangGia);
            this.grpThongTin.Controls.Add(this.lblMaBangGia);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.grpThongTin.Location = new System.Drawing.Point(784, 15);
            this.grpThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.grpThongTin.Size = new System.Drawing.Size(512, 418);
            this.grpThongTin.TabIndex = 4;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin Bảng giá";
            // 
            // dtpNgayApDung
            // 
            this.dtpNgayApDung.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayApDung.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpNgayApDung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayApDung.Location = new System.Drawing.Point(180, 351);
            this.dtpNgayApDung.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayApDung.Name = "dtpNgayApDung";
            this.dtpNgayApDung.Size = new System.Drawing.Size(305, 29);
            this.dtpNgayApDung.TabIndex = 5;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDonGia.Location = new System.Drawing.Point(180, 293);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(305, 29);
            this.txtDonGia.TabIndex = 4;
            // 
            // txtBacDen
            // 
            this.txtBacDen.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtBacDen.Location = new System.Drawing.Point(180, 235);
            this.txtBacDen.Margin = new System.Windows.Forms.Padding(4);
            this.txtBacDen.Name = "txtBacDen";
            this.txtBacDen.Size = new System.Drawing.Size(305, 29);
            this.txtBacDen.TabIndex = 3;
            // 
            // txtBacTu
            // 
            this.txtBacTu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtBacTu.Location = new System.Drawing.Point(180, 177);
            this.txtBacTu.Margin = new System.Windows.Forms.Padding(4);
            this.txtBacTu.Name = "txtBacTu";
            this.txtBacTu.Size = new System.Drawing.Size(305, 29);
            this.txtBacTu.TabIndex = 2;
            // 
            // txtTenBangGia
            // 
            this.txtTenBangGia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTenBangGia.Location = new System.Drawing.Point(180, 119);
            this.txtTenBangGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenBangGia.Name = "txtTenBangGia";
            this.txtTenBangGia.Size = new System.Drawing.Size(305, 29);
            this.txtTenBangGia.TabIndex = 1;
            // 
            // txtMaBangGia
            // 
            this.txtMaBangGia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMaBangGia.Location = new System.Drawing.Point(180, 62);
            this.txtMaBangGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaBangGia.Name = "txtMaBangGia";
            this.txtMaBangGia.Size = new System.Drawing.Size(305, 29);
            this.txtMaBangGia.TabIndex = 0;
            // 
            // lblNgayApDung
            // 
            this.lblNgayApDung.AutoSize = true;
            this.lblNgayApDung.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNgayApDung.ForeColor = System.Drawing.Color.White;
            this.lblNgayApDung.Location = new System.Drawing.Point(27, 357);
            this.lblNgayApDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayApDung.Name = "lblNgayApDung";
            this.lblNgayApDung.Size = new System.Drawing.Size(123, 23);
            this.lblNgayApDung.TabIndex = 5;
            this.lblNgayApDung.Text = "Ngày áp dụng:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDonGia.ForeColor = System.Drawing.Color.White;
            this.lblDonGia.Location = new System.Drawing.Point(27, 297);
            this.lblDonGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(74, 23);
            this.lblDonGia.TabIndex = 4;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblBacDen
            // 
            this.lblBacDen.AutoSize = true;
            this.lblBacDen.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblBacDen.ForeColor = System.Drawing.Color.White;
            this.lblBacDen.Location = new System.Drawing.Point(27, 239);
            this.lblBacDen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBacDen.Name = "lblBacDen";
            this.lblBacDen.Size = new System.Drawing.Size(75, 23);
            this.lblBacDen.TabIndex = 3;
            this.lblBacDen.Text = "Bậc đến:";
            // 
            // lblBacTu
            // 
            this.lblBacTu.AutoSize = true;
            this.lblBacTu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblBacTu.ForeColor = System.Drawing.Color.White;
            this.lblBacTu.Location = new System.Drawing.Point(27, 181);
            this.lblBacTu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBacTu.Name = "lblBacTu";
            this.lblBacTu.Size = new System.Drawing.Size(62, 23);
            this.lblBacTu.TabIndex = 2;
            this.lblBacTu.Text = "Bậc từ:";
            // 
            // lblTenBangGia
            // 
            this.lblTenBangGia.AutoSize = true;
            this.lblTenBangGia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTenBangGia.ForeColor = System.Drawing.Color.White;
            this.lblTenBangGia.Location = new System.Drawing.Point(27, 123);
            this.lblTenBangGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenBangGia.Name = "lblTenBangGia";
            this.lblTenBangGia.Size = new System.Drawing.Size(112, 23);
            this.lblTenBangGia.TabIndex = 1;
            this.lblTenBangGia.Text = "Tên bảng giá:";
            // 
            // lblMaBangGia
            // 
            this.lblMaBangGia.AutoSize = true;
            this.lblMaBangGia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMaBangGia.ForeColor = System.Drawing.Color.White;
            this.lblMaBangGia.Location = new System.Drawing.Point(27, 65);
            this.lblMaBangGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaBangGia.Name = "lblMaBangGia";
            this.lblMaBangGia.Size = new System.Drawing.Size(110, 23);
            this.lblMaBangGia.TabIndex = 0;
            this.lblMaBangGia.Text = "Mã bảng giá:";
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChucNang.Controls.Add(this.btnLamMoi);
            this.pnlChucNang.Controls.Add(this.btnXoa);
            this.pnlChucNang.Controls.Add(this.btnSua);
            this.pnlChucNang.Controls.Add(this.btnThem);
            this.pnlChucNang.Location = new System.Drawing.Point(784, 455);
            this.pnlChucNang.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(512, 74);
            this.pnlChucNang.TabIndex = 5;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Location = new System.Drawing.Point(400, 12);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 49);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(271, 12);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 49);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(134, 12);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 49);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(0, 12);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 49);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // FormQuanLyBangGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1312, 677);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.dgvBangGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQuanLyBangGia";
            this.Text = "Quản Lý Bảng Giá";
            this.Load += new System.EventHandler(this.FormQuanLyBangGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangGia)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.pnlChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.DataGridView dgvBangGia;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.Label lblMaBangGia;
        private System.Windows.Forms.Label lblTenBangGia;
        private System.Windows.Forms.Label lblBacTu;
        private System.Windows.Forms.Label lblBacDen;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblNgayApDung;
        private System.Windows.Forms.TextBox txtMaBangGia;
        private System.Windows.Forms.TextBox txtTenBangGia;
        private System.Windows.Forms.TextBox txtBacTu;
        private System.Windows.Forms.TextBox txtBacDen;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.DateTimePicker dtpNgayApDung;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
    }
}