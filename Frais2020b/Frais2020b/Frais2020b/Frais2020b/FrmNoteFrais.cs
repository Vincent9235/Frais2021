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
  public partial class FrmNoteFrais : Form
  {
    MySqlCommand sqlCommande;
    MySqlDataReader sqlLecteur;
    bool modif = false;
    int idFrais, idDemandeur, idLigue;
    string idMotif;
    bool réglée = false;
    DateTime dateReglement;
    decimal montant=0;
    string nomUser;
    int idUser,idNote;
    DataTable dt;
    decimal totalFrais = 0;

    private void label1_Click(object sender, EventArgs e)
    {

    }

    public FrmNoteFrais(MySqlCommand sqlC,int id)
    {
      InitializeComponent();
      sqlCommande = sqlC;
      idUser = id;
      sqlCommande.CommandText = "select nom_adherent from adherents " +
        "where id_adherent=" + id;

      nomUser = sqlCommande.ExecuteScalar().ToString();
            modif = false;
      completer();
      this.Text = "Note de frais saisie par " + nomUser;
      dt = new DataTable();
      dt.Columns.Add("Date");
      dt.Columns.Add("Motif");
      dt.Columns.Add("Categ");
      dt.Columns.Add("Montant");
      dt.Columns.Add("IDNOTE");
      dtgFrais.DataSource = dt;
      dtgFrais.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }

    public FrmNoteFrais(MySqlCommand sqlC, int id, int idN) : this(sqlC, id)
    {
      modif = true;
      idNote = idN;
      sqlCommande.CommandText = "select date,idLigue from notefrais "+
        "where idFrais="+idNote;
      sqlLecteur = sqlCommande.ExecuteReader();
      sqlLecteur.Read();
      dtpNote.Value = sqlLecteur.GetDateTime(0);
      idLigue = sqlLecteur.GetInt32(1);
      for(int i=0;i<cbxLigue.Items.Count;i++)
      {
        string st= cbxLigue.Items[i].ToString();
        int kdp =st .IndexOf(":");
        if (idLigue == int.Parse(st.Substring(0, kdp))) cbxLigue.SelectedIndex=i;
      }
      sqlLecteur.Close();
      sqlCommande.CommandText = "select idNote,concat(idMotif,':',nomMotif),objet,montant,date_frais " +
        "from detailfrais natural join motifs "+
        "where idFrais=" + idNote + " order by idFrais";
      sqlLecteur = sqlCommande.ExecuteReader();
      dt.Rows.Clear();
      totalFrais = 0;
      if(sqlLecteur.HasRows)
      {
        while(sqlLecteur.Read())
        {
          DataRow ligne = dt.NewRow();
          ligne[0] = sqlLecteur.GetDateTime(4);
          ligne[1] = sqlLecteur.GetString(2);
          ligne[2] = sqlLecteur.GetString(1);
          ligne[3] = sqlLecteur.GetDecimal(3);
          ligne[4] = sqlLecteur.GetString(0);
          totalFrais += decimal.Parse(ligne[3].ToString());
          dt.Rows.Add(ligne);
        }
        txbTotal.Value = totalFrais;
      }
      sqlLecteur.Close();
      dtgFrais.DataSource = dt;
    }


    private void FrmNoteFrais_Paint(object sender, PaintEventArgs e)
    {
      btnAjouter.Visible = txbMontant.Value > 0;
      btnValider.Visible = txbTotal.Value>0 && (sommeFrais() == txbTotal.Value);
    }

    private void txbMontant_ValueChanged(object sender, EventArgs e)
    {
            txbTotal.Value = sommeFrais();
            txbMontant.Parent.Parent.Refresh();
    }

    private void btnAjouter_Click(object sender, EventArgs e)
    {
      DataRow ligne = dt.NewRow();
      ligne[0] = dtpFrais.Value.Date.ToString().Substring(0,10);
      ligne[1] = txbObjet.Text;
      ligne[2] = cbxMotif.Text;
      ligne[3] = txbMontant.Value;
      dt.Rows.Add(ligne);
      txbMontant.Value = 0;
      txbObjet.Text = "";
      cbxMotif.Text = "";
    }

        private void FrmNoteFrais_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {               
                string idDetailFrais = dtgFrais.CurrentRow.Cells["IDNOTE"].Value.ToString();
                sqlCommande.CommandText = "delete from detailfrais where idNote=" + idDetailFrais;
                sqlCommande.ExecuteNonQuery();
                /*sqlCommande.CommandText = "delete from notefrais where idFrais=" + idNote;
                sqlCommande.ExecuteNonQuery();*/
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
        }

        private decimal sommeFrais()
    {
      decimal total = 0;
      for(int i=0;i<dt.Rows.Count;i++)
      {
        total += decimal.Parse(dt.Rows[i]["Montant"].ToString());
      }
      return total;
    }

    private void btnValider_Click(object sender, EventArgs e)
    {
      sqlCommande.CommandText = "start transaction";
      sqlCommande.ExecuteNonQuery();
      try
      {
        if(modif)
        {
          sqlCommande.CommandText = "delete from detailfrais where idNote=" + idNote;
          sqlCommande.ExecuteNonQuery();
        }
        string dateNote = dtpFrais.Value.ToString().Substring(0, 10);
        string dateNoteSql = dateNote.Substring(6, 4) + "-" +
          dateNote.Substring(3, 2) + "-" + dateNote.Substring(0, 2);
        int kdp = cbxLigue.Text.IndexOf(":");
        string idligue = "-1";
        if (kdp > 0) idligue = cbxLigue.Text.Substring(0, kdp);

        if (modif)
        {
          sqlCommande.CommandText = "update notefrais set date='" + dateNoteSql +
            "', idLigue=" + idLigue + " where idFrais=" + idNote;
          sqlCommande.ExecuteNonQuery();
        }
        else
        {
          sqlCommande.CommandText = "insert into notefrais (date,idDemandeur,idLigue) " +
          "values ('" + dateNoteSql + "'," + idUser + "," + idligue + ")";
          sqlCommande.ExecuteNonQuery();
          sqlCommande.CommandText = "select last_insert_id()";
          idNote = int.Parse(sqlCommande.ExecuteScalar().ToString());
        }
        for (int i = 0; i < dt.Rows.Count; i++)
        {
         string dejaCree = dt.Rows[i][4].ToString();
                    
                    if (string.IsNullOrEmpty(dejaCree))
                    {
                        string motif = dt.Rows[i][2].ToString();
                        kdp = motif.IndexOf(":");
                        string idMotif = motif.Substring(0, kdp);
                        string objet = dt.Rows[i][1].ToString();
                        string montant = dt.Rows[i][3].ToString().Replace(',', '.');
                        string dateFrais = dt.Rows[i][0].ToString().Substring(0, 10);
                        string dateFraisSql = dateFrais.Substring(6, 4) + "-" +
                           dateFrais.Substring(3, 2) + "-" + dateFrais.Substring(0, 2);
                        sqlCommande.CommandText = "insert into detailfrais " +
                          "(idFrais,idMotif,objet,montant,date_frais) values (" + idNote + ",'" +
                          idMotif + "','" + objet + "'," + montant + ",'" +
                          dateFraisSql + "')";
                        sqlCommande.ExecuteNonQuery();
                    }
        }
        sqlCommande.CommandText = "commit";
        sqlCommande.ExecuteNonQuery();
        string texte = "";
        if(modif)
        {
          texte = "La note de frais " + idNote + " a été modifiée";
        }
        else
        {
          texte = "Cette note de frais a été prise en compte " +
          "sous le numéro " + idNote;
        }
        MessageBox.Show(texte, "Gestion des notes de frais",
          MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch(Exception exc)
      {
        sqlCommande.CommandText = "rollback";
        sqlCommande.ExecuteNonQuery();
        MessageBox.Show(exc.Message, "Note de frais non saisie", MessageBoxButtons.OK,
          MessageBoxIcon.Error);
      }
    }


    private void completer()
    {
      sqlCommande.CommandText = "select concat(idMotif,':',nomMotif) from motifs " +
        "order by idMotif";
      sqlLecteur = sqlCommande.ExecuteReader();
      cbxMotif.Items.Clear();
      if(sqlLecteur.HasRows)
      {
        while(sqlLecteur.Read())
        {
          cbxMotif.Items.Add(sqlLecteur.GetString(0));
        }
      }
      sqlLecteur.Close();
      cbxMotif.Text = cbxMotif.Items[0].ToString();
      sqlCommande.CommandText = "select concat(idLigue,':',nom_ligue) from ligues " +
      "order by idLigue";
      sqlLecteur = sqlCommande.ExecuteReader();
      cbxLigue.Items.Clear();
      if (sqlLecteur.HasRows)
      {
        while (sqlLecteur.Read())
        {
          cbxLigue.Items.Add(sqlLecteur.GetString(0));
        }
      }
      sqlLecteur.Close();
      cbxLigue.Text = cbxLigue.Items[0].ToString();
    }

  }
}
