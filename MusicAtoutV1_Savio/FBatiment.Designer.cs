namespace MusicAtoutV1_Savio
{
    partial class FBatiment
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
            bsBatiment = new BindingSource(components);
            dgvBatiment = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bsBatiment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBatiment).BeginInit();
            SuspendLayout();
            // 
            // dgvBatiment
            // 
            dgvBatiment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatiment.Dock = DockStyle.Fill;
            dgvBatiment.Location = new Point(0, 0);
            dgvBatiment.Name = "dgvBatiment";
            dgvBatiment.ReadOnly = true;
            dgvBatiment.RowHeadersWidth = 62;
            dgvBatiment.Size = new Size(800, 450);
            dgvBatiment.TabIndex = 0;
            dgvBatiment.CellContentClick += dgvBatiment_CellContentClick;
            // 
            // FBatiment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBatiment);
            Name = "FBatiment";
            Text = "FBatiment";
            ((System.ComponentModel.ISupportInitialize)bsBatiment).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBatiment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsBatiment;
        private DataGridView dgvBatiment;
    }
}