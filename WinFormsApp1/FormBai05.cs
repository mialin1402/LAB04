using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class FormBai05 : Form
    {
        public FormBai05()
        {
            InitializeComponent();
            btnLogin.Enabled = false;
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbURL.Text) == false &&
                string.IsNullOrEmpty(tbUsrName.Text) == false &&
                string.IsNullOrEmpty(tbPass.Text) == false)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            rtbKetQua.Text = string.Empty;
            using (var client = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string,string>("username", tbUsrName.Text),
                    new KeyValuePair<string, string>("password", tbPass.Text)
                });

                var response = await client.PostAsync(tbURL.Text, content);
                var responseString = await response.Content.ReadAsStringAsync();
                var responseObject = JsonObject.Parse(responseString);
                if (!response.IsSuccessStatusCode)
                {
                    var detail = responseObject["detail"].ToString();
                    rtbKetQua.Text = detail;
                    return;
                }

                var tokenType = responseObject["token_type"].ToString();
                var accessToken = responseObject["access_token"].ToString();
                rtbKetQua.Text += $"Token Type: {tokenType}\n";
                rtbKetQua.Text += $"Access Token: {accessToken}\n";
                rtbKetQua.Text += "Đăng nhập thành công!!";

            }
        }
    }
}
