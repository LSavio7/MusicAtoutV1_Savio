namespace MusicAtoutV1_Savio
{
    partial class FOeuvresCompositeur
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cboStyle;
        private TextBox txtDebut;
        private TextBox txtFin;
        private DataGridView dgvCompositeurs;
        private Label NomCompo;
        private Label lblNationalité;
        private Label lbStyle;
        private Label lblNaiss;
        private Label lblDécès;
        private TextBox txtDescription;
        private DataGridView dgvOeuvres;
        private Button btnQuitter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cboStyle = new ComboBox();
            txtDebut = new TextBox();
            txtFin = new TextBox();
            dgvCompositeurs = new DataGridView();
            NomCompo = new Label();
            lblNationalité = new Label();
            lbStyle = new Label();
            lblNaiss = new Label();
            lblDécès = new Label();
            txtDescription = new TextBox();
            dgvOeuvres = new DataGridView();
            btnQuitter = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCompositeurs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOeuvres).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cboStyle
            // 
            cboStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStyle.Location = new Point(38, 28);
            cboStyle.Margin = new Padding(4, 4, 4, 4);
            cboStyle.Name = "cboStyle";
            cboStyle.Size = new Size(249, 33);
            cboStyle.TabIndex = 0;
            // 
            // txtDebut
            // 
            txtDebut.Location = new Point(38, 88);
            txtDebut.Margin = new Padding(4, 4, 4, 4);
            txtDebut.Name = "txtDebut";
            txtDebut.ReadOnly = true;
            txtDebut.Size = new Size(99, 31);
            txtDebut.TabIndex = 1;
            // 
            // txtFin
            // 
            txtFin.Location = new Point(150, 88);
            txtFin.Margin = new Padding(4, 4, 4, 4);
            txtFin.Name = "txtFin";
            txtFin.ReadOnly = true;
            txtFin.Size = new Size(99, 31);
            txtFin.TabIndex = 2;
            // 
            // dgvCompositeurs
            // 
            dgvCompositeurs.ColumnHeadersHeight = 34;
            dgvCompositeurs.Location = new Point(13, 150);
            dgvCompositeurs.Margin = new Padding(4, 4, 4, 4);
            dgvCompositeurs.Name = "dgvCompositeurs";
            dgvCompositeurs.ReadOnly = true;
            dgvCompositeurs.RowHeadersWidth = 62;
            dgvCompositeurs.Size = new Size(338, 462);
            dgvCompositeurs.TabIndex = 3;
            // 
            // NomCompo
            // 
            NomCompo.BackColor = Color.Snow;
            NomCompo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            NomCompo.Location = new Point(210, 22);
            NomCompo.Margin = new Padding(4, 0, 4, 0);
            NomCompo.Name = "NomCompo";
            NomCompo.Size = new Size(315, 38);
            NomCompo.TabIndex = 4;
            // 
            // lblNationalité
            // 
            lblNationalité.BackColor = Color.Snow;
            lblNationalité.Location = new Point(135, 75);
            lblNationalité.Margin = new Padding(4, 0, 4, 0);
            lblNationalité.Name = "lblNationalité";
            lblNationalité.Size = new Size(152, 38);
            lblNationalité.TabIndex = 5;
            // 
            // lbStyle
            // 
            lbStyle.BackColor = Color.Snow;
            lbStyle.Location = new Point(419, 75);
            lbStyle.Margin = new Padding(4, 0, 4, 0);
            lbStyle.Name = "lbStyle";
            lbStyle.Size = new Size(106, 38);
            lbStyle.TabIndex = 6;
            // 
            // lblNaiss
            // 
            lblNaiss.BackColor = Color.Snow;
            lblNaiss.Location = new Point(178, 121);
            lblNaiss.Margin = new Padding(4, 0, 4, 0);
            lblNaiss.Name = "lblNaiss";
            lblNaiss.Size = new Size(66, 38);
            lblNaiss.TabIndex = 7;
            // 
            // lblDécès
            // 
            lblDécès.BackColor = Color.Snow;
            lblDécès.Location = new Point(344, 121);
            lblDécès.Margin = new Padding(4, 0, 4, 0);
            lblDécès.Name = "lblDécès";
            lblDécès.Size = new Size(78, 38);
            lblDécès.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(19, 175);
            txtDescription.Margin = new Padding(4, 4, 4, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(506, 99);
            txtDescription.TabIndex = 9;
            // 
            // dgvOeuvres
            // 
            dgvOeuvres.ColumnHeadersHeight = 34;
            dgvOeuvres.Location = new Point(19, 306);
            dgvOeuvres.Margin = new Padding(4, 4, 4, 4);
            dgvOeuvres.Name = "dgvOeuvres";
            dgvOeuvres.ReadOnly = true;
            dgvOeuvres.RowHeadersWidth = 62;
            dgvOeuvres.Size = new Size(506, 229);
            dgvOeuvres.TabIndex = 10;
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(812, 575);
            btnQuitter.Margin = new Padding(4, 4, 4, 4);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(150, 38);
            btnQuitter.TabIndex = 11;
            btnQuitter.Text = "Quitter";
            btnQuitter.Click += btnQuitter_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvOeuvres);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(NomCompo);
            panel1.Controls.Add(lbStyle);
            panel1.Controls.Add(lblNationalité);
            panel1.Controls.Add(lblDécès);
            panel1.Controls.Add(lblNaiss);
            panel1.Location = new Point(437, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(551, 552);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 28);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 11;
            label1.Text = "Vous avez sélectionné";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 78);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 12;
            label2.Text = "Nationalité";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 78);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 13;
            label3.Text = "Style";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 129);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 14;
            label4.Text = "Naissance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(261, 126);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 15;
            label5.Text = "Décès";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 278);
            label6.Name = "label6";
            label6.Size = new Size(253, 25);
            label6.TabIndex = 16;
            label6.Text = "Les œuvres de ce compositeur";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, -1);
            label7.Name = "label7";
            label7.Size = new Size(49, 25);
            label7.TabIndex = 13;
            label7.Text = "Style";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 59);
            label8.Name = "label8";
            label8.Size = new Size(61, 25);
            label8.TabIndex = 14;
            label8.Text = "Début";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(164, 61);
            label9.Name = "label9";
            label9.Size = new Size(35, 25);
            label9.TabIndex = 15;
            label9.Text = "Fin";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 123);
            label10.Name = "label10";
            label10.Size = new Size(211, 25);
            label10.TabIndex = 16;
            label10.Text = "Compositeurs de ce style";
            label10.Click += label10_Click;
            // 
            // FOeuvresCompositeur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 625);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(cboStyle);
            Controls.Add(txtDebut);
            Controls.Add(txtFin);
            Controls.Add(btnQuitter);
            Controls.Add(dgvCompositeurs);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FOeuvresCompositeur";
            Text = "Oeuvres du Compositeur";
            Load += FOeuvresCompositeur_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompositeurs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOeuvres).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
