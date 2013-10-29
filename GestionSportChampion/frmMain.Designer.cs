namespace GestionSportChampion
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.venteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employésToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.venteToolStripMenuItem,
            this.retourToolStripMenuItem,
            this.articlesToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // venteToolStripMenuItem
            // 
            this.venteToolStripMenuItem.Name = "venteToolStripMenuItem";
            this.venteToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.venteToolStripMenuItem.Text = "Vente";
            this.venteToolStripMenuItem.Click += new System.EventHandler(this.venteToolStripMenuItem_Click);
            // 
            // retourToolStripMenuItem
            // 
            this.retourToolStripMenuItem.Name = "retourToolStripMenuItem";
            this.retourToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.retourToolStripMenuItem.Text = "Retour";
            this.retourToolStripMenuItem.Click += new System.EventHandler(this.retourToolStripMenuItem_Click);
            // 
            // articlesToolStripMenuItem
            // 
            this.articlesToolStripMenuItem.Name = "articlesToolStripMenuItem";
            this.articlesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.articlesToolStripMenuItem.Text = "Catalogue";
            this.articlesToolStripMenuItem.Click += new System.EventHandler(this.articlesToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem1,
            this.employésToolStripMenuItem1});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.clientsToolStripMenuItem.Text = "Gestion";
            // 
            // clientsToolStripMenuItem1
            // 
            this.clientsToolStripMenuItem1.Name = "clientsToolStripMenuItem1";
            this.clientsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.clientsToolStripMenuItem1.Text = "Clients";
            this.clientsToolStripMenuItem1.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // employésToolStripMenuItem1
            // 
            this.employésToolStripMenuItem1.Name = "employésToolStripMenuItem1";
            this.employésToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.employésToolStripMenuItem1.Text = "Employés";
            this.employésToolStripMenuItem1.Click += new System.EventHandler(this.employeToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivageToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // archivageToolStripMenuItem
            // 
            this.archivageToolStripMenuItem.Name = "archivageToolStripMenuItem";
            this.archivageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.archivageToolStripMenuItem.Text = "Archivage";
            this.archivageToolStripMenuItem.Click += new System.EventHandler(this.archivageToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 662);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Sport Champion - Programme de gestion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem venteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employésToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivageToolStripMenuItem;
    }
}

