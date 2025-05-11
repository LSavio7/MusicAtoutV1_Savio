using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicAtoutV1_Savio.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace MusicAtoutV1_Savio
{
    public partial class FAjoutModifCompositeur : Form
    {
        public FAjoutModifCompositeur()
        {
            InitializeComponent();
            btnCancel.Click += btnCancel_Click;
            btnOK.Click += btnOK_Click;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void FAjoutModifCompositeur_Load(object sender, EventArgs e)
        {
            cboNation.DataSource = ModelProjet.listeNationalite();
            cboNation.DisplayMember = "LibNation";
            cboNation.ValueMember = "IdNation";

            cboStyle.DataSource = ModelProjet.listeStyle();
            cboStyle.DisplayMember = "LibStyle";
            cboStyle.ValueMember = "IdStyle";

            if (ModelProjet.actionGestionCompositeur == 2 && ModelProjet.compositeurChoisi != null)
            {
                txtNom.Text = ModelProjet.compositeurChoisi.NomCompositeur;
                txtPrenom.Text = ModelProjet.compositeurChoisi.PrenomCompositeur;
                txtRemarque.Text = ModelProjet.compositeurChoisi.Remarque;
                txtAnNais.Text = ModelProjet.compositeurChoisi.AnNais.ToString();
                txtAnMort.Text = ModelProjet.compositeurChoisi.AnMort.ToString();

                cboNation.SelectedValue = ModelProjet.compositeurChoisi.IdNation;
                cboStyle.SelectedValue = ModelProjet.compositeurChoisi.IdStyle;
            }
        }

        private bool tests()
        {
            error1.Clear();
            bool vretour = true;

            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                error1.SetError(txtNom, "Nom obligatoire");
                vretour = false;
            }

            if (string.IsNullOrWhiteSpace(txtPrenom.Text))
            {
                error1.SetError(txtPrenom, "Prénom obligatoire");
                vretour = false;
            }

            if (string.IsNullOrWhiteSpace(txtRemarque.Text))
            {
                error1.SetError(txtRemarque, "Remarque obligatoire");
                vretour = false;
            }

            int anNais;
            if (!int.TryParse(txtAnNais.Text, out anNais) || anNais < 500 || anNais > DateTime.Now.Year - 15)
            {
                error1.SetError(txtAnNais, "Année de naissance invalide");
                vretour = false;
            }

            if (!string.IsNullOrWhiteSpace(txtAnMort.Text))
            {
                int anMort;
                if (!int.TryParse(txtAnMort.Text, out anMort) ||
                    anMort < anNais + 15 || anMort > anNais + 125 || anMort > DateTime.Now.Year)
                {
                    error1.SetError(txtAnMort, "Année de mort invalide");
                    vretour = false;
                }
            }

            return vretour;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!tests()) return;

            string nom = txtNom.Text.Trim();
            string prenom = txtPrenom.Text.Trim();
            string remarque = txtRemarque.Text.Trim();
            int anNais = int.Parse(txtAnNais.Text);
            int anMort = string.IsNullOrWhiteSpace(txtAnMort.Text) ? 0 : int.Parse(txtAnMort.Text);
            int idNation = (int)cboNation.SelectedValue;
            int idStyle = (int)cboStyle.SelectedValue;

            bool resultat = false;

            if (ModelProjet.actionGestionCompositeur == 1)
                resultat = ModelProjet.AjoutCompositeur(nom, prenom, remarque, anNais, anMort, idNation, idStyle);
            else
                resultat = ModelProjet.ModifCompositeur(nom, prenom, remarque, anNais, anMort, idNation, idStyle);

            if (resultat)
            {
                MessageBox.Show("Opération réussie !");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur !");
            }
        }

        
    }
}
