using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_LTM
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private async void bai3_Load(object sender, EventArgs e)
        {
            await InitBrowser();
        }

        private async Task InitBrowser()
        {          

            try
            {
                string userDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyWebView2App");

                // Tạo môi trường WebView2 với hồ sơ người dùng riêng biệt
                var env = await CoreWebView2Environment.CreateAsync(null, userDataFolder);

                if (webView.CoreWebView2 == null)
                {
                    await webView.EnsureCoreWebView2Async(env);
                }

                // Đặt URL mới mỗi khi khởi động lại
                webView.CoreWebView2.Navigate("https://student.uit.edu.vn/");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
}
}
