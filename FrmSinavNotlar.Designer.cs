namespace Okul
{
    partial class FrmSinavNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinavNotlar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSinav1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSinav2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSinav3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProje = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 236);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 187);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(97, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(175, 29);
            this.txtId.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "ID :";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(639, 18);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(115, 43);
            this.btnHesapla.TabIndex = 42;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(580, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "Ders :";
            // 
            // txtSinav1
            // 
            this.txtSinav1.Location = new System.Drawing.Point(97, 86);
            this.txtSinav1.Name = "txtSinav1";
            this.txtSinav1.Size = new System.Drawing.Size(175, 29);
            this.txtSinav1.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 47;
            this.label3.Text = "Sınav 1 :";
            // 
            // txtSinav2
            // 
            this.txtSinav2.Location = new System.Drawing.Point(97, 120);
            this.txtSinav2.Name = "txtSinav2";
            this.txtSinav2.Size = new System.Drawing.Size(175, 29);
            this.txtSinav2.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 49;
            this.label4.Text = "Sınav 2 :";
            // 
            // txtSinav3
            // 
            this.txtSinav3.Location = new System.Drawing.Point(97, 153);
            this.txtSinav3.Name = "txtSinav3";
            this.txtSinav3.Size = new System.Drawing.Size(175, 29);
            this.txtSinav3.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 51;
            this.label5.Text = "Sınav 3 :";
            // 
            // txtProje
            // 
            this.txtProje.Location = new System.Drawing.Point(375, 18);
            this.txtProje.Name = "txtProje";
            this.txtProje.Size = new System.Drawing.Size(175, 29);
            this.txtProje.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 53;
            this.label6.Text = "Proje :";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(375, 55);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(175, 29);
            this.txtOrtalama.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 55;
            this.label7.Text = "Ortalama :";
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(375, 89);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(175, 29);
            this.txtDurum.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 21);
            this.label8.TabIndex = 57;
            this.label8.Text = "Durum :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(639, 67);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(115, 43);
            this.btnGuncelle.TabIndex = 58;
            this.btnGuncelle.Text = "GUNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(580, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(639, 112);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(115, 43);
            this.btnTemizle.TabIndex = 60;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(580, 113);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 61;
            this.pictureBox3.TabStop = false;
            // 
            // cmbDers
            // 
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(97, 54);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(175, 29);
            this.cmbDers.TabIndex = 62;
            // 
            // FrmSinavNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 434);
            this.Controls.Add(this.cmbDers);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProje);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSinav3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSinav2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSinav1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmSinavNotlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinav Notları Paneli";
            this.Load += new System.EventHandler(this.FrmSinavNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSinav1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSinav2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSinav3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cmbDers;
    }
}