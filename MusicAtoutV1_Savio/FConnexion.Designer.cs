namespace MusicAtoutV1_Savio
{
    partial class FConnexion
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
            lblLogin = new Label();
            lblMdp = new Label();
            btnOK = new Button();
            txtMdp = new TextBox();
            txtLogin = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(28, 19);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(56, 25);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // lblMdp
            // 
            lblMdp.AutoSize = true;
            lblMdp.Location = new Point(28, 56);
            lblMdp.Name = "lblMdp";
            lblMdp.Size = new Size(87, 25);
            lblMdp.TabIndex = 1;
            lblMdp.Text = "Password";
            lblMdp.Click += label2_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(28, 98);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(112, 34);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // txtMdp
            // 
            txtMdp.Location = new Point(166, 19);
            txtMdp.Name = "txtMdp";
            txtMdp.Size = new Size(150, 31);
            txtMdp.TabIndex = 3;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(166, 53);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(150, 31);
            txtLogin.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FConnexion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLogin);
            Controls.Add(txtMdp);
            Controls.Add(btnOK);
            Controls.Add(lblMdp);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            Name = "FConnexion";
            Text = "FConnexion";
            Load += FConnexion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblMdp;
        private Button btnOK;
        private TextBox txtMdp;
        private TextBox txtLogin;
        private PictureBox pictureBox1;
    }
}