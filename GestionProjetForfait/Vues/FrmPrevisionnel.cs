using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GestionProjetForfait.Metier;
using GestionProjetForfait.Dao;
using GestionProjetForfait.Exceptions;

// =====================================================================================================//
// DGV en lecture seule : on crée ou modifie à partir du Group Box, on supprime dans le DGV             //
// Trucs à savoir :                                                                                     //
// Pour positionner la value des boutons dans le DGV ,                                                  //
//   utiliser la propriété UseColumnTextForBoutonValue dans la colonne Bouton du DGV                    //
// Pour retrouver un objet Bindé à travers un DGV  : Previson p = row.DataBoundItem as Prevision        //
// J'utilise l'évenement CellClick sur le DGV qui me donne la ligne et la colonne de la cellule cliquée //
// pour repérer quel bouton Modifier ou Supprimer a été cliqué                                          //
// On crée des méthodes dans la classe Projet permettant d'ajouter, modifier,                           //
// supprimer les prévisions du projet                                                                   //
//                                                                                                      //
// Les prévisions sont chargées à la sélection du projet dans la combo                                  //
// ou lorsque le projet est passé par la feuille FrmProjetForfait par ma méthode AfficherPrevisions()   //
// si elles n'ont pas déjà été chargées (nb d'occurences dans la liste dans le projet = 0)              //
// =====================================================================================================//

namespace GestionProjetForfait.Vues
{
    public partial class FrmPrevisionnel : Form
    {

        string Mode = string.Empty;
        Prevision newPMS = null;
        private ProjetForfait leProjetEnCours = null;

        public FrmPrevisionnel()
        {
            InitializeComponent();
        }

        public FrmPrevisionnel(ProjetForfait pf)
        {
            InitializeComponent();
            leProjetEnCours = pf;
        }

        //------------------------------------ Gestion des évenements ----------------------------------------------

        #region Gestion Evenements
        private void FrmPrevis_Load(object sender, EventArgs e)
        {
            // les qualifications 
            this.qualificationBindingSource.DataSource = DaoProjet.GetAllQualifications();

            if (leProjetEnCours == null)  // on va afficher la combo pour sélectionner un projet
            {
                // les projets
                AlimenterProjets();
                // affichage
                dgvPrevisions.Visible = false;
                // ne pas afficher les boutons
                btnCreer.Visible = false;
                // ne pas afficher le titre
                lblTitre.Visible = false;
            }
            else  // feuille s'affiche apres click bouton previsions dans FrmProjetForfait
            {
                // afficher prévisions
                AfficherPrevisions();

                // pas d'affichage combo
                lblProjet.Visible = false;
                cboProjets.Visible = false;
            }
            // les propriétés particulières du DataGridView
            dgvPrevisions.MultiSelect = false;
            // ne pas afficher le groupBox prevision
            gbUnePrevision.Visible = false;
        }

