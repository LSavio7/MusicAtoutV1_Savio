namespace MusicAtoutV1_Savio
{
    partial class FVille
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
            dgvVille = new DataGridView();
            bsVille = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvVille).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsVille).BeginInit();
            SuspendLayout();
            // 
            // dgvVille
            // 
            dgvVille.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVille.Dock = DockStyle.Fill;
            dgvVille.Location = new Point(0, 0);
            dgvVille.Name = "dgvVille";
            dgvVille.ReadOnly = true;
            dgvVille.RowHeadersWidth = 62;
            dgvVille.Size = new Size(800, 450);
            dgvVille.TabIndex = 0;
            dgvVille.CellContentClick += dgvVille_CellContentClick;
            // 
            // FVille
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVille);
            Name = "FVille";
            Text = "FVille";
            ((System.ComponentModel.ISupportInitialize)dgvVille).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsVille).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVille;
        private BindingSource bsVille;
    }
}