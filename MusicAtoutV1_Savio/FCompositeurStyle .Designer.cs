using System.Drawing;
using System.Windows.Forms;

namespace MusicAtoutV1_Savio
{
    partial class FCompositeurStyle
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cboStyle;
        private TextBox txtDebut;
        private TextBox txtFin;
        private DataGridView dgvCompositeur;
        private BindingSource bsStyle;
        private BindingSource bsCompositeur;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cboStyle = new ComboBox();
            txtDebut = new TextBox();
            txtFin = new TextBox();
            dgvCompositeur = new DataGridView();
            bsStyle = new BindingSource(components);
            bsCompositeur = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).BeginInit();
            SuspendLayout();
            // 
            // cboStyle
            // 
            cboStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStyle.Location = new Point(30, 20);
            cboStyle.Name = "cboStyle";
            cboStyle.Size = new Size(220, 33);
            cboStyle.TabIndex = 0;
            // 
            // txtDebut
            // 
            txtDebut.BackColor = Color.LightYellow;
            txtDebut.Location = new Point(270, 20);
            txtDebut.Name = "txtDebut";
            txtDebut.ReadOnly = true;
            txtDebut.Size = new Size(100, 31);
            txtDebut.TabIndex = 1;
            // 
            // txtFin
            // 
            txtFin.BackColor = Color.LightYellow;
            txtFin.Location = new Point(390, 20);
            txtFin.Name = "txtFin";
            txtFin.ReadOnly = true;
            txtFin.Size = new Size(100, 31);
            txtFin.TabIndex = 2;
            // 
            // dgvCompositeur
            // 
            dgvCompositeur.ColumnHeadersHeight = 34;
            dgvCompositeur.Location = new Point(30, 70);
            dgvCompositeur.Name = "dgvCompositeur";
            dgvCompositeur.ReadOnly = true;
            dgvCompositeur.RowHeadersWidth = 62;
            dgvCompositeur.Size = new Size(700, 350);
            dgvCompositeur.TabIndex = 3;
            dgvCompositeur.CellContentClick += dgvCompositeur_CellContentClick;
            // 
            // FCompositeurStyle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboStyle);
            Controls.Add(txtDebut);
            Controls.Add(txtFin);
            Controls.Add(dgvCompositeur);
            Name = "FCompositeurStyle";
            Text = "Compositeurs par style";
            Load += FCompositeurStyle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
