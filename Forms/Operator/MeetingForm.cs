using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniDARMAS.DAOs;
using MiniDARMAS.Domain;
namespace Mini_DARMAS.Forms.Operator
{
    public partial class MeetingForm : Form
    {
        private readonly MeetingDAOs _repo;
        private int _selectedMeetingId = 0;
        public MeetingForm()
        {
            InitializeComponent();
            _repo = new MeetingDAOs();
        }

        private void MeetingForm_Load(object sender, EventArgs e)
        {
            LoadMeetings();
        }
        private void LoadMeetings()
        {
            dgvMeetings.DataSource = _repo.GetAllMeetings();
            dgvMeetings.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var meeting = new Meeting
            {
                MeetingNo = txtMeetingNo.Text.Trim(),
                MeetingDate = dtpMeetingDate.Value,
                Location = txtLocation.Text.Trim(),
                Chairperson = txtChairperson.Text.Trim()
            };

            _repo.AddMeeting(meeting);
            LoadMeetings();
            ClearForm();
        }
      

        private void dgvMeetings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvMeetings.Rows[e.RowIndex];

            _selectedMeetingId = (int)row.Cells["MeetingId"].Value;
            txtMeetingNo.Text = row.Cells["MeetingNo"].Value.ToString();
            dtpMeetingDate.Value = (DateTime)row.Cells["MeetingDate"].Value;
            txtLocation.Text = row.Cells["Location"].Value.ToString();
            txtChairperson.Text = row.Cells["Chairperson"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedMeetingId == 0) return;

            var meeting = new Meeting
            {
                MeetingId = _selectedMeetingId,
                MeetingNo = txtMeetingNo.Text.Trim(),
                MeetingDate = dtpMeetingDate.Value,
                Location = txtLocation.Text.Trim(),
                Chairperson = txtChairperson.Text.Trim()
            };

            _repo.UpdateMeeting(meeting);
            LoadMeetings();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedMeetingId == 0) return;

            var confirm = MessageBox.Show(
                "Delete this meeting?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _repo.DeleteMeeting(_selectedMeetingId);
                LoadMeetings();
                ClearForm();
            }
        }
          private void ClearForm()
        {
            _selectedMeetingId = 0;
            txtMeetingNo.Clear();
            txtLocation.Clear();
            txtChairperson.Clear();
            dtpMeetingDate.Value = DateTime.Now;
            dgvMeetings.ClearSelection();
        }
    }
}
