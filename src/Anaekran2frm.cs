using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPU
{
    public partial class Anaekran2frm : Form
    {
        public Anaekran2frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void TPO_Click(object sender, EventArgs e)
        {
            Toplantiolustur3frm TPUO = new Toplantiolustur3frm();
            TPUO.Show();
            this.Hide();
        }

        private void TPK_Click(object sender, EventArgs e)
        {
            Toplantiyakatil4frm TPUK = new Toplantiyakatil4frm();
            TPUK.Show();
            this.Hide();
        }

        private void CIKIS_Click(object sender, EventArgs e)
        {
            Giris1frm TPUG = new Giris1frm();
            TPUG.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Anaekran2frm_Load(object sender, EventArgs e)
        {

        }
    }
}
