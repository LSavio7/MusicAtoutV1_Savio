using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicAtoutV1_Savio
{
    public partial class FChangeMdp : Form
    {
        public FChangeMdp()
        {
            InitializeComponent();
        }

        private void txtAncien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            error1.Clear();
            bool ok = true;

            if (string.IsNullOrWhiteSpace(txtAncien.Text))
            {
                error1.SetError(txtAncien, "Ancien mot de passe obligatoire");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtNouveau.Text) || txtNouveau.Text.Length < 6)
            {
                error1.SetError(txtNouveau, "Nouveau mot de passe trop court (min. 6)");
                ok = false;
            }

            if (txtNouveau.Text != txtConfirm.Text)
            {
                error1.SetError(txtConfirm, "Confirmation différente");
                ok = false;
            }

            // Vérifie l’ancien mot de passe
            string hashAncien = "xx" + GetMd5Hash(txtAncien.Text);
            if (ModelProjet.UtilisateurConnecte.Passwd != hashAncien)
            {
                error1.SetError(txtAncien, "Ancien mot de passe incorrect");
                ok = false;
            }

            if (!ok) return;

            // Mise à jour du mot de passe
            ModelProjet.UtilisateurConnecte.Passwd = "xx" + GetMd5Hash(txtNouveau.Text);
            ModelProjet.UtilisateurConnecte.Nbessais = 0;

            ModelProjet.MonModel.SaveChanges();

            MessageBox.Show("Mot de passe modifié !");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private string GetMd5Hash(string passwd)
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(passwd);
            byte[] hash = MD5.Create().ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
                sb.Append(b.ToString("x2"));
            return sb.ToString();
        }


    }
}
