namespace TPU
{
    partial class googletakvim6frm
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
            dateTimePicker = new DateTimePicker();
            label2 = new Label();
            TPO = new Button();
            konutbx = new TextBox();
            label5 = new Label();
            acıklamatxtbx = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.None;
            dateTimePicker.Location = new Point(135, 134);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 7;
            dateTimePicker.Value = new DateTime(2023, 12, 1, 0, 0, 0, 0);
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 137);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 6;
            label2.Text = "Tarih :";
            // 
            // TPO
            // 
            TPO.Anchor = AnchorStyles.None;
            TPO.BackColor = Color.LightSteelBlue;
            TPO.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TPO.ForeColor = SystemColors.Highlight;
            TPO.Location = new Point(108, 166);
            TPO.Name = "TPO";
            TPO.Size = new Size(151, 58);
            TPO.TabIndex = 8;
            TPO.Text = "Kesinleştir";
            TPO.UseVisualStyleBackColor = false;
            TPO.Click += TPO_Click;
            // 
            // konutbx
            // 
            konutbx.Anchor = AnchorStyles.None;
            konutbx.BackColor = SystemColors.ButtonHighlight;
            konutbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            konutbx.Location = new Point(135, 12);
            konutbx.Name = "konutbx";
            konutbx.ReadOnly = true;
            konutbx.Size = new Size(213, 29);
            konutbx.TabIndex = 11;
            konutbx.TextChanged += konutbx_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 22);
            label5.Name = "label5";
            label5.Size = new Size(113, 19);
            label5.TabIndex = 9;
            label5.Text = "Konu Başlığı:";
            // 
            // acıklamatxtbx
            // 
            acıklamatxtbx.Anchor = AnchorStyles.None;
            acıklamatxtbx.BackColor = SystemColors.ButtonHighlight;
            acıklamatxtbx.Location = new Point(135, 51);
            acıklamatxtbx.Multiline = true;
            acıklamatxtbx.Name = "acıklamatxtbx";
            acıklamatxtbx.ReadOnly = true;
            acıklamatxtbx.Size = new Size(213, 68);
            acıklamatxtbx.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 74);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 10;
            label1.Text = "Açıklama:";
            label1.Click += label1_Click;
            // 
            // googletakvim6frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 236);
            Controls.Add(konutbx);
            Controls.Add(label5);
            Controls.Add(acıklamatxtbx);
            Controls.Add(label1);
            Controls.Add(TPO);
            Controls.Add(dateTimePicker);
            Controls.Add(label2);
            Name = "googletakvim6frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Google Takvim";
            Load += googletakvim6frm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker;
        private Label label2;
        private Button TPO;
        private TextBox konutbx;
        private Label label5;
        private TextBox acıklamatxtbx;
        private Label label1;
    }
}