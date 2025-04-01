using System.Xml.Linq;

namespace TPU
{
    public partial class Giris1frm : Form
    {
        public Giris1frm()
        {
            InitializeComponent();
            // Enter tuşu
            this.AcceptButton = Giris;
        }

        private void Giris_Click(object sender, EventArgs e)
        {
            Anaekran2frm TPUG = new Anaekran2frm();
            TPUG.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}