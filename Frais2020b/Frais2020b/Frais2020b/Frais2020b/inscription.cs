using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Frais2020b
{
    public partial class inscription : Form
    {

        MySqlCommand sqlCommande;
        MySqlDataReader sqlLecteur;
        string nom_adherent, prenom_adherent, adresse_adherent, ville_adherent, tel_adherent, cp_adherent,email_adherent,mdp_adherent,date;
        int role_id = 2;

        public inscription(MySqlCommand sqlCommande)
        {
            InitializeComponent();
            nom_adherent = textBox1.Text;
            prenom_adherent = textBox2.Text;
            adresse_adherent = textBox3.Text;
            cp_adherent = textBox4.Text;
            ville_adherent = textBox5.Text;
            tel_adherent = textBox6.Text;
            email_adherent = textBox7.Text;
            mdp_adherent = textBox8.Text;
            date = dateTimePicker1.Text;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            sqlCommande.CommandText = "insert into adherents (nom_adherent,prenom_adherent," +
                "dateNaissance_adherent,adresse_adherent,cp_adherent,ville_adherent," +
                "tel_adherent,email_adherent,mdp_adherent,role_id) " +
            "values " +
            "('" + ","+ nom_adherent+ ","+ prenom_adherent + "," + date + "'," 
            + adresse_adherent + "," + ville_adherent + "," + tel_adherent + "," 
            + email_adherent +"," + mdp_adherent +","+ role_id +  ")";
            sqlCommande.ExecuteNonQuery();
        }
    }
}
