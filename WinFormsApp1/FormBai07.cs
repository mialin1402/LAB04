using System.Net.Http.Headers;

namespace LAB5
{
    public partial class FormBai07 : Form
    {
        public FormBai07()
        {
            InitializeComponent();
        }
        string authToken = string.Empty;
        string tokenType = string.Empty;
        private async void FormBai07_Load(object sender, EventArgs e)
        {
            FormBai07_Login formBai07_Login = new FormBai07_Login();
            formBai07_Login.ShowDialog();

            authToken = formBai07_Login.authToken;
            tokenType = formBai07_Login.tokenType;

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, authToken);
                var getUserUrl = "https://nt106.uitiot.vn/api/v1/user/me";
                var getUserResponse = await client.GetAsync(getUserUrl);
                var getUserResponseString = await
                getUserResponse.Content.ReadAsStringAsync();

                richTextBox1.Text = getUserResponseString;

            }
        }
    }
}
