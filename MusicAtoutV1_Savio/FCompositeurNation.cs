using System;
using System.Linq;
using System.Windows.Forms;
using MusicAtoutV1_Savio.Models;

namespace MusicAtoutV1_Savio
{
    public partial class FCompositeurNation : Form
    {
        public FCompositeurNation()
        {
            InitializeComponent();
        }

        private void FCompositeurNation_Load(object sender, EventArgs e)
        {
            var nationalites = ModelProjet.listeNationalite();

            cboNation.DisplayMember = "LibNation";
            cboNation.ValueMember = "IdNation";
            cboNation.DataSource = nationalites;

            cboNation.SelectedIndexChanged += cboNation_SelectedIndexChanged;

            if (nationalites.Count > 0)
                chargerCompositeurs((int)cboNation.SelectedValue);
           

        }

        private bool modeTous = false;


        private void cboNation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNation.SelectedValue != null)
                chargerCompositeurs((int)cboNation.SelectedValue);
        }

        private void chargerCompositeurs(int idNation)
        {
            var liste = ModelProjet.Contexte.Compositeurs
                .Where(c => c.IdNation == idNation)
                .ToList();

            dgvCompositeur.DataSource = liste;
            dgvCompositeur.AutoGenerateColumns = true;

            if (dgvCompositeur.Columns.Contains("NomCompositeur"))
                dgvCompositeur.Columns["NomCompositeur"].HeaderText = "NOM";
            if (dgvCompositeur.Columns.Contains("PrenomCompositeur"))
                dgvCompositeur.Columns["PrenomCompositeur"].HeaderText = "PRENOM";
            if (dgvCompositeur.Columns.Contains("AnNais"))
                dgvCompositeur.Columns["AnNais"].HeaderText = "Né le";
            if (dgvCompositeur.Columns.Contains("AnMort"))
                dgvCompositeur.Columns["AnMort"].HeaderText = "Mort le";
            if (dgvCompositeur.Columns.Contains("Remarque"))
                dgvCompositeur.Columns["Remarque"].HeaderText = "Informations";

            dgvCompositeur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void chargerTousCompositeurs()
        {
            var liste = ModelProjet.Contexte.Compositeurs.ToList();
            dgvCompositeur.DataSource = liste;
            dgvCompositeur.AutoGenerateColumns = true;

            if (dgvCompositeur.Columns.Contains("NomCompositeur"))
                dgvCompositeur.Columns["NomCompositeur"].HeaderText = "NOM";
            if (dgvCompositeur.Columns.Contains("PrenomCompositeur"))
                dgvCompositeur.Columns["PrenomCompositeur"].HeaderText = "PRENOM";
            if (dgvCompositeur.Columns.Contains("AnNais"))
                dgvCompositeur.Columns["AnNais"].HeaderText = "Né le";
            if (dgvCompositeur.Columns.Contains("AnMort"))
                dgvCompositeur.Columns["AnMort"].HeaderText = "Mort le";
            if (dgvCompositeur.Columns.Contains("Remarque"))
                dgvCompositeur.Columns["Remarque"].HeaderText = "Informations";

            dgvCompositeur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnToutesNationalites_Click(object sender, EventArgs e)
        {
            modeTous = !modeTous;

            if (modeTous)
            {
                btnToutesNationalites.Text = "Filtrer par nationalité";
                btnToutesNationalites.BackColor = Color.LightGreen;
                cboNation.Enabled = false;
                chargerTousCompositeurs();
            }
            else
            {
                btnToutesNationalites.Text = "Toutes les nationalités";
                btnToutesNationalites.BackColor = Color.IndianRed;
                cboNation.Enabled = true;

                if (cboNation.SelectedValue != null)
                    chargerCompositeurs((int)cboNation.SelectedValue);
            }
        }



        private void dgvCompositeur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pour plus tard : afficher les œuvres du compositeur sélectionné
        }
    }
}
