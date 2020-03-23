using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPL
{
    public partial class FormPeringatan : Form
    {
        public FormPeringatan()
        {
            InitializeComponent();
        }
        public FormPeringatan(FormPetugas frmP)
        {
            InitializeComponent();
            Form _formmP = frmP;
            this.Owner = _formmP;
        }
        public FormPeringatan(FormPetugasPemesanan frmP)
        {
            InitializeComponent();
            Form _formmP = frmP;
            this.Owner = _formmP;
        }
        public void isiLabel(String lbl)
        {
            label1.Text = lbl;
        }
        private void buttonYa_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void buttonTidak_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }
    }
}
