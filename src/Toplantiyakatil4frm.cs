using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection.Metadata;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace TPU
{
    public partial class Toplantiyakatil4frm : Form
    {
        private string konuValue = ""; 
        private string aciklamaValue = "";

        public Toplantiyakatil4frm()
        {
            InitializeComponent();


        }


        private void CIKIS_Click(object sender, EventArgs e)
        {
            Anaekran2frm TPUG = new Anaekran2frm();
            TPUG.Show();
            this.Hide();
        }

        private async void TPO_Click(object sender, EventArgs e)
        {
            var kod = kodytxtb.Text;
            if (string.IsNullOrEmpty(kod))
            {
                MessageBox.Show("Kodu Giriniz.");
                return;
            }
            if (kod.Length > 9 || kod.Length < 8)
            {
                MessageBox.Show("hatalı kod.");
                return;
                
            }

            Konu.Items.Clear();
            Açıklama.Items.Clear();
            listView1.Items.Clear();

            using (HttpClient Client = new HttpClient())
            {
                Cursor = Cursors.WaitCursor;
                this.Enabled = false;


                


                try
                {
                    HttpResponseMessage response = await Client.GetAsync("https://retoolapi.dev/dp0plk/data" + $"?Kod={kodytxtb.Text}");
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        var jsonArray = JArray.Parse(jsonResponse);

                        var dictionaries = jsonArray.ToObject<Dictionary<string, object>[]>();


                        foreach (var dictionary in dictionaries)
                        {

                            // قم بإجراءاتك هنا باستخدام dictionary

                            if (dictionary.ContainsKey("Konu"))
                            {
                                StringBuilder sbKonu = new StringBuilder();
                                sbKonu.Append($"Konu: {dictionary["Konu"]}");

                                // Konu listBox1'e ekle
                                Konu.Items.Add(sbKonu.ToString());

                                konuValue = dictionary["Konu"].ToString();
                            }

                            if (dictionary.ContainsKey("Açıklama"))
                            {
                                StringBuilder sbAciklama = new StringBuilder();
                                sbAciklama.Append($"Açıklama: {dictionary["Açıklama"]}");

                                //Açıklama listBox2'ye ekle
                                Açıklama.Items.Add(sbAciklama.ToString());

                                aciklamaValue = dictionary["Açıklama"].ToString();
                            }

                        }

                        foreach (var dictionary in dictionaries)
                        {
                            ListViewItem item = new ListViewItem();

                            // İlk sütuna "AdSoyad"ı ekle
                            item.Text = dictionary.ContainsKey("AdSoyad") ? dictionary["AdSoyad"].ToString() : "";

                            // İkinci sütuna "Tarih" ekle
                            item.SubItems.Add(dictionary.ContainsKey("Tarih") ? dictionary["Tarih"].ToString() : "");

                            listView1.Items.Add(item);
                        }
                        this.Enabled = true;
                        Cursor = Cursors.Default;

                        // Sütunları içeriğe göre otomatik olarak ayarla
                        foreach (ColumnHeader column in listView1.Columns)
                        {
                            column.Width = -2; //  auto size 
                        }
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("hatalı kod");
                    }

                }
                catch { MessageBox.Show("Lütfen internete bağlı olduğunuzdan emin olun"); }
                this.Cursor = Cursors.Default;
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void kodytxtb_TextChanged(object sender, EventArgs e)
        {
            // TextBox'un değerini ikinci forma aktar
            ekleduzenle5frm.SecondFormTextBoxValue = kodytxtb.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kod = kodytxtb.Text;

            if (string.IsNullOrEmpty(kod))
            {
                MessageBox.Show("Önce Kodu Giriniz ve Doğrulayınız.");
                return;
            }
            ekleduzenle5frm TPUED = new ekleduzenle5frm();
            TPUED.Show();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Toplantiyakatil4frm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(konuValue) || string.IsNullOrEmpty(aciklamaValue))
            {
                MessageBox.Show("önce kodu giriniz ve doğrulayınız");
                return;
            }
            googletakvim6frm.Konu = konuValue;
            googletakvim6frm.Acıklama = aciklamaValue;

            googletakvim6frm googletakvim6Frm = new googletakvim6frm();
            googletakvim6Frm.Show();

        }
    }
}
