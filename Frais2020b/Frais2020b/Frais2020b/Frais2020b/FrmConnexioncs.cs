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

namespace Frais2020b
{
  public partial class FrmConnexioncs : Form
  {
    public FrmConnexioncs()
    {
      InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
    }

    private void btnValider_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.OK;
    }
    public string getId()
    {
      return txbId.Text;
    }

    public string getPw()
    {
      return sha256(txbPw.Text);
    }

    private static string sha256(string rawdata)
    {

      SHA256 sha256Hash = SHA256.Create();
      byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawdata));
      StringBuilder builder = new StringBuilder();
      for (int i = 0; i < bytes.Length; i++)
      {
        builder.Append(bytes[i].ToString("x2"));
      }
      return builder.ToString();
    }

        private void FrmConnexioncs_Load(object sender, EventArgs e)
        {

        }
    }
}
