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
    public partial class frmEmploye : Form
    {
        private static frmEmploye instance = null;

        private frmEmploye()
        {
            InitializeComponent();
        }

        public static frmEmploye getInstance()
        {
            if (frmEmploye.instance == null)
            {
                frmEmploye.instance = new frmEmploye();
            }
            return frmEmploye.instance;
        }

        private void frmEmploye_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
