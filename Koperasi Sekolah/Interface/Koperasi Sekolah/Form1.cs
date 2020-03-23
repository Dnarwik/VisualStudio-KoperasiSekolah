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
    public partial class Form1 : Form
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "koperasi_sekolah";
        private const String UID = "root";
        private const String PASSWORD = "";
        private static MySqlConnection dbConn;
        public Form1()
        {
            InitializeComponent();
        }

        private void labelKoperasi_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoginPetugas_Click(object sender, EventArgs e)
        {
            FormPetugas frm = new FormPetugas(this);
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            panelHalamanAwal.Visible = false;
        }

        private void buttonBuatAkun_Click(object sender, EventArgs e)
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

            if (textBoxNamaDaftar.Text == "" || textBoxNisDaftar.Text == "" || textBoxPass.Text == "" || textBoxPassUlang.Text == "")
            {
                MessageBox.Show("Data harus diisi!");
            }
            else if (textBoxPass.Text != textBoxPassUlang.Text)
            {
                MessageBox.Show("Password dan Konfirmasi Password harus sama!");
            }
            else
            {
                String query = string.Format("INSERT INTO user (nama,NIS,password) VALUES ('{0}','{1}','{2}')", textBoxNamaDaftar.Text, textBoxNisDaftar.Text, textBoxPass.Text);
                MySqlCommand cmd = new MySqlCommand(query, dbConn);
                dbConn.Open();
                cmd.ExecuteNonQuery();
                dbConn.Close();
                MessageBox.Show("Data berhasil disimpan");
            }
        }

        private void buttonLoginSiswa_Click(object sender, EventArgs e)
        {
            FormSiswa frm = new FormSiswa(this);
            frm.Show();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            panelHalamanAwal.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
