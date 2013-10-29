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
    public partial class frmArchivage : Form
    {
        private static frmArchivage instance = null;

        private frmArchivage()
        {
            InitializeComponent();
        }

        public static frmArchivage getInstance()
        {
            if (frmArchivage.instance == null)
            {
                frmArchivage.instance = new frmArchivage();
            }
            return frmArchivage.instance;
        }

        private void frmArchivage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void frmArchivage_Load(object sender, EventArgs e)
        {

        }
    }
}
