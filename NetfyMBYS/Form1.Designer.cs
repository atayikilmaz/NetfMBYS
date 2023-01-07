
namespace NetfyMBYS
{
    partial class Form1
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
            this.doktorIdText = new System.Windows.Forms.TextBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.girisYapGrp = new System.Windows.Forms.GroupBox();
            this.sistemBilgiGrp = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.girisYapGrp.SuspendLayout();
            this.sistemBilgiGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // doktorIdText
            // 
            this.doktorIdText.Location = new System.Drawing.Point(191, 59);
            this.doktorIdText.Name = "doktorIdText";
            this.doktorIdText.Size = new System.Drawing.Size(100, 22);
            this.doktorIdText.TabIndex = 0;
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(191, 110);
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(100, 22);
            this.sifreText.TabIndex = 1;
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(140, 175);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(179, 80);
            this.girisBtn.TabIndex = 2;
            this.girisBtn.Text = "Giriş Yap";
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(264, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 76);
            this.label1.TabIndex = 3;
            this.label1.Text = "MBYS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(67, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(111, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre";
            // 
            // girisYapGrp
            // 
            this.girisYapGrp.Controls.Add(this.girisBtn);
            this.girisYapGrp.Controls.Add(this.label3);
            this.girisYapGrp.Controls.Add(this.doktorIdText);
            this.girisYapGrp.Controls.Add(this.label2);
            this.girisYapGrp.Controls.Add(this.sifreText);
            this.girisYapGrp.Location = new System.Drawing.Point(396, 129);
            this.girisYapGrp.Name = "girisYapGrp";
            this.girisYapGrp.Size = new System.Drawing.Size(392, 309);
            this.girisYapGrp.TabIndex = 6;
            this.girisYapGrp.TabStop = false;
            this.girisYapGrp.Text = "Giriş Yap";
            // 
            // sistemBilgiGrp
            // 
            this.sistemBilgiGrp.Controls.Add(this.label5);
            this.sistemBilgiGrp.Controls.Add(this.label4);
            this.sistemBilgiGrp.Location = new System.Drawing.Point(12, 129);
            this.sistemBilgiGrp.Name = "sistemBilgiGrp";
            this.sistemBilgiGrp.Size = new System.Drawing.Size(378, 309);
            this.sistemBilgiGrp.TabIndex = 7;
            this.sistemBilgiGrp.TabStop = false;
            this.sistemBilgiGrp.Text = "Sistem Bilgi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(21, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 50);
            this.label5.TabIndex = 1;
            this.label5.Text = "Aile Hekiminin Hasta Kaydı ve Reçete \r\nKaydı Tutulması İçin Oluşturulmuştur. ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(21, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Muayene Bilgi Sistemine Hoş Geldiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sistemBilgiGrp);
            this.Controls.Add(this.girisYapGrp);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.girisYapGrp.ResumeLayout(false);
            this.girisYapGrp.PerformLayout();
            this.sistemBilgiGrp.ResumeLayout(false);
            this.sistemBilgiGrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox doktorIdText;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox girisYapGrp;
        private System.Windows.Forms.GroupBox sistemBilgiGrp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

