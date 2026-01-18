namespace Mini_DARMAS.Forms.Admin
{
    partial class UserManagementForm
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
            lblUserForm = new Label();
            pnlUserForm = new Panel();
            btnClear = new Button();
            btnUpdateUser = new Button();
            btnAddUsers = new Button();
            cmbRole = new ComboBox();
            lblRole = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            lblUserName = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pnlUserList = new Panel();
            btnToggle = new Button();
            dgvUser = new DataGridView();
            cmbFilterRole = new ComboBox();
            lblFilter = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            pnlUserForm.SuspendLayout();
            pnlUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // lblUserForm
            // 
            lblUserForm.AutoSize = true;
            lblUserForm.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserForm.Location = new Point(12, 9);
            lblUserForm.Name = "lblUserForm";
            lblUserForm.Size = new Size(221, 30);
            lblUserForm.TabIndex = 0;
            lblUserForm.Text = "Create/Update User";
            // 
            // pnlUserForm
            // 
            pnlUserForm.Controls.Add(btnClear);
            pnlUserForm.Controls.Add(btnUpdateUser);
            pnlUserForm.Controls.Add(btnAddUsers);
            pnlUserForm.Controls.Add(cmbRole);
            pnlUserForm.Controls.Add(lblRole);
            pnlUserForm.Controls.Add(lblPassword);
            pnlUserForm.Controls.Add(txtPassword);
            pnlUserForm.Controls.Add(txtUserName);
            pnlUserForm.Controls.Add(lblUserName);
            pnlUserForm.Controls.Add(txtFullName);
            pnlUserForm.Controls.Add(lblFullName);
            pnlUserForm.Controls.Add(lblUserForm);
            pnlUserForm.Dock = DockStyle.Left;
            pnlUserForm.Location = new Point(0, 0);
            pnlUserForm.Name = "pnlUserForm";
            pnlUserForm.Size = new Size(432, 450);
            pnlUserForm.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(312, 346);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 34);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(157, 346);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(131, 34);
            btnUpdateUser.TabIndex = 9;
            btnUpdateUser.Text = "Update Users";
            btnUpdateUser.UseVisualStyleBackColor = true;
            // 
            // btnAddUsers
            // 
            btnAddUsers.Location = new Point(12, 346);
            btnAddUsers.Name = "btnAddUsers";
            btnAddUsers.Size = new Size(118, 34);
            btnAddUsers.TabIndex = 8;
            btnAddUsers.Text = "Add Users";
            btnAddUsers.UseVisualStyleBackColor = true;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(147, 237);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(240, 33);
            cmbRole.TabIndex = 3;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(27, 245);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(50, 25);
            lblRole.TabIndex = 7;
            lblRole.Text = "Role:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(27, 191);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(147, 191);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(240, 31);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(147, 130);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(240, 31);
            txtUserName.TabIndex = 4;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(35, 130);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(103, 25);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "User Name:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(147, 68);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(240, 31);
            txtFullName.TabIndex = 2;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(35, 71);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(95, 25);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pnlUserList
            // 
            pnlUserList.Controls.Add(btnToggle);
            pnlUserList.Controls.Add(dgvUser);
            pnlUserList.Controls.Add(cmbFilterRole);
            pnlUserList.Controls.Add(lblFilter);
            pnlUserList.Controls.Add(lblSearch);
            pnlUserList.Controls.Add(txtSearch);
            pnlUserList.Dock = DockStyle.Fill;
            pnlUserList.Location = new Point(432, 0);
            pnlUserList.Name = "pnlUserList";
            pnlUserList.Size = new Size(368, 450);
            pnlUserList.TabIndex = 4;
            // 
            // btnToggle
            // 
            btnToggle.Location = new Point(6, 121);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(108, 34);
            btnToggle.TabIndex = 13;
            btnToggle.Text = "Toggle";
            btnToggle.UseVisualStyleBackColor = true;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Dock = DockStyle.Bottom;
            dgvUser.Location = new Point(0, 161);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersWidth = 62;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(368, 289);
            dgvUser.TabIndex = 11;
            // 
            // cmbFilterRole
            // 
            cmbFilterRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterRole.FormattingEnabled = true;
            cmbFilterRole.Location = new Point(89, 68);
            cmbFilterRole.Name = "cmbFilterRole";
            cmbFilterRole.Size = new Size(206, 33);
            cmbFilterRole.TabIndex = 10;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(21, 74);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(54, 25);
            lblFilter.TabIndex = 9;
            lblFilter.Text = "Filter:";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(21, 24);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 25);
            lblSearch.TabIndex = 8;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(89, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(206, 31);
            txtSearch.TabIndex = 0;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlUserList);
            Controls.Add(pnlUserForm);
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            pnlUserForm.ResumeLayout(false);
            pnlUserForm.PerformLayout();
            pnlUserList.ResumeLayout(false);
            pnlUserList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUserForm;
        private Panel pnlUserForm;
        private TextBox txtFullName;
        private Label lblFullName;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblRole;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label lblUserName;
        private ComboBox cmbRole;
        private Button btnUpdateUser;
        private Button btnAddUsers;
        private Button btnClear;
        private Panel pnlUserList;
        private Label lblFilter;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnToggle;
        private DataGridView dgvUser;
        private ComboBox cmbFilterRole;
    }
}