using System;
using System.Linq;
using System.Windows.Forms;
using MusicAtoutV1_Savio.Models;

namespace MusicAtoutV1_Savio
{
    public partial class FBatiment : Form
    {
        public FBatiment()
        {
            InitializeComponent();
            this.Text = "Gestion des bâtiments";
            this.Load += FBatiment_Load;
        }

        private void FBatiment_Load(object? sender, EventArgs e)
        {
            bsBatiment.DataSource = ModelProjet.Contexte.Batiments.ToList();
            dgvBatiment.DataSource = bsBatiment;

            dgvBatiment.ReadOnly = true;
            dgvBatiment.AllowUserToAddRows = false;
            dgvBatiment.AllowUserToDeleteRows = false;

            if (dgvBatiment.Columns.Count > 2)
            {
                dgvBatiment.Columns["NomBati"].HeaderText = "Nom du bâtiment";
                dgvBatiment.Columns["AnConstruction"].HeaderText = "Année de construction";
                dgvBatiment.Columns["Responsable"].HeaderText = "Responsable";
            }
        }

        private void dgvBatiment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Gérer clic si besoin
        }
    }
}
