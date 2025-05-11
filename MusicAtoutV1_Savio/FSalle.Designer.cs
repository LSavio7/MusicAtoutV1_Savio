namespace MusicAtoutV1_Savio
{
    partial class FSalle
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvSalle = new DataGridView();
            bsSalle = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvSalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsSalle).BeginInit();
            SuspendLayout();
            // 
            // dgvSalle
            // 
            dgvSalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalle.Dock = DockStyle.Fill;
            dgvSalle.Location = new Point(0, 0);
            dgvSalle.Name = "dgvSalle";
            dgvSalle.ReadOnly = true;
            dgvSalle.RowHeadersWidth = 62;
            dgvSalle.Size = new Size(800, 450);
            dgvSalle.TabIndex = 0;
            dgvSalle.CellContentClick += dgvSalle_CellContentClick;
            // 
            // FSalle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSalle);
            Name = "FSalle";
            Text = "FSalle";
            ((System.ComponentModel.ISupportInitialize)dgvSalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsSalle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSalle;
        private BindingSource bsSalle;
    }
}
