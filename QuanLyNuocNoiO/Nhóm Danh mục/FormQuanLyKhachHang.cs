
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNuocNoiO.Nhóm_Danh_mục
{
    public partial class FormQuanLyKhachHang : Form
    {
        // Sử dụng lớp KetNoi của bạn
        private string connectionString = KetNoi.KetNoi.ChuoiKetNoi;

        private bool isAdding = false; // Cờ xác định đang ở chế độ Thêm hay Sửa

        public FormQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhuVucComboBox();
            SetupTrangThaiComboBox();
            LoadData();
            SetButtonStates(true);

        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Nối bảng KhachHang với KhuVuc để lấy được Tên Khu Vực
                    string sql = @"SELECT 
                                     kh.MaKH, kh.HoTen, kh.CMND, kh.DiaChi, kh.SoDienThoai, 
                                     kh.Email, kv.TenKhuVuc, kh.MaKhuVuc, kh.NgayDangKy, kh.TrangThai 
                                 FROM KhachHang kh
                                 JOIN KhuVuc kv ON kh.MaKhuVuc = kv.MaKhuVuc";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvKhachHang.DataSource = dt;
                    FormatGrid();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu khách hàng: " + ex.Message); }
        }

        private void FormatGrid()
        {
            if (dgvKhachHang.Columns.Count > 0)
            {
                dgvKhachHang.Columns["MaKH"].HeaderText = "Mã KH";
                dgvKhachHang.Columns["HoTen"].HeaderText = "Họ Tên";
                dgvKhachHang.Columns["SoDienThoai"].HeaderText = "Số ĐT";
                dgvKhachHang.Columns["TenKhuVuc"].HeaderText = "Khu Vực";
                dgvKhachHang.Columns["TrangThai"].HeaderText = "Trạng Thái";
                

                // Ẩn các cột không cần thiết
                dgvKhachHang.Columns["CMND"].Visible = false;
                dgvKhachHang.Columns["DiaChi"].Visible = false;
                dgvKhachHang.Columns["Email"].Visible = false;
                dgvKhachHang.Columns["MaKhuVuc"].Visible = false;
                dgvKhachHang.Columns["NgayDangKy"].Visible = false;
            }
        }

        private void LoadKhuVucComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT MaKhuVuc, TenKhuVuc FROM KhuVuc", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cboKhuVuc.DataSource = dt;
                    cboKhuVuc.DisplayMember = "TenKhuVuc";
                    cboKhuVuc.ValueMember = "MaKhuVuc";
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải danh sách khu vực: " + ex.Message); }
        }

        private void SetupTrangThaiComboBox()
        {
            cboTrangThai.Items.Add("Hoạt động");
            cboTrangThai.Items.Add("Bị khóa");
            cboTrangThai.SelectedIndex = 0;
        }

        private void ClearInputs()
        {
            txtMaKH.Text = "";
            txtHoTen.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtEmail.Text = "";
            if (cboKhuVuc.Items.Count > 0) cboKhuVuc.SelectedIndex = 0;
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;
            dtpNgayDangKy.Value = DateTime.Now;
        }

        private void SetButtonStates(bool isInitialState)
        {
            btnThem.Enabled = isInitialState;
            btnSua.Enabled = isInitialState;
            btnXoa.Enabled = isInitialState;
            dgvKhachHang.Enabled = isInitialState;

            btnLuu.Enabled = !isInitialState;
            btnLamMoi.Text = isInitialState ? "Làm mới" : "Hủy";
            grpThongTin.Enabled = !isInitialState;
        }
        private void DgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtCMND.Text = row.Cells["CMND"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                cboKhuVuc.SelectedValue = row.Cells["MaKhuVuc"].Value;
                dtpNgayDangKy.Value = Convert.ToDateTime(row.Cells["NgayDangKy"].Value);
                cboTrangThai.SelectedItem = row.Cells["TrangThai"].Value.ToString();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ClearInputs();
            SetButtonStates(false);
            txtMaKH.Enabled = true;
            txtMaKH.Focus();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0) return;
            isAdding = false;
            SetButtonStates(false);
            txtMaKH.Enabled = false;
            txtHoTen.Focus();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0) return;
            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM KhachHang WHERE MaKH = @MaKH", conn);
                        cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                        cmd.ExecuteNonQuery();
                    }
                    LoadData();
                    ClearInputs();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi khi xóa: Khách hàng này có thể đã có hóa đơn hoặc đồng hồ. Vui lòng kiểm tra lại.\n" + ex.Message); }
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Mã và Tên khách hàng không được để trống.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = isAdding
                        ? "INSERT INTO KhachHang(MaKH, HoTen, CMND, DiaChi, SoDienThoai, Email, MaKhuVuc, NgayDangKy, TrangThai) VALUES(@MaKH, @HoTen, @CMND, @DiaChi, @SoDT, @Email, @MaKV, @NgayDK, @TrangThai)"
                        : "UPDATE KhachHang SET HoTen=@HoTen, CMND=@CMND, DiaChi=@DiaChi, SoDienThoai=@SoDT, Email=@Email, MaKhuVuc=@MaKV, NgayDangKy=@NgayDK, TrangThai=@TrangThai WHERE MaKH=@MaKH";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@CMND", txtCMND.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        cmd.Parameters.AddWithValue("@SoDT", txtSoDienThoai.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@MaKV", cboKhuVuc.SelectedValue);
                        cmd.Parameters.AddWithValue("@NgayDK", dtpNgayDangKy.Value);
                        cmd.Parameters.AddWithValue("@TrangThai", cboTrangThai.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Lưu thành công!", "Thông báo");
                LoadData();
                SetButtonStates(true);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi khi lưu: " + ex.Message); }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            if (btnLamMoi.Text == "Hủy")
            {
                SetButtonStates(true);
                if (dgvKhachHang.SelectedRows.Count > 0)
                    DgvKhachHang_CellClick(null, new DataGridViewCellEventArgs(0, dgvKhachHang.CurrentRow.Index));
            }
            else
            {
                LoadData();
                ClearInputs();
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCMND.MaxLength = 12;
            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
               
            }
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSoDienThoai.MaxLength = 11;
            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
               
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}