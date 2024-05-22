using System.Net.Http.Headers;

namespace LAB5
{
    public partial class FormBai07 : Form
    {
        public FormBai07()
        {
            InitializeComponent();
        }
        string accessToken = string.Empty;
        string tokenType = string.Empty;
        private async void FormBai07_Load(object sender, EventArgs e)
        {
            FormBai07_Login formBai07_Login = new FormBai07_Login();
            formBai07_Login.ShowDialog();

            accessToken = formBai07_Login.accessToken;
            tokenType = formBai07_Login.tokenType;

            if (string.IsNullOrEmpty(accessToken) || string.IsNullOrEmpty(tokenType))
            {
                FormBai07_SignUp formBai07_SignUp = new FormBai07_SignUp();
                formBai07_SignUp.ShowDialog();

                accessToken = formBai07_SignUp.accessToken;
                tokenType = formBai07_SignUp.tokenType;
            }

            if (string.IsNullOrEmpty(accessToken) || string.IsNullOrEmpty(tokenType))
            {
                MessageBox.Show("không nhận được token");
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, accessToken);
                var getUserUrl = "https://nt106.uitiot.vn/api/v1/user/me";
                var getUserResponse = await client.GetAsync(getUserUrl);
                var getUserResponseString = await getUserResponse.Content.ReadAsStringAsync();

                richTextBox1.Text = getUserResponseString;

            }
        }
    }
}
