using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MusicAtoutV1_Savio.Models;

namespace MusicAtoutV1_Savio
{
    public partial class FGestionUtilisateur : Form
    {
        public FGestionUtilisateur()
        {
            InitializeComponent();
            btnAjout.Click += btnAjout_Click;
            btnReactivation.Click += btnReactivation_Click;
            btnDesactivation.Click += btnDesactivation_Click;
            dgvUtilisateur.CellFormatting += dgvUtilisateur_CellFormatting;
        }

        private void FGestionUtilisateur_Load(object sender, EventArgs e)
        {
            bsUtilisateur.DataSource = ModelProjet.listeUtilisateurs();
            dgvUtilisateur.DataSource = bsUtilisateur;

            dgvUtilisateur.Columns["IdUtilisateur"].HeaderText = "Identifiant";
            dgvUtilisateur.Columns["Actif"].HeaderText = "Actif";
            dgvUtilisateur.Columns["Nbessais"].HeaderText = "Nbessais";
            dgvUtilisateur.Columns["Droits"].HeaderText = "Droit";
            dgvUtilisateur.Columns["Passwd"].Visible = false;
        }

        private void dgvUtilisateur_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUtilisateur.Columns[e.ColumnIndex].Name == "Droits" && e.Value is int d)
            {
                e.Value = d == 1 ? "Utilisateur" : d == 2 ? "Admin" : "SuperAdmin";
                e.FormattingApplied = true;
            }

            if (dgvUtilisateur.Columns[e.ColumnIndex].Name == "Actif" && e.Value is bool a)
            {
                e.Value = a ? "✅" : "❌";
                e.FormattingApplied = true;
            }
        }

        private void btnReactivation_Click(object sender, EventArgs e)
        {
            if (bsUtilisateur.Current == null) return;
            var user = (Utilisateur)bsUtilisateur.Current;

            if (ModelProjet.UtilisateurConnecte.Droits < 2 || user.Droits > ModelProjet.UtilisateurConnecte.Droits)
            {
                MessageBox.Show("Vous n'avez pas le droit de réactiver cet utilisateur.");
                return;
            }

            user.Actif = true;
            user.Nbessais = 4;
            user.Passwd = "xx" + ModelProjet.GetMd5Hash(user.IdUtilisateur);

            ModelProjet.MonModel.SaveChanges();
            MessageBox.Show("Utilisateur réactivé !");
            FGestionUtilisateur_Load(null, null);
        }

        private void btnDesactivation_Click(object sender, EventArgs e)
        {
            if (bsUtilisateur.Current == null) return;
            var user = (Utilisateur)bsUtilisateur.Current;

            if (ModelProjet.UtilisateurConnecte.Droits != 3 || user.Droits >= 3)
            {
                MessageBox.Show("Vous n'avez pas le droit de désactiver cet utilisateur.");
                return;
            }

            user.Actif = false;
            ModelProjet.MonModel.SaveChanges();
            MessageBox.Show("Utilisateur désactivé !");
            FGestionUtilisateur_Load(null, null);
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            string id = Microsoft.VisualBasic.Interaction.InputBox("Identifiant du nouvel utilisateur ?", "Ajout utilisateur");

            if (string.IsNullOrWhiteSpace(id)) return;

            if (ModelProjet.MonModel.Utilisateurs.Any(u => u.IdUtilisateur == id))
            {
                MessageBox.Show("Cet identifiant existe déjà !");
                return;
            }

            Utilisateur nouveau = new Utilisateur
            {
                IdUtilisateur = id,
                Passwd = "xx" + ModelProjet.GetMd5Hash(id),
                Actif = true,
                Droits = 1,
                Nbessais = 4
            };

            ModelProjet.MonModel.Utilisateurs.Add(nouveau);
            ModelProjet.MonModel.SaveChanges();

            MessageBox.Show("Utilisateur ajouté !");
            FGestionUtilisateur_Load(null, null);
        }
    }
}
