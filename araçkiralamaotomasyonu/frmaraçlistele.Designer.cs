
namespace araçkiralamaotomasyonu
{
    partial class frmaraçlistele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboaraçlar = new System.Windows.Forms.ComboBox();
            this.btniptal = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelseri = new System.Windows.Forms.Label();
            this.labelmarka = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ücrettxt = new System.Windows.Forms.TextBox();
            this.yıltxt = new System.Windows.Forms.TextBox();
            this.sericombo = new System.Windows.Forms.ComboBox();
            this.markacombo = new System.Windows.Forms.ComboBox();
            this.plakatxt = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboaraçlar
            // 
            this.comboaraçlar.FormattingEnabled = true;
            this.comboaraçlar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boş Araçlar",
            "Dolu Araçlar"});
            this.comboaraçlar.Location = new System.Drawing.Point(640, 38);
            this.comboaraçlar.Name = "comboaraçlar";
            this.comboaraçlar.Size = new System.Drawing.Size(121, 21);
            this.comboaraçlar.TabIndex = 1;
            this.comboaraçlar.SelectedIndexChanged += new System.EventHandler(this.comboaraçlar_SelectedIndexChanged);
            // 
            // btniptal
            // 
            this.btniptal.ForeColor = System.Drawing.Color.Black;
            this.btniptal.Location = new System.Drawing.Point(81, 340);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(75, 23);
            this.btniptal.TabIndex = 25;
            this.btniptal.Text = "İPTAL";
            this.btniptal.UseVisualStyleBackColor = true;
            // 
            // btngüncelle
            // 
            this.btngüncelle.ForeColor = System.Drawing.Color.Black;
            this.btngüncelle.Location = new System.Drawing.Point(81, 302);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(75, 23);
            this.btngüncelle.TabIndex = 24;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "ÜCRET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "YIL";
            // 
            // labelseri
            // 
            this.labelseri.AutoSize = true;
            this.labelseri.ForeColor = System.Drawing.Color.Black;
            this.labelseri.Location = new System.Drawing.Point(26, 174);
            this.labelseri.Name = "labelseri";
            this.labelseri.Size = new System.Drawing.Size(32, 13);
            this.labelseri.TabIndex = 20;
            this.labelseri.Text = "SERİ";
            // 
            // labelmarka
            // 
            this.labelmarka.AutoSize = true;
            this.labelmarka.ForeColor = System.Drawing.Color.Black;
            this.labelmarka.Location = new System.Drawing.Point(26, 129);
            this.labelmarka.Name = "labelmarka";
            this.labelmarka.Size = new System.Drawing.Size(45, 13);
            this.labelmarka.TabIndex = 19;
            this.labelmarka.Text = "MARKA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "PLAKA";
            // 
            // ücrettxt
            // 
            this.ücrettxt.Location = new System.Drawing.Point(81, 261);
            this.ücrettxt.Name = "ücrettxt";
            this.ücrettxt.Size = new System.Drawing.Size(136, 20);
            this.ücrettxt.TabIndex = 17;
            // 
            // yıltxt
            // 
            this.yıltxt.Location = new System.Drawing.Point(81, 215);
            this.yıltxt.Name = "yıltxt";
            this.yıltxt.Size = new System.Drawing.Size(136, 20);
            this.yıltxt.TabIndex = 16;
            // 
            // sericombo
            // 
            this.sericombo.FormattingEnabled = true;
            this.sericombo.Location = new System.Drawing.Point(81, 174);
            this.sericombo.Name = "sericombo";
            this.sericombo.Size = new System.Drawing.Size(136, 21);
            this.sericombo.TabIndex = 15;
            // 
            // markacombo
            // 
            this.markacombo.FormattingEnabled = true;
            this.markacombo.Items.AddRange(new object[] {
            "BMW",
            "PORCHE",
            "RENAULT"});
            this.markacombo.Location = new System.Drawing.Point(81, 129);
            this.markacombo.Name = "markacombo";
            this.markacombo.Size = new System.Drawing.Size(136, 21);
            this.markacombo.TabIndex = 14;
            this.markacombo.SelectedIndexChanged += new System.EventHandler(this.markacombo_SelectedIndexChanged);
            // 
            // plakatxt
            // 
            this.plakatxt.Location = new System.Drawing.Point(81, 92);
            this.plakatxt.Name = "plakatxt";
            this.plakatxt.Size = new System.Drawing.Size(136, 20);
            this.plakatxt.TabIndex = 13;
            // 
            // btnsil
            // 
            this.btnsil.ForeColor = System.Drawing.Color.Black;
            this.btnsil.Location = new System.Drawing.Point(81, 379);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 25;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmaraçlistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btngüncelle);
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
            this.Controls.Add(this.comboaraçlar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmaraçlistele";
            this.Text = "Araç Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmaraçlistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboaraçlar;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelseri;
        private System.Windows.Forms.Label labelmarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ücrettxt;
        private System.Windows.Forms.TextBox yıltxt;
        private System.Windows.Forms.ComboBox sericombo;
        private System.Windows.Forms.ComboBox markacombo;
        private System.Windows.Forms.TextBox plakatxt;
        private System.Windows.Forms.Button btnsil;
    }
}