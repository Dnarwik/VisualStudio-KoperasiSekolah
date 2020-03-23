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
    public partial class FormSiswaPemesanan : Form
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "koperasi_sekolah";
        private const String UID = "root";
        private const String PASSWORD = "";
        private static MySqlConnection dbConn;
        private String NISis = "";
        public FormSiswaPemesanan()
        {
            InitializeComponent();
        }

        public FormSiswaPemesanan(FormSiswa frm)
        {
            InitializeComponent();
            Form _form = frm;
            this.Owner = _form;
            loadBuku();
        }

        public void NISSiswa(String NISiswa)
        {
            this.NISis = NISiswa;
        }

        private void buttonBaju_Click(object sender, EventArgs e)
        {
            panelBuku.Visible = false;
            loadBaju();
        }

        private void buttonBuku_Click(object sender, EventArgs e)
        {
            panelBuku.Visible = true;
        }
        ///////////////////////////// Pemesanan Buku ////////////////////////////////////
        private void loadBuku()
        {
            textBoxNisBuku.Text = NISis;
            textBoxNisBaju.Text = NISis;
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
        }

        private void buttonPesanBuku_Click(object sender, EventArgs e)
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
        }

        private void buttonPesanBaju_Click(object sender, EventArgs e)
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

        private void pemesananBajuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelBuku.Visible = false;
            loadBaju();
        }

        private void pemesananBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelBuku.Visible = true;
        }
    }
}
