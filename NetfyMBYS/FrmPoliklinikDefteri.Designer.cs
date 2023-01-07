
namespace NetfyMBYS
{
    partial class FrmPoliklinikDefteri
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
            this.label1 = new System.Windows.Forms.Label();
            this.poliklinikDefteriDgw = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikDefteriDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(55, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(704, 76);
            this.label1.TabIndex = 4;
            this.label1.Text = "POLİKLİNİK DEFTERİ";
            // 
            // poliklinikDefteriDgw
            // 
            this.poliklinikDefteriDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poliklinikDefteriDgw.Location = new System.Drawing.Point(68, 164);
            this.poliklinikDefteriDgw.Name = "poliklinikDefteriDgw";
            this.poliklinikDefteriDgw.RowHeadersWidth = 51;
            this.poliklinikDefteriDgw.RowTemplate.Height = 24;
            this.poliklinikDefteriDgw.Size = new System.Drawing.Size(671, 224);
            this.poliklinikDefteriDgw.TabIndex = 5;
            // 
            // FrmPoliklinikDefteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.poliklinikDefteriDgw);
            this.Controls.Add(this.label1);
            this.Name = "FrmPoliklinikDefteri";
            this.Text = "FrmPoliklinikDefteri";
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikDefteriDgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView poliklinikDefteriDgw;
    }
}