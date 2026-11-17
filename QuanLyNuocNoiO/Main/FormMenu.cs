
using QuanLyNuocNoiO.Class;
using QuanLyNuocNoiO.Nhóm_Danh_mục;
using QuanLyNuocNoiO.Nhóm_Hệ_thống;
using QuanLyNuocNoiO.Nhóm_Nghiệp_vụ;
using QuanLyNuocNoiO.Nhóm_Tra_cứu___Báo_cáo;
using System;
using System.Windows.Forms;

namespace QuanLyNuocNoiO.Main
{
    public partial class FormMenu : Form
    {
        private Form currentFormChild = null;

        public FormMenu()
        {
            InitializeComponent();
            palChaDanhMuc.Height = 50;
            palChaTrCuuBaoCao.Height = 50;
            palChaNghiepVu.Height = 50;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            PhanQuyenMenu();
        }
        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            palMain.Controls.Add(childForm);
            palMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem menu này đang mở hay đóng
            bool dangMo = palChaDanhMuc.Height > btnDanhMuc.Height;

            // Luôn đóng tất cả các menu trước
            palChaTrCuuBaoCao.Height = btnTraCuubaoCao.Height;
            palChaNghiepVu.Height = btnNghiepVu.Height;

            // Nếu đang đóng thì mở ra, nếu đang mở thì thôi (vì đã bị đóng ở trên)
            if (!dangMo)
            {
                palChaDanhMuc.Height = btnDanhMuc.Height + panel5.Height;
            }
        }

        private void btnTraCuubaoCao_Click(object sender, EventArgs e)
        {
            bool dangMo = palChaTrCuuBaoCao.Height > btnTraCuubaoCao.Height;

            palChaDanhMuc.Height = btnDanhMuc.Height;
            palChaNghiepVu.Height = btnNghiepVu.Height;

            if (!dangMo)
            {
                palChaTrCuuBaoCao.Height = btnTraCuubaoCao.Height + pallistTraCuuBaoCao.Height;
            }
        }

        private void btnNghiepVu_Click(object sender, EventArgs e)
        {
            bool dangMo = palChaNghiepVu.Height > btnNghiepVu.Height;

            palChaDanhMuc.Height = btnDanhMuc.Height;
            palChaTrCuuBaoCao.Height = btnTraCuubaoCao.Height;

            if (!dangMo)
            {
                palChaNghiepVu.Height = btnNghiepVu.Height + panel6.Height;
            }
        }

        private void PhanQuyenMenu()
        {
            string vaiTro = ThongTinNhanVien.VaiTro;

            // Nếu không có thông tin đăng nhập, không làm gì cả
            if (ThongTinNhanVien.VaiTro == null)
                return;

            else if (vaiTro == "NhanVien")
            {
                btnKhuVuc.Visible = false;
                btnKhachHang.Visible = false;
               btnDanhMuc.Visible = false;
                btnBaoCaoDoanhThu.Visible = false;
                btnBaoCaoTieuThu.Visible = false;
                btnTaiKhoan.Visible = false;
                palChaDanhMuc.Visible=false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ThongTinNhanVien.DangXuat();
                Application.Exit();
            }
        }

        // --- Các sự kiện click mở form con (giữ nguyên code của bạn) ---
        private void btnKhuVuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyKhuVuc());
            labTieuDe.Text = "Quản Lý Khu Vực";
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyKhachHang());
            labTieuDe.Text = "Quản Lý Khách Hàng";
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyNhanVien());
            labTieuDe.Text = "Quản Lý Nhân Viên";
        }
        private void btnDongHoNuoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyDongHoNuoc());
            labTieuDe.Text = "Quản Lý Đồng Hồ Nước";
        }
        private void btnBangGia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyBangGia());
            labTieuDe.Text = "Quản Lý Bảng Giá";
        }
        private void btnGhiChiSo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormGhiChiSo());
            labTieuDe.Text = "Ghi Chỉ Số";
        }
        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLapHoaDon());
            labTieuDe.Text = "Lập Hóa Đơn";
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThanhToan());
            labTieuDe.Text = "Thanh Toán";
        }
        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTaiKhoan());
            labTieuDe.Text = "Quản Lý Tài Khoản";
        }
        private void btnTraCuuHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTraCuuHoaDon());
            labTieuDe.Text = "Tra Cứu Hóa Đơn";
        }
        private void btnDanhSachNo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDanhSachNo());
            labTieuDe.Text = "Danh Sách Nợ";
        }
        private void btnBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBaoCaoDoanhThu());
            labTieuDe.Text = "Báo Cáo Doanh Thu";
        }
        private void btnBaoCaoTieuThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBaoCaoTieuThu());
            labTieuDe.Text = "Báo Cáo Tiêu Thụ";
        }
    }
}