using System;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Windows.Forms;

using GestionProjetForfait.Metier;
using GestionProjetForfait.Dao;
using GestionProjetForfait.Utilitaires;
using GestionProjetForfait.Exceptions;

// =========================================================================================================//
// Création, mise à jour, suppression et visualisation d'un projet au forfait                               //
// Les contrôles graphiques sont liés à la combo par databinding ,                                          //
// le mode de mise à jour de la source de données est never (la combo n'est pas mise à jour en auto)        //
// La propriété MAXLENGTH a été positionnée pour tous les champs texte conformément à la description base   // 
// Dans la classe Dao :                                                                                     //
// Les données sont lues et modifiées en base  : chaque accès base est exécuté dans un bloc try catch       //
// Les erreurs SQL sont gérées dans la classe Dao                                                           //                      
// La requête SQL ne lit que des projets au forfait , mais on traite la classe Projet                       //
// Dans l'IHM, sont gérées spécifiquement                                                                   //
//  - Les erreurs DaoExceptionFinAppli :  on arrete le traitement                                           //
//  - Toutes les autres Exceptions : on affiche le message                                                  //
// Nécessité de mettre à jour le BindingSource qui lie la combo pour réaffichage des données modifiées pour //
// chaque opération sur la base                                                                             //
// =========================================================================================================//


namespace GestionProjetForfait.Vues
{
    public partial class FrmProjetForfait : Form
    {

        bool creation = false;
        int codeProjet;

        public FrmProjetForfait()
        {
            InitializeComponent();

        }

        //------------------------------------ Gestion des évenements ----------------------------------------------
        #region Gestion évenements

        // Chargement
        private void FrmProjetForfait_Load(object sender, EventArgs e)
        {
            try
            {
                // Alimente les combos
                AlimenterChefs();
                AlimenterClients();
                AlimenterProjets();

                // Affichage initial
                btnAnnuler_Click(btnAnnuler, new EventArgs());
            }
            catch (DaoExceptionFinAppli defa)
            {
                MessageBox.Show(defa.Message);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite \n" + ex.Message);
            }


        }

