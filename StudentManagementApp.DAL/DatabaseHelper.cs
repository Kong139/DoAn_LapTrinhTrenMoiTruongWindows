using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Management;
using System.ServiceProcess;

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
                // Tự động yêu cầu quyền
                string directoryPath = System.IO.Path.GetDirectoryName(backupFilePath);
                GrantSqlServerServiceAccountWritePermission(directoryPath);

                // Thử lại sao lưu sau khi cấp quyền
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
                catch (Exception retryEx)
                {
                    throw new Exception("Đã xảy ra lỗi khi sao lưu cơ sở dữ liệu.", retryEx);
                }
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

        public void RunPowerShellScript(string scriptText)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{scriptText}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(psi))
            {
                process.WaitForExit();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (process.ExitCode != 0)
                {
                    throw new Exception($"PowerShell script failed with error: {error}");
                }
            }
        }

        public string GetSqlServerServiceAccount()
        {
            string serviceName = "MSSQLSERVER"; // Thay đổi nếu bạn sử dụng một instance cụ thể
            using (ServiceController sc = new ServiceController(serviceName))
            {
                var wmiService = new ManagementObject($"Win32_Service.Name='{sc.ServiceName}'");
                wmiService.Get();
                return wmiService["StartName"].ToString();
            }
        }

        public void GrantSqlServerServiceAccountWritePermission(string directoryPath)
        {
            string serviceAccount = GetSqlServerServiceAccount();
            string scriptText = $@"
                $acl = Get-Acl '{directoryPath}'
                $permission = '{serviceAccount}', 'Write', 'ContainerInherit, ObjectInherit', 'None', 'Allow'
                $accessRule = New-Object System.Security.AccessControl.FileSystemAccessRule $permission
                $acl.SetAccessRule($accessRule)
                Set-Acl '{directoryPath}' $acl
            ";

            RunPowerShellScript(scriptText);
        }
    }
}
