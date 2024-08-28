using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using TrackandTrace2.db;

namespace TrackandTrace2.auth
{
    public partial class form_login : Form
    {
        private bool isLoggingIn = false;

        public form_login()
        {
            InitializeComponent();
            DataBaseUser.InitializeDatabase();
        }


        private async void btn_login_Click(object sender, EventArgs e)
        {
            if (isLoggingIn)
                return;

            string username = txtUsername.Texts;
            string password = txtPassword.Texts;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                ShowSnackbar("Username and password cannot be empty.");
                return;
            }

            isLoggingIn = true;
            ShowLoadingIndicator(true);

            bool loginSuccess = await PostLoginData(username, password);

            ShowLoadingIndicator(false);
            isLoggingIn = false;

            if (loginSuccess)
            {
                this.Hide();
                Form_Main mainForm = new Form_Main(this);
                mainForm.Show();
            }
            else
            {
                ShowSnackbar("Invalid username or password.");
            }
        }


        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                txtPassword.PasswordChar = false;
            }
            else
            {
                txtPassword.PasswordChar = true;
            }
        }
        private void ShowSnackbar(string message, int duration = 5000)
        {
            lblsnackbar.Text = message;
            lblsnackbar.Visible = false;

            Timer timer = new Timer();
            timer.Interval = duration;
            timer.Tick += (s, e) =>
            {
                lblsnackbar.Visible = false;
                timer.Stop();
            };
            timer.Start();
        }
        private async Task<bool> PostLoginData(string username, string password)
        {
            HttpClientHandler handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };

            using (HttpClient client = new HttpClient(handler))
            {
                var postData = new
                {
                    username = username,
                    password = password,
                    flag = 1
               
                };

                string json = Newtonsoft.Json.JsonConvert.SerializeObject(postData);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("https://192.168.100.190:8080/auth/token", content);
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    var jsonResponse = JObject.Parse(responseContent);
                    var data = jsonResponse["data"];
                    var token = (string)data["token"];
                    var tokenExpiredAt = (long)data["tokenExpiredAt"];
                    var idSubRole = (int)data["idSubRole"];

                    DataBaseUser.SaveUserData(username, token, tokenExpiredAt, idSubRole);

                    bool permissionsSaved = await FetchMenuPermissions(token);
                    if (!permissionsSaved)
                    {
                        ShowSnackbar("Failed to fetch or save menu permissions.");
                        return false;
                    }

                    return true;
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response Content: " + responseContent);
                    return false;
                }
            }
        }

        private async Task<bool> FetchMenuPermissions(string token)
        {
            HttpClientHandler handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };

            using (HttpClient client = new HttpClient(handler))
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response = await client.GetAsync("https://192.168.100.190:8080/api/menupermissions");
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Menu Permissions Response Content: " + responseContent);

                    var jsonResponse = JObject.Parse(responseContent);
                    var menuPermissions = jsonResponse["data"] as JArray;

                    var user = DataBaseUser.LoadUserData();
                    int idSubRole = user.IdSubRole;

                    var filteredPermissions = new JArray();
                    foreach (var item in menuPermissions)
                    {
                        int itemIdSubRole = (int)item["idSubRole"];
                        if (itemIdSubRole == idSubRole)
                        {
                            filteredPermissions.Add(item);
                        }
                    }

                    DataBaseUser.SaveMenuPermissions(filteredPermissions);

                    return true;
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Failed to fetch menu permissions. Response Content: " + responseContent);
                    return false;
                }
            }
        }

        private void ShowLoadingIndicator(bool show)
        {
            btn_login.Visible = !show;
            loading.Visible = show;
        }



    }
}
