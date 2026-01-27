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
            dgvMeetings = new DataGridView();
            groupBoxMetting = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            dtpMeetingDate = new DateTimePicker();
            txtLocation = new TextBox();
            txtChairperson = new TextBox();
            txtMeetingNo = new TextBox();
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
            btnDocument = new Button();
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
            dataGridView2 = new DataGridView();
            gbRecording = new GroupBox();
            txtRecordingPath = new TextBox();
            lblRecordingPath = new Label();
            lblFile = new Label();
            btnBrowseRecord = new Button();
            btnSaveRecord = new Button();
            btnPause_Start = new Button();
            btnRecord = new Button();
            groupBox1 = new GroupBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            labelAgenda = new Label();
            labelMeeting = new Label();
            tabAssignments = new TabPage();
            groupBox3 = new GroupBox();
            label2 = new Label();
            dgvAssignment = new DataGridView();
            btnAssign = new Button();
            cmbStatus = new ComboBox();
            cmbTranscriber = new ComboBox();
            labelTranscriber = new Label();
            groupBox2 = new GroupBox();
            dgvRecordings = new DataGridView();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            label3 = new Label();
            lableMeeting = new Label();
            tabOperator.SuspendLayout();
            tabMetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMeetings).BeginInit();
            groupBoxMetting.SuspendLayout();
            tabAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelMeetingSelected.SuspendLayout();
            gbAgenda.SuspendLayout();
            tabRecording.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            gbRecording.SuspendLayout();
            groupBox1.SuspendLayout();
            tabAssignments.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssignment).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecordings).BeginInit();
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
            tabMetting.Controls.Add(dgvMeetings);
            tabMetting.Controls.Add(groupBoxMetting);
            tabMetting.Location = new Point(4, 24);
            tabMetting.Name = "tabMetting";
            tabMetting.Padding = new Padding(3);
            tabMetting.Size = new Size(1268, 422);
            tabMetting.TabIndex = 0;
            tabMetting.Text = "Meetings";
            // 
            // dgvMeetings
            // 
            dgvMeetings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeetings.Dock = DockStyle.Fill;
            dgvMeetings.Location = new Point(3, 158);
            dgvMeetings.Name = "dgvMeetings";
            dgvMeetings.Size = new Size(1262, 261);
            dgvMeetings.TabIndex = 1;
            dgvMeetings.CellContentClick += dgvMeetings_CellContentClick;
            // 
            // groupBoxMetting
            // 
            groupBoxMetting.BackColor = Color.WhiteSmoke;
            groupBoxMetting.Controls.Add(btnDelete);
            groupBoxMetting.Controls.Add(btnUpdate);
            groupBoxMetting.Controls.Add(btnSave);
            groupBoxMetting.Controls.Add(dtpMeetingDate);
            groupBoxMetting.Controls.Add(txtLocation);
            groupBoxMetting.Controls.Add(txtChairperson);
            groupBoxMetting.Controls.Add(txtMeetingNo);
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
            btnDelete.Click += btnDelete_Click;
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
            btnUpdate.Click += btnUpdate_Click;
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
            btnSave.Click += btnSave_Click;
            // 
            // dtpMeetingDate
            // 
            dtpMeetingDate.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpMeetingDate.Format = DateTimePickerFormat.Custom;
            dtpMeetingDate.Location = new Point(364, 110);
            dtpMeetingDate.Name = "dtpMeetingDate";
            dtpMeetingDate.Size = new Size(170, 23);
            dtpMeetingDate.TabIndex = 8;
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
            // txtMeetingNo
            // 
            txtMeetingNo.Location = new Point(43, 47);
            txtMeetingNo.Name = "txtMeetingNo";
            txtMeetingNo.Size = new Size(170, 23);
            txtMeetingNo.TabIndex = 4;
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
            gbAgenda.Controls.Add(btnDocument);
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
            // btnDocument
            // 
            btnDocument.BackColor = Color.LightSkyBlue;
            btnDocument.Location = new Point(43, 219);
            btnDocument.Name = "btnDocument";
            btnDocument.Size = new Size(106, 34);
            btnDocument.TabIndex = 11;
            btnDocument.Text = "Browse";
            btnDocument.UseVisualStyleBackColor = false;
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
            lblAgendaTitle.Location = new Point(0, 0);
            lblAgendaTitle.Name = "lblAgendaTitle";
            lblAgendaTitle.Size = new Size(100, 23);
            lblAgendaTitle.TabIndex = 12;
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
            tabRecording.Controls.Add(dataGridView2);
            tabRecording.Controls.Add(gbRecording);
            tabRecording.Controls.Add(groupBox1);
            tabRecording.Location = new Point(4, 24);
            tabRecording.Name = "tabRecording";
            tabRecording.Size = new Size(1268, 422);
            tabRecording.TabIndex = 2;
            tabRecording.Text = "Recordings";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Right;
            dataGridView2.Location = new Point(696, 100);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(572, 322);
            dataGridView2.TabIndex = 4;
            // 
            // gbRecording
            // 
            gbRecording.BackColor = Color.LightGray;
            gbRecording.Controls.Add(txtRecordingPath);
            gbRecording.Controls.Add(lblRecordingPath);
            gbRecording.Controls.Add(lblFile);
            gbRecording.Controls.Add(btnBrowseRecord);
            gbRecording.Controls.Add(btnSaveRecord);
            gbRecording.Controls.Add(btnPause_Start);
            gbRecording.Controls.Add(btnRecord);
            gbRecording.Dock = DockStyle.Left;
            gbRecording.Location = new Point(0, 100);
            gbRecording.Name = "gbRecording";
            gbRecording.Size = new Size(698, 322);
            gbRecording.TabIndex = 3;
            gbRecording.TabStop = false;
            gbRecording.Text = "Recording Controls";
            // 
            // txtRecordingPath
            // 
            txtRecordingPath.Location = new Point(212, 95);
            txtRecordingPath.Name = "txtRecordingPath";
            txtRecordingPath.Size = new Size(231, 23);
            txtRecordingPath.TabIndex = 4;
            // 
            // lblRecordingPath
            // 
            lblRecordingPath.AutoSize = true;
            lblRecordingPath.Location = new Point(89, 98);
            lblRecordingPath.Name = "lblRecordingPath";
            lblRecordingPath.Size = new Size(94, 15);
            lblRecordingPath.TabIndex = 3;
            lblRecordingPath.Text = "Recording Path :";
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Location = new Point(89, 53);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(104, 15);
            lblFile.TabIndex = 0;
            lblFile.Text = "Attach Audio File :";
            // 
            // btnBrowseRecord
            // 
            btnBrowseRecord.BackColor = Color.LightSkyBlue;
            btnBrowseRecord.Location = new Point(212, 47);
            btnBrowseRecord.Name = "btnBrowseRecord";
            btnBrowseRecord.Size = new Size(75, 27);
            btnBrowseRecord.TabIndex = 1;
            btnBrowseRecord.Text = "Browse";
            btnBrowseRecord.UseVisualStyleBackColor = false;
            // 
            // btnSaveRecord
            // 
            btnSaveRecord.BackColor = Color.White;
            btnSaveRecord.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveRecord.ForeColor = Color.Black;
            btnSaveRecord.Location = new Point(427, 148);
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.Size = new Size(41, 35);
            btnSaveRecord.TabIndex = 2;
            btnSaveRecord.Text = "⬛";
            btnSaveRecord.UseVisualStyleBackColor = false;
            // 
            // btnPause_Start
            // 
            btnPause_Start.BackColor = Color.White;
            btnPause_Start.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPause_Start.ForeColor = Color.Black;
            btnPause_Start.Location = new Point(356, 148);
            btnPause_Start.Name = "btnPause_Start";
            btnPause_Start.Size = new Size(41, 35);
            btnPause_Start.TabIndex = 1;
            btnPause_Start.Text = "⏯️";
            btnPause_Start.UseVisualStyleBackColor = false;
            // 
            // btnRecord
            // 
            btnRecord.BackColor = Color.White;
            btnRecord.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecord.ForeColor = Color.Red;
            btnRecord.Location = new Point(296, 148);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(39, 35);
            btnRecord.TabIndex = 0;
            btnRecord.Text = "🔴";
            btnRecord.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(labelAgenda);
            groupBox1.Controls.Add(labelMeeting);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1268, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agenda Selection";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(260, 61);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(267, 23);
            comboBox3.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(260, 16);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(267, 23);
            comboBox2.TabIndex = 2;
            // 
            // labelAgenda
            // 
            labelAgenda.AutoSize = true;
            labelAgenda.Location = new Point(197, 64);
            labelAgenda.Name = "labelAgenda";
            labelAgenda.Size = new Size(54, 15);
            labelAgenda.TabIndex = 1;
            labelAgenda.Text = "Agenda :";
            // 
            // labelMeeting
            // 
            labelMeeting.AutoSize = true;
            labelMeeting.Location = new Point(197, 19);
            labelMeeting.Name = "labelMeeting";
            labelMeeting.Size = new Size(57, 15);
            labelMeeting.TabIndex = 0;
            labelMeeting.Text = "Meeting :";
            // 
            // tabAssignments
            // 
            tabAssignments.BackColor = Color.Silver;
            tabAssignments.Controls.Add(groupBox3);
            tabAssignments.Controls.Add(groupBox2);
            tabAssignments.Location = new Point(4, 24);
            tabAssignments.Name = "tabAssignments";
            tabAssignments.Size = new Size(1268, 422);
            tabAssignments.TabIndex = 3;
            tabAssignments.Text = "Assignments";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(dgvAssignment);
            groupBox3.Controls.Add(btnAssign);
            groupBox3.Controls.Add(cmbStatus);
            groupBox3.Controls.Add(cmbTranscriber);
            groupBox3.Controls.Add(labelTranscriber);
            groupBox3.Location = new Point(648, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(620, 422);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Assignment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 112);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 5;
            label2.Text = "Status :";
            // 
            // dgvAssignment
            // 
            dgvAssignment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvAssignment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssignment.Location = new Point(3, 212);
            dgvAssignment.Name = "dgvAssignment";
            dgvAssignment.Size = new Size(617, 214);
            dgvAssignment.TabIndex = 2;
            // 
            // btnAssign
            // 
            btnAssign.BackColor = Color.Teal;
            btnAssign.Location = new Point(379, 151);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(81, 29);
            btnAssign.TabIndex = 4;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = false;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(78, 130);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(207, 23);
            cmbStatus.TabIndex = 3;
            // 
            // cmbTranscriber
            // 
            cmbTranscriber.FormattingEnabled = true;
            cmbTranscriber.Location = new Point(78, 58);
            cmbTranscriber.Name = "cmbTranscriber";
            cmbTranscriber.Size = new Size(207, 23);
            cmbTranscriber.TabIndex = 2;
            // 
            // labelTranscriber
            // 
            labelTranscriber.AutoSize = true;
            labelTranscriber.Location = new Point(78, 40);
            labelTranscriber.Name = "labelTranscriber";
            labelTranscriber.Size = new Size(71, 15);
            labelTranscriber.TabIndex = 0;
            labelTranscriber.Text = "Transcriber :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightGray;
            groupBox2.Controls.Add(dgvRecordings);
            groupBox2.Controls.Add(comboBox5);
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(lableMeeting);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(653, 422);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Recording Selection";
            // 
            // dgvRecordings
            // 
            dgvRecordings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecordings.Location = new Point(0, 112);
            dgvRecordings.Name = "dgvRecordings";
            dgvRecordings.Size = new Size(556, 196);
            dgvRecordings.TabIndex = 4;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(435, 35);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(207, 23);
            comboBox5.TabIndex = 3;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(149, 35);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(206, 23);
            comboBox4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 38);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 1;
            label3.Text = "Agenda :";
            // 
            // lableMeeting
            // 
            lableMeeting.AutoSize = true;
            lableMeeting.Location = new Point(86, 38);
            lableMeeting.Name = "lableMeeting";
            lableMeeting.Size = new Size(57, 15);
            lableMeeting.TabIndex = 0;
            lableMeeting.Text = "Meeting :";
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
            Load += MeetingForm_Load;
            tabOperator.ResumeLayout(false);
            tabMetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMeetings).EndInit();
            groupBoxMetting.ResumeLayout(false);
            groupBoxMetting.PerformLayout();
            tabAgenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelMeetingSelected.ResumeLayout(false);
            panelMeetingSelected.PerformLayout();
            gbAgenda.ResumeLayout(false);
            gbAgenda.PerformLayout();
            tabRecording.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            gbRecording.ResumeLayout(false);
            gbRecording.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabAssignments.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssignment).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecordings).EndInit();
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
        private DateTimePicker dtpMeetingDate;
        private TextBox txtLocation;
        private TextBox txtChairperson;
        private TextBox txtMeetingNo;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private DataGridView dgvMeetings;
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
        private Button btnDocument;
        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private Label labelAgenda;
        private Label labelMeeting;
        private ComboBox comboBox3;
        private GroupBox gbRecording;
        private Button btnSaveRecord;
        private Button btnPause_Start;
        private Button btnRecord;
        private Button btnBrowseRecord;
        private Label lblFile;
        private DataGridView dataGridView2;
        private GroupBox groupBox2;
        private TextBox txtRecordingPath;
        private Label lblRecordingPath;
        private Label label3;
        private Label lableMeeting;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private GroupBox groupBox3;
        private TextBox textBox4;
        private Label label4;
        private Label labelTranscriber;
        private DataGridView dgvRecordings;
        private ComboBox cmbStatus;
        private ComboBox cmbTranscriber;
        private Button btnAssign;
        private DataGridView dgvAssignment;
        private Label label2;
    }
}