using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicAtoutV1_Savio
{
    public partial class FSalle : Form
    {
        public FSalle()
        {
            InitializeComponent();
            this.Text = "Gestion des salles";
            this.Load += FSalle_Load;
        }
        private void FSalle_Load(object? sender, EventArgs e)
        {
            // Charger les données des salles via EF Core
            bsSalle.DataSource = ModelProjet.Contexte.Salles.ToList();
            dgvSalle.DataSource = bsSalle;

            // Verrouiller les actions utilisateur
            dgvSalle.ReadOnly = true;
            dgvSalle.AllowUserToAddRows = false;
            dgvSalle.AllowUserToDeleteRows = false;

            // Personnalisation de l’affichage si les colonnes existent
            if (dgvSalle.Columns.Count > 2)
            {
                dgvSalle.Columns["NomSalle"].HeaderText = "Nom de la salle";
                dgvSalle.Columns["Capacite"].HeaderText = "Capacité";
                dgvSalle.Columns["Superficie"].HeaderText = "Superficie";
            }
        }

        private void dgvSalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
