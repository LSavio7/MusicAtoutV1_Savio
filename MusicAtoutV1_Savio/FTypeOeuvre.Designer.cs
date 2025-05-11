namespace MusicAtoutV1_Savio
{
    partial class FTypeOeuvre
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
            bsTypeOeuvre = new BindingSource(components);
            dgvTypeOeuvre = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bsTypeOeuvre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTypeOeuvre).BeginInit();
            SuspendLayout();
            // 
            // dgvTypeOeuvre
            // 
            dgvTypeOeuvre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTypeOeuvre.Dock = DockStyle.Fill;
            dgvTypeOeuvre.Location = new Point(0, 0);
            dgvTypeOeuvre.Name = "dgvTypeOeuvre";
            dgvTypeOeuvre.ReadOnly = true;
            dgvTypeOeuvre.RowHeadersWidth = 62;
            dgvTypeOeuvre.Size = new Size(800, 450);
            dgvTypeOeuvre.TabIndex = 0;
            dgvTypeOeuvre.CellContentClick += dgvTypeOeuvre_CellContentClick;
            // 
            // FTypeOeuvre
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTypeOeuvre);
            Name = "FTypeOeuvre";
            Text = "FTypeOeuvre";
            ((System.ComponentModel.ISupportInitialize)bsTypeOeuvre).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTypeOeuvre).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsTypeOeuvre;
        private DataGridView dgvTypeOeuvre;
    }
}