
namespace araçkiralamaotomasyonu
{
    partial class araçkayıtsayfası
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
            this.plakatxt = new System.Windows.Forms.TextBox();
            this.markacombo = new System.Windows.Forms.ComboBox();
            this.sericombo = new System.Windows.Forms.ComboBox();
            this.yıltxt = new System.Windows.Forms.TextBox();
            this.ücrettxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelmarka = new System.Windows.Forms.Label();
            this.labelseri = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plakatxt
            // 
            this.plakatxt.Location = new System.Drawing.Point(102, 67);
            this.plakatxt.Name = "plakatxt";
            this.plakatxt.Size = new System.Drawing.Size(136, 20);
            this.plakatxt.TabIndex = 0;
            // 
            // markacombo
            // 
            this.markacombo.FormattingEnabled = true;
            this.markacombo.Items.AddRange(new object[] {
            "BMW",
            "PORCHE",
            "RENAULT"});
            this.markacombo.Location = new System.Drawing.Point(102, 104);
            this.markacombo.Name = "markacombo";
            this.markacombo.Size = new System.Drawing.Size(136, 21);
            this.markacombo.TabIndex = 1;
            this.markacombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sericombo
            // 
            this.sericombo.FormattingEnabled = true;
            this.sericombo.Location = new System.Drawing.Point(102, 149);
            this.sericombo.Name = "sericombo";
            this.sericombo.Size = new System.Drawing.Size(136, 21);
            this.sericombo.TabIndex = 2;
            // 
            // yıltxt
            // 
            this.yıltxt.Location = new System.Drawing.Point(102, 190);
            this.yıltxt.Name = "yıltxt";
            this.yıltxt.Size = new System.Drawing.Size(136, 20);
            this.yıltxt.TabIndex = 3;
            // 
            // ücrettxt
            // 
            this.ücrettxt.Location = new System.Drawing.Point(102, 236);
            this.ücrettxt.Name = "ücrettxt";
            this.ücrettxt.Size = new System.Drawing.Size(136, 20);
            this.ücrettxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PLAKA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelmarka
            // 
            this.labelmarka.AutoSize = true;
            this.labelmarka.ForeColor = System.Drawing.Color.Black;
            this.labelmarka.Location = new System.Drawing.Point(47, 104);
            this.labelmarka.Name = "labelmarka";
            this.labelmarka.Size = new System.Drawing.Size(45, 13);
            this.labelmarka.TabIndex = 6;
            this.labelmarka.Text = "MARKA";
            // 
            // labelseri
            // 
            this.labelseri.AutoSize = true;
            this.labelseri.ForeColor = System.Drawing.Color.Black;
            this.labelseri.Location = new System.Drawing.Point(47, 149);
            this.labelseri.Name = "labelseri";
            this.labelseri.Size = new System.Drawing.Size(32, 13);
            this.labelseri.TabIndex = 7;
            this.labelseri.Text = "SERİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(47, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "YIL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(47, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ÜCRET";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(102, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "KAYIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(102, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "İPTAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // araçkayıtsayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelseri);
            this.Controls.Add(this.labelmarka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ücrettxt);
            this.Controls.Add(this.yıltxt);
            this.Controls.Add(this.sericombo);
            this.Controls.Add(this.markacombo);
            this.Controls.Add(this.plakatxt);
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.Name = "araçkayıtsayfası";
            this.Text = "araçkayıtsayfası";
            this.Load += new System.EventHandler(this.araçkayıtsayfası_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plakatxt;
        private System.Windows.Forms.ComboBox markacombo;
        private System.Windows.Forms.ComboBox sericombo;
        private System.Windows.Forms.TextBox yıltxt;
        private System.Windows.Forms.TextBox ücrettxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelmarka;
        private System.Windows.Forms.Label labelseri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}