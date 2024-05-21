using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;

namespace WinFormsApp1
{
    public partial class FormBai06 : Form
    {
        public FormBai06()
        {
            InitializeComponent();
            btnGet.Enabled = false;
            tbToken.TextChanged += tbText_Changed;
            tbType.TextChanged += tbText_Changed;
        }

        private void tbText_Changed(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbToken.Text) == false &&
                string.IsNullOrEmpty(tbType.Text) == false)
            {
                btnGet.Enabled = true;
            } 
            else
            {
                btnGet.Enabled = false;
            }
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            string tokenType = tbType.Text;
            string accessToken = tbToken.Text;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, accessToken);
                var getUserUrl = "https://nt106.uitiot.vn/api/v1/user/me";
                var getUserResponse = await client.GetAsync(getUserUrl);
                var getUserResponseString = await
                getUserResponse.Content.ReadAsStringAsync();

                rtbKetQua.Text = getUserResponseString;

            }

        }
    }
}
