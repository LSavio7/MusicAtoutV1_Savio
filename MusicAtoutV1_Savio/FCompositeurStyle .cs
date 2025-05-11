using System;
using System.Linq;
using System.Windows.Forms;
using MusicAtoutV1_Savio.Models;

namespace MusicAtoutV1_Savio
{
    public partial class FCompositeurStyle : Form
    {
        public FCompositeurStyle()
        {
            InitializeComponent();
        }

        private void FCompositeurStyle_Load(object sender, EventArgs e)
        {
            bsStyle.DataSource = ModelProjet.listeStyle();
            cboStyle.DisplayMember = "LibStyle";
            cboStyle.ValueMember = "IdStyle";
            cboStyle.DataSource = bsStyle;

            bsStyle.CurrentChanged += BsStyle_CurrentChanged;

            dgvCompositeur.AutoGenerateColumns = true;

            if (bsStyle.Count > 0)
                BsStyle_CurrentChanged(null, null);
        }

        private void BsStyle_CurrentChanged(object? sender, EventArgs e)
        {
            if (bsStyle.Current is Style style)
            {


                txtDebut.Text = style.DateDebut?.ToString() ?? "";
                txtFin.Text = style.DateFin?.ToString() ?? "";



                var liste = ModelProjet.Contexte.Compositeurs
                .Where(c => c.IdStyle == style.IdStyle)
                       .Select(c => new
                       {
                           c.NomCompositeur,
                           c.PrenomCompositeur,
                           c.Remarque,
                           c.AnNais,
                           c.AnMort
                       })
                    .OrderBy(c => c.NomCompositeur)
                    .ToList();
                bsCompositeur.DataSource = liste;
                dgvCompositeur.DataSource = bsCompositeur;
                dgvCompositeur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void dgvCompositeur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
