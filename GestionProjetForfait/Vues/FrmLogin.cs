using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionProjetForfait.Vues
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------//
        //- Identification réussie si login = password                        //
        //--------------------------------------------------------------------//


        private FrmAccueil  frmMere;
     
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == txtPwd.Text)
            {
                frmMere = (FrmAccueil)this.MdiParent;
                // Positionner le login dans la feuille principale pour utilisation future
                // rendre accessible tous les boutons menus
                frmMere.GestionProjetToolStripMenuItem.Enabled = true;
                frmMere.FenetresToolStripMenuItem.Enabled = true;
                // rendre accessible le bouton toolbar
                frmMere.ToolStripGererProjetForfait.Enabled = true;
                // message de bienvenue
                MessageBox.Show("Bienvenue " + txtLogin.Text, "Bienvenue");
                this.Close();
            }
            else
            {
                MessageBox.Show("Recommencez !");
                txtLogin.Focus();
            }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //((frmMenu)this.MdiParent).Login = null;
            this.Close();

        }
    }
}