using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Nodes;

namespace LAB4
{
    public partial class FormBai07_SignUp : Form
    {
        public FormBai07_SignUp()
        {
            InitializeComponent();
        }

        public string tokenType = string.Empty;
        public string accessToken = string.Empty;

        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMale.Checked)
            {
                rbtnFemale.Checked = false;
            }
        }

        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFemale.Checked)
            {
                rbtnMale.Checked = false;
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsrName.Text) ||
                string.IsNullOrEmpty(tbPass.Text) ||
                string.IsNullOrEmpty(tbEmail.Text) ||
                string.IsNullOrEmpty(tbFirstName.Text) ||
                string.IsNullOrEmpty(tbLastName.Text) ||
                string.IsNullOrEmpty(tbPhone.Text) ||
                dateTimePicker.Value == DateTime.Now ||
                cbLanguage.SelectedIndex == -1 ||
                rbtnMale.Checked == false && rbtnFemale.Checked == false)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!!", "Missing info");
                return;
            }

            // Create new user
            using (var client = new HttpClient())
            {

                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                var baseAddress = "https://nt106.uitiot.vn";
                var apiCreateUser = "/api/v1/user/signup";
                var data = new Dictionary<string, string>
                {
                    { "username", tbUsrName.Text },
                    { "email", tbEmail.Text },
                    { "password", tbPass.Text },
                    { "first_name", tbFirstName.Text },
                    { "last_name", tbLastName.Text },
                    { "sex", rbtnMale.Checked ? "1" : "0" },
                    { "birthday", dateTimePicker.Value.ToString("yyyy-MM-dd") },
                    { "language", cbLanguage.Text },
                    { "phone", tbPhone.Text }
                };
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Add(contentType);
                var jsonData = JsonConvert.SerializeObject(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(apiCreateUser, content);
                var responseString = await response.Content.ReadAsStringAsync();
                var responseObject = JsonObject.Parse(responseString);
                if (!response.IsSuccessStatusCode)
                {
                    var detail = responseObject["detail"].ToString();
                    MessageBox.Show(detail);
                    return;
                }
                MessageBox.Show($"Tạo người dùng thành công\nXin chào {tbUsrName.Text}","Sign Up Successfully");
            }

            // Authenticate
            using (var client = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string,string>("username", tbUsrName.Text),
                    new KeyValuePair<string, string>("password", tbPass.Text)
                });
                var AuthUrl = "https://nt106.uitiot.vn/auth/token";
                var response = await client.PostAsync(AuthUrl, content);
                var responseString = await response.Content.ReadAsStringAsync();
                var responseObject = JsonObject.Parse(responseString);
                if (!response.IsSuccessStatusCode)
                {
                    var detail = responseObject["detail"].ToString();
                    MessageBox.Show(detail);
                    return;
                }

                tokenType = responseObject["token_type"].ToString();
                accessToken = responseObject["access_token"].ToString();
            }

            this.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUsrName.Text = string.Empty;
            tbPass.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbPhone.Text = string.Empty;
            cbLanguage.SelectedIndex = -1;
            dateTimePicker.Value = DateTime.Now;
        }
    }
}
