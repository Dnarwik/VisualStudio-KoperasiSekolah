namespace RPL
{
    partial class FormPetugas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPetugas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLoginPetugas = new System.Windows.Forms.Panel();
            this.buttonLoginPet = new System.Windows.Forms.Button();
            this.textBoxPassPet = new System.Windows.Forms.TextBox();
            this.textBoxNikPet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPetugas = new System.Windows.Forms.Panel();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonPerbarui = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.daftarBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pemesananBajuBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxGambar = new System.Windows.Forms.PictureBox();
            this.textBoxImagePath = new System.Windows.Forms.TextBox();
            this.buttonBukaGambar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLoginPetugas.SuspendLayout();
            this.panelPetugas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGambar)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 66);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(59, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 66);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Koperasi SMPN 2 Bangsal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelLoginPetugas
            // 
            this.panelLoginPetugas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelLoginPetugas.Controls.Add(this.buttonLoginPet);
            this.panelLoginPetugas.Controls.Add(this.textBoxPassPet);
            this.panelLoginPetugas.Controls.Add(this.textBoxNikPet);
            this.panelLoginPetugas.Controls.Add(this.label3);
            this.panelLoginPetugas.Controls.Add(this.label2);
            this.panelLoginPetugas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoginPetugas.Location = new System.Drawing.Point(0, 0);
            this.panelLoginPetugas.Name = "panelLoginPetugas";
            this.panelLoginPetugas.Size = new System.Drawing.Size(764, 474);
            this.panelLoginPetugas.TabIndex = 1;
            this.panelLoginPetugas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLoginPetugas_Paint);
            // 
            // buttonLoginPet
            // 
            this.buttonLoginPet.Location = new System.Drawing.Point(563, 233);
            this.buttonLoginPet.Name = "buttonLoginPet";
            this.buttonLoginPet.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginPet.TabIndex = 4;
            this.buttonLoginPet.Text = "Login";
            this.buttonLoginPet.UseVisualStyleBackColor = true;
            this.buttonLoginPet.Click += new System.EventHandler(this.buttonLoginPet_Click);
            // 
            // textBoxPassPet
            // 
            this.textBoxPassPet.Location = new System.Drawing.Point(369, 182);
            this.textBoxPassPet.Name = "textBoxPassPet";
            this.textBoxPassPet.PasswordChar = '*';
            this.textBoxPassPet.Size = new System.Drawing.Size(269, 20);
            this.textBoxPassPet.TabIndex = 3;
            // 
            // textBoxNikPet
            // 
            this.textBoxNikPet.Location = new System.Drawing.Point(369, 108);
            this.textBoxNikPet.Name = "textBoxNikPet";
            this.textBoxNikPet.Size = new System.Drawing.Size(269, 20);
            this.textBoxNikPet.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "NIP";
            // 
            // panelPetugas
            // 
            this.panelPetugas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelPetugas.Controls.Add(this.buttonHapus);
            this.panelPetugas.Controls.Add(this.buttonPerbarui);
            this.panelPetugas.Controls.Add(this.buttonTambah);
            this.panelPetugas.Controls.Add(this.textBoxJumlah);
            this.panelPetugas.Controls.Add(this.textBoxHarga);
            this.panelPetugas.Controls.Add(this.label6);
            this.panelPetugas.Controls.Add(this.label5);
            this.panelPetugas.Controls.Add(this.label4);
            this.panelPetugas.Controls.Add(this.textBoxNama);
            this.panelPetugas.Controls.Add(this.dataGridView1);
            this.panelPetugas.Controls.Add(this.menuStrip1);
            this.panelPetugas.Controls.Add(this.textBoxId);
            this.panelPetugas.Controls.Add(this.label7);
            this.panelPetugas.Controls.Add(this.pictureBoxGambar);
            this.panelPetugas.Controls.Add(this.textBoxImagePath);
            this.panelPetugas.Controls.Add(this.buttonBukaGambar);
            this.panelPetugas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPetugas.Location = new System.Drawing.Point(0, 0);
            this.panelPetugas.Name = "panelPetugas";
            this.panelPetugas.Size = new System.Drawing.Size(764, 474);
            this.panelPetugas.TabIndex = 2;
            // 
            // buttonHapus
            // 
            this.buttonHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHapus.Location = new System.Drawing.Point(594, 441);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(108, 23);
            this.buttonHapus.TabIndex = 10;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonPerbarui
            // 
            this.buttonPerbarui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPerbarui.Location = new System.Drawing.Point(594, 412);
            this.buttonPerbarui.Name = "buttonPerbarui";
            this.buttonPerbarui.Size = new System.Drawing.Size(108, 23);
            this.buttonPerbarui.TabIndex = 9;
            this.buttonPerbarui.Text = "Perbarui";
            this.buttonPerbarui.UseVisualStyleBackColor = true;
            this.buttonPerbarui.Click += new System.EventHandler(this.buttonPerbarui_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTambah.Location = new System.Drawing.Point(594, 383);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(108, 23);
            this.buttonTambah.TabIndex = 8;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxJumlah.Location = new System.Drawing.Point(111, 414);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(157, 20);
            this.textBoxJumlah.TabIndex = 7;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxHarga.Location = new System.Drawing.Point(111, 380);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(157, 20);
            this.textBoxHarga.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Jumlah";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nama";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxNama.Location = new System.Drawing.Point(111, 346);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(157, 20);
            this.textBoxNama.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 120;
            this.dataGridView1.Size = new System.Drawing.Size(643, 313);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daftarBarangToolStripMenuItem,
            this.pemesananBajuBukuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // daftarBarangToolStripMenuItem
            // 
            this.daftarBarangToolStripMenuItem.Name = "daftarBarangToolStripMenuItem";
            this.daftarBarangToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.daftarBarangToolStripMenuItem.Text = "Daftar Barang";
            this.daftarBarangToolStripMenuItem.Click += new System.EventHandler(this.daftarBarangToolStripMenuItem_Click);
            // 
            // pemesananBajuBukuToolStripMenuItem
            // 
            this.pemesananBajuBukuToolStripMenuItem.Name = "pemesananBajuBukuToolStripMenuItem";
            this.pemesananBajuBukuToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.pemesananBajuBukuToolStripMenuItem.Text = "Pemesanan";
            this.pemesananBajuBukuToolStripMenuItem.Click += new System.EventHandler(this.pemesananBajuBukuToolStripMenuItem_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxId.Location = new System.Drawing.Point(111, 448);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(157, 20);
            this.textBoxId.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Id";
            // 
            // pictureBoxGambar
            // 
            this.pictureBoxGambar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGambar.Location = new System.Drawing.Point(430, 375);
            this.pictureBoxGambar.Name = "pictureBoxGambar";
            this.pictureBoxGambar.Size = new System.Drawing.Size(110, 93);
            this.pictureBoxGambar.TabIndex = 16;
            this.pictureBoxGambar.TabStop = false;
            // 
            // textBoxImagePath
            // 
            this.textBoxImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImagePath.Location = new System.Drawing.Point(430, 352);
            this.textBoxImagePath.Name = "textBoxImagePath";
            this.textBoxImagePath.ReadOnly = true;
            this.textBoxImagePath.Size = new System.Drawing.Size(162, 20);
            this.textBoxImagePath.TabIndex = 15;
            // 
            // buttonBukaGambar
            // 
            this.buttonBukaGambar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBukaGambar.Location = new System.Drawing.Point(321, 350);
            this.buttonBukaGambar.Name = "buttonBukaGambar";
            this.buttonBukaGambar.Size = new System.Drawing.Size(88, 23);
            this.buttonBukaGambar.TabIndex = 14;
            this.buttonBukaGambar.Text = "Buka Gambar";
            this.buttonBukaGambar.UseVisualStyleBackColor = true;
            this.buttonBukaGambar.Click += new System.EventHandler(this.buttonBukaGambar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelLoginPetugas);
            this.panel3.Controls.Add(this.panelPetugas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 474);
            this.panel3.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormPetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 540);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPetugas";
            this.Text = "Petugas";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLoginPetugas.ResumeLayout(false);
            this.panelLoginPetugas.PerformLayout();
            this.panelPetugas.ResumeLayout(false);
            this.panelPetugas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGambar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLoginPetugas;
        private System.Windows.Forms.Button buttonLoginPet;
        private System.Windows.Forms.TextBox textBoxPassPet;
        private System.Windows.Forms.TextBox textBoxNikPet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPetugas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem daftarBarangToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem pemesananBajuBukuToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonPerbarui;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxGambar;
        private System.Windows.Forms.TextBox textBoxImagePath;
        private System.Windows.Forms.Button buttonBukaGambar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}