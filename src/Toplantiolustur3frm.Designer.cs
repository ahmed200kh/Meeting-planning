namespace TPU
{
    partial class Toplantiolustur3frm
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
            acıklamatxtbx = new TextBox();
            label2 = new Label();
            TPO = new Button();
            CIKIS = new Button();
            label4 = new Label();
            kodktxtb = new TextBox();
            label3 = new Label();
            Adtxtbx = new TextBox();
            dateTimePicker = new DateTimePicker();
            label5 = new Label();
            konutbx = new TextBox();
            listView1 = new ListView();
            tarihler = new ColumnHeader();
            eklebttn = new Button();
            silbttn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 141);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 1;
            label1.Text = "Açıklama:";
            label1.Click += label1_Click;
            // 
            // acıklamatxtbx
            // 
            acıklamatxtbx.Anchor = AnchorStyles.None;
            acıklamatxtbx.Location = new Point(147, 117);
            acıklamatxtbx.Multiline = true;
            acıklamatxtbx.Name = "acıklamatxtbx";
            acıklamatxtbx.Size = new Size(213, 68);
            acıklamatxtbx.TabIndex = 2;
            acıklamatxtbx.TextChanged += acıklamatxtbx_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 206);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 3;
            label2.Text = "Tarih :";
            label2.Click += label2_Click;
            // 
            // TPO
            // 
            TPO.Anchor = AnchorStyles.None;
            TPO.BackColor = Color.LightSteelBlue;
            TPO.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TPO.ForeColor = SystemColors.Highlight;
            TPO.Location = new Point(28, 366);
            TPO.Name = "TPO";
            TPO.Size = new Size(151, 58);
            TPO.TabIndex = 4;
            TPO.Text = "Oluştur";
            TPO.UseVisualStyleBackColor = false;
            TPO.Click += TPO_Click;
            // 
            // CIKIS
            // 
            CIKIS.Anchor = AnchorStyles.None;
            CIKIS.BackColor = Color.NavajoWhite;
            CIKIS.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CIKIS.ForeColor = SystemColors.InfoText;
            CIKIS.Location = new Point(417, 477);
            CIKIS.Name = "CIKIS";
            CIKIS.Size = new Size(105, 58);
            CIKIS.TabIndex = 6;
            CIKIS.Text = "Geri";
            CIKIS.UseVisualStyleBackColor = false;
            CIKIS.Click += CIKIS_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(37, 439);
            label4.Name = "label4";
            label4.Size = new Size(129, 19);
            label4.TabIndex = 9;
            label4.Text = "Kod üretilecek :";
            label4.Click += label4_Click;
            // 
            // kodktxtb
            // 
            kodktxtb.Anchor = AnchorStyles.None;
            kodktxtb.BackColor = Color.White;
            kodktxtb.Location = new Point(172, 439);
            kodktxtb.Name = "kodktxtb";
            kodktxtb.ReadOnly = true;
            kodktxtb.Size = new Size(141, 23);
            kodktxtb.TabIndex = 10;
            kodktxtb.TextChanged += kodktxtb_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 40);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 1;
            label3.Text = "Ad Soyad:";
            label3.Click += label3_Click;
            // 
            // Adtxtbx
            // 
            Adtxtbx.Anchor = AnchorStyles.None;
            Adtxtbx.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Adtxtbx.Location = new Point(147, 37);
            Adtxtbx.Name = "Adtxtbx";
            Adtxtbx.Size = new Size(213, 26);
            Adtxtbx.TabIndex = 2;
            Adtxtbx.TextChanged += Adtxtbx_TextChanged;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.None;
            dateTimePicker.Location = new Point(147, 203);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 5;
            dateTimePicker.Value = new DateTime(2023, 12, 1, 0, 0, 0, 0);
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 83);
            label5.Name = "label5";
            label5.Size = new Size(113, 19);
            label5.TabIndex = 1;
            label5.Text = "Konu Başlığı:";
            label5.Click += label5_Click_1;
            // 
            // konutbx
            // 
            konutbx.Anchor = AnchorStyles.None;
            konutbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            konutbx.Location = new Point(147, 78);
            konutbx.Name = "konutbx";
            konutbx.Size = new Size(213, 29);
            konutbx.TabIndex = 2;
            konutbx.TextChanged += textBox1_TextChanged;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.None;
            listView1.Columns.AddRange(new ColumnHeader[] { tarihler });
            listView1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.GridLines = true;
            listView1.Location = new Point(147, 232);
            listView1.Name = "listView1";
            listView1.Size = new Size(151, 106);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // tarihler
            // 
            tarihler.Text = "olası Tarihleri:";
            tarihler.Width = 150;
            // 
            // eklebttn
            // 
            eklebttn.Anchor = AnchorStyles.None;
            eklebttn.BackColor = Color.LightSteelBlue;
            eklebttn.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            eklebttn.ForeColor = SystemColors.Highlight;
            eklebttn.Location = new Point(353, 203);
            eklebttn.Name = "eklebttn";
            eklebttn.Size = new Size(42, 24);
            eklebttn.TabIndex = 14;
            eklebttn.Text = "Ekle";
            eklebttn.UseVisualStyleBackColor = false;
            eklebttn.Click += eklebttn_Click;
            // 
            // silbttn
            // 
            silbttn.Anchor = AnchorStyles.None;
            silbttn.BackColor = Color.LightPink;
            silbttn.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            silbttn.ForeColor = SystemColors.Highlight;
            silbttn.Location = new Point(397, 203);
            silbttn.Name = "silbttn";
            silbttn.Size = new Size(42, 24);
            silbttn.TabIndex = 15;
            silbttn.Text = "Sil";
            silbttn.UseVisualStyleBackColor = false;
            silbttn.Click += silbttn_Click;
            // 
            // Toplantiolustur3frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 569);
            Controls.Add(silbttn);
            Controls.Add(eklebttn);
            Controls.Add(listView1);
            Controls.Add(dateTimePicker);
            Controls.Add(kodktxtb);
            Controls.Add(label4);
            Controls.Add(CIKIS);
            Controls.Add(TPO);
            Controls.Add(label2);
            Controls.Add(Adtxtbx);
            Controls.Add(label3);
            Controls.Add(konutbx);
            Controls.Add(label5);
            Controls.Add(acıklamatxtbx);
            Controls.Add(label1);
            Name = "Toplantiolustur3frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Toplantı oluştur";
            Load += Toplantiolustur3frm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox acıklamatxtbx;
        private Label label2;
        private Button TPO;
        private Button CIKIS;
        private Label label4;
        private TextBox kodktxtb;
        private Label label3;
        private TextBox Adtxtbx;
        private DateTimePicker dateTimePicker;
        private Label label5;
        private TextBox konutbx;
        private ListView listView1;
        private ColumnHeader tarihler;
        private Button eklebttn;
        private Button silbttn;
    }
}