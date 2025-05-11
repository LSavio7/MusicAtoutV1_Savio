using System;
using System.Linq;
using System.Windows.Forms;
using MusicAtoutV1_Savio.Models;

namespace MusicAtoutV1_Savio
{
    public partial class FTypeOeuvre : Form
    {
        public FTypeOeuvre()
        {
            InitializeComponent();
            this.Text = "Gestion des types d'œuvre";
            this.Load += FTypeOeuvre_Load;
        }

        private void FTypeOeuvre_Load(object? sender, EventArgs e)
        {
            bsTypeOeuvre.DataSource = ModelProjet.Contexte.Typeoeuvres.ToList();
            dgvTypeOeuvre.DataSource = bsTypeOeuvre;

            dgvTypeOeuvre.ReadOnly = true;
            dgvTypeOeuvre.AllowUserToAddRows = false;
            dgvTypeOeuvre.AllowUserToDeleteRows = false;

            if (dgvTypeOeuvre.Columns.Count > 1)
            {
                dgvTypeOeuvre.Columns["LibelleType"].HeaderText = "Type d'œuvre";
            }
        }

        private void dgvTypeOeuvre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optionnel
        }
    }
}
