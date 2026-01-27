namespace Mini_DARMAS
{
    partial class LoginForm
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblUsername = new Label();
            lblPassword = new Label();
            textUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblMessage = new Label();
            picLogo = new PictureBox();
            picFlag = new PictureBox();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFlag).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(297, 230);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 25);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Name:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(297, 291);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(426, 224);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(240, 31);
            textUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(426, 285);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(240, 31);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(272, 447);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(98, 39);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(384, 213);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 25);
            lblMessage.TabIndex = 5;
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picLogo.BackColor = Color.Transparent;
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(714, -2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(200, 111);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 6;
            picLogo.TabStop = false;
            // 
            // picFlag
            // 
            picFlag.Image = (Image)resources.GetObject("picFlag.Image");
            picFlag.Location = new Point(1, -2);
            picFlag.Name = "picFlag";
            picFlag.Size = new Size(150, 111);
            picFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            picFlag.TabIndex = 7;
            picFlag.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(293, 96);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(415, 74);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Mini-DARMAS";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 639);
            Controls.Add(lblTitle);
            Controls.Add(picFlag);
            Controls.Add(picLogo);
            Controls.Add(lblMessage);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(textUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFlag).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private TextBox textUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblMessage;
        private PictureBox picLogo;
        private PictureBox picFlag;
        private Label lblTitle;
    }
}
