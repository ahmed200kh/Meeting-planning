namespace TPU
{
    partial class ekleduzenle5frm
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
            label3 = new Label();
            Adtxtbx = new TextBox();
            label2 = new Label();
            silbttn = new Button();
            eklebttn = new Button();
            dateTimePicker = new DateTimePicker();
            listView1 = new ListView();
            tarihler = new ColumnHeader();
            TPO = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 29);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 2;
            label3.Text = "Ad Soyad:";
            // 
            // Adtxtbx
            // 
            Adtxtbx.Anchor = AnchorStyles.None;
            Adtxtbx.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Adtxtbx.Location = new Point(136, 26);
            Adtxtbx.Name = "Adtxtbx";
            Adtxtbx.Size = new Size(213, 26);
            Adtxtbx.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 69);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 4;
            label2.Text = "Tarih :";
            label2.Click += label2_Click;
            // 
            // silbttn
            // 
            silbttn.Anchor = AnchorStyles.None;
            silbttn.BackColor = Color.LightPink;
            silbttn.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            silbttn.ForeColor = SystemColors.Highlight;
            silbttn.Location = new Point(386, 69);
            silbttn.Name = "silbttn";
            silbttn.Size = new Size(42, 24);
            silbttn.TabIndex = 18;
            silbttn.Text = "Sil";
            silbttn.UseVisualStyleBackColor = false;
            silbttn.Click += silbttn_Click_1;
            // 
            // eklebttn
            // 
            eklebttn.Anchor = AnchorStyles.None;
            eklebttn.BackColor = Color.LightSteelBlue;
            eklebttn.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            eklebttn.ForeColor = SystemColors.Highlight;
            eklebttn.Location = new Point(342, 69);
            eklebttn.Name = "eklebttn";
            eklebttn.Size = new Size(42, 24);
            eklebttn.TabIndex = 17;
            eklebttn.Text = "Ekle";
            eklebttn.UseVisualStyleBackColor = false;
            eklebttn.Click += eklebttn_Click_1;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.None;
            dateTimePicker.Location = new Point(136, 69);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 5;
            dateTimePicker.Value = new DateTime(2023, 12, 1, 0, 0, 0, 0);
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.None;
            listView1.Columns.AddRange(new ColumnHeader[] { tarihler });
            listView1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.GridLines = true;
            listView1.Location = new Point(136, 98);
            listView1.Name = "listView1";
            listView1.Size = new Size(151, 106);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // tarihler
            // 
            tarihler.Text = "olası Tarihleri:";
            tarihler.Width = 150;
            // 
            // TPO
            // 
            TPO.Anchor = AnchorStyles.None;
            TPO.BackColor = Color.LightSteelBlue;
            TPO.Font = new Font("Arial Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            TPO.ForeColor = SystemColors.Highlight;
            TPO.Location = new Point(136, 276);
            TPO.Name = "TPO";
            TPO.Size = new Size(151, 58);
            TPO.TabIndex = 20;
            TPO.Text = "Katıl";
            TPO.UseVisualStyleBackColor = false;
            TPO.Click += TPO_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(136, 221);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(213, 26);
            textBox1.TabIndex = 22;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 224);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 21;
            label1.Text = "Kod:";
            // 
            // ekleduzenle5frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 373);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(TPO);
            Controls.Add(listView1);
            Controls.Add(silbttn);
            Controls.Add(eklebttn);
            Controls.Add(dateTimePicker);
            Controls.Add(label2);
            Controls.Add(Adtxtbx);
            Controls.Add(label3);
            Name = "ekleduzenle5frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ekle/Düzenle";
            Load += ekleduzenle5frm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox Adtxtbx;
        private Label label2;
        private Button silbttn;
        private Button eklebttn;
        private DateTimePicker dateTimePicker;
        private ListView listView1;
        private ColumnHeader tarihler;
        private Button TPO;
        private TextBox textBox1;
        private Label label1;
    }
}