namespace GestionProjetForfait.Vues
{
    partial class FrmAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccueil));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidentifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionProjetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererProjetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prévisionnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionPrevisionnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenetresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatuslblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSidentifier = new System.Windows.Forms.ToolStripButton();
            this.toolStripGererProjet = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.gestionProjetsToolStripMenuItem,
            this.gestionPrevisionnelToolStripMenuItem,
            this.fenetresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.fenetresToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidentifierToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // sidentifierToolStripMenuItem
            // 
            this.sidentifierToolStripMenuItem.Name = "sidentifierToolStripMenuItem";
            this.sidentifierToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.sidentifierToolStripMenuItem.Text = "S\'identifier";
            this.sidentifierToolStripMenuItem.Click += new System.EventHandler(this.sidentifierToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // gestionProjetsToolStripMenuItem
            // 
            this.gestionProjetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererProjetToolStripMenuItem,
            this.prévisionnelToolStripMenuItem});
            this.gestionProjetsToolStripMenuItem.Enabled = false;
            this.gestionProjetsToolStripMenuItem.Name = "gestionProjetsToolStripMenuItem";
            this.gestionProjetsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.gestionProjetsToolStripMenuItem.Text = "Gestion Projets";
            // 
            // gererProjetToolStripMenuItem
            // 
            this.gererProjetToolStripMenuItem.Name = "gererProjetToolStripMenuItem";
            this.gererProjetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gererProjetToolStripMenuItem.Text = "Gérer projets";
            this.gererProjetToolStripMenuItem.Click += new System.EventHandler(this.GererProjetToolStripMenuItem_Click);
            // 
            // prévisionnelToolStripMenuItem
            // 
            this.prévisionnelToolStripMenuItem.Name = "prévisionnelToolStripMenuItem";
            this.prévisionnelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.prévisionnelToolStripMenuItem.Text = "Prévisionnel";
            this.prévisionnelToolStripMenuItem.Click += new System.EventHandler(this.prévisionnelToolStripMenuItem_Click);
            // 
            // gestionPrevisionnelToolStripMenuItem
            // 
            this.gestionPrevisionnelToolStripMenuItem.Name = "gestionPrevisionnelToolStripMenuItem";
            this.gestionPrevisionnelToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // fenetresToolStripMenuItem
            // 
            this.fenetresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.toolStripSeparator1});
            this.fenetresToolStripMenuItem.Enabled = false;
            this.fenetresToolStripMenuItem.Name = "fenetresToolStripMenuItem";
            this.fenetresToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.fenetresToolStripMenuItem.Text = "Fenetres";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatuslblDate,
            this.tsslblAction});
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatuslblDate
            // 
            this.toolStripStatuslblDate.Name = "toolStripStatuslblDate";
            this.toolStripStatuslblDate.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatuslblDate.Text = "t";
            // 
            // tsslblAction
            // 
            this.tsslblAction.Name = "tsslblAction";
            this.tsslblAction.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSidentifier,
            this.toolStripGererProjet});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSidentifier
            // 
            this.toolStripSidentifier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSidentifier.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSidentifier.Image")));
            this.toolStripSidentifier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSidentifier.Name = "toolStripSidentifier";
            this.toolStripSidentifier.Size = new System.Drawing.Size(67, 22);
            this.toolStripSidentifier.Text = "S\'identifier";
            this.toolStripSidentifier.Click += new System.EventHandler(this.toolStripSidentifier_Click);
            // 
            // toolStripGererProjet
            // 
            this.toolStripGererProjet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripGererProjet.Enabled = false;
            this.toolStripGererProjet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGererProjet.Image")));
            this.toolStripGererProjet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGererProjet.Name = "toolStripGererProjet";
            this.toolStripGererProjet.Size = new System.Drawing.Size(81, 22);
            this.toolStripGererProjet.Text = "Gerer projets ";
            this.toolStripGererProjet.Click += new System.EventHandler(this.toolStripGererProjet_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 662);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAccueil";
            this.Text = "Accueil";
            this.MdiChildActivate += new System.EventHandler(this.FrmAccueil_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionProjetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererProjetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionPrevisionnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prévisionnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fenetresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sidentifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripSidentifier;
        private System.Windows.Forms.ToolStripButton toolStripGererProjet;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatuslblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblAction;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}