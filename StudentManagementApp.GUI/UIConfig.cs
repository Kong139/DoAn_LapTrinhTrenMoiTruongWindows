using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public static class UIConfig
{
    // Cấu hình chung cho Form (màu nền, font chữ, kiểu biên giới)
    public static void ConfigureForm(Form form)
    {
        form.BackColor = Color.WhiteSmoke;
        form.Font = new Font("Segoe UI", 10);
        form.FormBorderStyle = FormBorderStyle.Sizable;
    }

    // Cấu hình MenuStrip (màu nền, màu chữ, font chữ và hiệu ứng hover)
    public static void ConfigureMenuStrip(MenuStrip menuStrip)
    {
        menuStrip.BackColor = Color.FromArgb(70, 130, 180);
        menuStrip.ForeColor = Color.White;
        menuStrip.Font = new Font("Segoe UI", 10, FontStyle.Bold);

        // Cấu hình hiệu ứng cho các item trong MenuStrip khi di chuột vào
        foreach (ToolStripMenuItem item in menuStrip.Items)
        {
            item.BackColor = Color.FromArgb(70, 130, 180);
            item.ForeColor = Color.White;

            item.MouseEnter += (sender, e) =>
            {
                var menuItem = (ToolStripMenuItem)sender;
                menuItem.BackColor = Color.FromArgb(100, 149, 237);
            };

            item.MouseLeave += (sender, e) =>
            {
                var menuItem = (ToolStripMenuItem)sender;
                menuItem.BackColor = Color.FromArgb(70, 130, 180);
            };
        }
    }

    // Cấu hình ToolStrip (màu nền, màu chữ, font chữ và hiệu ứng hover)
    public static void ConfigureToolStrip(ToolStrip toolStrip)
    {
        toolStrip.BackColor = Color.Gray;
        toolStrip.ForeColor = Color.White;
        toolStrip.Font = new Font("Segoe UI", 10, FontStyle.Bold);

        // Cấu hình hiệu ứng cho các item trong ToolStrip khi di chuột vào
        foreach (ToolStripItem item in toolStrip.Items)
        {
            item.BackColor = Color.Gray;
            item.ForeColor = Color.White;

            // Kiểm tra nếu item không phải là ToolStripTextBox thì mới áp dụng hiệu ứng hover
            if (!(item is ToolStripTextBox))
            {
                item.MouseEnter += (sender, e) =>
                {
                    var toolStripItem = (ToolStripItem)sender;
                    toolStripItem.BackColor = Color.Silver;
                };

                item.MouseLeave += (sender, e) =>
                {
                    var toolStripItem = (ToolStripItem)sender;
                    toolStripItem.BackColor = Color.Gray;
                };
            }
        }

        // Cấu hình cho ToolStripTextBox (nếu có) khi focus và mất focus
        foreach (ToolStripItem item in toolStrip.Items)
        {
            if (item is ToolStripTextBox toolStripTextBox)
            {
                toolStripTextBox.BorderStyle = BorderStyle.FixedSingle;
                toolStripTextBox.BackColor = Color.White;
                toolStripTextBox.ForeColor = Color.Black;
                toolStripTextBox.Font = new Font("Segoe UI", 10);

                // Cải thiện màu nền khi focus vào TextBox
                toolStripTextBox.GotFocus += (sender, e) =>
                {
                    var textBox = (ToolStripTextBox)sender;
                    textBox.BackColor = Color.LightYellow;
                };

                // Quay lại màu nền khi mất focus
                toolStripTextBox.LostFocus += (sender, e) =>
                {
                    var textBox = (ToolStripTextBox)sender;
                    textBox.BackColor = Color.White;
                };
            }
        }
    }

    // Cấu hình DataGridView (màu nền, màu chữ, kiểu chọn ô, và header)
    public static void ConfigureDataGridView(DataGridView dgv)
    {
        dgv.BackgroundColor = Color.White;
        dgv.BorderStyle = BorderStyle.None;
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 149, 237);
        dgv.DefaultCellStyle.SelectionForeColor = Color.White;
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
        dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        dgv.EnableHeadersVisualStyles = false;
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(70, 130, 180);
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
    }

    // Cải tiến cho Button để có góc bo tròn và hiệu ứng hover
    public static void ConfigureButton(Button btn)
    {
        btn.BackColor = Color.FromArgb(135, 206, 250);
        btn.ForeColor = Color.Black;
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;
        btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
        btn.Cursor = Cursors.Hand;
        btn.Padding = new Padding(5);
        btn.TextAlign = ContentAlignment.MiddleCenter;
        btn.AutoSize = false;

        // Bo góc button (dùng GraphicsPath)
        btn.Region = new Region(CreateRoundedRectanglePath(btn.ClientRectangle, 20));

        // Thêm sự kiện hover
        btn.MouseEnter += (sender, e) =>
        {
            btn.BackColor = Color.FromArgb(173, 216, 230);
        };

        btn.MouseLeave += (sender, e) =>
        {
            btn.BackColor = Color.FromArgb(135, 206, 250);
        };
    }

    // Hàm vẽ hình chữ nhật với các góc bo tròn (Dùng cho giao diện button)
    private static GraphicsPath CreateRoundedRectanglePath(Rectangle rectangle, int cornerRadius)
    {
        GraphicsPath path = new GraphicsPath();
        path.AddArc(rectangle.X, rectangle.Y, cornerRadius, cornerRadius, 180, 90);
        path.AddArc(rectangle.X + rectangle.Width - cornerRadius, rectangle.Y, cornerRadius, cornerRadius, 270, 90);
        path.AddArc(rectangle.X + rectangle.Width - cornerRadius, rectangle.Y + rectangle.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
        path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
        path.CloseFigure();
        return path;
    }

    // Cấu hình TextBox (màu nền, màu chữ, viền và padding)
    public static void ConfigureTextBox(TextBox txt)
    {
        txt.BackColor = Color.White;
        txt.ForeColor = Color.Black;
        txt.Font = new Font("Segoe UI", 10);
        txt.BorderStyle = BorderStyle.FixedSingle;
        txt.Padding = new Padding(10);
    }

    // Cấu hình Label (màu chữ và font)
    public static void ConfigureLabel(Label lbl)
    {
        lbl.ForeColor = Color.Black;
        lbl.Font = new Font("Segoe UI", 9, FontStyle.Bold);
    }
}
