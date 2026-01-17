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
            dataGridView1 = new DataGridView();
            panelMeetingSelected = new Panel();
            comboBox1 = new ComboBox();
            lblMeeting = new Label();
            gbAgenda = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblDocument = new Label();
            lblOffice = new Label();
            lblAgendaTitle = new Label();
            btnAdd = new Button();
            button2 = new Button();
            btnRemove = new Button();
            tabRecording = new TabPage();
            tabAssignments = new TabPage();
            tabOperator.SuspendLayout();
            tabMetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMeeting).BeginInit();
            groupBoxMetting.SuspendLayout();
            tabAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelMeetingSelected.SuspendLayout();
            gbAgenda.SuspendLayout();
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
            tabAgenda.Controls.Add(dataGridView1);
            tabAgenda.Controls.Add(panelMeetingSelected);
            tabAgenda.Controls.Add(gbAgenda);
            tabAgenda.Location = new Point(4, 24);
            tabAgenda.Name = "tabAgenda";
            tabAgenda.Padding = new Padding(3);
            tabAgenda.Size = new Size(1268, 422);
            tabAgenda.TabIndex = 1;
            tabAgenda.Text = "Agendas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(3, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(781, 353);
            dataGridView1.TabIndex = 3;
            // 
            // panelMeetingSelected
            // 
            panelMeetingSelected.BackColor = Color.LightGray;
            panelMeetingSelected.Controls.Add(comboBox1);
            panelMeetingSelected.Controls.Add(lblMeeting);
            panelMeetingSelected.Dock = DockStyle.Top;
            panelMeetingSelected.Location = new Point(3, 3);
            panelMeetingSelected.Name = "panelMeetingSelected";
            panelMeetingSelected.Size = new Size(781, 63);
            panelMeetingSelected.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(124, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 23);
            comboBox1.TabIndex = 6;
            // 
            // lblMeeting
            // 
            lblMeeting.AutoSize = true;
            lblMeeting.Location = new Point(27, 16);
            lblMeeting.Name = "lblMeeting";
            lblMeeting.Size = new Size(91, 15);
            lblMeeting.TabIndex = 5;
            lblMeeting.Text = "Select Meeting :";
            // 
            // gbAgenda
            // 
            gbAgenda.BackColor = Color.LightGray;
            gbAgenda.Controls.Add(textBox3);
            gbAgenda.Controls.Add(textBox2);
            gbAgenda.Controls.Add(textBox1);
            gbAgenda.Controls.Add(lblDocument);
            gbAgenda.Controls.Add(lblOffice);
            gbAgenda.Controls.Add(lblAgendaTitle);
            gbAgenda.Controls.Add(btnAdd);
            gbAgenda.Controls.Add(button2);
            gbAgenda.Controls.Add(btnRemove);
            gbAgenda.Dock = DockStyle.Right;
            gbAgenda.Location = new Point(784, 3);
            gbAgenda.Name = "gbAgenda";
            gbAgenda.Size = new Size(481, 416);
            gbAgenda.TabIndex = 1;
            gbAgenda.TabStop = false;
            gbAgenda.Text = "Agenda Details";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(43, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(262, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(43, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(262, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 23);
            textBox1.TabIndex = 8;
            // 
            // lblDocument
            // 
            lblDocument.AutoSize = true;
            lblDocument.Location = new Point(43, 149);
            lblDocument.Name = "lblDocument";
            lblDocument.Size = new Size(131, 15);
            lblDocument.TabIndex = 7;
            lblDocument.Text = "Supporting Document :";
            // 
            // lblOffice
            // 
            lblOffice.AutoSize = true;
            lblOffice.Location = new Point(43, 92);
            lblOffice.Name = "lblOffice";
            lblOffice.Size = new Size(45, 15);
            lblOffice.TabIndex = 6;
            lblOffice.Text = "Office :";
            // 
            // lblAgendaTitle
            // 
            lblAgendaTitle.AutoSize = true;
            lblAgendaTitle.Location = new Point(43, 38);
            lblAgendaTitle.Name = "lblAgendaTitle";
            lblAgendaTitle.Size = new Size(80, 15);
            lblAgendaTitle.TabIndex = 5;
            lblAgendaTitle.Text = "Agenda Title :";
            lblAgendaTitle.Click += label1_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LimeGreen;
            btnAdd.Location = new Point(99, 295);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.Location = new Point(197, 295);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(255, 128, 128);
            btnRemove.Location = new Point(331, 295);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
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
            tabAgenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelMeetingSelected.ResumeLayout(false);
            panelMeetingSelected.PerformLayout();
            gbAgenda.ResumeLayout(false);
            gbAgenda.PerformLayout();
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
        private GroupBox gbAgenda;
        private Button btnRemove;
        private Button button2;
        private Button btnAdd;
        private Panel panelMeetingSelected;
        private Label lblMeeting;
        private ComboBox comboBox1;
        private Label lblDocument;
        private Label lblOffice;
        private Label lblAgendaTitle;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}