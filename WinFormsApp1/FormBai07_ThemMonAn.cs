using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace LAB4
{
    public partial class FormBai07_ThemMonAn : Form
    {
        string accessToken = string.Empty;
        string tokenType = string.Empty;
        public FormBai07_ThemMonAn(string accessToken, string tokenType)
        {
            InitializeComponent();
            this.accessToken = accessToken;
            this.tokenType = tokenType;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is RichTextBox)
                        (control as RichTextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox textbox)
                    {
                        if (string.IsNullOrEmpty(textbox.Text))
                        {
                            MessageBox.Show("Nhập thiếu thông tin");
                            return;
                        }
                    }
                }
            };

            func(Controls);

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, accessToken);
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                var baseAddress = "https://nt106.uitiot.vn";
                string apiCreateUser = "/api/v1/monan/add";
                var data = new Dictionary<string, string>
                {
                    { "ten_mon_an", tbMonAn.Text },
                    { "gia", tbGia.Text },
                    { "mo_ta", rtbMoTa.Text },
                    { "hinh_anh", tbHinhAnh.Text },
                    { "dia_chi", tbDiaChi.Text }
                };
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Add(contentType);
                var jsonData = JsonConvert.SerializeObject(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(apiCreateUser, content);
                var responseStatus = response.StatusCode;
                if (responseStatus != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Thêm món ăn thất bại");
                    return;
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
