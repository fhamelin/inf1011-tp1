﻿using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void articlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatalogue frm = frmCatalogue.getInstance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void employésToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void venteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVente frmVente = frmVente.getInstance();
            frmVente.MdiParent = this;
            frmVente.Show();
        }

        private void retourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRetour frmRetour = frmRetour.getInstance();
            frmRetour.MdiParent = this;
            frmRetour.Show();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClients frmClient = frmClients.getInstance();
            frmClient.MdiParent = this;
            frmClient.Show();
        }

        private void employeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmploye frmEmploye = frmEmploye.getInstance();
            frmEmploye.MdiParent = this;
            frmEmploye.Show();
        }

        private void archivageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArchivage frmArchivage = frmArchivage.getInstance();
            frmArchivage.MdiParent = this;
            frmArchivage.Show();
        }
    }
}
