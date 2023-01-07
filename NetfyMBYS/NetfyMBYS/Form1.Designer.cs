
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
            this.doktorAdText = new System.Windows.Forms.TextBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doktorAdText
            // 
            this.doktorAdText.Location = new System.Drawing.Point(280, 157);
            this.doktorAdText.Name = "doktorAdText";
            this.doktorAdText.Size = new System.Drawing.Size(100, 22);
            this.doktorAdText.TabIndex = 0;
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(280, 213);
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(100, 22);
            this.sifreText.TabIndex = 1;
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(497, 322);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(75, 23);
            this.girisBtn.TabIndex = 2;
            this.girisBtn.Text = "Giriş Yap";
            this.girisBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.doktorAdText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox doktorAdText;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.Button girisBtn;
    }
}

