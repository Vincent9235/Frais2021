
namespace Frais2020b
{
  partial class Form1
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
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.stsConnecté = new System.Windows.Forms.ToolStripStatusLabel();
      this.stsUtilisateur = new System.Windows.Forms.ToolStripStatusLabel();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuConnexion = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuNotesDeFrais = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuSaisieFrais = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuModifFrais = new System.Windows.Forms.ToolStripMenuItem();
      this.dtgResul = new System.Windows.Forms.DataGridView();
      this.statusStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgResul)).BeginInit();
      this.SuspendLayout();
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsConnecté,
            this.stsUtilisateur});
      this.statusStrip1.Location = new System.Drawing.Point(0, 317);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(952, 26);
      this.statusStrip1.TabIndex = 0;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // stsConnecté
      // 
      this.stsConnecté.Name = "stsConnecté";
      this.stsConnecté.Size = new System.Drawing.Size(151, 20);
      this.stsConnecté.Text = "toolStripStatusLabel1";
      // 
      // stsUtilisateur
      // 
      this.stsUtilisateur.Name = "stsUtilisateur";
      this.stsUtilisateur.Size = new System.Drawing.Size(13, 20);
      this.stsUtilisateur.Text = " ";
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.mnuNotesDeFrais});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(952, 28);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fichierToolStripMenuItem
      // 
      this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConnexion});
      this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
      this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
      this.fichierToolStripMenuItem.Text = "Fichier";
      // 
      // mnuConnexion
      // 
      this.mnuConnexion.Name = "mnuConnexion";
      this.mnuConnexion.Size = new System.Drawing.Size(162, 26);
      this.mnuConnexion.Text = "Connexion";
      this.mnuConnexion.Click += new System.EventHandler(this.mnuConnexion_Click);
      // 
      // mnuNotesDeFrais
      // 
      this.mnuNotesDeFrais.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSaisieFrais,
            this.mnuModifFrais});
      this.mnuNotesDeFrais.Name = "mnuNotesDeFrais";
      this.mnuNotesDeFrais.Size = new System.Drawing.Size(115, 26);
      this.mnuNotesDeFrais.Text = "Notes de frais";
      // 
      // mnuSaisieFrais
      // 
      this.mnuSaisieFrais.Name = "mnuSaisieFrais";
      this.mnuSaisieFrais.Size = new System.Drawing.Size(264, 26);
      this.mnuSaisieFrais.Text = "Saisir une note de frais";
      this.mnuSaisieFrais.Click += new System.EventHandler(this.mnuSaisieFrais_Click);
      // 
      // mnuModifFrais
      // 
      this.mnuModifFrais.Name = "mnuModifFrais";
      this.mnuModifFrais.Size = new System.Drawing.Size(264, 26);
      this.mnuModifFrais.Text = "Modifier une note de frais";
      this.mnuModifFrais.Click += new System.EventHandler(this.mnuModifFrais_Click);
      // 
      // dtgResul
      // 
      this.dtgResul.AllowUserToAddRows = false;
      this.dtgResul.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dtgResul.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dtgResul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgResul.Location = new System.Drawing.Point(12, 52);
      this.dtgResul.Name = "dtgResul";
      this.dtgResul.RowHeadersWidth = 51;
      this.dtgResul.RowTemplate.Height = 24;
      this.dtgResul.Size = new System.Drawing.Size(928, 262);
      this.dtgResul.TabIndex = 2;
      this.dtgResul.Visible = false;
      this.dtgResul.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgResul_RowHeaderMouseClick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(952, 343);
      this.Controls.Add(this.dtgResul);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgResul)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel stsConnecté;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem mnuConnexion;
    private System.Windows.Forms.ToolStripStatusLabel stsUtilisateur;
    private System.Windows.Forms.ToolStripMenuItem mnuNotesDeFrais;
    private System.Windows.Forms.ToolStripMenuItem mnuSaisieFrais;
    private System.Windows.Forms.ToolStripMenuItem mnuModifFrais;
    private System.Windows.Forms.DataGridView dtgResul;
  }
}

