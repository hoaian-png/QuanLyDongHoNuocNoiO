# Quản lý đồng hồ nước nội ô

Ứng dụng Windows Forms giúp nhân viên theo dõi chỉ số nước theo tháng, lập hóa đơn theo bảng giá bậc thang và ghi nhận thanh toán. Dự án viết bằng C# trên .NET Framework 4.7.2, dùng SQL Server để lưu dữ liệu và Microsoft ReportViewer để in hóa đơn.

## Chức năng

| Mục | Nội dung |
| --- | --- |
| Danh mục | Quản lý khu vực, khách hàng, nhân viên, đồng hồ nước và bảng giá. |
| Nghiệp vụ | Ghi chỉ số theo kỳ, lập và in hóa đơn, ghi nhận thanh toán. |
| Tra cứu & Báo cáo | Tra cứu hóa đơn, xem danh sách nợ, báo cáo tiêu thụ và doanh thu. |
| Tài khoản | Đăng nhập và quản lý tài khoản nhân viên. |

## Cài đặt và chạy

### 1. Chuẩn bị môi trường

- Windows và Visual Studio 2022 với workload **.NET desktop development**.
- **.NET Framework 4.7.2 targeting pack** trong **Visual Studio Installer → Individual components**.
- Một SQL Server có cơ sở dữ liệu đúng cấu trúc của dự án. Dùng **SQL Server Management Studio (SSMS)** nếu cần nhập bản sao cơ sở dữ liệu.

### 2. Tải mã nguồn và khôi phục NuGet

```powershell
git clone https://github.com/hoaian-png/QuanLyDongHoNuocNoiO.git
cd QuanLyDongHoNuocNoiO
```

Mở [QuanLyNuocNoiO.sln](QuanLyNuocNoiO.sln) bằng Visual Studio. Trong **Solution Explorer**, nhấp phải vào solution và chọn **Restore NuGet Packages** để tải ReportViewer và Microsoft.SqlServer.Types.

### 3. Kết nối cơ sở dữ liệu

1. Chuẩn bị cơ sở dữ liệu `QuanLyDongHoNuocNoiO`. Nếu đã có bản sao `.bacpac` của dự án, mở SSMS, nhấp phải **Databases** và chọn **Import Data-tier Application**. Kho GitHub hiện chỉ cung cấp mã nguồn ứng dụng, nên cần có sẵn cơ sở dữ liệu hoặc bản sao tương thích.
2. Mở [KetNoi.cs](QuanLyNuocNoiO/KetNoi/KetNoi.cs). Trong biến `ChuoiKetNoi`, sửa `Data Source` thành tên máy chủ hoặc instance hiển thị trong SSMS. Nếu cơ sở dữ liệu được nhập với tên khác, sửa cả `Initial Catalog`.
3. Chuỗi kết nối hiện dùng Windows Authentication. Tài khoản Windows chạy chương trình cần quyền truy cập cơ sở dữ liệu.

### 4. Khởi chạy

Chọn **Build → Build Solution**, sau đó nhấn **F5**. Khi màn hình đăng nhập xuất hiện, dùng tài khoản nhân viên đã có trong cơ sở dữ liệu.

Nếu build báo lỗi thiếu assembly ReportViewer, chạy lại **Restore NuGet Packages**. Nếu ứng dụng báo lỗi kết nối, thử kết nối bằng SSMS với cùng instance và tài khoản Windows, rồi kiểm tra tên cơ sở dữ liệu.

## Quy trình sử dụng

1. Vào **Danh mục** để chuẩn bị khu vực, khách hàng, đồng hồ và bảng giá.
2. Vào **Nghiệp vụ → Ghi chỉ số**, chọn kỳ tháng/năm rồi nhập và lưu chỉ số mới cho đồng hồ.
3. Vào **Lập hóa đơn**, chọn bản ghi chỉ số chưa có hóa đơn, kiểm tra số tiền và lưu hóa đơn.
4. Vào **Thanh toán** để ghi nhận khoản thu. Dùng **Tra cứu & Báo cáo** để tìm hóa đơn, kiểm tra công nợ hoặc xem số liệu tiêu thụ và doanh thu.

## Cấu trúc dự án

| Tệp hoặc thư mục | Vai trò |
| --- | --- |
| [QuanLyNuocNoiO.sln](QuanLyNuocNoiO.sln) | Solution mở trong Visual Studio. |
| [QuanLyNuocNoiO/](QuanLyNuocNoiO/) | Mã nguồn Windows Forms và các nhóm màn hình. |
| [KetNoi/](QuanLyNuocNoiO/KetNoi/) | Cấu hình kết nối SQL Server. |
| [rdlc/](QuanLyNuocNoiO/rdlc/) | Biểu mẫu ReportViewer dùng để in hóa đơn. |
