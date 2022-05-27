
namespace veri_yapıları_proje
{
    partial class Form1
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
            this.lblMetin = new System.Windows.Forms.Label();
            this.btnDosya = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMetin
            // 
            this.lblMetin.AutoSize = true;
            this.lblMetin.Location = new System.Drawing.Point(51, 35);
            this.lblMetin.Name = "lblMetin";
            this.lblMetin.Size = new System.Drawing.Size(38, 15);
            this.lblMetin.TabIndex = 0;
            this.lblMetin.Text = "metin";
            // 
            // btnDosya
            // 
            this.btnDosya.Location = new System.Drawing.Point(23, 78);
            this.btnDosya.Name = "btnDosya";
            this.btnDosya.Size = new System.Drawing.Size(99, 30);
            this.btnDosya.TabIndex = 1;
            this.btnDosya.Text = "dosya aktar";
            this.btnDosya.UseVisualStyleBackColor = true;
            this.btnDosya.Click += new System.EventHandler(this.btnDosya_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDosya);
            this.Controls.Add(this.lblMetin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMetin;
        private System.Windows.Forms.Button btnDosya;
    }
}

