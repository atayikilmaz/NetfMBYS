namespace NetfyMBYS
{
    partial class FrmIslemSayfasi
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
            this.hastaEkleBtn = new System.Windows.Forms.Button();
            this.muayeneOlusturBtn = new System.Windows.Forms.Button();
            this.poliklinikDefteriBtn = new System.Windows.Forms.Button();
            this.ilacRaporuBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hastaEkleBtn
            // 
            this.hastaEkleBtn.Location = new System.Drawing.Point(91, 172);
            this.hastaEkleBtn.Name = "hastaEkleBtn";
            this.hastaEkleBtn.Size = new System.Drawing.Size(251, 65);
            this.hastaEkleBtn.TabIndex = 3;
            this.hastaEkleBtn.Text = "Hasta Ekle";
            this.hastaEkleBtn.UseVisualStyleBackColor = true;
            this.hastaEkleBtn.Click += new System.EventHandler(this.hastaEkleBtn_Click);
            // 
            // muayeneOlusturBtn
            // 
            this.muayeneOlusturBtn.Location = new System.Drawing.Point(445, 266);
            this.muayeneOlusturBtn.Name = "muayeneOlusturBtn";
            this.muayeneOlusturBtn.Size = new System.Drawing.Size(251, 64);
            this.muayeneOlusturBtn.TabIndex = 4;
            this.muayeneOlusturBtn.Text = "Muayene Ekle";
            this.muayeneOlusturBtn.UseVisualStyleBackColor = true;
            this.muayeneOlusturBtn.Click += new System.EventHandler(this.muayeneOlusturBtn_Click);
            // 
            // poliklinikDefteriBtn
            // 
            this.poliklinikDefteriBtn.Location = new System.Drawing.Point(435, 172);
            this.poliklinikDefteriBtn.Name = "poliklinikDefteriBtn";
            this.poliklinikDefteriBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.poliklinikDefteriBtn.Size = new System.Drawing.Size(261, 64);
            this.poliklinikDefteriBtn.TabIndex = 5;
            this.poliklinikDefteriBtn.Text = "Poliklinik Defteri Görüntüle";
            this.poliklinikDefteriBtn.UseVisualStyleBackColor = true;
            this.poliklinikDefteriBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // ilacRaporuBtn
            // 
            this.ilacRaporuBtn.Location = new System.Drawing.Point(91, 266);
            this.ilacRaporuBtn.Name = "ilacRaporuBtn";
            this.ilacRaporuBtn.Size = new System.Drawing.Size(251, 67);
            this.ilacRaporuBtn.TabIndex = 6;
            this.ilacRaporuBtn.Text = "Hasta İlaç Raporu Görüntüle";
            this.ilacRaporuBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(128, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 76);
            this.label1.TabIndex = 7;
            this.label1.Text = "İŞLEM SAYFASI";
            // 
            // FrmIslemSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ilacRaporuBtn);
            this.Controls.Add(this.poliklinikDefteriBtn);
            this.Controls.Add(this.muayeneOlusturBtn);
            this.Controls.Add(this.hastaEkleBtn);
            this.Name = "FrmIslemSayfasi";
            this.Text = "IslemSayfasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hastaEkleBtn;
        private System.Windows.Forms.Button muayeneOlusturBtn;
        private System.Windows.Forms.Button poliklinikDefteriBtn;
        private System.Windows.Forms.Button ilacRaporuBtn;
        private System.Windows.Forms.Label label1;
    }
}