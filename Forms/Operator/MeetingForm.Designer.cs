namespace Mini_DARMAS.Forms.Operator
{
    partial class MeetingForm
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
            tabOperator = new TabControl();
            tabMetting = new TabPage();
            dgvMeeting = new DataGridView();
            groupBoxMetting = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtLocation = new TextBox();
            txtChairperson = new TextBox();
            txtMeeting = new TextBox();
            lblDate = new Label();
            lblChairperson = new Label();
            labelLocation = new Label();
            lblMeetingNo = new Label();
            tabAgenda = new TabPage();
            tabRecording = new TabPage();
            tabAssignments = new TabPage();
            tabOperator.SuspendLayout();
            tabMetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMeeting).BeginInit();
            groupBoxMetting.SuspendLayout();
            SuspendLayout();
            // 
            // tabOperator
            // 
            tabOperator.Controls.Add(tabMetting);
            tabOperator.Controls.Add(tabAgenda);
            tabOperator.Controls.Add(tabRecording);
            tabOperator.Controls.Add(tabAssignments);
            tabOperator.Dock = DockStyle.Fill;
            tabOperator.ItemSize = new Size(107, 20);
            tabOperator.Location = new Point(0, 0);
            tabOperator.Name = "tabOperator";
            tabOperator.SelectedIndex = 0;
            tabOperator.Size = new Size(1276, 450);
            tabOperator.TabIndex = 0;
            // 
            // tabMetting
            // 
            tabMetting.BackColor = Color.Silver;
            tabMetting.Controls.Add(dgvMeeting);
            tabMetting.Controls.Add(groupBoxMetting);
            tabMetting.Location = new Point(4, 24);
            tabMetting.Name = "tabMetting";
            tabMetting.Padding = new Padding(3);
            tabMetting.Size = new Size(1268, 422);
            tabMetting.TabIndex = 0;
            tabMetting.Text = "Meetings";
            // 
            // dgvMeeting
            // 
            dgvMeeting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeeting.Dock = DockStyle.Fill;
            dgvMeeting.Location = new Point(3, 158);
            dgvMeeting.Name = "dgvMeeting";
            dgvMeeting.Size = new Size(1262, 261);
            dgvMeeting.TabIndex = 1;
            // 
            // groupBoxMetting
            // 
            groupBoxMetting.BackColor = Color.WhiteSmoke;
            groupBoxMetting.Controls.Add(btnDelete);
            groupBoxMetting.Controls.Add(btnUpdate);
            groupBoxMetting.Controls.Add(btnSave);
            groupBoxMetting.Controls.Add(dateTimePicker1);
            groupBoxMetting.Controls.Add(txtLocation);
            groupBoxMetting.Controls.Add(txtChairperson);
            groupBoxMetting.Controls.Add(txtMeeting);
            groupBoxMetting.Controls.Add(lblDate);
            groupBoxMetting.Controls.Add(lblChairperson);
            groupBoxMetting.Controls.Add(labelLocation);
            groupBoxMetting.Controls.Add(lblMeetingNo);
            groupBoxMetting.Dock = DockStyle.Top;
            groupBoxMetting.Location = new Point(3, 3);
            groupBoxMetting.Name = "groupBoxMetting";
            groupBoxMetting.Size = new Size(1262, 155);
            groupBoxMetting.TabIndex = 0;
            groupBoxMetting.TabStop = false;
            groupBoxMetting.Text = "Metting Detials";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Location = new Point(1075, 111);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 192, 255);
            btnUpdate.Location = new Point(931, 110);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.Location = new Point(779, 110);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(364, 110);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(170, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(43, 111);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(170, 23);
            txtLocation.TabIndex = 7;
            // 
            // txtChairperson
            // 
            txtChairperson.Location = new Point(364, 56);
            txtChairperson.Name = "txtChairperson";
            txtChairperson.Size = new Size(170, 23);
            txtChairperson.TabIndex = 5;
            // 
            // txtMeeting
            // 
            txtMeeting.Location = new Point(43, 47);
            txtMeeting.Name = "txtMeeting";
            txtMeeting.Size = new Size(170, 23);
            txtMeeting.TabIndex = 4;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(364, 93);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(37, 15);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date :";
            // 
            // lblChairperson
            // 
            lblChairperson.AutoSize = true;
            lblChairperson.Location = new Point(364, 38);
            lblChairperson.Name = "lblChairperson";
            lblChairperson.Size = new Size(77, 15);
            lblChairperson.TabIndex = 2;
            lblChairperson.Text = "Chairperson :";
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Location = new Point(43, 93);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new Size(59, 15);
            labelLocation.TabIndex = 1;
            labelLocation.Text = "Location :";
            // 
            // lblMeetingNo
            // 
            lblMeetingNo.AutoSize = true;
            lblMeetingNo.Location = new Point(43, 29);
            lblMeetingNo.Name = "lblMeetingNo";
            lblMeetingNo.Size = new Size(76, 15);
            lblMeetingNo.TabIndex = 0;
            lblMeetingNo.Text = "Meeting No :";
            // 
            // tabAgenda
            // 
            tabAgenda.BackColor = Color.Silver;
            tabAgenda.Location = new Point(4, 24);
            tabAgenda.Name = "tabAgenda";
            tabAgenda.Padding = new Padding(3);
            tabAgenda.Size = new Size(1268, 422);
            tabAgenda.TabIndex = 1;
            tabAgenda.Text = "Agendas";
            // 
            // tabRecording
            // 
            tabRecording.BackColor = Color.Silver;
            tabRecording.Location = new Point(4, 24);
            tabRecording.Name = "tabRecording";
            tabRecording.Size = new Size(1268, 422);
            tabRecording.TabIndex = 2;
            tabRecording.Text = "Recordings";
            // 
            // tabAssignments
            // 
            tabAssignments.BackColor = Color.Silver;
            tabAssignments.Location = new Point(4, 24);
            tabAssignments.Name = "tabAssignments";
            tabAssignments.Size = new Size(1268, 422);
            tabAssignments.TabIndex = 3;
            tabAssignments.Text = "Assignments";
            // 
            // MeetingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1276, 450);
            Controls.Add(tabOperator);
            Name = "MeetingForm";
            Text = "MeetingForm";
            tabOperator.ResumeLayout(false);
            tabMetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMeeting).EndInit();
            groupBoxMetting.ResumeLayout(false);
            groupBoxMetting.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabOperator;
        private TabPage tabMetting;
        private TabPage tabAgenda;
        private TabPage tabRecording;
        private TabPage tabAssignments;
        private GroupBox groupBoxMetting;
        private Label lblMeetingNo;
        private Label lblChairperson;
        private Label labelLocation;
        private Label lblDate;
        private DateTimePicker dateTimePicker1;
        private TextBox txtLocation;
        private TextBox txtChairperson;
        private TextBox txtMeeting;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private DataGridView dgvMeeting;
    }
}