﻿namespace Borsa
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtApple = new System.Windows.Forms.TextBox();
            this.txtMicrosoft = new System.Windows.Forms.TextBox();
            this.txtAmazon = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtApple
            // 
            this.txtApple.Location = new System.Drawing.Point(104, 128);
            this.txtApple.Name = "txtApple";
            this.txtApple.ReadOnly = true;
            this.txtApple.Size = new System.Drawing.Size(100, 22);
            this.txtApple.TabIndex = 0;
            // 
            // txtMicrosoft
            // 
            this.txtMicrosoft.Location = new System.Drawing.Point(374, 128);
            this.txtMicrosoft.Name = "txtMicrosoft";
            this.txtMicrosoft.ReadOnly = true;
            this.txtMicrosoft.Size = new System.Drawing.Size(100, 22);
            this.txtMicrosoft.TabIndex = 1;
            // 
            // txtAmazon
            // 
            this.txtAmazon.Location = new System.Drawing.Point(637, 128);
            this.txtAmazon.Name = "txtAmazon";
            this.txtAmazon.ReadOnly = true;
            this.txtAmazon.Size = new System.Drawing.Size(100, 22);
            this.txtAmazon.TabIndex = 2;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(334, 230);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(164, 70);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apple(APPL)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Microsoft(MSFT)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amazon(AMZN)";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(895, 525);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtAmazon);
            this.Controls.Add(this.txtMicrosoft);
            this.Controls.Add(this.txtApple);
            this.Name = "Form1";
            this.Text = "Borsa Hisse Fiyatları";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtApple;
        private System.Windows.Forms.TextBox txtMicrosoft;
        private System.Windows.Forms.TextBox txtAmazon;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
