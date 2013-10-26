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
    public partial class frmCatalogue : Form
    {
        private static frmCatalogue instance;

        private frmCatalogue()
        {
            InitializeComponent();
        }

        public static frmCatalogue getInstance() {
            if (instance == null) {
                instance = new frmCatalogue();
            }
            return instance;
        }

        private void frmCatalogue_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
