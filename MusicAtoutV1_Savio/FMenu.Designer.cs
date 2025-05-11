using System.Drawing;
using System.Windows.Forms;

namespace MusicAtoutV1_Savio
{
    partial class FMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            listesToolStripMenuItem = new ToolStripMenuItem();
            villesToolStripMenuItem = new ToolStripMenuItem();
            sallesToolStripMenuItem = new ToolStripMenuItem();
            batimentsToolStripMenuItem = new ToolStripMenuItem();
            typesDœuvreToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            cOMPOSITEURSToolStripMenuItem = new ToolStripMenuItem();
            parNationalitéToolStripMenuItem = new ToolStripMenuItem();
            parStyleToolStripMenuItem = new ToolStripMenuItem();
            lesOeuvresDunCompositeurToolStripMenuItem = new ToolStripMenuItem();
            gestionToolStripMenuItem = new ToolStripMenuItem();
            administrationToolStripMenuItem = new ToolStripMenuItem();
            gestionUtilisateursToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            btnDeconnexion = new Button();
            btnChangerMdp = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { listesToolStripMenuItem, cOMPOSITEURSToolStripMenuItem, administrationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1066, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // listesToolStripMenuItem
            // 
            listesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { villesToolStripMenuItem, sallesToolStripMenuItem, batimentsToolStripMenuItem, typesDœuvreToolStripMenuItem, quitterToolStripMenuItem });
            listesToolStripMenuItem.Name = "listesToolStripMenuItem";
            listesToolStripMenuItem.Size = new Size(71, 29);
            listesToolStripMenuItem.Text = "Listes";
            // 
            // villesToolStripMenuItem
            // 
            villesToolStripMenuItem.Name = "villesToolStripMenuItem";
            villesToolStripMenuItem.Size = new Size(230, 34);
            villesToolStripMenuItem.Text = "Villes";
            villesToolStripMenuItem.Click += villesToolStripMenuItem_Click;
            // 
            // sallesToolStripMenuItem
            // 
            sallesToolStripMenuItem.Name = "sallesToolStripMenuItem";
            sallesToolStripMenuItem.Size = new Size(230, 34);
            sallesToolStripMenuItem.Text = "Salles";
            sallesToolStripMenuItem.Click += sallesToolStripMenuItem_Click;
            // 
            // batimentsToolStripMenuItem
            // 
            batimentsToolStripMenuItem.Name = "batimentsToolStripMenuItem";
            batimentsToolStripMenuItem.Size = new Size(230, 34);
            batimentsToolStripMenuItem.Text = "Batiments";
            batimentsToolStripMenuItem.Click += batimentsToolStripMenuItem_Click;
            // 
            // typesDœuvreToolStripMenuItem
            // 
            typesDœuvreToolStripMenuItem.Name = "typesDœuvreToolStripMenuItem";
            typesDœuvreToolStripMenuItem.Size = new Size(230, 34);
            typesDœuvreToolStripMenuItem.Text = "Types d’œuvre";
            typesDœuvreToolStripMenuItem.Click += typesDœuvreToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(230, 34);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // cOMPOSITEURSToolStripMenuItem
            // 
            cOMPOSITEURSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { parNationalitéToolStripMenuItem, parStyleToolStripMenuItem, lesOeuvresDunCompositeurToolStripMenuItem, gestionToolStripMenuItem });
            cOMPOSITEURSToolStripMenuItem.Name = "cOMPOSITEURSToolStripMenuItem";
            cOMPOSITEURSToolStripMenuItem.Size = new Size(159, 29);
            cOMPOSITEURSToolStripMenuItem.Text = "COMPOSITEURS";
            // 
            // parNationalitéToolStripMenuItem
            // 
            parNationalitéToolStripMenuItem.Name = "parNationalitéToolStripMenuItem";
            parNationalitéToolStripMenuItem.Size = new Size(351, 34);
            parNationalitéToolStripMenuItem.Text = "Par Nationalité";
            parNationalitéToolStripMenuItem.Click += parNationalitéToolStripMenuItem_Click;
            // 
            // parStyleToolStripMenuItem
            // 
            parStyleToolStripMenuItem.Name = "parStyleToolStripMenuItem";
            parStyleToolStripMenuItem.Size = new Size(351, 34);
            parStyleToolStripMenuItem.Text = "Par Style";
            parStyleToolStripMenuItem.Click += parStyleToolStripMenuItem_Click;
            // 
            // lesOeuvresDunCompositeurToolStripMenuItem
            // 
            lesOeuvresDunCompositeurToolStripMenuItem.Name = "lesOeuvresDunCompositeurToolStripMenuItem";
            lesOeuvresDunCompositeurToolStripMenuItem.Size = new Size(351, 34);
            lesOeuvresDunCompositeurToolStripMenuItem.Text = "Les oeuvres d'un compositeur";
            lesOeuvresDunCompositeurToolStripMenuItem.Click += lesOeuvresDunCompositeurToolStripMenuItem_Click;
            // 
            // gestionToolStripMenuItem
            // 
            gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            gestionToolStripMenuItem.Size = new Size(351, 34);
            gestionToolStripMenuItem.Text = "Gestion";
            gestionToolStripMenuItem.Click += gestionToolStripMenuItem_Click;
            // 
            // administrationToolStripMenuItem
            // 
            administrationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionUtilisateursToolStripMenuItem });
            administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            administrationToolStripMenuItem.Size = new Size(145, 29);
            administrationToolStripMenuItem.Text = "Administration";
            // 
            // gestionUtilisateursToolStripMenuItem
            // 
            gestionUtilisateursToolStripMenuItem.Name = "gestionUtilisateursToolStripMenuItem";
            gestionUtilisateursToolStripMenuItem.Size = new Size(296, 34);
            gestionUtilisateursToolStripMenuItem.Text = "Gestion des utilisateurs";
            gestionUtilisateursToolStripMenuItem.Click += gestionDesUtilisateursToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1066, 417);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.Location = new Point(885, 408);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(144, 34);
            btnDeconnexion.TabIndex = 2;
            btnDeconnexion.Text = "Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = true;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // btnChangerMdp
            // 
            btnChangerMdp.Location = new Point(22, 404);
            btnChangerMdp.Name = "btnChangerMdp";
            btnChangerMdp.Size = new Size(263, 34);
            btnChangerMdp.TabIndex = 3;
            btnChangerMdp.Text = "Changer mon mot de passe";
            btnChangerMdp.UseVisualStyleBackColor = true;
            btnChangerMdp.Click += btnChangerMdp_Click;
            // 
            // FMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 450);
            Controls.Add(btnChangerMdp);
            Controls.Add(btnDeconnexion);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FMenu";
            Text = "FMenu";
            Load += FMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem listesToolStripMenuItem;
        private ToolStripMenuItem villesToolStripMenuItem;
        private ToolStripMenuItem sallesToolStripMenuItem;
        private ToolStripMenuItem batimentsToolStripMenuItem;
        private ToolStripMenuItem typesDœuvreToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem cOMPOSITEURSToolStripMenuItem;
        private ToolStripMenuItem parNationalitéToolStripMenuItem;
        private ToolStripMenuItem parStyleToolStripMenuItem;
        private ToolStripMenuItem lesOeuvresDunCompositeurToolStripMenuItem;
        private ToolStripMenuItem gestionToolStripMenuItem;
        private Button btnDeconnexion;
        private Button btnChangerMdp;
        private ToolStripMenuItem administrationToolStripMenuItem;
        private ToolStripMenuItem gestionUtilisateursToolStripMenuItem;
    }
}
