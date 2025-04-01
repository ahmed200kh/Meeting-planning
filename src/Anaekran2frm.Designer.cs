namespace TPU
{
    partial class Anaekran2frm
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
            TPO = new Button();
            TPK = new Button();
            CIKIS = new Button();
            SuspendLayout();
            // 
            // TPO
            // 
            TPO.Anchor = AnchorStyles.None;
            TPO.BackColor = Color.LightSteelBlue;
            TPO.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            TPO.ForeColor = SystemColors.Highlight;
            TPO.Location = new Point(222, 170);
            TPO.Name = "TPO";
            TPO.Size = new Size(302, 67);
            TPO.TabIndex = 2;
            TPO.Text = "Toplantı oluştur";
            TPO.UseVisualStyleBackColor = false;
            TPO.Click += TPO_Click;
            // 
            // TPK
            // 
            TPK.Anchor = AnchorStyles.None;
            TPK.BackColor = Color.LightSteelBlue;
            TPK.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            TPK.ForeColor = SystemColors.Highlight;
            TPK.Location = new Point(222, 279);
            TPK.Name = "TPK";
            TPK.Size = new Size(302, 70);
            TPK.TabIndex = 3;
            TPK.Text = "Toplantıya katıl";
            TPK.UseVisualStyleBackColor = false;
            TPK.Click += TPK_Click;
            // 
            // CIKIS
            // 
            CIKIS.Anchor = AnchorStyles.None;
            CIKIS.BackColor = Color.NavajoWhite;
            CIKIS.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            CIKIS.ForeColor = SystemColors.InfoText;
            CIKIS.Location = new Point(277, 396);
            CIKIS.Name = "CIKIS";
            CIKIS.Size = new Size(171, 58);
            CIKIS.TabIndex = 5;
            CIKIS.Text = "Geri";
            CIKIS.UseVisualStyleBackColor = false;
            CIKIS.Click += CIKIS_Click;
            // 
            // Anaekran2frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources._4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(730, 618);
            Controls.Add(CIKIS);
            Controls.Add(TPK);
            Controls.Add(TPO);
            Name = "Anaekran2frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Ekran";
            Load += Anaekran2frm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button TPO;
        private Button TPK;
        private Button CIKIS;
    }
}