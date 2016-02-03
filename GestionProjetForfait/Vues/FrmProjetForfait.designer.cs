namespace GestionProjetForfait.Vues
{
    partial class FrmProjetForfait
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.cboProjets = new System.Windows.Forms.ComboBox();
            this.projetForfaitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCreer = new System.Windows.Forms.Button();
            this.gbProjet = new System.Windows.Forms.GroupBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDateF = new System.Windows.Forms.TextBox();
            this.bindingProjetF = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cboClients = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomProjet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDateD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.gbForfait = new System.Windows.Forms.GroupBox();
            this.txtMtContrat = new System.Windows.Forms.TextBox();
            this.gbPenalite = new System.Windows.Forms.GroupBox();
            this.rbPenNon = new System.Windows.Forms.RadioButton();
            this.rbPenOui = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCollaborateurs = new System.Windows.Forms.ComboBox();
            this.collaborateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrevisions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projetForfaitBindingSource)).BeginInit();
            this.gbProjet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingProjetF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.gbForfait.SuspendLayout();
            this.gbPenalite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collaborateurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Nom projet  :";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(334, 41);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(84, 23);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // cboProjets
            // 
            this.cboProjets.DataSource = this.projetForfaitBindingSource;
            this.cboProjets.DisplayMember = "NomProjet";
            this.cboProjets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProjets.FormattingEnabled = true;
            this.cboProjets.Location = new System.Drawing.Point(85, 14);
            this.cboProjets.Name = "cboProjets";
            this.cboProjets.Size = new System.Drawing.Size(121, 21);
            this.cboProjets.TabIndex = 0;
            this.cboProjets.ValueMember = "CodeProjet";
            this.cboProjets.SelectedIndexChanged += new System.EventHandler(this.cboProjets_SelectedIndexChanged);
            // 
            // projetForfaitBindingSource
            // 
            this.projetForfaitBindingSource.DataSource = typeof(GestionProjetForfait.Metier.ProjetForfait);
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(334, 12);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(84, 23);
            this.btnCreer.TabIndex = 1;
            this.btnCreer.Text = "Creer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // gbProjet
            // 
            this.gbProjet.Controls.Add(this.btnSupprimer);
            this.gbProjet.Controls.Add(this.btnModifier);
            this.gbProjet.Controls.Add(this.btnAnnuler);
            this.gbProjet.Controls.Add(this.label2);
            this.gbProjet.Controls.Add(this.txtDateF);
            this.gbProjet.Controls.Add(this.label7);
            this.gbProjet.Controls.Add(this.txtContact);
            this.gbProjet.Controls.Add(this.label9);
            this.gbProjet.Controls.Add(this.txtMail);
            this.gbProjet.Controls.Add(this.cboClients);
            this.gbProjet.Controls.Add(this.label3);
            this.gbProjet.Controls.Add(this.txtNomProjet);
            this.gbProjet.Controls.Add(this.label5);
            this.gbProjet.Controls.Add(this.txtDateD);
            this.gbProjet.Controls.Add(this.label10);
            this.gbProjet.Controls.Add(this.btnValider);
            this.gbProjet.Location = new System.Drawing.Point(11, 70);
            this.gbProjet.Name = "gbProjet";
            this.gbProjet.Size = new System.Drawing.Size(440, 195);
            this.gbProjet.TabIndex = 50;
            this.gbProjet.TabStop = false;
            this.gbProjet.Text = "Projet";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(323, 112);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(84, 23);
            this.btnSupprimer.TabIndex = 90;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(323, 26);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(84, 23);
            this.btnModifier.TabIndex = 88;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(323, 55);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(84, 23);
            this.btnAnnuler.TabIndex = 89;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Date fin  :";
            // 
            // txtDateF
            // 
            this.txtDateF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingProjetF, "DFin", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtDateF.Location = new System.Drawing.Point(173, 80);
            this.txtDateF.MaxLength = 10;
            this.txtDateF.Name = "txtDateF";
            this.txtDateF.Size = new System.Drawing.Size(120, 20);
            this.txtDateF.TabIndex = 2;
            // 
            // bindingProjetF
            // 
            this.bindingProjetF.DataSource = typeof(GestionProjetForfait.Metier.ProjetForfait);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 83;
            this.label7.Text = "Contact :";
            // 
            // txtContact
            // 
            this.txtContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingProjetF, "Contact", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtContact.Location = new System.Drawing.Point(173, 133);
            this.txtContact.MaxLength = 30;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(121, 20);
            this.txtContact.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "Mail Contact :";
            // 
            // txtMail
            // 
            this.txtMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingProjetF, "MailContact", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtMail.Location = new System.Drawing.Point(173, 159);
            this.txtMail.MaxLength = 30;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(120, 20);
            this.txtMail.TabIndex = 5;
            // 
            // cboClients
            // 
            this.cboClients.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingProjetF, "LeClient", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cboClients.DataSource = this.clientBindingSource;
            this.cboClients.DisplayMember = "RaisonSociale";
            this.cboClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClients.FormattingEnabled = true;
            this.cboClients.Location = new System.Drawing.Point(173, 106);
            this.cboClients.Name = "cboClients";
            this.cboClients.Size = new System.Drawing.Size(121, 21);
            this.cboClients.TabIndex = 3;
            this.cboClients.ValueMember = "Code";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(GestionProjetForfait.Metier.Client);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Nom projet :";
            // 
            // txtNomProjet
            // 
            this.txtNomProjet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingProjetF, "NomProjet", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtNomProjet.Location = new System.Drawing.Point(172, 28);
            this.txtNomProjet.MaxLength = 30;
            this.txtNomProjet.Name = "txtNomProjet";
            this.txtNomProjet.Size = new System.Drawing.Size(121, 20);
            this.txtNomProjet.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Date debut  :";
            // 
            // txtDateD
            // 
            this.txtDateD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingProjetF, "DDebut", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtDateD.Location = new System.Drawing.Point(173, 54);
            this.txtDateD.MaxLength = 10;
            this.txtDateD.Name = "txtDateD";
            this.txtDateD.Size = new System.Drawing.Size(120, 20);
            this.txtDateD.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(123, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 82;
            this.label10.Text = "Client :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(323, 83);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(84, 23);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // gbForfait
            // 
            this.gbForfait.Controls.Add(this.btnPrevisions);
            this.gbForfait.Controls.Add(this.txtMtContrat);
            this.gbForfait.Controls.Add(this.gbPenalite);
            this.gbForfait.Controls.Add(this.label6);
            this.gbForfait.Controls.Add(this.cboCollaborateurs);
            this.gbForfait.Controls.Add(this.label4);
            this.gbForfait.Location = new System.Drawing.Point(11, 271);
            this.gbForfait.Name = "gbForfait";
            this.gbForfait.Size = new System.Drawing.Size(437, 165);
            this.gbForfait.TabIndex = 51;
            this.gbForfait.TabStop = false;
            this.gbForfait.Text = "Forfait";
            // 
            // txtMtContrat
            // 
            this.txtMtContrat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingProjetF, "MontantContrat", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtMtContrat.Location = new System.Drawing.Point(171, 16);
            this.txtMtContrat.Name = "txtMtContrat";
            this.txtMtContrat.Size = new System.Drawing.Size(120, 20);
            this.txtMtContrat.TabIndex = 0;
            // 
            // gbPenalite
            // 
            this.gbPenalite.Controls.Add(this.rbPenNon);
            this.gbPenalite.Controls.Add(this.rbPenOui);
            this.gbPenalite.Location = new System.Drawing.Point(90, 91);
            this.gbPenalite.Name = "gbPenalite";
            this.gbPenalite.Size = new System.Drawing.Size(190, 69);
            this.gbPenalite.TabIndex = 3;
            this.gbPenalite.TabStop = false;
            this.gbPenalite.Text = "Penalites";
            // 
            // rbPenNon
            // 
            this.rbPenNon.AutoSize = true;
            this.rbPenNon.Checked = true;
            this.rbPenNon.Location = new System.Drawing.Point(30, 19);
            this.rbPenNon.Name = "rbPenNon";
            this.rbPenNon.Size = new System.Drawing.Size(45, 17);
            this.rbPenNon.TabIndex = 0;
            this.rbPenNon.TabStop = true;
            this.rbPenNon.Text = "Non";
            this.rbPenNon.UseVisualStyleBackColor = true;
            // 
            // rbPenOui
            // 
            this.rbPenOui.AutoSize = true;
            this.rbPenOui.Location = new System.Drawing.Point(104, 19);
            this.rbPenOui.Name = "rbPenOui";
            this.rbPenOui.Size = new System.Drawing.Size(41, 17);
            this.rbPenOui.TabIndex = 1;
            this.rbPenOui.Text = "Oui";
            this.rbPenOui.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Montant contrat :";
            // 
            // cboCollaborateurs
            // 
            this.cboCollaborateurs.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingProjetF, "ChefDeProjet", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cboCollaborateurs.DataSource = this.collaborateurBindingSource;
            this.cboCollaborateurs.DisplayMember = "Nom";
            this.cboCollaborateurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCollaborateurs.FormattingEnabled = true;
            this.cboCollaborateurs.Location = new System.Drawing.Point(170, 51);
            this.cboCollaborateurs.Name = "cboCollaborateurs";
            this.cboCollaborateurs.Size = new System.Drawing.Size(121, 21);
            this.cboCollaborateurs.TabIndex = 1;
            this.cboCollaborateurs.ValueMember = "Code";
            // 
            // collaborateurBindingSource
            // 
            this.collaborateurBindingSource.DataSource = typeof(GestionProjetForfait.Metier.Collaborateur);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "Responsable :";
            // 
            // btnPrevisions
            // 
            this.btnPrevisions.Location = new System.Drawing.Point(339, 121);
            this.btnPrevisions.Name = "btnPrevisions";
            this.btnPrevisions.Size = new System.Drawing.Size(75, 23);
            this.btnPrevisions.TabIndex = 95;
            this.btnPrevisions.Text = "Previsions";
            this.btnPrevisions.UseVisualStyleBackColor = true;
            this.btnPrevisions.Click += new System.EventHandler(this.btnPrevisions_Click);
            // 
            // FrmProjetForfait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 448);
            this.Controls.Add(this.gbForfait);
            this.Controls.Add(this.gbProjet);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.cboProjets);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label1);
            this.Name = "FrmProjetForfait";
            this.Text = "Gestion d\'un projet au forfait";
            this.Load += new System.EventHandler(this.FrmProjetForfait_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetForfaitBindingSource)).EndInit();
            this.gbProjet.ResumeLayout(false);
            this.gbProjet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingProjetF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.gbForfait.ResumeLayout(false);
            this.gbForfait.PerformLayout();
            this.gbPenalite.ResumeLayout(false);
            this.gbPenalite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collaborateurBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ComboBox cboProjets;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.GroupBox gbProjet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDateF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cboClients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomProjet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDateD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox gbForfait;
        private System.Windows.Forms.TextBox txtMtContrat;
        private System.Windows.Forms.GroupBox gbPenalite;
        private System.Windows.Forms.RadioButton rbPenNon;
        private System.Windows.Forms.RadioButton rbPenOui;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCollaborateurs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.BindingSource projetForfaitBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource collaborateurBindingSource;
        private System.Windows.Forms.BindingSource bindingProjetF;
        private System.Windows.Forms.Button btnPrevisions;
    }
}