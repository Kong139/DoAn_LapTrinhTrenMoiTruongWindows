# Đồ án Lập trình trên môi trường Windows
# Đề tài: Ứng dụng Quản lý Học sinh
## Mô hình 3 lớp
Ứng dụng sử dụng mô hình 3 lớp, bao gồm:
- Presentation Layer (Lớp giao diện người dùng - UI Layer):
  - Mô tả: Đây là lớp mà người dùng tương tác trực tiếp. Nó chịu trách nhiệm hiển thị dữ liệu và tiếp nhận các thao tác từ người dùng (như nhập liệu, nhấn nút, lựa chọn, v.v.). Lớp này không xử lý logic nghiệp vụ hay lưu trữ dữ liệu.
  - Chức năng chính:
    - Hiển thị thông tin từ các lớp bên dưới.
    - Tiếp nhận các yêu cầu từ người dùng (ví dụ: thêm, sửa, xóa dữ liệu).
    - Gửi yêu cầu đến lớp Logic nghiệp vụ (BLL) để xử lý.
- Business Logic Layer (Lớp logic nghiệp vụ - BLL):
  - Mô tả: Đây là lớp chứa logic nghiệp vụ của ứng dụng. Nó xử lý các yêu cầu từ giao diện người dùng, thực hiện các quy trình nghiệp vụ, và gọi các dịch vụ từ lớp dữ liệu để truy xuất hoặc cập nhật dữ liệu. BLL giữ vai trò là cầu nối giữa lớp giao diện và lớp dữ liệu.
  - Chức năng chính:
    - Xử lý logic nghiệp vụ, tính toán, quyết định các hành động cần thực hiện.
    - Tương tác với lớp dữ liệu (DAL) để lấy hoặc lưu trữ dữ liệu.
    - Trả lại kết quả cho lớp giao diện người dùng (UI).
- Data Access Layer (Lớp truy cập dữ liệu - DAL):
  - Mô tả: Lớp này chịu trách nhiệm truy xuất dữ liệu từ các nguồn dữ liệu (thường là cơ sở dữ liệu). Nó thực hiện các thao tác CRUD (Create, Read, Update, Delete) và trả dữ liệu cho lớp Logic nghiệp vụ (BLL).
  - Chức năng chính:
    - Thực hiện các thao tác truy xuất dữ liệu từ cơ sở dữ liệu.
    - Cung cấp dữ liệu cho lớp Logic nghiệp vụ (BLL).
    - Trả kết quả hoặc thông báo lỗi về việc thao tác dữ liệu cho lớp BLL.
