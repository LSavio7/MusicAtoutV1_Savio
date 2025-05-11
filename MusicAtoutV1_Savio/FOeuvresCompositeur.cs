using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MusicAtoutV1_Savio.Models;

namespace MusicAtoutV1_Savio
{
    public partial class FOeuvresCompositeur : Form
    {
        private BindingSource bsStyle = new BindingSource();
        private BindingSource bsCompositeur = new BindingSource();
        private BindingSource bsOeuvre = new BindingSource();

        public FOeuvresCompositeur()
        {
            InitializeComponent();
        }

        private void FOeuvresCompositeur_Load(object sender, EventArgs e)
        {
            bsStyle.DataSource = ModelProjet.listeStyle();
            cboStyle.DisplayMember = "LibStyle";
            cboStyle.ValueMember = "IdStyle";
            cboStyle.DataSource = bsStyle;

            bsStyle.CurrentChanged += BsStyle_CurrentChanged;
            bsCompositeur.CurrentChanged += BsCompositeur_CurrentChanged;

            if (bsStyle.Count > 0)
                BsStyle_CurrentChanged(null, null);
        }

        private void BsStyle_CurrentChanged(object sender, EventArgs e)
        {
            if (bsStyle.Current is Style style)
            {
                txtDebut.Text = style.DateDebut?.ToString() ?? "";
                txtFin.Text = style.DateFin?.ToString() ?? "";

                var compositeurs = ModelProjet.Contexte.Compositeurs
                    .Where(c => c.IdStyle == style.IdStyle)
                    .Include(c => c.IdNationNavigation)
                    .Include(c => c.IdStyleNavigation)
                    .Include(c => c.Oeuvres)
                    .OrderBy(c => c.NomCompositeur)
                    .ToList();

                bsCompositeur.DataSource = compositeurs;
                dgvCompositeurs.DataSource = bsCompositeur;
            }
        }

        private void BsCompositeur_CurrentChanged(object sender, EventArgs e)
        {
            if (bsCompositeur.Current is Compositeur c)
            {
                NomCompo.Text = $"{c.PrenomCompositeur?.Trim()} {c.NomCompositeur?.Trim()}";
                txtDescription.Text = c.Remarque ?? "";
                lblNationalité.Text = c.IdNationNavigation?.LibNation ?? "";
                lbStyle.Text = c.IdStyleNavigation?.LibStyle ?? "";
                lblNaiss.Text = c.AnNais?.ToString() ?? "";
                lblDécès.Text = c.AnMort?.ToString() ?? "";

                var oeuvres = c.Oeuvres
                    .Select(o => new
                    {
                        o.TitreOeuvre,
                        o.AnComposition
                    })
                    .ToList();

                bsOeuvre.DataSource = oeuvres;
                dgvOeuvres.DataSource = bsOeuvre;
                dgvOeuvres.ReadOnly = true;
                dgvOeuvres.AllowUserToAddRows = false;
                dgvOeuvres.AllowUserToDeleteRows = false;
                dgvOeuvres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                if (dgvOeuvres.Columns.Contains("IdType"))
                    dgvOeuvres.Columns["IdType"].Visible = false;
                if (dgvOeuvres.Columns.Contains("IdCompositeur"))
                    dgvOeuvres.Columns["IdCompositeur"].Visible = false;

                if (dgvOeuvres.Columns.Contains("TitreOeuvre"))
                    dgvOeuvres.Columns["TitreOeuvre"].HeaderText = "Titre de l'œuvre";
                if (dgvOeuvres.Columns.Contains("AnComposition"))
                    dgvOeuvres.Columns["AnComposition"].HeaderText = "Année";
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
