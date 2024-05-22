using System.Text.Json.Nodes;

namespace LAB5
{
    public partial class FormBai07_Login : Form
    {
        public FormBai07_Login()
        {
            InitializeComponent();
        }
        public string accessToken = string.Empty;
        public string tokenType = string.Empty;
        private void lbSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsrName.Text) || string.IsNullOrEmpty(tbPass.Text))
            {
                return;
            }

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

                this.Close();
            }
        }
    }
}
