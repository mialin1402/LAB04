using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using System.Net;

namespace LAB4
{
    public partial class FormBai07 : Form
    {
        public FormBai07()
        {
            InitializeComponent();
            cbMePage.Text = "1";
            cbMePageSize.Text = "5";
            cbAllPage.Text = "1";
            cbAllPageSize.Text = "5";
            cbAllPage.SelectedIndexChanged += Reload_SelectedChanged;
            cbAllPageSize.SelectedIndexChanged += Reload_SelectedChanged;
            cbMePage.SelectedIndexChanged += Reload_SelectedChanged;
            cbMePageSize.SelectedIndexChanged += Reload_SelectedChanged;
        }
        public class Data
        {
            public string id { get; set; }
            public string ten_mon_an { get; set; }
            public string gia { get; set; }
            public string mo_ta { get; set; }
            public string hinh_anh { get; set; }
            public string dia_chi { get; set; }
            public string nguoi_dong_gop { get; set; }
            public Data() { }
        }

        public class Pagination
        {
            public int current { get; set; }
            public int pageSize { get; set; }
            public int total { get; set; }
            public Pagination() { }
        }
        public class MonAn
        {
            public List<Data> Data { get; set; }
            public Pagination Pagination { get; set; }
            public MonAn() { }
        }
        string accessToken = string.Empty;
        string tokenType = string.Empty;
        private MonAn monAn = new MonAn(); 
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

            LoadMonAn("1", "5", 0);

        }
        private Image LoadImageFromUrl(string imageUrl)
        {
            Image output;
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    byte[] imageBytes = webClient.DownloadData(imageUrl);
                    using (MemoryStream memStream = new MemoryStream(imageBytes))
                    {
                        output = Image.FromStream(memStream);
                        output = new Bitmap(output, new Size(150, 150));
                        return output;
                    }
                }
                catch (Exception ex)
                {
                    output = SystemIcons.Error.ToBitmap();
                    output = new Bitmap(output, new Size(150, 150));
                    return output;
                }
            }
        }
        private async void LoadMonAn(string page, string pagesize, int tabIndex)
        {
            dsMonAnMe.Controls.Clear();
            dsMonAnAll.Controls.Clear();
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, accessToken);
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                var baseAddress = "https://nt106.uitiot.vn";
                string apiCreateUser = (tabIndex == 0) ? "/api/v1/monan/my-dishes" : "/api/v1/monan/all";
                var data = new Dictionary<string, int>
                {
                    { "current", int.Parse(page) },
                    { "pageSize", int.Parse(pagesize) }
                };
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Add(contentType);
                var jsonData = JsonConvert.SerializeObject(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(apiCreateUser, content);
                var responseString = await response.Content.ReadAsStringAsync();
                monAn = JsonConvert.DeserializeObject<MonAn>(responseString);
                if (monAn == null)
                {
                    MessageBox.Show("Không nhận được món ăn");
                    return;
                }
                int totalPage = (monAn.Pagination.total < monAn.Pagination.pageSize) ? 1 : monAn.Pagination.total / monAn.Pagination.pageSize;
                cbMePage.Items.Clear();
                cbAllPage.Items.Clear();
                for (int i = 1; i <= totalPage; i++)
                {
                    if (tabIndex == 0)
                    {
                        cbMePage.Items.Add(i.ToString());
                    }
                    else
                    {
                        cbAllPage.Items.Add(i.ToString());
                    }
                }
                dsMonAnMe.Controls.Clear();
                foreach (Data dataMonAn in monAn.Data)
                {
                    FormBai07_MonAnItem MonAnItem = new FormBai07_MonAnItem();
                    MonAnItem.id = dataMonAn.id;
                    MonAnItem.tenMonAn = dataMonAn.ten_mon_an;
                    MonAnItem.Gia = dataMonAn.gia;
                    MonAnItem.DiaChi = dataMonAn.dia_chi;
                    MonAnItem.DongGop = dataMonAn.nguoi_dong_gop;
                    MonAnItem.AnhMonAn = LoadImageFromUrl(dataMonAn.hinh_anh);

                    if (tabIndex == 0)
                    {
                        MonAnItem.DoubleClick += MonAnItem_DoubleClick;
                        MonAnItem.Cursor = Cursors.Hand;
                        dsMonAnMe.Controls.Add(MonAnItem);
                    }
                    else
                    {
                        dsMonAnAll.Controls.Add(MonAnItem);
                    }

                }
            }
        }

        private async void MonAnItem_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Đang xoá món ăn");
            FormBai07_MonAnItem monan = (FormBai07_MonAnItem)sender;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, accessToken);
                    var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                    var baseAddress = "https://nt106.uitiot.vn";
                    string api = $"/api/v1/monan/{monan.id}";
                    client.BaseAddress = new Uri(baseAddress);
                    client.DefaultRequestHeaders.Accept.Add(contentType);
                    var response = await client.DeleteAsync(api);
                    var resonseStatus = response.StatusCode;
                    if (resonseStatus != HttpStatusCode.OK)
                    {
                        MessageBox.Show("Không thể xoá món ăn");
                        return;
                    }
                }

                LoadMonAn(cbMePage.Text, cbMePageSize.Text, 0);
            }
            catch
            {
                MessageBox.Show("Không thể xoá món ăn");
                return;
            }

        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            FormBai07_ThemMonAn formBai07_ThemMonAn = new FormBai07_ThemMonAn(accessToken, tokenType);
            formBai07_ThemMonAn.ShowDialog();

            LoadMonAn(cbMePage.Text, cbMePageSize.Text, 0);
        }

        private void Reload_SelectedChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                LoadMonAn(cbMePage.Text, cbMePageSize.Text, 0);
            }
            else
            {
                LoadMonAn(cbAllPage.Text, cbAllPageSize.Text, 1);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int randomIndex = new Random().Next(0, monAn.Data.Count);

            Data HomNayAn = monAn.Data[randomIndex];

            FormBai07_MonAnItem _MonAnItem = new FormBai07_MonAnItem();
            _MonAnItem.tenMonAn = HomNayAn.ten_mon_an;
            _MonAnItem.Gia = HomNayAn.gia;
            _MonAnItem.DiaChi = HomNayAn.dia_chi;
            _MonAnItem.DongGop = HomNayAn.nguoi_dong_gop;
            _MonAnItem.AnhMonAn = LoadImageFromUrl(HomNayAn.hinh_anh);

            Form window = new Form
            {
                Text = $"Đi ăn {HomNayAn.ten_mon_an} đi",
                TopLevel = true,
                FormBorderStyle = FormBorderStyle.Fixed3D, //Disables user resizing
                MaximizeBox = false,
                MinimizeBox = false,
                ClientSize = _MonAnItem.Size //size the form to fit the content
            };

            window.Controls.Add(_MonAnItem);
            _MonAnItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            window.ShowDialog();
        }


    }
}