        // Choix d'un projet dans la combo
        private void cboProjets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProjets.SelectedIndex != -1)
            {
                // Chargement du datagridview
                //-----------------------------
                leProjetEnCours = (ProjetForfait)cboProjets.SelectedItem;

                // afficher prévisions
                AfficherPrevisions();

                lblTitre.Visible = true;
                btnCreer.Visible = true;
            }
        }



        // modification ou suppression dans le dategrid view
        private void dgvPrevisions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // L'evenement DataGridViewCellEventArgs donne la colonne et la ligne de la cellule cliquée
            bool success = false;
            // Ignore click qui n'est pas sur une cellule bouton  
            if ((e.RowIndex >= 0 && e.ColumnIndex == dgvPrevisions.Columns["btnModifier"].Index)
                ||
                (e.RowIndex >= 0 && e.ColumnIndex == dgvPrevisions.Columns["btnSupprimer"].Index)
                )
            {
                // A partir des objets DataBoundItem
                //======================================

                // creer la prévision à modifier ou supprimer
                newPMS = (dgvPrevisions.Rows[e.RowIndex]).DataBoundItem as Prevision;

                //Modif ou Suppression
                if (e.ColumnIndex == dgvPrevisions.Columns["btnModifier"].Index)
                {
                    Mode = "M";
                    // affectations champs du groupBox
                    nudJours.Value = newPMS.NbJours;
                    cboQualif.SelectedItem = newPMS.LaQualif;
                    // affiche le groupBox pour modification
                    gbUnePrevision.Visible = true;
                }
                else
                {

                    DialogResult dr = MessageBox.Show("Confirmez-vous la suppression", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            // Supprime en base
                            success = DaoProjet.DelPrevision(newPMS);
                            if (success)
                            {
                                // Supprime dans les prévisions du projet
                                leProjetEnCours.DelPrevision(newPMS);
                                // rafraichissement du datagrid view
                                this.previsionBindingSource.ResetBindings(false);
                                // Peut-être plus aucune prevision apres suppression
                                AffichageDG(previsionBindingSource.Count);
                            }
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
            }
        }

        // création
        private void btnCreer_Click(object sender, EventArgs e)
        {
            // Réinitialise les champs du groupBox 
            cboQualif.SelectedIndex = -1;
            nudJours.Value = 0;
            cboQualif.Text = "Choisir";
            gbUnePrevision.Visible = true;
            Mode = "C";
        }

        // annulation après bouton créer ou modifier
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            gbUnePrevision.Visible = false;
        }

        // validation après bouton créer ou modifier
        private void btnValider_Click(object sender, EventArgs e)
        {
            // Controles

            if (cboQualif.SelectedIndex == -1)
                MessageBox.Show("Choisir une qualification");
            else if (nudJours.Value == 0)
                MessageBox.Show("Saisir le nombre de jours");
            else // controles OK
            {
                // creer une nouvelle prévision
                Prevision newP = new Prevision();
                newP.LaQualif = (Qualification)cboQualif.SelectedItem;
                newP.NbJours = (short)nudJours.Value;
                newP.CodeProjet = leProjetEnCours.CodeProjet;

                if (Mode == "C") // création
                {
                    // Controle qualif non existe déjà 
                    if (leProjetEnCours.GetPrevisions().Contains(newP))
                        MessageBox.Show("Existe déjà");
                    else
                    {
                        try
                        {
                            // ajout en base
                            int idPrev = DaoProjet.AddPrevision(newP);
                            // si ok
                            if (idPrev != 0)
                            {
                                newP.CodePrev = idPrev;
                                // ajout projet
                                leProjetEnCours.AddPrevision(newP);
                                // rafraichissement du datagrid view
                                this.previsionBindingSource.ResetBindings(false);
                                MessageBox.Show(String.Format("Prévision ajoutée"));
                                // efface le group box
                                gbUnePrevision.Visible = false;
                                // Datagrid view devient peut être visible apres 1er ajout
                                if (!dgvPrevisions.Visible)
                                {
                                    dgvPrevisions.Visible = true;
                                    lblTitre.Text = "Les previsions";
                                }
                            }
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
                else // Modification
                {
                    try
                    {
                        newP.CodePrev = newPMS.CodePrev;
                        newP.CodeProjet = newPMS.CodeProjet;
                        // modif en base
                        if (DaoProjet.UpdPrevision(newP))
                        {
                            //modif dans les prévisions projet
                            leProjetEnCours.UpdPrevision(newP);
                            // rafraichissement du datagrid view
                            this.previsionBindingSource.ResetBindings(false);
                            // efface le group box
                            gbUnePrevision.Visible = false;

                        }
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
        }

        // Quitter
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        //---------------------------------------- Traitements -----------------------------------------------------

        #region Traitements
        public void AlimenterProjets()
        {
            try
            {
                this.projetBindingSource.DataSource = DaoProjet.GetAllProjetForfaits();
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
        #endregion

        //---------------------------------------- Affichage ------------------------------------------------------

        #region Affichage

        // recherche et affichage des prévisions (refactorisée)
        private void AfficherPrevisions()
        {
            List<Prevision> lstPre = leProjetEnCours.GetPrevisions();
            // Recherche des prévisions en base si non déjà chargées
            if (lstPre.Count == 0)
            {
                lstPre = DaoProjet.GetPrevisionByProjet(leProjetEnCours.CodeProjet);
                // affectation au projet
                leProjetEnCours.SetPrevisions(lstPre);
            }
            this.previsionBindingSource.DataSource = lstPre;

            // affichage
            AffichageDG(lstPre.Count);
        }

        private void AffichageDG(int n)
        {
            if (n > 0) // au moins une prévision
            {
                // efface la sélection
                dgvPrevisions.ClearSelection();

                dgvPrevisions.Visible = true;
                lblTitre.Text = "Les previsions";
                gbUnePrevision.Visible = false;

            }
            else // 0 previsions
            {
                gbUnePrevision.Visible = false;
                dgvPrevisions.Visible = false;
                lblTitre.Text = "Aucune prévision";
            }
        } 
        #endregion

    }
}
