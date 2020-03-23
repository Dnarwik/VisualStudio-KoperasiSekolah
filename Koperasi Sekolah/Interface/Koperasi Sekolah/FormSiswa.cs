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
    public partial class FormSiswa : Form
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "koperasi_sekolah";
        private const String UID = "root";
        private const String PASSWORD = "";
        private static MySqlConnection dbConn;
        private String NISiswa = "";
        public FormSiswa()
        {
            InitializeComponent();
        }

        public FormSiswa(Form form1)
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

        private void buttonLoginSis_Click(object sender, EventArgs e)
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
                bool loginSiswa = false;

                dbConn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM user WHERE NIS = '" + textBoxNisSis.Text + "' && password='" + textBoxPassSis.Text + "'", dbConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count <= 0)
                {
                    loginSiswa = false;
                }
                else
                {
                    loginSiswa = true;
                }
                dbConn.Close();

                if (loginSiswa == true)
                {
                    String query = "SELECT * FROM user WHERE NIS = '" + textBoxNisSis.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, dbConn);
                    dbConn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        NISiswa = reader["NIS"].ToString();
                    }
                    loginSiswa = false;
                    panelLoginSiswa.Visible = false;
                }
                else
                {
                    MessageBox.Show("NIS atau Password salah!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Error");
            }
        }

        private void panelLoginSiswa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pesanBajuBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSiswaPemesanan frm = new FormSiswaPemesanan(this);
            frm.NISSiswa(NISiswa);
            frm.Show();
        }
    }
}
