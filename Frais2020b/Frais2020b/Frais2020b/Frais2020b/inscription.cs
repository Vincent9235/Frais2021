using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace Frais2020b
{
    public partial class inscription : Form
    {
        MySqlCommand sqlCommande;
        MySqlDataReader sqlLecteur;
        string nom_adherent, prenom_adherent, adresse_adherent, ville_adherent, tel_adherent, cp_adherent,email_adherent,mdp_adherent,dateNaissance;
        int role_id;
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        

        public inscription(MySqlCommand sqlC)
        {
            InitializeComponent();
            sqlCommande = sqlC;
            string nom_adherent = textBox1.Text;
            prenom_adherent = textBox2.Text;
            adresse_adherent = textBox3.Text;
            cp_adherent = textBox4.Text;
            ville_adherent = textBox5.Text;
            tel_adherent = textBox6.Text;
            email_adherent = textBox7.Text;
            mdp_adherent = textBox8.Text;
            dateNaissance = dateTimePicker1.Text;
            role_id = 2;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        static string getCodedPassword(string pwClair)
        {
            SHA256 algo = SHA256.Create();
            byte[] tbClair = Encoding.UTF8.GetBytes(pwClair);
            byte[] code = algo.ComputeHash(tbClair);
            var sBuilder = new StringBuilder();
            for (int i = 0; i < code.Length; i++)
            {
                sBuilder.Append(code[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            string nom_adherent = textBox1.Text;
            string prenom_adherent = textBox2.Text;
            string adresse_adherent = textBox3.Text;
            string cp_adherent = textBox4.Text;
            string ville_adherent = textBox5.Text;
            string tel_adherent = textBox6.Text;
            string email_adherent = textBox7.Text;
            string mdp_adherent = textBox8.Text;
            dateNaissance = dateTimePicker1.Text.Substring(0, 10);
            string dateNaissanceSql = dateNaissance.Substring(6, 4) + "-" +
            dateNaissance.Substring(3, 2) + "-" + dateNaissance.Substring(0, 2);
            int role_id = 2;
            try { 
            sqlCommande.CommandText = "insert into adherents (nom_adherent,prenom_adherent," +
                "dateNaissance_adherent,adresse_adherent,cp_adherent,ville_adherent," +
                "tel_adherent,email_adherent,mdp_adherent,role_id) " +
            "values " +
            "('" +  nom_adherent+ "','"+ prenom_adherent + "','" + dateNaissanceSql + "','" 
            + adresse_adherent + "','" + cp_adherent + "','" + ville_adherent + "','" + tel_adherent + "','"
            + email_adherent + "','" + getCodedPassword(mdp_adherent) + "'," + role_id + ")";
            sqlCommande.ExecuteNonQuery();
                MessageBox.Show("Merci " + prenom_adherent +" " + nom_adherent + ". Vous êtes désormais inscrit"+dateNaissance+dateNaissanceSql);
                DialogResult = DialogResult.OK;
            }
            catch (Exception exc) { MessageBox.Show(exc.Message);
            }
        }
    }
}
