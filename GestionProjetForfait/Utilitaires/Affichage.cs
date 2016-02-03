using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionProjetForfait.Utilitaires
{
    class Affichage
    {
        public static void ErreurSaisie(Control txtSaisie, string message)
        {
            // affichage des messages d'erreur avec mise en évidence de l'erreur
            MessageBox.Show(message);
            if (txtSaisie is TextBox)
            { 
                ((TextBox)txtSaisie).SelectionStart = 0;
                ((TextBox)txtSaisie).SelectionLength = txtSaisie.Text.Length;
            }
            txtSaisie.Focus();
        }

        public static void ProtegeDeprotege(bool enable, Control ctrl)
        {
            foreach (Control ct in ctrl.Controls)
            {
                if (ct.HasChildren) ProtegeDeprotege(enable, ct);
                else if (!(ct is Label)) ct.Enabled = enable;
            }
        }


        // Initialisation Formulaire
        public static void InitContainer(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                c.Enabled = true;
                if (c is TextBox) ((TextBox)c).Clear();
                else if (c is ComboBox)((ComboBox)c).SelectedIndex = -1;
                else if (c.HasChildren) InitContainer(c);
            }

            // 
        }




    }
}
