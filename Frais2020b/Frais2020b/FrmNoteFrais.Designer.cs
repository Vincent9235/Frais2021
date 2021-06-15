
namespace Frais2020b
{
  partial class FrmNoteFrais
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.dtpFrais = new System.Windows.Forms.DateTimePicker();
      this.label6 = new System.Windows.Forms.Label();
      this.txbMontant = new System.Windows.Forms.NumericUpDown();
      this.label5 = new System.Windows.Forms.Label();
      this.txbObjet = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.cbxMotif = new System.Windows.Forms.ComboBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label7 = new System.Windows.Forms.Label();
      this.cbxLigue = new System.Windows.Forms.ComboBox();
      this.txbTotal = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.dtpNote = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.dtgFrais = new System.Windows.Forms.DataGridView();
      this.panel3 = new System.Windows.Forms.Panel();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.btnValider = new System.Windows.Forms.Button();
      this.btnAjouter = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txbMontant)).BeginInit();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txbTotal)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtgFrais)).BeginInit();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.Controls.Add(this.dtpFrais);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.txbMontant);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.txbObjet);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.cbxMotif);
      this.panel1.Location = new System.Drawing.Point(12, 70);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1005, 107);
      this.panel1.TabIndex = 4;
      // 
      // dtpFrais
      // 
      this.dtpFrais.Location = new System.Drawing.Point(571, 76);
      this.dtpFrais.Name = "dtpFrais";
      this.dtpFrais.Size = new System.Drawing.Size(260, 22);
      this.dtpFrais.TabIndex = 16;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(430, 79);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(125, 17);
      this.label6.TabIndex = 15;
      this.label6.Text = "Date des frais : ";
      // 
      // txbMontant
      // 
      this.txbMontant.DecimalPlaces = 2;
      this.txbMontant.Location = new System.Drawing.Point(692, 47);
      this.txbMontant.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.txbMontant.Name = "txbMontant";
      this.txbMontant.Size = new System.Drawing.Size(139, 22);
      this.txbMontant.TabIndex = 14;
      this.txbMontant.ThousandsSeparator = true;
      this.txbMontant.ValueChanged += new System.EventHandler(this.txbMontant_ValueChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(430, 47);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(134, 17);
      this.label5.TabIndex = 13;
      this.label5.Text = "Montant des frais";
      // 
      // txbObjet
      // 
      this.txbObjet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txbObjet.Location = new System.Drawing.Point(88, 7);
      this.txbObjet.Name = "txbObjet";
      this.txbObjet.Size = new System.Drawing.Size(893, 22);
      this.txbObjet.TabIndex = 10;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(24, 10);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(47, 17);
      this.label4.TabIndex = 9;
      this.label4.Text = "Objet";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(24, 44);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(58, 17);
      this.label3.TabIndex = 5;
      this.label3.Text = "Motif : ";
      // 
      // cbxMotif
      // 
      this.cbxMotif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxMotif.FormattingEnabled = true;
      this.cbxMotif.Location = new System.Drawing.Point(88, 44);
      this.cbxMotif.Name = "cbxMotif";
      this.cbxMotif.Size = new System.Drawing.Size(277, 24);
      this.cbxMotif.TabIndex = 6;
      // 
      // panel2
      // 
      this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel2.Controls.Add(this.label7);
      this.panel2.Controls.Add(this.cbxLigue);
      this.panel2.Controls.Add(this.txbTotal);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Controls.Add(this.dtpNote);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Location = new System.Drawing.Point(12, 12);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1005, 52);
      this.panel2.TabIndex = 5;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(742, 19);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(63, 17);
      this.label7.TabIndex = 13;
      this.label7.Text = "Ligue : ";
      // 
      // cbxLigue
      // 
      this.cbxLigue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cbxLigue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxLigue.FormattingEnabled = true;
      this.cbxLigue.Location = new System.Drawing.Point(806, 19);
      this.cbxLigue.Name = "cbxLigue";
      this.cbxLigue.Size = new System.Drawing.Size(175, 24);
      this.cbxLigue.TabIndex = 14;
      // 
      // txbTotal
      // 
      this.txbTotal.DecimalPlaces = 2;
      this.txbTotal.Location = new System.Drawing.Point(584, 19);
      this.txbTotal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.txbTotal.Name = "txbTotal";
      this.txbTotal.Size = new System.Drawing.Size(139, 22);
      this.txbTotal.TabIndex = 12;
      this.txbTotal.ThousandsSeparator = true;
      this.txbTotal.ValueChanged += new System.EventHandler(this.txbMontant_ValueChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(336, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(256, 17);
      this.label1.TabIndex = 11;
      this.label1.Text = "Montant total de la note de frais : ";
      // 
      // dtpNote
      // 
      this.dtpNote.Location = new System.Drawing.Point(165, 16);
      this.dtpNote.Name = "dtpNote";
      this.dtpNote.Size = new System.Drawing.Size(152, 22);
      this.dtpNote.TabIndex = 10;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(24, 19);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(135, 17);
      this.label2.TabIndex = 9;
      this.label2.Text = "Date de la note : ";
      // 
      // dtgFrais
      // 
      this.dtgFrais.AllowUserToAddRows = false;
      this.dtgFrais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dtgFrais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.dtgFrais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgFrais.Location = new System.Drawing.Point(12, 246);
      this.dtgFrais.Name = "dtgFrais";
      this.dtgFrais.RowHeadersWidth = 51;
      this.dtgFrais.RowTemplate.Height = 24;
      this.dtgFrais.Size = new System.Drawing.Size(1005, 192);
      this.dtgFrais.TabIndex = 6;
      // 
      // panel3
      // 
      this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel3.Controls.Add(this.button4);
      this.panel3.Controls.Add(this.button3);
      this.panel3.Controls.Add(this.btnValider);
      this.panel3.Controls.Add(this.btnAjouter);
      this.panel3.Location = new System.Drawing.Point(12, 194);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(1005, 46);
      this.panel3.TabIndex = 7;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(325, 12);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(75, 23);
      this.button4.TabIndex = 3;
      this.button4.Text = "Supprimer";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(219, 12);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 2;
      this.button3.Text = "Modifier";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // btnValider
      // 
      this.btnValider.Location = new System.Drawing.Point(109, 12);
      this.btnValider.Name = "btnValider";
      this.btnValider.Size = new System.Drawing.Size(75, 23);
      this.btnValider.TabIndex = 1;
      this.btnValider.Text = "Valider";
      this.btnValider.UseVisualStyleBackColor = true;
      this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
      // 
      // btnAjouter
      // 
      this.btnAjouter.Location = new System.Drawing.Point(7, 12);
      this.btnAjouter.Name = "btnAjouter";
      this.btnAjouter.Size = new System.Drawing.Size(75, 23);
      this.btnAjouter.TabIndex = 0;
      this.btnAjouter.Text = "Ajouter";
      this.btnAjouter.UseVisualStyleBackColor = true;
      this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
      // 
      // FrmNoteFrais
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1029, 450);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.dtgFrais);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "FrmNoteFrais";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "FrmNoteFrais";
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmNoteFrais_Paint);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txbMontant)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txbTotal)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtgFrais)).EndInit();
      this.panel3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cbxMotif;
    private System.Windows.Forms.TextBox txbObjet;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.NumericUpDown txbTotal;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker dtpNote;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView dtgFrais;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button btnValider;
    private System.Windows.Forms.Button btnAjouter;
    private System.Windows.Forms.NumericUpDown txbMontant;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.DateTimePicker dtpFrais;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ComboBox cbxLigue;
  }
}