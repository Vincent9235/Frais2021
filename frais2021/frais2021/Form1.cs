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

namespace frais2021
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlconnect;
        MySqlCommand sqlCommande;
        bool connecté = false;
        bool utilisateurConnecté = false;


        public Form1()
        {
            //Connexion à la BDD
            InitializeComponent();
            string st = "server=localhost;uid=frais2020;password=frais2020;database=frais2021";
            sqlconnect = new MySqlConnection(st);
            try
            {
                sqlconnect.Open();
                sqlCommande = sqlconnect.CreateCommand();
                connecté = true;
            }
            catch { }
        }
        private void Form1_paint (object sender, PaintEventArgs e)
        {

            stsConnecté.BackColor = connecté ? Color.LawnGreen : Color.Tomato;
            stsConnecté.Text = connecté ? "Connecté" : "Deconnecté";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
