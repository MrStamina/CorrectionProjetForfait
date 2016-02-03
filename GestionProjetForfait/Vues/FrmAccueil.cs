using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionProjetForfait.Vues
{
    public partial class FrmAccueil : Form
    {
        public FrmAccueil()
        {
            InitializeComponent();
        }

        // Déclaration des contrôles accessibles de l'extérieur // plop
        //-----------------------------------------------------
        // Menu
        //------
        public ToolStripMenuItem GestionProjetToolStripMenuItem
        {
            get { return gestionProjetsToolStripMenuItem; }
        }
        public ToolStripMenuItem FenetresToolStripMenuItem
        {
            get { return fenetresToolStripMenuItem; }
        }
        // ToolBar
        //---------
        public ToolStripButton ToolStripGererProjetForfait
        {
            get { return toolStripGererProjet; }
        }

        // Sidentifier
        //============
        // menu
        private void sidentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sidentifier();
        }
        // toolbar
        private void toolStripSidentifier_Click(object sender, EventArgs e)
        {
            Sidentifier();
        }
        private void Sidentifier()
        {
            FrmLogin frmfille = new FrmLogin();
            frmfille.MdiParent = this;
            frmfille.Show();
        }
       

        // Gerer projet
        //===============
        // menu
        private void GererProjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GererProjet();
        }
        // toolbar
        private void toolStripGererProjet_Click(object sender, EventArgs e)
        {
            GererProjet();
        }

        private void GererProjet()
        {
            FrmProjetForfait frmfille = new FrmProjetForfait();
            frmfille.MdiParent = this;
            frmfille.Show();
        }

        // Prévisionnel - menu
        private void prévisionnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrevisionnel frmfille = new FrmPrevisionnel();
            frmfille.MdiParent = this;
            frmfille.Show();
        }


        // Arrangement des fenêtres
        //=========================
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatuslblDate.Text = DateTime.Now.ToString();
        }

        // Activation d'un évenement fille 
        //=================================
        private void FrmAccueil_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null) tsslblAction.Text = this.ActiveMdiChild.Text;
            else tsslblAction.Text = "";
        }

    }
}
