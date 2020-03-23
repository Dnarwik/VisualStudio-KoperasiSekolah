namespace RPL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelHalamanAwal = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDaftar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLoginSiswa = new System.Windows.Forms.Button();
            this.buttonLoginPetugas = new System.Windows.Forms.Button();
            this.labelKoperasi = new System.Windows.Forms.Label();
            this.panelBuatAkun = new System.Windows.Forms.Panel();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.textBoxNamaDaftar = new System.Windows.Forms.TextBox();
            this.textBoxPassUlang = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxNisDaftar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBuatAkun = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelHalamanAwal.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelBuatAkun.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 373);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.panelHalamanAwal);
            this.panel5.Controls.Add(this.panelBuatAkun);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(609, 349);
            this.panel5.TabIndex = 4;
            // 
            // panelHalamanAwal
            // 
            this.panelHalamanAwal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelHalamanAwal.Controls.Add(this.panel4);
            this.panelHalamanAwal.Controls.Add(this.pictureBox1);
            this.panelHalamanAwal.Controls.Add(this.panel2);
            this.panelHalamanAwal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHalamanAwal.Location = new System.Drawing.Point(0, 0);
            this.panelHalamanAwal.Name = "panelHalamanAwal";
            this.panelHalamanAwal.Size = new System.Drawing.Size(609, 349);
            this.panelHalamanAwal.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.buttonDaftar);
            this.panel4.Location = new System.Drawing.Point(188, 246);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(348, 100);
            this.panel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Belum punya akun siswa?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonDaftar
            // 
            this.buttonDaftar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDaftar.Location = new System.Drawing.Point(203, 28);
            this.buttonDaftar.Name = "buttonDaftar";
            this.buttonDaftar.Size = new System.Drawing.Size(75, 23);
            this.buttonDaftar.TabIndex = 3;
            this.buttonDaftar.Text = "Daftar";
            this.buttonDaftar.UseVisualStyleBackColor = false;
            this.buttonDaftar.Click += new System.EventHandler(this.buttonDaftar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 144);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.buttonLoginSiswa);
            this.panel2.Controls.Add(this.buttonLoginPetugas);
            this.panel2.Controls.Add(this.labelKoperasi);
            this.panel2.Location = new System.Drawing.Point(211, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 144);
            this.panel2.TabIndex = 2;
            // 
            // buttonLoginSiswa
            // 
            this.buttonLoginSiswa.Location = new System.Drawing.Point(39, 88);
            this.buttonLoginSiswa.Name = "buttonLoginSiswa";
            this.buttonLoginSiswa.Size = new System.Drawing.Size(258, 23);
            this.buttonLoginSiswa.TabIndex = 3;
            this.buttonLoginSiswa.Text = "Masuk sebagai Siswa";
            this.buttonLoginSiswa.UseVisualStyleBackColor = true;
            this.buttonLoginSiswa.Click += new System.EventHandler(this.buttonLoginSiswa_Click);
            // 
            // buttonLoginPetugas
            // 
            this.buttonLoginPetugas.Location = new System.Drawing.Point(39, 59);
            this.buttonLoginPetugas.Name = "buttonLoginPetugas";
            this.buttonLoginPetugas.Size = new System.Drawing.Size(258, 23);
            this.buttonLoginPetugas.TabIndex = 2;
            this.buttonLoginPetugas.Text = "Masuk sebagai Petugas";
            this.buttonLoginPetugas.UseVisualStyleBackColor = true;
            this.buttonLoginPetugas.Click += new System.EventHandler(this.buttonLoginPetugas_Click);
            // 
            // labelKoperasi
            // 
            this.labelKoperasi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKoperasi.AutoSize = true;
            this.labelKoperasi.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKoperasi.Location = new System.Drawing.Point(33, 0);
            this.labelKoperasi.Name = "labelKoperasi";
            this.labelKoperasi.Size = new System.Drawing.Size(264, 33);
            this.labelKoperasi.TabIndex = 1;
            this.labelKoperasi.Text = "Koperasi Sekolah";
            this.labelKoperasi.Click += new System.EventHandler(this.labelKoperasi_Click);
            // 
            // panelBuatAkun
            // 
            this.panelBuatAkun.Controls.Add(this.buttonKembali);
            this.panelBuatAkun.Controls.Add(this.textBoxNamaDaftar);
            this.panelBuatAkun.Controls.Add(this.textBoxPassUlang);
            this.panelBuatAkun.Controls.Add(this.textBoxPass);
            this.panelBuatAkun.Controls.Add(this.textBoxNisDaftar);
            this.panelBuatAkun.Controls.Add(this.label5);
            this.panelBuatAkun.Controls.Add(this.label4);
            this.panelBuatAkun.Controls.Add(this.label3);
            this.panelBuatAkun.Controls.Add(this.label2);
            this.panelBuatAkun.Controls.Add(this.buttonBuatAkun);
            this.panelBuatAkun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBuatAkun.Location = new System.Drawing.Point(0, 0);
            this.panelBuatAkun.Name = "panelBuatAkun";
            this.panelBuatAkun.Size = new System.Drawing.Size(609, 349);
            this.panelBuatAkun.TabIndex = 4;
            // 
            // buttonKembali
            // 
            this.buttonKembali.Location = new System.Drawing.Point(461, 270);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(75, 23);
            this.buttonKembali.TabIndex = 10;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = true;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // textBoxNamaDaftar
            // 
            this.textBoxNamaDaftar.Location = new System.Drawing.Point(250, 86);
            this.textBoxNamaDaftar.Name = "textBoxNamaDaftar";
            this.textBoxNamaDaftar.Size = new System.Drawing.Size(286, 20);
            this.textBoxNamaDaftar.TabIndex = 9;
            // 
            // textBoxPassUlang
            // 
            this.textBoxPassUlang.Location = new System.Drawing.Point(250, 166);
            this.textBoxPassUlang.Name = "textBoxPassUlang";
            this.textBoxPassUlang.PasswordChar = '*';
            this.textBoxPassUlang.Size = new System.Drawing.Size(286, 20);
            this.textBoxPassUlang.TabIndex = 8;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(250, 140);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(286, 20);
            this.textBoxPass.TabIndex = 7;
            // 
            // textBoxNisDaftar
            // 
            this.textBoxNisDaftar.Location = new System.Drawing.Point(250, 112);
            this.textBoxNisDaftar.Name = "textBoxNisDaftar";
            this.textBoxNisDaftar.Size = new System.Drawing.Size(286, 20);
            this.textBoxNisDaftar.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Isi ulang Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // buttonBuatAkun
            // 
            this.buttonBuatAkun.Location = new System.Drawing.Point(461, 217);
            this.buttonBuatAkun.Name = "buttonBuatAkun";
            this.buttonBuatAkun.Size = new System.Drawing.Size(75, 23);
            this.buttonBuatAkun.TabIndex = 0;
            this.buttonBuatAkun.Text = "Buat Akun";
            this.buttonBuatAkun.UseVisualStyleBackColor = true;
            this.buttonBuatAkun.Click += new System.EventHandler(this.buttonBuatAkun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 373);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Koperasi Sekolah";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelHalamanAwal.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelBuatAkun.ResumeLayout(false);
            this.panelBuatAkun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelKoperasi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHalamanAwal;
        private System.Windows.Forms.Button buttonLoginSiswa;
        private System.Windows.Forms.Button buttonLoginPetugas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDaftar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelBuatAkun;
        private System.Windows.Forms.TextBox textBoxPassUlang;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxNisDaftar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBuatAkun;
        private System.Windows.Forms.TextBox textBoxNamaDaftar;
        private System.Windows.Forms.Button buttonKembali;
    }
}

