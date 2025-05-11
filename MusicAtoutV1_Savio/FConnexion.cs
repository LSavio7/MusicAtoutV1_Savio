using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicAtoutV1_Savio
{
    public partial class FConnexion : Form
    {
        public FConnexion()
        {
            InitializeComponent();
            btnOK.Click += btnOK_Click;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FConnexion_Load(object sender, EventArgs e)
        {
            string imagePath = Application.StartupPath + @"\folle-journee.jpg";
            if (System.IO.File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Image non trouvée : " + imagePath);
            }


        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string mdp = txtMdp.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(mdp))
            {
                MessageBox.Show("Veuillez saisir un identifiant et un mot de passe.");
                return;
            }

            string message = ModelProjet.ValidConnexion(login, mdp);

            if (ModelProjet.ConnexionValide)
            {
                MessageBox.Show("Connexion réussie !");

                // Ouvre le menu principal dans un nouveau thread
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                t.Start();

                this.Close(); // ferme la fenêtre de connexion
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        public static void ThreadProc()
        {
            Application.Run(new FMenu());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
