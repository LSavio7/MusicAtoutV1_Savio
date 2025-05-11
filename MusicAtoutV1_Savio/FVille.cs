using System;
using System.Windows.Forms;
using MusicAtoutV1_Savio.Models;

namespace MusicAtoutV1_Savio
{
    public partial class FVille : Form
    {
        public FVille()
        {
            InitializeComponent();
            this.Text = "Gestion des villes";
            this.Load += FVille_Load;
        }

        private void FVille_Load(object? sender, EventArgs e)
        {
            // Liaison EF → BindingSource
            bsVille.DataSource = ModelProjet.listeVille();

            // BindingSource → DataGridView
            dgvVille.DataSource = bsVille;

            // Sécurité d’affichage
            dgvVille.ReadOnly = true;

            // Masquer les colonnes sauf 1 et 2 (index 0 et 1 = idVille et nomVille, 2 = departement)
            if (dgvVille.Columns.Count > 2)
            {
                for (int i = 0; i < dgvVille.Columns.Count; i++)
                {
                    dgvVille.Columns[i].Visible = (i == 1 || i == 2);
                }

                dgvVille.Columns[1].HeaderText = "Nom de la Ville";
                dgvVille.Columns[2].HeaderText = "N° Département";
            }
        }

        private void dgvVille_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tu peux ajouter du code ici plus tard si nécessaire
        }
    }
}
