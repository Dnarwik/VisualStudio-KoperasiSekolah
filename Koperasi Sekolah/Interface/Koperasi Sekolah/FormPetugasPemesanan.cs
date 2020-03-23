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

namespace RPL
{
    public partial class FormPetugasPemesanan : Form
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "koperasi_sekolah";
        private const String UID = "root";
        private const String PASSWORD = "";
        private static MySqlConnection dbConn;
        public FormPetugasPemesanan()
        {
            InitializeComponent();
        }

        public FormPetugasPemesanan(FormPetugas frm)
        {
            InitializeComponent();
            Form _form = frm;
            this.Owner = _form;
            loadBuku();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        ///////////////////////////// Pemesanan Buku ////////////////////////////////////
        private void loadBuku()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;

            String connString = builder.ToString();

            dbConn = new MySqlConnection(connString);
            String query = "SELECT * FROM pesan_buku";
            DataTable dt = new DataTable();

            MySqlDataAdapter da;
            da = new MySqlDataAdapter(query, dbConn);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBoxNisBuku.Text = row.Cells["NIS"].Value.ToString();
                textBoxMapel.Text = row.Cells["Mata_Pelajaran"].Value.ToString();
                textBoxKelas.Text = row.Cells["Kelas"].Value.ToString();
                textBoxIdBuku.Text = row.Cells["Id"].Value.ToString();
                textBoxPenerbit.Text = row.Cells["Penerbit"].Value.ToString();
            }
        }

        private void buttonPesanBaju_Click(object sender, EventArgs e)
        {
            panelBuku.Visible = false;
            loadBaju();
        }

        private void buttonPesanBuku_Click(object sender, EventArgs e)
        {
            panelBuku.Visible = true;
        }

        private void buttonTambahBuku_Click(object sender, EventArgs e)
        {
            if (textBoxNisBuku.Text != "" && textBoxMapel.Text != "" && textBoxKelas.Text != "" && textBoxPenerbit.Text != "")
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = SERVER;
                builder.Database = DATABASE;
                builder.UserID = UID;
                builder.Password = PASSWORD;

                String connString = builder.ToString();

                dbConn = new MySqlConnection(connString);

                String query = string.Format("INSERT INTO pesan_buku(NIS,Mata_Pelajaran,Kelas,Penerbit) VALUES ('{0}','{1}','{2}','{3}')", textBoxNisBuku.Text, textBoxMapel.Text, textBoxKelas.Text, textBoxPenerbit.Text);
                MySqlCommand cmd = new MySqlCommand(query, dbConn);
                dbConn.Open();
                cmd.ExecuteNonQuery();
                dbConn.Close();
                MessageBox.Show("Data berhasil ditambah");
                loadBuku();
            }
            else
            {
                MessageBox.Show("Data tidak boleh kosong");
            }
        }

        private void buttonPerbaruiBuku_Click(object sender, EventArgs e)
        {
            if (textBoxNisBuku.Text != "" && textBoxMapel.Text != "" && textBoxKelas.Text != "" && textBoxPenerbit.Text != "")
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = SERVER;
                builder.Database = DATABASE;
                builder.UserID = UID;
                builder.Password = PASSWORD;

                String connString = builder.ToString();

                dbConn = new MySqlConnection(connString);

                MySqlCommand cmd;
                cmd = new MySqlCommand("UPDATE pesan_buku SET NIS=@NIS,Mata_Pelajaran=@Mata_Pelajaran,Kelas=@Kelas,Penerbit=@Penerbit WHERE Id=@Id", dbConn);
                dbConn.Open();
                cmd.Parameters.AddWithValue("@Id", textBoxIdBuku.Text);
                cmd.Parameters.AddWithValue("@NIS", textBoxNisBuku.Text);
                cmd.Parameters.AddWithValue("@Mata_Pelajaran", textBoxMapel.Text);
                cmd.Parameters.AddWithValue("@Kelas", textBoxKelas.Text);
                cmd.Parameters.AddWithValue("@Penerbit", textBoxPenerbit.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate");
                dbConn.Close();
                loadBuku();
            }
            else
            {
                MessageBox.Show("Data tidak boleh kosong");
            }
        }

        private void buttonHapusBuku_Click(object sender, EventArgs e)
        {
            if (textBoxIdBuku.Text != "")
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
                    String query = string.Format("DELETE  from pesan_buku where Id IN ('" + textBoxIdBuku.Text + "')");

                    MySqlCommand cmd = new MySqlCommand(query, dbConn);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                    dbConn.Close();
                    MessageBox.Show("Anda berhasil menghapus");
                    loadBuku();
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

        ///////////////////////////// Pemesanan Baju ////////////////////////////////////
        private void loadBaju()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;

            String connString = builder.ToString();

            dbConn = new MySqlConnection(connString);
            String query = "SELECT * FROM pesan_baju";
            DataTable dt = new DataTable();

            MySqlDataAdapter da;
            da = new MySqlDataAdapter(query, dbConn);
            da.Fill(dt);

            dataGridView2.DataSource = dt;
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                textBoxNisBaju.Text = row.Cells["NIS"].Value.ToString();
                textBoxJenisKelamin.Text = row.Cells["Jenis_Kelamin"].Value.ToString();
                textBoxJenisBaju.Text = row.Cells["Jenis_Baju"].Value.ToString();
                textBoxUkuran.Text = row.Cells["Ukuran"].Value.ToString();
                textBoxIdBaju.Text = row.Cells["Id"].Value.ToString();
            }
        }

        private void buttonTambahBaju_Click(object sender, EventArgs e)
        {
            if (textBoxNisBaju.Text != "" && textBoxJenisBaju.Text != "" && textBoxJenisKelamin.Text != "" && textBoxUkuran.Text != "")
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = SERVER;
                builder.Database = DATABASE;
                builder.UserID = UID;
                builder.Password = PASSWORD;

                String connString = builder.ToString();

                dbConn = new MySqlConnection(connString);

                String query = string.Format("INSERT INTO pesan_baju(NIS,Jenis_Baju,Jenis_Kelamin,Ukuran) VALUES ('{0}','{1}','{2}','{3}')", textBoxNisBaju.Text, textBoxJenisBaju.Text, textBoxJenisKelamin.Text, textBoxUkuran.Text);
                MySqlCommand cmd = new MySqlCommand(query, dbConn);
                dbConn.Open();
                cmd.ExecuteNonQuery();
                dbConn.Close();
                MessageBox.Show("Data berhasil ditambah");
                loadBaju();
            }
            else
            {
                MessageBox.Show("Data tidak boleh kosong");
            }
        }

        private void buttonPerbaruiBaju_Click(object sender, EventArgs e)
        {
            if (textBoxNisBaju.Text != "" && textBoxJenisBaju.Text != "" && textBoxJenisKelamin.Text != "" && textBoxUkuran.Text != "")
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = SERVER;
                builder.Database = DATABASE;
                builder.UserID = UID;
                builder.Password = PASSWORD;

                String connString = builder.ToString();

                dbConn = new MySqlConnection(connString);

                MySqlCommand cmd;
                cmd = new MySqlCommand("UPDATE pesan_baju SET NIS=@NIS,Jenis_Baju=@Jenis_Baju,Jenis_Kelamin=@Jenis_Kelamin,Ukuran=@Ukuran WHERE Id=@Id", dbConn);
                dbConn.Open();
                cmd.Parameters.AddWithValue("@Id", textBoxIdBaju.Text);
                cmd.Parameters.AddWithValue("@NIS", textBoxNisBaju.Text);
                cmd.Parameters.AddWithValue("@Jenis_Baju", textBoxJenisBaju.Text);
                cmd.Parameters.AddWithValue("@Jenis_Kelamin", textBoxJenisKelamin.Text);
                cmd.Parameters.AddWithValue("@Ukuran", textBoxUkuran.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate");
                dbConn.Close();
                loadBaju();
            }
            else
            {
                MessageBox.Show("Data tidak boleh kosong");
            }
        }

        private void buttonHapusBaju_Click(object sender, EventArgs e)
        {
            if (textBoxIdBaju.Text != "")
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
                    String query = string.Format("DELETE  from pesan_baju where Id IN ('" + textBoxIdBaju.Text + "')");

                    MySqlCommand cmd = new MySqlCommand(query, dbConn);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                    dbConn.Close();
                    MessageBox.Show("Anda berhasil menghapus");
                    loadBaju();
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

        private void panelBuku_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pemesananBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelBuku.Visible = true;
        }

        private void pemesananBajuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelBuku.Visible = false;
            loadBaju();
        }
    }
}
