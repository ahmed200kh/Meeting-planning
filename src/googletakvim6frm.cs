using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TPU
{
    public partial class googletakvim6frm : Form
    {
        public static string Konu { get; set; }
        public static string Acıklama { get; set; }


        private CalendarService service;
        public googletakvim6frm()
        {
            InitializeComponent();

        }



        private void googletakvim6frm_Load(object sender, EventArgs e)
        {
            konutbx.Text = Konu;
            acıklamatxtbx.Text = Acıklama;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";


        }

        private void TPO_Click(object sender, EventArgs e)
        {
            DateTime selectedDateTime = dateTimePicker.Value;


            AddToGoogleCalendar(selectedDateTime);

        }
        private static string[] Scopes = { CalendarService.Scope.Calendar };


        private void AddToGoogleCalendar(DateTime selectedDateTime)
        {
            try
            {


                UserCredential credential;


                string jsonCredentials = @"
                {
                      ""installed"": {
                             ""client_id"": ""108297643664-85qvh4559jfr8q7gpd3g8pa543iaua6o.apps.googleusercontent.com"",
                             ""project_id"": ""meeting-planning-app"",
                             ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
                             ""token_uri"": ""https://oauth2.googleapis.com/token"",
                             ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
                             ""client_secret"": ""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"",
                             ""redirect_uris"": [
                                 ""http://localhost""
                       ]
                    }
                }";






                using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonCredentials)))
                {
                    string credPath = "token.json";
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                }


                var service = new CalendarService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Your Application Name",
                });


                Event newEvent = new Event()
                {
                    Summary = konutbx.Text,
                    Description = acıklamatxtbx.Text,
                    Start = new EventDateTime() { DateTime = selectedDateTime, TimeZone = "Europe/Istanbul" },
                    End = new EventDateTime() { DateTime = selectedDateTime.AddHours(1), TimeZone = "Europe/Istanbul" }
                };


                service.Events.Insert(newEvent, "primary").Execute();


                MessageBox.Show("Takvim etkinliği başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }













        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void konutbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