        // Sélection combo
        private void cboProjets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProjets.SelectedItem != null)
            {

                ProjetForfait oProjet = ((ProjetForfait)cboProjets.SelectedItem);

                // réalisation binding 
                bindingProjetF.ResumeBinding();

                bindingProjetF.DataSource = oProjet;
                if (oProjet.PenaliteOuiNon == Penalite.Non) rbPenNon.Checked = true;
                else rbPenOui.Checked = true;

                codeProjet = oProjet.CodeProjet;

                creation = false;

                // Affichage en visu
                //==================
                AfficheForm("V");
                //}


            }
        }

        // Créer 
        private void btnCreer_Click(object sender, EventArgs e)
        {
            // affichage vierge
            cboProjets.SelectedIndex = -1;
            AfficheForm("C");
            creation = true;
        }

        // Modifier
        private void btnModifier_Click(object sender, EventArgs e)
        {
            // On déprotege les champs
            AfficheForm("M");
        }

        // Annuler
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // Affichage initial
            gbProjet.Visible = false;
            gbForfait.Visible = false;
            cboProjets.SelectedIndex = -1;

            // en cas de modif de champs annulés
            bindingProjetF.ResetCurrentItem();

            btnCreer.Enabled = true;
        }

        // Valider
        private void btnValider_Click(object sender, EventArgs e)
        {
            // Controle la saisie des champs 
            //==============================
            decimal mtContrat;
            DateTime dateDebut, dateFin;
            // test champ alpha : au moins 1 caractere 
            if (!Regex.IsMatch(txtNomProjet.Text, @"^[A-Za-z ]+$"))// espace autorisé
            {
                Affichage.ErreurSaisie(txtNomProjet, "Nom projet invalide");
            }
            // test Date
            // attention date de format jj/mm passe avec tryParse , année en cours par défaut
            // on pourrait ajouter le controle du format jj/mm/aaaa par expression régulière
            else if (!DateTime.TryParse(txtDateD.Text, out dateDebut))
            {
                Affichage.ErreurSaisie(txtDateD, "Date invalide");
            }
            else if (!DateTime.TryParse(txtDateF.Text, out dateFin))
            {
                Affichage.ErreurSaisie(txtDateF, "Date invalide");
            }
            // DateDebut < DateFin
            else if (dateDebut.CompareTo(dateFin) > 0)
            {
                Affichage.ErreurSaisie(txtDateD, "La date de début doit être inférieure à la date du jour");
            }
            // test client sélectionnée
            else if (cboClients.SelectedIndex == -1)
            {
                Affichage.ErreurSaisie(cboClients, "Sélectionnez un client");
            }
            //Contact, non obligatoire, mais alpha si saisi
            else if (!Regex.IsMatch(txtNomProjet.Text, @"^[A-Za-z ]*$"))// espace autorisé
            {
                Affichage.ErreurSaisie(txtNomProjet, "Ne peut contenir que des caractères");
            }
            // test Adresse mail, avec utilisation System.Net.Mail
            else if (!IsValidEMail(txtMail.Text))
            {
                Affichage.ErreurSaisie(txtMail, "Adresse mail erronée");
            }
            // test collaborateur sélectionnée
            else if (cboCollaborateurs.SelectedIndex == -1)
            {
                Affichage.ErreurSaisie(cboCollaborateurs, "Sélectionnez un chef de projet");
            }
            // test mt contrat
            else if (!Decimal.TryParse(txtMtContrat.Text, out mtContrat))
            {
                Affichage.ErreurSaisie(txtMtContrat, "Montant contrat invalide");
            }
            else  // saisie OK
            {
                //Affectation du code penalite : utilisation de l'opérateur ternaire
                //Penalite cp;
                //if (rbPenNon.Checked) cp = Penalite.Non;
                //else cp = Penalite.Oui;
                ProjetForfait oProjet = new ProjetForfait(txtNomProjet.Text, dateDebut, dateFin, (Client)cboClients.SelectedItem,
                        txtContact.Text, txtMail.Text, mtContrat, rbPenNon.Checked ? Penalite.Non:Penalite.Oui, (Collaborateur)cboCollaborateurs.SelectedItem);

                bool success;
                try {
                    if (creation) // Création
                    {
                        int code = DaoProjet.AddProjet(oProjet);
                        oProjet.CodeProjet = code;
                        success = true;
                        // ajout dans la combo au travers du binding
                        projetForfaitBindingSource.Add(oProjet);

                    }
                    else // Modification
                    {
                        oProjet.CodeProjet = codeProjet;
                        DaoProjet.UpdProjet(oProjet);
                        success = true;
                        // modif du bindingSource 
                        int rang = projetForfaitBindingSource.IndexOf(oProjet);
                        if (rang != -1) projetForfaitBindingSource[rang] = oProjet;
                    }

                    // Echec ou succes ?
                    if (success)
                    {
                        // actualisation
                        projetForfaitBindingSource.ResetBindings(false);
                        cboProjets.SelectedItem = oProjet;
                        // Affichage en visu
                        AfficheForm("V");
                    }
                    // sinon on reste en l'état
                }
                catch (DaoExceptionFinAppli defa)
                {
                    MessageBox.Show(defa.Message);
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        } 

        // Supprimer
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Confirmez-vous la suppression", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    bool success = DaoProjet.DelProjet(((ProjetForfait)cboProjets.SelectedItem));
                    // Echec ou succes ?
                    if (success)
                    {
                        // actualisation combo
                        projetForfaitBindingSource.Remove(((Projet)cboProjets.SelectedItem));
                        projetForfaitBindingSource.ResetBindings(false);
                        // Affichage initial
                        btnAnnuler_Click(btnSupprimer, new EventArgs());
                    }
                    // sinon on reste en l'état
                }
                catch (DaoExceptionFinAppli defa)
                {
                    MessageBox.Show(defa.Message);
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        //---------------------------------------- Controles -------------------------------------------------------
        #region Controles
        // Controle email avec la class MailAdress de l'espace de nom System.Net.Mail
        public bool IsValidEMail(string emailaddress)
        {
            if (emailaddress != String.Empty)
            {
                try
                {
                    MailAddress m = new MailAddress(emailaddress);

                    return true;
                }
                catch (FormatException)
                {
                    return false;
                }
            }
            else return true;
        }
        #endregion

        //---------------------------------------- Traitements -----------------------------------------------------
        #region Traitements
        public void AlimenterChefs()
        {
            collaborateurBindingSource.DataSource = DaoProjet.GetAllChefs();
        }
        public void AlimenterClients()
        {
            clientBindingSource.DataSource = DaoProjet.GetAllClients();
        }

        public void AlimenterProjets()
        {
            projetForfaitBindingSource.DataSource = DaoProjet.GetAllProjetForfaits();
        }
        #endregion

        //---------------------------------------- Affichage ------------------------------------------------------
        #region Affichage
        // Affichage de la feuille apres selection ou création
       private void AfficheForm(string action)
        {
            gbProjet.Visible = true;
            gbForfait.Visible = true;

            switch (action)
            {
                case "C": // création
                    Affichage.InitContainer(this);
                    cboProjets.SelectedIndex = -1;
                    // les boutons
                    btnModifier.Enabled = false;
                    btnSupprimer.Enabled = false;
                    btnValider.Enabled = true;
                    btnPrevisions.Enabled = false;
                    break;
                case "M": // Modification
                    Affichage.ProtegeDeprotege(true, this);
                    // les boutons
                    btnSupprimer.Enabled = false;
                    btnModifier.Enabled = false;
                    btnPrevisions.Enabled = false;
                    break;
                case "V": // Visualisation
                    Affichage.ProtegeDeprotege(false, this);
                    cboProjets.Enabled = true;
                    // les boutons
                    btnSupprimer.Enabled = true; // pour la modif
                    btnModifier.Enabled = true;
                    btnPrevisions.Enabled = true;

                    break;
            }

            btnAnnuler.Enabled = true;
            btnCreer.Enabled = false;
            btnQuitter.Enabled = true;

            txtNomProjet.Focus();

        }

        #endregion

        private void btnPrevisions_Click(object sender, EventArgs e)
        {
            FrmPrevisionnel f = new FrmPrevisionnel((ProjetForfait)cboProjets.SelectedItem);
            f.Show();
        }
    }
}
