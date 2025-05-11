namespace MusicAtoutV1_Savio
{
    partial class FChangeMdp
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
            label1 = new Label();
            txtAncien = new TextBox();
            lblNouveau = new Label();
            txtNouveau = new TextBox();
            lblConfirm = new Label();
            txtConfirm = new TextBox();
            btnValider = new Button();
            error1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 26);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 0;
            label1.Text = "Ancien mot de passe";
            // 
            // txtAncien
            // 
            txtAncien.Location = new Point(231, 26);
            txtAncien.Name = "txtAncien";
            txtAncien.Size = new Size(150, 31);
            txtAncien.TabIndex = 1;
            txtAncien.TextChanged += txtAncien_TextChanged;
            // 
            // lblNouveau
            // 
            lblNouveau.AutoSize = true;
            lblNouveau.Location = new Point(25, 73);
            lblNouveau.Name = "lblNouveau";
            lblNouveau.Size = new Size(196, 25);
            lblNouveau.TabIndex = 2;
            lblNouveau.Text = "Nouveau mot de passe";
            // 
            // txtNouveau
            // 
            txtNouveau.Location = new Point(231, 73);
            txtNouveau.Name = "txtNouveau";
            txtNouveau.Size = new Size(150, 31);
            txtNouveau.TabIndex = 3;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(17, 118);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(204, 25);
            lblConfirm.TabIndex = 4;
            lblConfirm.Text = "Confirmer mot de passe";
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(231, 115);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(150, 31);
            txtConfirm.TabIndex = 5;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(231, 185);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(112, 34);
            btnValider.TabIndex = 6;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // FChangeMdp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnValider);
            Controls.Add(txtConfirm);
            Controls.Add(lblConfirm);
            Controls.Add(txtNouveau);
            Controls.Add(lblNouveau);
            Controls.Add(txtAncien);
            Controls.Add(label1);
            Name = "FChangeMdp";
            Text = "FChangeMdp";
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAncien;
        private Label lblNouveau;
        private TextBox txtNouveau;
        private Label lblConfirm;
        private TextBox txtConfirm;
        private Button btnValider;
        private ErrorProvider error1;
    }
}