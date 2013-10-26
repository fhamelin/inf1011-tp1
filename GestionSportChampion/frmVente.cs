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
    public partial class frmVente : Form
    {
        private static frmVente instance = null;

        private frmVente()
        {
            InitializeComponent();
        }

        public static frmVente getInstance() {
            if (frmVente.instance == null) {
                frmVente.instance = new frmVente();
            }
            return frmVente.instance;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                Hide();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
