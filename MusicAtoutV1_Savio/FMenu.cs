using System;
using System.Windows.Forms;

namespace MusicAtoutV1_Savio
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
            btnChangerMdp.Click += btnChangerMdp_Click;
            btnDeconnexion.Click += btnDeconnexion_Click;



        }

        private void FMenu_Load(object sender, EventArgs e)
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

            // Masquer le menu si l'utilisateur n'est pas admin
            if (ModelProjet.UtilisateurConnecte.Droits < 3)
            {
                gestionUtilisateursToolStripMenuItem.Visible = false;
            }


        }

        private void villesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FVille().ShowDialog();
        }

        private void sallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FSalle().ShowDialog();
        }

        private void batimentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FBatiment().ShowDialog();
        }

        private void typesDœuvreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FTypeOeuvre().ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Optionnel
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void parNationalitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click détecté sur Par Nationalité !");
            new FCompositeurNation().ShowDialog();
        }

        private void parStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FCompositeurStyle().ShowDialog();
        }

        private void lesOeuvresDunCompositeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FOeuvresCompositeur().ShowDialog();
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FGestionCompositeur f = new FGestionCompositeur();
            f.Show();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Threading.Thread t = new System.Threading.Thread(() =>
            {
                Application.Run(new FConnexion());
            });
            t.Start();
            this.Close();
        }

        private void btnChangerMdp_Click(object sender, EventArgs e)
        {
            FChangeMdp f = new FChangeMdp();
            f.ShowDialog();
        }

        private void gestionDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FGestionUtilisateur().ShowDialog();
        }
    }
}
