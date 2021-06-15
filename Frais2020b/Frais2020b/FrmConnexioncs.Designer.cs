
namespace Frais2020b
{
  partial class FrmConnexioncs
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbPw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnValider);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 64);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Location = new System.Drawing.Point(541, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.LawnGreen;
            this.btnValider.Location = new System.Drawing.Point(21, 20);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 31);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Votre identifiant : ";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(163, 16);
            this.txbId.MaxLength = 25;
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(299, 22);
            this.txbId.TabIndex = 1;
            // 
            // txbPw
            // 
            this.txbPw.Location = new System.Drawing.Point(188, 62);
            this.txbPw.Name = "txbPw";
            this.txbPw.PasswordChar = '*';
            this.txbPw.Size = new System.Drawing.Size(299, 22);
            this.txbPw.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Votre mot de passe : ";
            // 
            // FrmConnexioncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 176);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPw);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConnexioncs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmConnexioncs";
            this.Load += new System.EventHandler(this.FrmConnexioncs_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button btnValider;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txbId;
    private System.Windows.Forms.TextBox txbPw;
    private System.Windows.Forms.Label label2;
  }
}