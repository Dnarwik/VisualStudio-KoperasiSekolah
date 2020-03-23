using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace RPL
{
    public partial class FormPetugas : Form
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "koperasi_sekolah";
        private const String UID = "root";
        private const String PASSWORD = "";
        private static MySqlConnection dbConn;
        public FormPetugas()
        {
            InitializeComponent();
        }

        public FormPetugas(Form form1)
        {
            InitializeComponent();
            Form _form1 = form1;
            this.Owner = _form1;
            loadBarang();
        }

        private void loadBarang()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;

            String connString = builder.ToString();

            dbConn = new MySqlConnection(connString);
            String query = "SELECT * FROM daftar_barang";
            DataTable dt = new DataTable();

            MySqlDataAdapter da;
            da = new MySqlDataAdapter(query, dbConn);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[4];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLoginPet_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;

            MySqlDataAdapter adapter;
            DataTable table = new DataTable();

            String connString = builder.ToString();

            dbConn = new MySqlConnection(connString);

            try
            {
                bool loginPetugas = false;

                dbConn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM user WHERE NIP = '" + textBoxNikPet.Text + "' && password='" + textBoxPassPet.Text + "'", dbConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count <= 0)
                {
                    loginPetugas = false;
                }
                else
                {
                    loginPetugas = true;
                }
                dbConn.Close();

                if (loginPetugas == true)
                {
                    loginPetugas = false;
                    panelLoginPetugas.Visible = false;
                }
                else
                {
                    MessageBox.Show("NIP atau Password salah!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBoxNama.Text = row.Cells["Nama"].Value.ToString();
                textBoxHarga.Text = row.Cells["Harga"].Value.ToString();
                textBoxJumlah.Text = row.Cells["Jumlah"].Value.ToString();
                textBoxId.Text = row.Cells["Id"].Value.ToString();
                textBoxImagePath.Text ="";
                pictureBoxGambar.Image = null;
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FileStream fs;
            BinaryReader br;
            if (textBoxNama.Text != "" && textBoxJumlah.Text != "" && textBoxHarga.Text != "" && textBoxImagePath.Text != "")
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = SERVER;
                builder.Database = DATABASE;
                builder.UserID = UID;
                builder.Password = PASSWORD;

                String connString = builder.ToString();

                dbConn = new MySqlConnection(connString);

                string FileName = textBoxImagePath.Text;
                byte[] ImageData;
                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                ImageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();

                String query = "INSERT INTO daftar_barang(Nama,Harga,Jumlah,Gambar) VALUES(@Nama, @Harga, @Jumlah, @Gambar)";
                MySqlCommand cmd = new MySqlCommand(query, dbConn);
                cmd.Parameters.Add("@Nama", MySqlDbType.VarChar, 50);
                cmd.Parameters.Add("@Harga", MySqlDbType.VarChar, 25);
                cmd.Parameters.Add("@Jumlah", MySqlDbType.VarChar, 10);
                cmd.Parameters.Add("@Gambar", MySqlDbType.Blob);
                cmd.Parameters["@Nama"].Value = textBoxNama.Text;
                cmd.Parameters["@Harga"].Value = textBoxHarga.Text;
                cmd.Parameters["@Jumlah"].Value = textBoxJumlah.Text;
                cmd.Parameters["@Gambar"].Value = ImageData;
                dbConn.Open();
                cmd.ExecuteNonQuery();
                dbConn.Close();
                MessageBox.Show("Data berhasil ditambah");
                loadBarang();
            }
            else
            {
                MessageBox.Show("Data tidak boleh kosong");
            }
        }

        private void buttonPerbarui_Click(object sender, EventArgs e)
        {
            if (textBoxImagePath.Text != "")
            {
                if (textBoxNama.Text != "" && textBoxJumlah.Text != "" && textBoxHarga.Text != "")
                {
                    FileStream fs;
                    BinaryReader br;

                    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                    builder.Server = SERVER;
                    builder.Database = DATABASE;
                    builder.UserID = UID;
                    builder.Password = PASSWORD;

                    String connString = builder.ToString();

                    dbConn = new MySqlConnection(connString);

                    string FileName = textBoxImagePath.Text;
                    byte[] ImageData;
                    fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                    br = new BinaryReader(fs);
                    ImageData = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();

                    MySqlCommand cmd;
                    cmd = new MySqlCommand("UPDATE daftar_barang SET Nama=@Nama,Harga=@Harga,Jumlah=@Jumlah,Gambar=@Gambar WHERE Id=@Id", dbConn);
                    dbConn.Open();
                    cmd.Parameters.Add("@Gambar", MySqlDbType.Blob);
                    cmd.Parameters.AddWithValue("@Id", textBoxId.Text);
                    cmd.Parameters.AddWithValue("@Nama", textBoxNama.Text);
                    cmd.Parameters.AddWithValue("@Harga", textBoxHarga.Text);
                    cmd.Parameters.AddWithValue("@Jumlah", textBoxJumlah.Text);
                    cmd.Parameters["@Gambar"].Value = ImageData;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil diupdate");
                    dbConn.Close();
                    loadBarang();
                }
                else
                {
                    MessageBox.Show("Data tidak boleh kosong");
                }
            }
            else
            {
                if (textBoxNama.Text != "" && textBoxJumlah.Text != "" && textBoxHarga.Text != "")
                {
                    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                    builder.Server = SERVER;
                    builder.Database = DATABASE;
                    builder.UserID = UID;
                    builder.Password = PASSWORD;

                    String connString = builder.ToString();

                    dbConn = new MySqlConnection(connString);

                    MySqlCommand cmd;
                    cmd = new MySqlCommand("UPDATE daftar_barang SET Nama=@Nama,Harga=@Harga,Jumlah=@Jumlah WHERE Id=@Id", dbConn);
                    dbConn.Open();
                    cmd.Parameters.AddWithValue("@Id", textBoxId.Text);
                    cmd.Parameters.AddWithValue("@Nama", textBoxNama.Text);
                    cmd.Parameters.AddWithValue("@Harga", textBoxHarga.Text);
                    cmd.Parameters.AddWithValue("@Jumlah", textBoxJumlah.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil diupdate");
                    dbConn.Close();
                    loadBarang();
                }
                else
                {
                    MessageBox.Show("Data tidak boleh kosong");
                }
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = SERVER;
                builder.Database = DATABASE;
                builder.UserID = UID;
                builder.Password = PASSWORD;

                String connString = builder.ToString();

                dbConn = new MySqlConnection(connString);

                FormPeringatan frmP = new FormPeringatan(this);
                frmP.isiLabel("Apakah anda yakin?");
                DialogResult result = frmP.ShowDialog();
                if (result == DialogResult.OK)
                {
                    String query = string.Format("DELETE  from daftar_barang where Id IN ('"+textBoxId.Text+"')");

                    MySqlCommand cmd = new MySqlCommand(query, dbConn);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                    dbConn.Close();
                    MessageBox.Show("Anda berhasil menghapus");
                    loadBarang();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("hapus dibatalkan");
                }

            }
            else
            {
                MessageBox.Show("Data tidak boleh kosong");
            }
        }

        private void buttonBuatAkun_Click(object sender, EventArgs e)
        {
            
        }

        private void daftarBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void buatAkunPetugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pemesananBajuBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPetugasPemesanan frm = new FormPetugasPemesanan(this);
            frm.Show();
        }

        private void buttonBukaGambar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open File";
            openFileDialog1.Filter = "JPG|*jpg|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxGambar.Image = Image.FromFile(openFileDialog1.FileName);
                textBoxImagePath.Text = openFileDialog1.FileName;
                pictureBoxGambar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void panelLoginPetugas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
