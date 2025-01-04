using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagementApp.DAL
{
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper()
        {
            // Lấy connection string từ file cấu hình, lưu ý thay đổi tên connection string ("StudentModel") tương ứng với project của bạn
            connectionString = ConfigurationManager.ConnectionStrings["StudentModel"].ConnectionString;
        }

        public void BackupDatabase(string backupFilePath)
        {
            try
            {
                string backupCommand = $"BACKUP DATABASE [StudentManagement] TO DISK = '{backupFilePath}' WITH INIT";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(backupCommand, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi bằng MessageBox
                string errorMessage = "Đã xảy ra lỗi khi sao lưu cơ sở dữ liệu." + Environment.NewLine +
                                      "Vui lòng đảm bảo rằng tài khoản dịch vụ SQL Server có quyền ghi vào thư mục sao lưu." + Environment.NewLine +
                                      "Để kiểm tra tài khoản nào đang chạy SQL Server và cấp quyền, hãy làm theo các bước sau:" + Environment.NewLine +
                                      "1. Mở 'Services' bằng cách nhấn Win + R, gõ 'services.msc' và nhấn Enter." + Environment.NewLine +
                                      "2. Tìm dịch vụ SQL Server (ví dụ: 'SQL Server (MSSQLSERVER)' hoặc 'SQL Server (InstanceName)')." + Environment.NewLine +
                                      "3. Nhấp chuột phải vào dịch vụ và chọn 'Properties'." + Environment.NewLine +
                                      "4. Chuyển đến tab 'Log On' để xem tài khoản đang chạy dịch vụ." + Environment.NewLine +
                                      "5. Mở File Explorer và điều hướng đến thư mục sao lưu." + Environment.NewLine +
                                      "6. Nhấp chuột phải vào thư mục và chọn 'Properties'." + Environment.NewLine +
                                      "7. Chuyển đến tab 'Security' và nhấp vào 'Edit'." + Environment.NewLine +
                                      "8. Nhấp vào 'Add', nhập tên tài khoản dịch vụ (ví dụ: 'NT SERVICE\\MSSQLSERVER'), và nhấp vào 'Check Names'." + Environment.NewLine +
                                      "9. Cấp quyền 'Write' cho tài khoản và nhấp vào 'OK'.";

                MessageBox.Show(errorMessage, "Lỗi sao lưu cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw new Exception("Đã xảy ra lỗi khi sao lưu cơ sở dữ liệu.", ex);
            }
        }

        public void RestoreDatabase(string backupFilePath)
        {
            try
            {
                string setSingleUserCommand = "ALTER DATABASE [StudentManagement] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                string restoreCommand = $"RESTORE DATABASE [StudentManagement] FROM DISK = '{backupFilePath}' WITH REPLACE";
                string setMultiUserCommand = "ALTER DATABASE [StudentManagement] SET MULTI_USER";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Chuyển sang cơ sở dữ liệu master
                    using (SqlCommand command = new SqlCommand("USE master", connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Đặt cơ sở dữ liệu về chế độ đơn người dùng
                    using (SqlCommand command = new SqlCommand(setSingleUserCommand, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Khôi phục cơ sở dữ liệu
                    using (SqlCommand command = new SqlCommand(restoreCommand, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Đặt cơ sở dữ liệu về chế độ đa người dùng
                    using (SqlCommand command = new SqlCommand(setMultiUserCommand, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while restoring the database.", ex);
            }
        }
    }
}
