# Quản lý đồng hồ nước nội ô

Ứng dụng Windows Forms viết bằng C# để quản lý khách hàng, đồng hồ nước, chỉ số tiêu thụ, hóa đơn và thanh toán. Ứng dụng dùng SQL Server và Microsoft ReportViewer để in hóa đơn.

## Cài đặt và chạy trên Windows

1. Cài [Visual Studio 2022](https://visualstudio.microsoft.com/) với workload **.NET desktop development** và **.NET Framework 4.7.2 targeting pack**.
2. Tải kho và mở `QuanLyNuocNoiO.sln`.

   ```powershell
   git clone https://github.com/hoaian-png/QuanLyDongHoNuocNoiO.git
   cd QuanLyDongHoNuocNoiO
   ```

3. Trong **Solution Explorer**, nhấp phải vào solution và chọn **Restore NuGet Packages** nếu Visual Studio chưa tự khôi phục gói.
4. Cài SQL Server nếu máy chưa có. Chuẩn bị cơ sở dữ liệu `QuanLyDongHoNuocNoiO` đúng cấu trúc của ứng dụng. Nếu bạn có bản sao `.bacpac` của dự án, dùng **Import Data-tier Application** trong SQL Server Management Studio để nhập vào SQL Server. Kho công khai hiện chưa có tệp tạo cơ sở dữ liệu.
5. Mở `QuanLyNuocNoiO/KetNoi/KetNoi.cs` và cập nhật `Data Source` trong `ChuoiKetNoi` theo tên máy chủ hoặc instance SQL Server của bạn. Chuỗi mặc định dùng Windows Authentication. Tài khoản Windows đang chạy ứng dụng cần quyền truy cập cơ sở dữ liệu.
6. Nhấn **F5** để chạy và đăng nhập bằng tài khoản nhân viên đã có trong cơ sở dữ liệu.

## Cách sử dụng

- **Danh mục** để quản lý khu vực, khách hàng, nhân viên, đồng hồ nước và bảng giá.
- **Nghiệp vụ** để ghi chỉ số, lập hóa đơn và ghi nhận thanh toán.
- **Tra cứu & Báo cáo** để tìm hóa đơn, xem danh sách nợ, báo cáo tiêu thụ và doanh thu.
