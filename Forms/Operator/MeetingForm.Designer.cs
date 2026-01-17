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
            tabAgenda = new TabPage();
            tabRecording = new TabPage();
            tabAssignments = new TabPage();
            groupBoxMetting = new GroupBox();
            lblMeetingNo = new Label();
            labelLocation = new Label();
            lblChairperson = new Label();
            lblDate = new Label();
            txtMeeting = new TextBox();
            txtChairperson = new TextBox();
            txtLocation = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            tabOperator.SuspendLayout();
            tabMetting.SuspendLayout();
            groupBoxMetting.SuspendLayout();
            SuspendLayout();
            // 
            // tabOperator
            // 
            tabOperator.Controls.Add(tabMetting);
            tabOperator.Controls.Add(tabAgenda);
            tabOperator.Controls.Add(tabRecording);
            tabOperator.Controls.Add(tabAssignments);
            tabOperator.Location = new Point(3, 2);
            tabOperator.Name = "tabOperator";
            tabOperator.SelectedIndex = 0;
            tabOperator.Size = new Size(801, 453);
            tabOperator.TabIndex = 0;
            // 
            // tabMetting
            // 
            tabMetting.BackColor = Color.Silver;
            tabMetting.Controls.Add(groupBoxMetting);
            tabMetting.Location = new Point(4, 24);
            tabMetting.Name = "tabMetting";
            tabMetting.Padding = new Padding(3);
            tabMetting.Size = new Size(793, 425);
            tabMetting.TabIndex = 0;
            tabMetting.Text = "Meetings";
            // 
            // tabAgenda
            // 
            tabAgenda.BackColor = Color.Silver;
            tabAgenda.Location = new Point(4, 24);
            tabAgenda.Name = "tabAgenda";
            tabAgenda.Padding = new Padding(3);
            tabAgenda.Size = new Size(793, 425);
            tabAgenda.TabIndex = 1;
            tabAgenda.Text = "Agendas";
            // 
            // tabRecording
            // 
            tabRecording.BackColor = Color.Silver;
            tabRecording.Location = new Point(4, 24);
            tabRecording.Name = "tabRecording";
            tabRecording.Size = new Size(793, 425);
            tabRecording.TabIndex = 2;
            tabRecording.Text = "Recordings";
            // 
            // tabAssignments
            // 
            tabAssignments.BackColor = Color.Silver;
            tabAssignments.Location = new Point(4, 24);
            tabAssignments.Name = "tabAssignments";
            tabAssignments.Size = new Size(793, 425);
            tabAssignments.TabIndex = 3;
            tabAssignments.Text = "Assignments";
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
            groupBoxMetting.Location = new Point(6, 6);
            groupBoxMetting.Name = "groupBoxMetting";
            groupBoxMetting.Size = new Size(784, 155);
            groupBoxMetting.TabIndex = 0;
            groupBoxMetting.TabStop = false;
            groupBoxMetting.Text = "Metting Detials";
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
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Location = new Point(43, 93);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new Size(59, 15);
            labelLocation.TabIndex = 1;
            labelLocation.Text = "Location :";
            // 
            // lblChairperson
            // 
            lblChairperson.AutoSize = true;
            lblChairperson.Location = new Point(325, 38);
            lblChairperson.Name = "lblChairperson";
            lblChairperson.Size = new Size(77, 15);
            lblChairperson.TabIndex = 2;
            lblChairperson.Text = "Chairperson :";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(325, 93);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(37, 15);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date :";
            // 
            // txtMeeting
            // 
            txtMeeting.Location = new Point(43, 47);
            txtMeeting.Name = "txtMeeting";
            txtMeeting.Size = new Size(170, 23);
            txtMeeting.TabIndex = 4;
            // 
            // txtChairperson
            // 
            txtChairperson.Location = new Point(325, 56);
            txtChairperson.Name = "txtChairperson";
            txtChairperson.Size = new Size(170, 23);
            txtChairperson.TabIndex = 5;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(43, 111);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(170, 23);
            txtLocation.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(325, 111);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(170, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.Location = new Point(526, 89);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 192, 255);
            btnUpdate.Location = new Point(607, 89);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Location = new Point(688, 89);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // MeetingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(tabOperator);
            Name = "MeetingForm";
            Text = "MeetingForm";
            tabOperator.ResumeLayout(false);
            tabMetting.ResumeLayout(false);
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
    }
}