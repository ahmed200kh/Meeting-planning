using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPU
{
    public partial class ekleduzenle5frm : Form
    {
        public static string SecondFormTextBoxValue { get; set; } = "";

        public ekleduzenle5frm()
        {
            InitializeComponent();
        }

        private async void TPO_Click(object sender, EventArgs e)
        {
            string ad = Adtxtbx.Text;
            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Lütfen adınızı giriniz..");
                return;
            }

            string tarih = string.Join(" || ", listView1.Items.Cast<ListViewItem>().Select(item => item.Text));
            int tarihCount = listView1.Items.Count;

            if (tarihCount < 1)
            {
                MessageBox.Show("Lütfen en az bir tarih ekleyin.");
                return;
            }



            using (HttpClient client = new HttpClient())
            {
                this.Cursor = Cursors.WaitCursor;
                this.Enabled = false;
                try
                {


                    var jsonBody = new
                    {
                        AdSoyad = Adtxtbx.Text,
                        Tarih = tarih,
                        Kod = textBox1.Text


                    };
                    string data = JsonConvert.SerializeObject(jsonBody);
                    StringContent stringcontent = new StringContent(data, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync("https://retoolapi.dev/dp0plk/data", stringcontent);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Kaydedildi.");
                        Cursor = Cursors.Default;
                        this.Enabled = true;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("hata");
                    }
                }
                catch
                {
                    MessageBox.Show("Lütfen internete bağlı olduğunuzdan emin olun");
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private bool IsDateAlreadyAdded(DateTime date)
        {
            // ListView'da tarihin zaten mevcut olup olmadığını kontrol et
            return listView1.Items.Cast<ListViewItem>().Any(item => DateTime.Parse(item.Text) == date);
        }



        private void eklebttn_Click_1(object sender, EventArgs e)
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

        private void silbttn_Click_1(object sender, EventArgs e)
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

        private void ekleduzenle5frm_Load_1(object sender, EventArgs e)
        {
            textBox1.Text = SecondFormTextBoxValue;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
