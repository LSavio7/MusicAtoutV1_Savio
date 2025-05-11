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
    public partial class FGestionCompositeur : Form
    {
        public FGestionCompositeur()
        {
            InitializeComponent();
            btnAjouter.Click += btnAjouter_Click;
            btnModifier.Click += btnModifier_Click;
            btnSupprimer.Click += btnSupprimer_Click;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ModelProjet.actionGestionCompositeur = 1;
            ModelProjet.compositeurChoisi = null;

            FAjoutModifCompositeur f = new FAjoutModifCompositeur();
            f.ShowDialog();

            FGestionCompositeur_Load(null, null);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (bsCompositeur.Current == null)
                return;

            Type type = bsCompositeur.Current.GetType();
            int id = (int)type.GetProperty("IdCompositeur").GetValue(bsCompositeur.Current, null);

            ModelProjet.actionGestionCompositeur = 2;
            ModelProjet.compositeurChoisi = ModelProjet.MonModel.Compositeurs.Find(id);

            FAjoutModifCompositeur f = new FAjoutModifCompositeur();
            f.ShowDialog();

            FGestionCompositeur_Load(null, null);
        }

        private void btnSupprimer_Click(object sender, EventArgs e) 
        {
            if (bsCompositeur.Current == null)
                return;

            Type type = bsCompositeur.Current.GetType();
            int id = (int)type.GetProperty("IdCompositeur").GetValue(bsCompositeur.Current, null);

            ModelProjet.compositeurChoisi = ModelProjet.MonModel.Compositeurs.Find(id);

            if (MessageBox.Show("Supprimer le compositeur : " +
                ModelProjet.compositeurChoisi.PrenomCompositeur.Trim() + " " +
                ModelProjet.compositeurChoisi.NomCompositeur.Trim() + " ?",
                "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (ModelProjet.SuppCompositeur())
                    MessageBox.Show("Suppression réussie.");
                else
                    MessageBox.Show("Erreur lors de la suppression.");

                FGestionCompositeur_Load(null, null);
            }

        }


        private void dgvCompositeur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FGestionCompositeur_Load(object sender, EventArgs e)
        {
            bsCompositeur.DataSource = ModelProjet.MonModel.Compositeurs
                .Select(x => new
                {
                    x.NomCompositeur,
                    x.PrenomCompositeur,
                    x.IdStyleNavigation.LibStyle,
                    x.AnNais,
                    x.AnMort,
                    x.Remarque,
                    x.IdCompositeur
                }).OrderBy(x => x.NomCompositeur).ToList();

            dgvCompositeur.DataSource = bsCompositeur;

            dgvCompositeur.Columns[0].HeaderText = "Nom";
            dgvCompositeur.Columns[1].HeaderText = "Prénom";
            dgvCompositeur.Columns[2].HeaderText = "Style";
            dgvCompositeur.Columns[3].HeaderText = "Né en";
            dgvCompositeur.Columns[4].HeaderText = "Mort en";
            dgvCompositeur.Columns[5].HeaderText = "Remarques";
            dgvCompositeur.Columns[6].Visible = false;
        }

        
    }
}
