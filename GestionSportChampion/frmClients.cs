
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSportChampion
{
    public partial class frmClients : Form
    {
        private static frmClients instance = null;

        private frmClients()
        {
            InitializeComponent();
        }

        public static frmClients getInstance()
        {
            if (frmClients.instance == null)
            {
                frmClients.instance = new frmClients();
            }
            return frmClients.instance;
        }

        private void frmClients_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
