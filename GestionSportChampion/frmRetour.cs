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
    public partial class frmRetour : Form
    {
        private static frmRetour instance = null;

        private frmRetour()
        {
            InitializeComponent();
        }

        public static frmRetour getInstance()
        {
            if (frmRetour.instance == null)
            {
                frmRetour.instance = new frmRetour();
            }
            return frmRetour.instance;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmRetour_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
