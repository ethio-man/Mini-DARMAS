namespace Mini_DARMAS.Forms.Admin
{
    partial class AdminDashboard
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
            lblTitle = new Label();
            btnManageUsers = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(252, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(293, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Admin Dashboard";
            // 
            // btnManageUsers
            // 
            btnManageUsers.Location = new Point(24, 334);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(142, 34);
            btnManageUsers.TabIndex = 1;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(620, 334);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(142, 34);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnManageUsers);
            Controls.Add(lblTitle);
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnManageUsers;
        private Button btnLogout;
    }
}