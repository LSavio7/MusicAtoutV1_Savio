namespace MusicAtoutV1_Savio
{
    partial class FGestionUtilisateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvUtilisateur = new DataGridView();
            bsUtilisateur = new BindingSource(components);
            btnReactivation = new Button();
            btnDesactivation = new Button();
            btnAjout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUtilisateur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsUtilisateur).BeginInit();
            SuspendLayout();
            // 
            // dgvUtilisateur
            // 
            dgvUtilisateur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUtilisateur.Location = new Point(12, 21);
            dgvUtilisateur.Name = "dgvUtilisateur";
            dgvUtilisateur.RowHeadersWidth = 62;
            dgvUtilisateur.Size = new Size(828, 280);
            dgvUtilisateur.TabIndex = 0;
            // 
            // btnReactivation
            // 
            btnReactivation.Location = new Point(255, 321);
            btnReactivation.Name = "btnReactivation";
            btnReactivation.Size = new Size(112, 34);
            btnReactivation.TabIndex = 1;
            btnReactivation.Text = "Réactiver";
            btnReactivation.UseVisualStyleBackColor = true;
            // 
            // btnDesactivation
            // 
            btnDesactivation.Location = new Point(412, 321);
            btnDesactivation.Name = "btnDesactivation";
            btnDesactivation.Size = new Size(112, 34);
            btnDesactivation.TabIndex = 2;
            btnDesactivation.Text = "Désactiver";
            btnDesactivation.UseVisualStyleBackColor = true;
            // 
            // btnAjout
            // 
            btnAjout.Location = new Point(106, 321);
            btnAjout.Name = "btnAjout";
            btnAjout.Size = new Size(112, 34);
            btnAjout.TabIndex = 3;
            btnAjout.Text = "Ajouter";
            btnAjout.UseVisualStyleBackColor = true;
            // 
            // FGestionUtilisateur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 450);
            Controls.Add(btnAjout);
            Controls.Add(btnDesactivation);
            Controls.Add(btnReactivation);
            Controls.Add(dgvUtilisateur);
            Name = "FGestionUtilisateur";
            Text = "FGestionUtilisateur";
            Load += FGestionUtilisateur_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUtilisateur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsUtilisateur).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUtilisateur;
        private BindingSource bsUtilisateur;
        private Button btnReactivation;
        private Button btnDesactivation;
        private Button btnAjout;
    }
}