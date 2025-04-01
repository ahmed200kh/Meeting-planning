namespace TPU
{
    partial class Toplantiyakatil4frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Toplantidobottn = new Button();
            Konu = new ListBox();
            label2 = new Label();
            kodytxtb = new TextBox();
            Açıklama = new ListBox();
            label4 = new Label();
            listView1 = new ListView();
            AdSoyad = new ColumnHeader();
            Tarih = new ColumnHeader();
            ekleduzenlebtn = new Button();
            Geri = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(117, 19);
            label1.TabIndex = 2;
            label1.Text = "Kodu Yapıştır:";
            // 
            // Toplantidobottn
            // 
            Toplantidobottn.Anchor = AnchorStyles.None;
            Toplantidobottn.BackColor = Color.LightSteelBlue;
            Toplantidobottn.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Toplantidobottn.ForeColor = SystemColors.Highlight;
            Toplantidobottn.Location = new Point(12, 75);
            Toplantidobottn.Name = "Toplantidobottn";
            Toplantidobottn.Size = new Size(261, 58);
            Toplantidobottn.TabIndex = 7;
            Toplantidobottn.Text = "Doğrula/Güncelle";
            Toplantidobottn.UseVisualStyleBackColor = false;
            Toplantidobottn.Click += TPO_Click;
            // 
            // Konu
            // 
            Konu.Anchor = AnchorStyles.None;
            Konu.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Konu.FormattingEnabled = true;
            Konu.HorizontalScrollbar = true;
            Konu.ItemHeight = 19;
            Konu.Location = new Point(153, 162);
            Konu.Name = "Konu";
            Konu.Size = new Size(120, 42);
            Konu.TabIndex = 9;
            Konu.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 162);
            label2.Name = "label2";
            label2.Size = new Size(135, 19);
            label2.TabIndex = 11;
            label2.Text = "Toplantı bilgileri:";
            // 
            // kodytxtb
            // 
            kodytxtb.Anchor = AnchorStyles.None;
            kodytxtb.Location = new Point(153, 30);
            kodytxtb.Name = "kodytxtb";
            kodytxtb.Size = new Size(157, 23);
            kodytxtb.TabIndex = 10;
            kodytxtb.TextChanged += kodytxtb_TextChanged;
            // 
            // Açıklama
            // 
            Açıklama.Anchor = AnchorStyles.None;
            Açıklama.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Açıklama.FormattingEnabled = true;
            Açıklama.HorizontalScrollbar = true;
            Açıklama.ItemHeight = 19;
            Açıklama.Location = new Point(153, 220);
            Açıklama.Name = "Açıklama";
            Açıklama.Size = new Size(120, 42);
            Açıklama.TabIndex = 9;
            Açıklama.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(463, 22);
            label4.Name = "label4";
            label4.Size = new Size(121, 19);
            label4.TabIndex = 13;
            label4.Text = "-- Katılımcılar --";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.None;
            listView1.Columns.AddRange(new ColumnHeader[] { AdSoyad, Tarih });
            listView1.GridLines = true;
            listView1.Location = new Point(379, 44);
            listView1.Name = "listView1";
            listView1.Size = new Size(289, 299);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // AdSoyad
            // 
            AdSoyad.Text = "AdSoyad";
            AdSoyad.Width = 120;
            // 
            // Tarih
            // 
            Tarih.Text = "Olası Tarihler";
            Tarih.Width = 190;
            // 
            // ekleduzenlebtn
            // 
            ekleduzenlebtn.Anchor = AnchorStyles.None;
            ekleduzenlebtn.BackColor = Color.DeepSkyBlue;
            ekleduzenlebtn.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ekleduzenlebtn.ForeColor = SystemColors.InfoText;
            ekleduzenlebtn.Location = new Point(42, 361);
            ekleduzenlebtn.Name = "ekleduzenlebtn";
            ekleduzenlebtn.Size = new Size(167, 58);
            ekleduzenlebtn.TabIndex = 15;
            ekleduzenlebtn.Text = "Kaydol";
            ekleduzenlebtn.UseVisualStyleBackColor = false;
            ekleduzenlebtn.Click += button1_Click;
            // 
            // Geri
            // 
            Geri.Anchor = AnchorStyles.None;
            Geri.BackColor = Color.NavajoWhite;
            Geri.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Geri.ForeColor = SystemColors.InfoText;
            Geri.Location = new Point(497, 361);
            Geri.Name = "Geri";
            Geri.Size = new Size(171, 58);
            Geri.TabIndex = 8;
            Geri.Text = "Geri";
            Geri.UseVisualStyleBackColor = false;
            Geri.Click += CIKIS_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.LightSlateGray;
            button1.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.InfoText;
            button1.Location = new Point(290, 361);
            button1.Name = "button1";
            button1.Size = new Size(125, 58);
            button1.TabIndex = 16;
            button1.Text = "Google Takvim'e Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Toplantiyakatil4frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 443);
            Controls.Add(button1);
            Controls.Add(ekleduzenlebtn);
            Controls.Add(listView1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(kodytxtb);
            Controls.Add(Açıklama);
            Controls.Add(Konu);
            Controls.Add(Geri);
            Controls.Add(Toplantidobottn);
            Controls.Add(label1);
            Name = "Toplantiyakatil4frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Toplantıya katıl";
            Load += Toplantiyakatil4frm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Toplantidobottn;
        private ListBox Konu;
        private Label label2;
        private TextBox kodytxtb;
        private ListBox Açıklama;
        private Label label4;
        private ListView listView1;
        private ColumnHeader AdSoyad;
        private ColumnHeader Tarih;
        private Button ekleduzenlebtn;
        private Button Geri;
        private Button button1;
    }
}