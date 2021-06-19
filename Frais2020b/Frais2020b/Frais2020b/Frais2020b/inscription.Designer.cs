namespace Frais2020b
{
    partial class inscription
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.date_naissance = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.adresse = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CP = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ville = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 0;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(156, 21);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(85, 17);
            this.nom.TabIndex = 1;
            this.nom.Text = "Votre nom : ";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(156, 71);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(106, 17);
            this.prenom.TabIndex = 2;
            this.prenom.Text = "Votre prénom : ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 22);
            this.textBox2.TabIndex = 3;
            // 
            // date_naissance
            // 
            this.date_naissance.AutoSize = true;
            this.date_naissance.Location = new System.Drawing.Point(156, 114);
            this.date_naissance.Name = "date_naissance";
            this.date_naissance.Size = new System.Drawing.Size(174, 17);
            this.date_naissance.TabIndex = 4;
            this.date_naissance.Text = "Votre date de naissance : ";
            this.date_naissance.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(336, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // adresse
            // 
            this.adresse.AutoSize = true;
            this.adresse.Location = new System.Drawing.Point(156, 166);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(109, 17);
            this.adresse.TabIndex = 6;
            this.adresse.Text = "Votre adresse : ";
            this.adresse.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(271, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 22);
            this.textBox3.TabIndex = 7;
            // 
            // CP
            // 
            this.CP.AutoSize = true;
            this.CP.Location = new System.Drawing.Point(156, 217);
            this.CP.Name = "CP";
            this.CP.Size = new System.Drawing.Size(131, 17);
            this.CP.TabIndex = 8;
            this.CP.Text = "Votre code postal : ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(281, 214);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(154, 22);
            this.textBox4.TabIndex = 9;
            // 
            // ville
            // 
            this.ville.AutoSize = true;
            this.ville.Location = new System.Drawing.Point(156, 266);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(82, 17);
            this.ville.TabIndex = 10;
            this.ville.Text = "Votre ville : ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(244, 263);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(154, 22);
            this.textBox5.TabIndex = 11;
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Location = new System.Drawing.Point(159, 307);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(121, 17);
            this.tel.TabIndex = 12;
            this.tel.Text = "Votre téléphone : ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(278, 307);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(154, 22);
            this.textBox6.TabIndex = 13;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(159, 348);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(91, 17);
            this.email.TabIndex = 14;
            this.email.Text = "Votre email : ";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(244, 348);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(154, 22);
            this.textBox7.TabIndex = 15;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(281, 400);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(154, 22);
            this.textBox8.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Votre mot de passe : ";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(511, 398);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(129, 23);
            this.btnValider.TabIndex = 18;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(680, 398);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(92, 23);
            this.btnAnnuler.TabIndex = 19;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.email);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.ville);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.CP);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.date_naissance);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.textBox1);
            this.Name = "inscription";
            this.Text = "inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label date_naissance;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label adresse;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label CP;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label ville;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}