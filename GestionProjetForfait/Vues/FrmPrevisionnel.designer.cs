namespace GestionProjetForfait.Vues
{
    partial class FrmPrevisionnel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblProjet = new System.Windows.Forms.Label();
            this.dgvPrevisions = new System.Windows.Forms.DataGridView();
            this.qualificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.previsionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboProjets = new System.Windows.Forms.ComboBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.gbUnePrevision = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.nudJours = new System.Windows.Forms.NumericUpDown();
            this.cboQualif = new System.Windows.Forms.ComboBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.DgCodePrevision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaQualif = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DgNbJours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSupprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CodePrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevisions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previsionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).BeginInit();
            this.gbUnePrevision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJours)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjet
            // 
            this.lblProjet.AutoSize = true;
            this.lblProjet.Location = new System.Drawing.Point(12, 20);
            this.lblProjet.Name = "lblProjet";
            this.lblProjet.Size = new System.Drawing.Size(40, 13);
            this.lblProjet.TabIndex = 47;
            this.lblProjet.Text = "Projet :";
            // 
            // dgvPrevisions
            // 
            this.dgvPrevisions.AllowUserToAddRows = false;
            this.dgvPrevisions.AllowUserToDeleteRows = false;
            this.dgvPrevisions.AutoGenerateColumns = false;
            this.dgvPrevisions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrevisions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgCodePrevision,
            this.LaQualif,
            this.DgNbJours,
            this.btnModifier,
            this.btnSupprimer,
            this.CodePrev});
            this.dgvPrevisions.DataSource = this.previsionBindingSource;
            this.dgvPrevisions.Location = new System.Drawing.Point(16, 81);
            this.dgvPrevisions.Name = "dgvPrevisions";
            this.dgvPrevisions.ReadOnly = true;
            this.dgvPrevisions.Size = new System.Drawing.Size(594, 113);
            this.dgvPrevisions.TabIndex = 50;
            this.dgvPrevisions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrevisions_CellClick);
            // 
            // qualificationBindingSource
            // 
            this.qualificationBindingSource.DataSource = typeof(GestionProjetForfait.Metier.Qualification);
            // 
            // previsionBindingSource
            // 
            this.previsionBindingSource.DataSource = typeof(GestionProjetForfait.Metier.Prevision);
            // 
            // projetBindingSource
            // 
            this.projetBindingSource.DataSource = typeof(GestionProjetForfait.Metier.Projet);
            // 
            // cboProjets
            // 
            this.cboProjets.DataSource = this.projetBindingSource;
            this.cboProjets.DisplayMember = "NomProjet";
            this.cboProjets.FormattingEnabled = true;
            this.cboProjets.Location = new System.Drawing.Point(58, 17);
            this.cboProjets.Name = "cboProjets";
            this.cboProjets.Size = new System.Drawing.Size(121, 21);
            this.cboProjets.TabIndex = 51;
            this.cboProjets.ValueMember = "Code";
            this.cboProjets.SelectedIndexChanged += new System.EventHandler(this.cboProjets_SelectedIndexChanged);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(12, 51);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(57, 20);
            this.lblTitre.TabIndex = 52;
            this.lblTitre.Text = "label2";
            // 
            // gbUnePrevision
            // 
            this.gbUnePrevision.Controls.Add(this.btnAnnuler);
            this.gbUnePrevision.Controls.Add(this.btnValider);
            this.gbUnePrevision.Controls.Add(this.nudJours);
            this.gbUnePrevision.Controls.Add(this.cboQualif);
            this.gbUnePrevision.Location = new System.Drawing.Point(15, 229);
            this.gbUnePrevision.Name = "gbUnePrevision";
            this.gbUnePrevision.Size = new System.Drawing.Size(315, 93);
            this.gbUnePrevision.TabIndex = 53;
            this.gbUnePrevision.TabStop = false;
            this.gbUnePrevision.Text = "Prévision";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(216, 55);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(135, 55);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // nudJours
            // 
            this.nudJours.Location = new System.Drawing.Point(188, 20);
            this.nudJours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudJours.Name = "nudJours";
            this.nudJours.Size = new System.Drawing.Size(120, 20);
            this.nudJours.TabIndex = 2;
            // 
            // cboQualif
            // 
            this.cboQualif.DataSource = this.qualificationBindingSource;
            this.cboQualif.DisplayMember = "Nom";
            this.cboQualif.FormattingEnabled = true;
            this.cboQualif.Location = new System.Drawing.Point(43, 19);
            this.cboQualif.Name = "cboQualif";
            this.cboQualif.Size = new System.Drawing.Size(121, 21);
            this.cboQualif.TabIndex = 1;
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(15, 200);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(75, 23);
            this.btnCreer.TabIndex = 54;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(535, 20);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 55;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // DgCodePrevision
            // 
            this.DgCodePrevision.DataPropertyName = "CodePrevision";
            this.DgCodePrevision.HeaderText = "Code";
            this.DgCodePrevision.Name = "DgCodePrevision";
            this.DgCodePrevision.ReadOnly = true;
            this.DgCodePrevision.Visible = false;
            this.DgCodePrevision.Width = 50;
            // 
            // LaQualif
            // 
            this.LaQualif.DataPropertyName = "LaQualif";
            this.LaQualif.DataSource = this.qualificationBindingSource;
            this.LaQualif.DisplayMember = "Libelle";
            this.LaQualif.HeaderText = "Qualification";
            this.LaQualif.Name = "LaQualif";
            this.LaQualif.ReadOnly = true;
            this.LaQualif.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LaQualif.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.LaQualif.ValueMember = "Self";
            this.LaQualif.Width = 200;
            // 
            // DgNbJours
            // 
            this.DgNbJours.DataPropertyName = "NbJours";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.DgNbJours.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgNbJours.HeaderText = "NbJours";
            this.DgNbJours.Name = "DgNbJours";
            this.DgNbJours.ReadOnly = true;
            // 
            // btnModifier
            // 
            this.btnModifier.HeaderText = "";
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.ReadOnly = true;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseColumnTextForButtonValue = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.HeaderText = "";
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.ReadOnly = true;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseColumnTextForButtonValue = true;
            // 
            // CodePrev
            // 
            this.CodePrev.DataPropertyName = "CodePrev";
            this.CodePrev.HeaderText = "CodePrev";
            this.CodePrev.Name = "CodePrev";
            this.CodePrev.ReadOnly = true;
            this.CodePrev.Visible = false;
            // 
            // FrmPrevisionnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 335);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.gbUnePrevision);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.cboProjets);
            this.Controls.Add(this.dgvPrevisions);
            this.Controls.Add(this.lblProjet);
            this.Name = "FrmPrevisionnel";
            this.Text = "Prévisions";
            this.Load += new System.EventHandler(this.FrmPrevis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevisions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previsionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).EndInit();
            this.gbUnePrevision.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudJours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjet;
        private System.Windows.Forms.DataGridView dgvPrevisions;
        private System.Windows.Forms.ComboBox cboProjets;
        private System.Windows.Forms.BindingSource projetBindingSource;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.GroupBox gbUnePrevision;
        private System.Windows.Forms.NumericUpDown nudJours;
        private System.Windows.Forms.ComboBox cboQualif;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.BindingSource previsionBindingSource;
        private System.Windows.Forms.BindingSource qualificationBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn laQualifDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgCodePrevision;
        private System.Windows.Forms.DataGridViewComboBoxColumn LaQualif;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgNbJours;
        private System.Windows.Forms.DataGridViewButtonColumn btnModifier;
        private System.Windows.Forms.DataGridViewButtonColumn btnSupprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePrev;
    }
}