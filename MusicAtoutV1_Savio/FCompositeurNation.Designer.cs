using System.Drawing;
using System.Windows.Forms;

namespace MusicAtoutV1_Savio
{
    partial class FCompositeurNation
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox cboNation;
        private DataGridView dgvCompositeur;
        private Button btnToutesNationalites;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cboNation = new ComboBox();
            dgvCompositeur = new DataGridView();
            btnToutesNationalites = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).BeginInit();
            SuspendLayout();
            // 
            // cboNation
            // 
            cboNation.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNation.FormattingEnabled = true;
            cboNation.Location = new Point(107, 25);
            cboNation.Name = "cboNation";
            cboNation.Size = new Size(250, 33);
            cboNation.TabIndex = 0;
            // 
            // dgvCompositeur
            // 
            dgvCompositeur.AllowUserToAddRows = false;
            dgvCompositeur.AllowUserToDeleteRows = false;
            dgvCompositeur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompositeur.Location = new Point(12, 64);
            dgvCompositeur.Name = "dgvCompositeur";
            dgvCompositeur.ReadOnly = true;
            dgvCompositeur.RowHeadersWidth = 62;
            dgvCompositeur.Size = new Size(776, 331);
            dgvCompositeur.TabIndex = 1;
            dgvCompositeur.CellContentClick += dgvCompositeur_CellContentClick;
            // 
            // btnToutesNationalites
            // 
            btnToutesNationalites.BackColor = Color.IndianRed;
            btnToutesNationalites.Location = new Point(388, 25);
            btnToutesNationalites.Name = "btnToutesNationalites";
            btnToutesNationalites.Size = new Size(135, 33);
            btnToutesNationalites.TabIndex = 2;
            btnToutesNationalites.Text = "Toutes les nationalités";
            btnToutesNationalites.UseVisualStyleBackColor = false;
            btnToutesNationalites.Click += btnToutesNationalites_Click;
            // 
            // button1
            // 
            button1.Location = new Point(39, 411);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(181, 411);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(329, 411);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 6;
            label1.Text = "Natinalité :";
            // 
            // FCompositeurNation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvCompositeur);
            Controls.Add(cboNation);
            Controls.Add(btnToutesNationalites);
            Name = "FCompositeurNation";
            Text = "Compositeurs par nationalité";
            Load += FCompositeurNation_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}
