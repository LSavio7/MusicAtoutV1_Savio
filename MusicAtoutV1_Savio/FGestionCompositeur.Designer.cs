namespace MusicAtoutV1_Savio
{
    partial class FGestionCompositeur
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
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            dgvCompositeur = new DataGridView();
            bsCompositeur = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).BeginInit();
            SuspendLayout();
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(23, 404);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(112, 34);
            btnAjouter.TabIndex = 0;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(157, 404);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(112, 34);
            btnModifier.TabIndex = 1;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(300, 404);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(112, 34);
            btnSupprimer.TabIndex = 2;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // dgvCompositeur
            // 
            dgvCompositeur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompositeur.Location = new Point(23, 84);
            dgvCompositeur.Name = "dgvCompositeur";
            dgvCompositeur.RowHeadersWidth = 62;
            dgvCompositeur.Size = new Size(734, 314);
            dgvCompositeur.TabIndex = 3;
            dgvCompositeur.CellContentClick += dgvCompositeur_CellContentClick;
            // 
            // FGestionCompositeur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCompositeur);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Name = "FGestionCompositeur";
            Text = "FGestionCompositeur";
            Load += FGestionCompositeur_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
        private DataGridView dgvCompositeur;
        private BindingSource bsCompositeur;
    }
}