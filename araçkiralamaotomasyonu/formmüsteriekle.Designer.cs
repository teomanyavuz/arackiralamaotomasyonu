
namespace araçkiralamaotomasyonu
{
    partial class formmüsteriekle
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
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnİPTAL = new System.Windows.Forms.Button();
            this.btnEKLE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(112, 64);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(138, 20);
            this.txtad.TabIndex = 0;
            this.txtad.TextChanged += new System.EventHandler(this.txtad_TextChanged);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(112, 102);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(138, 20);
            this.txtsoyad.TabIndex = 1;
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(112, 143);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(138, 20);
            this.txtno.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "AD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SOYAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "TELEFON";
            // 
            // btnİPTAL
            // 
            this.btnİPTAL.Location = new System.Drawing.Point(203, 187);
            this.btnİPTAL.Name = "btnİPTAL";
            this.btnİPTAL.Size = new System.Drawing.Size(75, 23);
            this.btnİPTAL.TabIndex = 6;
            this.btnİPTAL.Text = "İPTAL";
            this.btnİPTAL.UseVisualStyleBackColor = true;
            this.btnİPTAL.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEKLE
            // 
            this.btnEKLE.Location = new System.Drawing.Point(112, 187);
            this.btnEKLE.Name = "btnEKLE";
            this.btnEKLE.Size = new System.Drawing.Size(75, 23);
            this.btnEKLE.TabIndex = 7;
            this.btnEKLE.Text = "EKLE";
            this.btnEKLE.UseVisualStyleBackColor = true;
            this.btnEKLE.Click += new System.EventHandler(this.button2_Click);
            // 
            // formmüsteriekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(333, 317);
            this.Controls.Add(this.btnEKLE);
            this.Controls.Add(this.btnİPTAL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Name = "formmüsteriekle";
            this.Text = "Müşteri Ekleme Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnİPTAL;
        private System.Windows.Forms.Button btnEKLE;
    }
}