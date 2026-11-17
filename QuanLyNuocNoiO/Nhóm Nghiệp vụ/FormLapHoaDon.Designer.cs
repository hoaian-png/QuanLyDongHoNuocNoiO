namespace QuanLyNuocNoiO.Nhóm_Nghiệp_vụ
{
    partial class FormLapHoaDon
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
            this.pnlChonKy = new System.Windows.Forms.Panel();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.lblThang = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnLapHoaDonTatCa = new System.Windows.Forms.Button();
            this.btnLapHoaDonChon = new System.Windows.Forms.Button();
            this.dgvDanhSachCho = new System.Windows.Forms.DataGridView();
            this.colChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlChonKy.SuspendLayout();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCho)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChonKy
            // 
            this.pnlChonKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.pnlChonKy.Controls.Add(this.btnHienThi);
            this.pnlChonKy.Controls.Add(this.cboKhuVuc);
            this.pnlChonKy.Controls.Add(this.lblKhuVuc);
            this.pnlChonKy.Controls.Add(this.txtNam);
            this.pnlChonKy.Controls.Add(this.lblNam);
            this.pnlChonKy.Controls.Add(this.cboThang);
            this.pnlChonKy.Controls.Add(this.lblThang);
            this.pnlChonKy.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChonKy.Location = new System.Drawing.Point(0, 0);
            this.pnlChonKy.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChonKy.Name = "pnlChonKy";
            this.pnlChonKy.Size = new System.Drawing.Size(1312, 74);
            this.pnlChonKy.TabIndex = 6;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHienThi.Location = new System.Drawing.Point(907, 17);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(240, 37);
            this.btnHienThi.TabIndex = 4;
            this.btnHienThi.Text = "Hiển thị danh sách chờ";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.BtnHienThi_Click);
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboKhuVuc.FormattingEnabled = true;
            this.cboKhuVuc.Location = new System.Drawing.Point(560, 21);
            this.cboKhuVuc.Margin = new System.Windows.Forms.Padding(4);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(292, 29);
            this.cboKhuVuc.TabIndex = 3;
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblKhuVuc.Location = new System.Drawing.Point(467, 25);
            this.lblKhuVuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(75, 23);
            this.lblKhuVuc.TabIndex = 4;
            this.lblKhuVuc.Text = "Khu vực:";
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNam.Location = new System.Drawing.Point(293, 21);
            this.txtNam.Margin = new System.Windows.Forms.Padding(4);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(132, 29);
            this.txtNam.TabIndex = 2;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNam.Location = new System.Drawing.Point(233, 25);
            this.lblNam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(51, 23);
            this.lblNam.TabIndex = 2;
            this.lblNam.Text = "Năm:";
            // 
            // cboThang
            // 
            this.cboThang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(93, 21);
            this.cboThang.Margin = new System.Windows.Forms.Padding(4);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(105, 29);
            this.cboThang.TabIndex = 1;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblThang.Location = new System.Drawing.Point(16, 25);
            this.lblThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(62, 23);
            this.lblThang.TabIndex = 0;
            this.lblThang.Text = "Tháng:";
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.pnlActions.Controls.Add(this.btnLapHoaDonTatCa);
            this.pnlActions.Controls.Add(this.btnLapHoaDonChon);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Location = new System.Drawing.Point(0, 603);
            this.pnlActions.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(1312, 74);
            this.pnlActions.TabIndex = 7;
            // 
            // btnLapHoaDonTatCa
            // 
            this.btnLapHoaDonTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLapHoaDonTatCa.BackColor = System.Drawing.Color.Green;
            this.btnLapHoaDonTatCa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHoaDonTatCa.ForeColor = System.Drawing.Color.White;
            this.btnLapHoaDonTatCa.Location = new System.Drawing.Point(1043, 12);
            this.btnLapHoaDonTatCa.Margin = new System.Windows.Forms.Padding(4);
            this.btnLapHoaDonTatCa.Name = "btnLapHoaDonTatCa";
            this.btnLapHoaDonTatCa.Size = new System.Drawing.Size(253, 49);
            this.btnLapHoaDonTatCa.TabIndex = 1;
            this.btnLapHoaDonTatCa.Text = "Lập hóa đơn cho tất cả";
            this.btnLapHoaDonTatCa.UseVisualStyleBackColor = false;
            this.btnLapHoaDonTatCa.Click += new System.EventHandler(this.BtnLapHoaDonTatCa_Click);
            // 
            // btnLapHoaDonChon
            // 
            this.btnLapHoaDonChon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLapHoaDonChon.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnLapHoaDonChon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHoaDonChon.Location = new System.Drawing.Point(781, 12);
            this.btnLapHoaDonChon.Margin = new System.Windows.Forms.Padding(4);
            this.btnLapHoaDonChon.Name = "btnLapHoaDonChon";
            this.btnLapHoaDonChon.Size = new System.Drawing.Size(253, 49);
            this.btnLapHoaDonChon.TabIndex = 0;
            this.btnLapHoaDonChon.Text = "Lập hóa đơn đã chọn";
            this.btnLapHoaDonChon.UseVisualStyleBackColor = false;
            this.btnLapHoaDonChon.Click += new System.EventHandler(this.BtnLapHoaDonChon_Click);
            // 
            // dgvDanhSachCho
            // 
            this.dgvDanhSachCho.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachCho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChon});
            this.dgvDanhSachCho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachCho.Location = new System.Drawing.Point(0, 74);
            this.dgvDanhSachCho.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSachCho.Name = "dgvDanhSachCho";
            this.dgvDanhSachCho.RowHeadersWidth = 51;
            this.dgvDanhSachCho.Size = new System.Drawing.Size(1312, 529);
            this.dgvDanhSachCho.TabIndex = 8;
            this.dgvDanhSachCho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachCho_CellContentClick);
            this.dgvDanhSachCho.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDanhSachCho_CurrentCellDirtyStateChanged);
            // 
            // colChon
            // 
            this.colChon.HeaderText = "CHọn";
            this.colChon.MinimumWidth = 6;
            this.colChon.Name = "colChon";
            this.colChon.Width = 125;
            // 
            // FormLapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 677);
            this.Controls.Add(this.dgvDanhSachCho);
            this.Controls.Add(this.pnlChonKy);
            this.Controls.Add(this.pnlActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLapHoaDon";
            this.Text = "Lập Hóa Đơn";
            this.Load += new System.EventHandler(this.FormLapHoaDon_Load);
            this.pnlChonKy.ResumeLayout(false);
            this.pnlChonKy.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCho)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlChonKy;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.Label lblKhuVuc;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnLapHoaDonTatCa;
        private System.Windows.Forms.Button btnLapHoaDonChon;
        private System.Windows.Forms.DataGridView dgvDanhSachCho;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChon;
    }
}