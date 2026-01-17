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
            tabOperator.SuspendLayout();
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
            tabMetting.Location = new Point(4, 24);
            tabMetting.Name = "tabMetting";
            tabMetting.Padding = new Padding(3);
            tabMetting.Size = new Size(793, 425);
            tabMetting.TabIndex = 0;
            tabMetting.Text = "Meetings";
            tabMetting.UseVisualStyleBackColor = true;
            // 
            // tabAgenda
            // 
            tabAgenda.Location = new Point(4, 24);
            tabAgenda.Name = "tabAgenda";
            tabAgenda.Padding = new Padding(3);
            tabAgenda.Size = new Size(793, 425);
            tabAgenda.TabIndex = 1;
            tabAgenda.Text = "Agendas";
            tabAgenda.UseVisualStyleBackColor = true;
            // 
            // tabRecording
            // 
            tabRecording.Location = new Point(4, 24);
            tabRecording.Name = "tabRecording";
            tabRecording.Size = new Size(793, 425);
            tabRecording.TabIndex = 2;
            tabRecording.Text = "Recordings";
            tabRecording.UseVisualStyleBackColor = true;
            // 
            // tabAssignments
            // 
            tabAssignments.Location = new Point(4, 24);
            tabAssignments.Name = "tabAssignments";
            tabAssignments.Size = new Size(793, 425);
            tabAssignments.TabIndex = 3;
            tabAssignments.Text = "Assignments";
            tabAssignments.UseVisualStyleBackColor = true;
            // 
            // MeetingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabOperator);
            Name = "MeetingForm";
            Text = "MeetingForm";
            tabOperator.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabOperator;
        private TabPage tabMetting;
        private TabPage tabAgenda;
        private TabPage tabRecording;
        private TabPage tabAssignments;
    }
}