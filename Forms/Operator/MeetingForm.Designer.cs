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
            btnDocument = new Button();
            groupBox1 = new GroupBox();
            labelMeeting = new Label();
            labelAgenda = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            gbFile = new GroupBox();
            lblFile = new Label();
            btnBrowseRecord = new Button();
            dgvRecordings = new DataGridView();
            gbRecording = new GroupBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            tabOperator.SuspendLayout();
            tabMetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMeeting).BeginInit();
            groupBoxMetting.SuspendLayout();
            tabAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelMeetingSelected.SuspendLayout();
            gbAgenda.SuspendLayout();
            tabRecording.SuspendLayout();
            groupBox1.SuspendLayout();
            gbFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecordings).BeginInit();
            gbRecording.SuspendLayout();
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
            tabRecording.Controls.Add(gbRecording);
            tabRecording.Controls.Add(dgvRecordings);
            tabRecording.Controls.Add(gbFile);
            tabRecording.Controls.Add(groupBox1);
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
            // labelMeeting
            // 
            labelMeeting.AutoSize = true;
            labelMeeting.Location = new Point(197, 19);
            labelMeeting.Name = "labelMeeting";
            labelMeeting.Size = new Size(57, 15);
            labelMeeting.TabIndex = 0;
            labelMeeting.Text = "Meeting :";
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(260, 16);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(267, 23);
            comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(260, 61);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(267, 23);
            comboBox3.TabIndex = 3;
            // 
            // gbFile
            // 
            gbFile.BackColor = Color.LightGray;
            gbFile.Controls.Add(btnBrowseRecord);
            gbFile.Controls.Add(lblFile);
            gbFile.Location = new Point(8, 106);
            gbFile.Name = "gbFile";
            gbFile.Size = new Size(740, 100);
            gbFile.TabIndex = 1;
            gbFile.TabStop = false;
            gbFile.Text = "File Attachment";
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Location = new Point(92, 34);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(104, 15);
            lblFile.TabIndex = 0;
            lblFile.Text = "Attach Audio File :";
            // 
            // btnBrowseRecord
            // 
            btnBrowseRecord.BackColor = Color.LightSkyBlue;
            btnBrowseRecord.Location = new Point(202, 28);
            btnBrowseRecord.Name = "btnBrowseRecord";
            btnBrowseRecord.Size = new Size(75, 27);
            btnBrowseRecord.TabIndex = 1;
            btnBrowseRecord.Text = "Browse";
            btnBrowseRecord.UseVisualStyleBackColor = false;
            // 
            // dgvRecordings
            // 
            dgvRecordings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecordings.Location = new Point(754, 106);
            dgvRecordings.Name = "dgvRecordings";
            dgvRecordings.Size = new Size(506, 313);
            dgvRecordings.TabIndex = 2;
            // 
            // gbRecording
            // 
            gbRecording.BackColor = Color.LightGray;
            gbRecording.Controls.Add(label1);
            gbRecording.Controls.Add(button4);
            gbRecording.Controls.Add(button3);
            gbRecording.Controls.Add(button1);
            gbRecording.Location = new Point(8, 233);
            gbRecording.Name = "gbRecording";
            gbRecording.Size = new Size(740, 181);
            gbRecording.TabIndex = 3;
            gbRecording.TabStop = false;
            gbRecording.Text = "Recording Controls";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(144, 74);
            button1.Name = "button1";
            button1.Size = new Size(39, 35);
            button1.TabIndex = 0;
            button1.Text = "🔴";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(189, 74);
            button3.Name = "button3";
            button3.Size = new Size(41, 35);
            button3.TabIndex = 1;
            button3.Text = "⏯️";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(236, 74);
            button4.Name = "button4";
            button4.Size = new Size(41, 35);
            button4.TabIndex = 2;
            button4.Text = "⬛";
            button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 129);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Recording Timer :";
            label1.Click += label1_Click_1;
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
            tabRecording.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbFile.ResumeLayout(false);
            gbFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecordings).EndInit();
            gbRecording.ResumeLayout(false);
            gbRecording.PerformLayout();
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
        private Button btnDocument;
        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private Label labelAgenda;
        private Label labelMeeting;
        private ComboBox comboBox3;
        private GroupBox gbRecording;
        private Label label1;
        private Button button4;
        private Button button3;
        private DataGridView dgvRecordings;
        private GroupBox gbFile;
        private Button btnBrowseRecord;
        private Button button1;
        private Label lblFile;
        private GroupBox groupBox2;
    }
}