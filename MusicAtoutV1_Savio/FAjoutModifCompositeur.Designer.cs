using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MusicAtoutV1_Savio
{
    partial class FAjoutModifCompositeur
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
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            txtRemarque = new RichTextBox();
            txtAnNais = new TextBox();
            txtAnMort = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            lblNom = new Label();
            lblPrenom = new Label();
            lblRemarque = new Label();
            lblAnNais = new Label();
            lblAnMort = new Label();
            labellblNation = new Label();
            lblStyle = new Label();
            cboNation = new ComboBox();
            cboStyle = new ComboBox();
            error1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new Point(177, 22);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(150, 31);
            txtNom.TabIndex = 0;
            txtNom.TextChanged += textBox1_TextChanged;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(203, 59);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(150, 31);
            txtPrenom.TabIndex = 1;
            // 
            // txtRemarque
            // 
            txtRemarque.Location = new Point(127, 96);
            txtRemarque.Name = "txtRemarque";
            txtRemarque.Size = new Size(603, 144);
            txtRemarque.TabIndex = 2;
            txtRemarque.Text = "";
            // 
            // txtAnNais
            // 
            txtAnNais.Location = new Point(102, 255);
            txtAnNais.Name = "txtAnNais";
            txtAnNais.Size = new Size(150, 31);
            txtAnNais.TabIndex = 3;
            // 
            // txtAnMort
            // 
            txtAnMort.Location = new Point(381, 255);
            txtAnMort.Name = "txtAnMort";
            txtAnMort.Size = new Size(150, 31);
            txtAnMort.TabIndex = 4;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(127, 393);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(112, 34);
            btnOK.TabIndex = 7;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(278, 393);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(14, 22);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(157, 25);
            lblNom.TabIndex = 9;
            lblNom.Text = "nom Compositeur";
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(14, 62);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(183, 25);
            lblPrenom.TabIndex = 10;
            lblPrenom.Text = "prenom Compositeur";
            // 
            // lblRemarque
            // 
            lblRemarque.AutoSize = true;
            lblRemarque.Location = new Point(20, 110);
            lblRemarque.Name = "lblRemarque";
            lblRemarque.Size = new Size(88, 25);
            lblRemarque.TabIndex = 11;
            lblRemarque.Text = "remarque";
            // 
            // lblAnNais
            // 
            lblAnNais.AutoSize = true;
            lblAnNais.Location = new Point(26, 258);
            lblAnNais.Name = "lblAnNais";
            lblAnNais.Size = new Size(70, 25);
            lblAnNais.TabIndex = 12;
            lblAnNais.Text = "an Nais";
            // 
            // lblAnMort
            // 
            lblAnMort.AutoSize = true;
            lblAnMort.Location = new Point(290, 261);
            lblAnMort.Name = "lblAnMort";
            lblAnMort.Size = new Size(75, 25);
            lblAnMort.TabIndex = 13;
            lblAnMort.Text = "an Mort";
            // 
            // labellblNation
            // 
            labellblNation.AutoSize = true;
            labellblNation.Location = new Point(38, 307);
            labellblNation.Name = "labellblNation";
            labellblNation.Size = new Size(97, 25);
            labellblNation.TabIndex = 14;
            labellblNation.Text = "Nationalité";
            // 
            // lblStyle
            // 
            lblStyle.AutoSize = true;
            lblStyle.Location = new Point(39, 348);
            lblStyle.Name = "lblStyle";
            lblStyle.Size = new Size(49, 25);
            lblStyle.TabIndex = 15;
            lblStyle.Text = "Style";
            // 
            // cboNation
            // 
            cboNation.FormattingEnabled = true;
            cboNation.Location = new Point(141, 304);
            cboNation.Name = "cboNation";
            cboNation.Size = new Size(182, 33);
            cboNation.TabIndex = 16;
            // 
            // cboStyle
            // 
            cboStyle.FormattingEnabled = true;
            cboStyle.Location = new Point(141, 348);
            cboStyle.Name = "cboStyle";
            cboStyle.Size = new Size(182, 33);
            cboStyle.TabIndex = 17;
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // FAjoutModifCompositeur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboStyle);
            Controls.Add(cboNation);
            Controls.Add(lblStyle);
            Controls.Add(labellblNation);
            Controls.Add(lblAnMort);
            Controls.Add(lblAnNais);
            Controls.Add(lblRemarque);
            Controls.Add(lblPrenom);
            Controls.Add(lblNom);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtAnMort);
            Controls.Add(txtAnNais);
            Controls.Add(txtRemarque);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Name = "FAjoutModifCompositeur";
            Text = "FAjoutModifCompositeur";
            Load += FAjoutModifCompositeur_Load;
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNom;
        private TextBox txtPrenom;
        private RichTextBox txtRemarque;
        private TextBox txtAnNais;
        private TextBox txtAnMort;
        private Button btnOK;
        private Button btnCancel;
        private Label lblNom;
        private Label lblPrenom;
        private Label lblRemarque;
        private Label lblAnNais;
        private Label lblAnMort;
        private Label labellblNation;
        private Label lblStyle;
        private ComboBox cboNation;
        private ComboBox cboStyle;
        private ErrorProvider error1;
    }
}