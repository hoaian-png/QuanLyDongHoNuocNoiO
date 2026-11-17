# Quản lý đồng hồ nước nội ô

Dự án Windows Forms bằng C# dành cho ứng dụng quản lý đồng hồ nước nội ô. Phiên bản hiện tại mở một cửa sổ `FormMain` trống. Các chức năng quản lý đồng hồ, nhập chỉ số và lưu dữ liệu đang chờ triển khai.

## Cài đặt và chạy trên Windows

1. Cài [Visual Studio 2022](https://visualstudio.microsoft.com/) với workload **.NET desktop development**. Trong **Individual components**, kiểm tra đã cài **.NET Framework 4.7.2 targeting pack**.
2. Tải mã nguồn.

   ```powershell
   git clone https://github.com/hoaian-png/QuanLyDongHoNuocNoiO.git
   cd QuanLyDongHoNuocNoiO
   ```

3. Mở `QuanLyDongHoNuocNoiO.sln` trong Visual Studio. Chọn dự án `QuanLyDongHoNuocNoiO` làm **Startup Project** nếu cần.
4. Nhấn **F5** để chạy. Một cửa sổ có tiêu đề **Form1** sẽ xuất hiện. Đóng cửa sổ để thoát.

## Mở giao diện để phát triển

Trong **Solution Explorer**, nhấp phải vào `FormMain.cs` và chọn **View Designer**. `Program.cs` là điểm khởi chạy và gọi `Application.Run(new FormMain())`.
