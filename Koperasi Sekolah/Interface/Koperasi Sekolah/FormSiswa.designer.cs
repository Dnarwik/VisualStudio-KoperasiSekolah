namespace RPL
{
    partial class FormSiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSiswa));
            this.panelLoginSiswa = new System.Windows.Forms.Panel();
            this.buttonLoginSis = new System.Windows.Forms.Button();
            this.textBoxPassSis = new System.Windows.Forms.TextBox();
            this.textBoxNisSis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.daftarBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesanBajuBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelLoginSiswa.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLoginSiswa
            // 
            this.panelLoginSiswa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelLoginSiswa.Controls.Add(this.buttonLoginSis);
            this.panelLoginSiswa.Controls.Add(this.textBoxPassSis);
            this.panelLoginSiswa.Controls.Add(this.textBoxNisSis);
            this.panelLoginSiswa.Controls.Add(this.label3);
            this.panelLoginSiswa.Controls.Add(this.label2);
            this.panelLoginSiswa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoginSiswa.Location = new System.Drawing.Point(0, 0);
            this.panelLoginSiswa.Name = "panelLoginSiswa";
            this.panelLoginSiswa.Size = new System.Drawing.Size(768, 363);
            this.panelLoginSiswa.TabIndex = 3;
            this.panelLoginSiswa.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLoginSiswa_Paint);
            // 
            // buttonLoginSis
            // 
            this.buttonLoginSis.Location = new System.Drawing.Point(544, 232);
            this.buttonLoginSis.Name = "buttonLoginSis";
            this.buttonLoginSis.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginSis.TabIndex = 9;
            this.buttonLoginSis.Text = "Login";
            this.buttonLoginSis.UseVisualStyleBackColor = true;
            this.buttonLoginSis.Click += new System.EventHandler(this.buttonLoginSis_Click);
            // 
            // textBoxPassSis
            // 
            this.textBoxPassSis.Location = new System.Drawing.Point(350, 181);
            this.textBoxPassSis.Name = "textBoxPassSis";
            this.textBoxPassSis.PasswordChar = '*';
            this.textBoxPassSis.Size = new System.Drawing.Size(269, 20);
            this.textBoxPassSis.TabIndex = 8;
            // 
            // textBoxNisSis
            // 
            this.textBoxNisSis.Location = new System.Drawing.Point(350, 107);
            this.textBoxNisSis.Name = "textBoxNisSis";
            this.textBoxNisSis.Size = new System.Drawing.Size(269, 20);
            this.textBoxNisSis.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "NIS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 66);
            this.panel1.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(191, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Koperasi SMPN 2 Bangsal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(768, 363);
            this.panel3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 120;
            this.dataGridView1.Size = new System.Drawing.Size(643, 320);
            this.dataGridView1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daftarBarangToolStripMenuItem,
            this.pesanBajuBukuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // daftarBarangToolStripMenuItem
            // 
            this.daftarBarangToolStripMenuItem.Name = "daftarBarangToolStripMenuItem";
            this.daftarBarangToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.daftarBarangToolStripMenuItem.Text = "Daftar Barang";
            // 
            // pesanBajuBukuToolStripMenuItem
            // 
            this.pesanBajuBukuToolStripMenuItem.Name = "pesanBajuBukuToolStripMenuItem";
            this.pesanBajuBukuToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.pesanBajuBukuToolStripMenuItem.Text = "Pemesanan";
            this.pesanBajuBukuToolStripMenuItem.Click += new System.EventHandler(this.pesanBajuBukuToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelLoginSiswa);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(768, 363);
            this.panel4.TabIndex = 5;
            // 
            // FormSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 429);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSiswa";
            this.Text = "Siswa";
            this.panelLoginSiswa.ResumeLayout(false);
            this.panelLoginSiswa.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLoginSiswa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLoginSis;
        private System.Windows.Forms.TextBox textBoxPassSis;
        private System.Windows.Forms.TextBox textBoxNisSis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem daftarBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesanBajuBukuToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}