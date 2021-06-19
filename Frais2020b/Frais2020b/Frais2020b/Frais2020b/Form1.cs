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
  public partial class Form1 : Form
  {
    MySqlConnection sqlConnect;
    MySqlCommand sqlCommande;
    MySqlDataReader sqlLecteur;
    bool connecté = false;
    string nomUser="";
    int idUser;
    bool utilisateurConnecté = false;
    public Form1()
    {
      InitializeComponent();
      string st = "server=localhost;uid=root;password=root;database=frais2021";
      sqlConnect = new MySqlConnection(st);
      try
      {
        sqlConnect.Open();
        sqlCommande = sqlConnect.CreateCommand();
        connecté = true;
      }
      catch { }
    }
    private void Form1_Paint(object sender, PaintEventArgs e)
    {
       stsConnecté.BackColor = connecté ? Color.Orange : Color.Tomato;
      stsConnecté.Text = connecté ? "Serveur Disponible" : "Déconnecté";
      if (utilisateurConnecté)
      {
        stsConnecté.BackColor = Color.LawnGreen;
        stsConnecté.Text = nomUser;
        Form1.ActiveForm.Width++;
        Form1.ActiveForm.Width--;
      }
      mnuNotesDeFrais.Enabled = utilisateurConnecté;
    }

    private void mnuConnexion_Click(object sender, EventArgs e)
    {
      FrmConnexioncs Fiche = new FrmConnexioncs();
      if (Fiche.ShowDialog() == DialogResult.OK)
      {
        string pw = Fiche.getPw();
        string id = Fiche.getId();
        sqlCommande.CommandText = "select nom_adherent,id_adherent " +
          "from adherents " +
          "where email_adherent='" + id + "' and mdp_adherent='" + pw + "'";
        sqlLecteur = sqlCommande.ExecuteReader();
        if(sqlLecteur.HasRows)
        {
          sqlLecteur.Read();
          nomUser = sqlLecteur.GetString(0);
          idUser = sqlLecteur.GetInt32(1);
          utilisateurConnecté = true;
          stsUtilisateur.Text= nomUser;
        }
        else { utilisateurConnecté = false;
               MessageBox.Show("Votre email ou mot de passe est incorrect.");
                }
        sqlLecteur.Close();

            };
      Fiche.Dispose();
      Form1.ActiveForm.Width-= 1;
      Form1.ActiveForm.Refresh();
      Form1.ActiveForm.Width++;
    }

    private void mnuSaisieFrais_Click(object sender, EventArgs e)
    {
      FrmNoteFrais fiche = new FrmNoteFrais(sqlCommande,idUser);
      fiche.ShowDialog();
      fiche.Dispose();
    }

    private void mnuModifFrais_Click(object sender, EventArgs e)
    {
      sqlCommande.CommandText = "select * from notefrais LEFT JOIN detailfrais on detailfrais.idNote " +
        "where iddemandeur="+idUser+" "+
        "order by date";
      sqlLecteur = sqlCommande.ExecuteReader();
      DataTable dt = new DataTable();
      dt.Load(sqlLecteur);
      sqlLecteur.Close();
      dtgResul.DataSource = dt;
      dtgResul.Visible = true;
    }

    private void dtgResul_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      int idNote = int.Parse(dtgResul.Rows[e.RowIndex].Cells[0].Value.ToString());
      FrmNoteFrais fiche = new FrmNoteFrais(sqlCommande, idUser,idNote);
      fiche.ShowDialog();
      fiche.Dispose();
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnuInscription_Click(object sender, EventArgs e)
        {

            inscription fiche = new inscription(sqlCommande);
            fiche.ShowDialog();
            fiche.Dispose();
        }
    }
}
