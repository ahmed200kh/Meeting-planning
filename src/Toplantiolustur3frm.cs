using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;
using System.Net.Http;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPU
{

    public partial class Toplantiolustur3frm : Form
    {
        public Toplantiolustur3frm()
        {
            InitializeComponent();
        }
        private void Toplantiolustur3frm_Load(object sender, EventArgs e)
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
        }
        private void CIKIS_Click(object sender, EventArgs e)
        {
            Anaekran2frm TPUG = new Anaekran2frm();
            TPUG.Show();
            this.Hide();
        }

        private async void TPO_Click(object sender, EventArgs e)
        {
            try
            {

                string ad = Adtxtbx.Text;
                string konu = konutbx.Text;
                string acıklama = acıklamatxtbx.Text;



                if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(konu) || string.IsNullOrEmpty(acıklama))
                {
                    MessageBox.Show("Lütfen adınızı ve Konu başlığı ve açıklamayı giriniz..");
                    return;
                }

                string Kod = GenerateRandomCode(8);

                string tarih = string.Join(" | ", listView1.Items.Cast<ListViewItem>().Select(item => item.Text));
                int tarihCount = listView1.Items.Count;
                if (tarihCount < 1)
                {
                    MessageBox.Show("Lütfen en az bir tarih ekleyin.");
                    return;
                }
                //socket (using retool)
                
                using (HttpClient client = new HttpClient())
                {

                    this.Cursor = Cursors.WaitCursor;
                    this.Enabled = false;
                    var jsonBody = new
                    {
                        AdSoyad = Adtxtbx.Text,
                        Konu = konutbx.Text,
                        Açıklama = acıklamatxtbx.Text,
                        Tarih = tarih,
                        Kod = Kod
                    };

                    string data = JsonConvert.SerializeObject(jsonBody);
                    StringContent stringcontent = new StringContent(data, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync("https://retoolapi.dev/dp0plk/data", stringcontent);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Kaydedildi. \nKodu kopyalamayı unutmayın.");
                        this.Cursor = Cursors.Default;
                        this.Enabled = true;
                        kodktxtb.Text = Kod;
                    }
                    else
                    {
                        MessageBox.Show("hata");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lütfen internete bağlı olduğunuzdan emin olun.");
                this.Cursor = Cursors.Default;
            }



        }

        private string GenerateRandomCode(int length)
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder code = new StringBuilder();

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(characters.Length);
                code.Append(characters[index]);
            }

            return code.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool IsDateAlreadyAdded(DateTime date)
        {
            //ListView'da tarihin zaten mevcut olup olmadığını kontrol et
            return listView1.Items.Cast<ListViewItem>().Any(item => DateTime.Parse(item.Text) == date);
        }
        private void eklebttn_Click(object sender, EventArgs e)
        {

            DateTime date = dateTimePicker.Value;

            // en çok 3 tarih kontrolu
            if (listView1.Items.Count < 3 && !IsDateAlreadyAdded(date))
            {
                // ListView'e tarih ekleme
                ListViewItem item = new ListViewItem(date.ToString("yyyy-MM-dd HH:mm"));
                listView1.Items.Add(item);
            }
            else if (listView1.Items.Count >= 3)
            {
                MessageBox.Show("3'ten fazla tarih ekleyemezsiniz.");
            }
            else
            {
                MessageBox.Show("Tarih zaten listede.");
            }


        }

        private void silbttn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Seçilen tarihi sil
                listView1.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz tarihi seçin.");
            }


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void acıklamatxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void kodktxtb_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Adtxtbx_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
        }
    }
}
