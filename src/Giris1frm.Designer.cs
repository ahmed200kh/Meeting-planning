namespace TPU
{
    partial class Giris1frm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris1frm));
            Giris = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Giris
            // 
            Giris.Anchor = AnchorStyles.None;
            Giris.BackColor = Color.LightSteelBlue;
            Giris.BackgroundImageLayout = ImageLayout.Center;
            Giris.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Giris.ForeColor = SystemColors.Highlight;
            Giris.Location = new Point(291, 264);
            Giris.Name = "Giris";
            Giris.Size = new Size(149, 67);
            Giris.TabIndex = 1;
            Giris.Text = "Başlat";
            Giris.UseVisualStyleBackColor = false;
            Giris.Click += Giris_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(189, 193);
            label1.Name = "label1";
            label1.Size = new Size(356, 56);
            label1.TabIndex = 2;
            label1.Text = "--Hoşgeldiniz--";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // Giris1frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(744, 602);
            Controls.Add(label1);
            Controls.Add(Giris);
            Name = "Giris1frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Giris;
        private Label label1;
    }
}