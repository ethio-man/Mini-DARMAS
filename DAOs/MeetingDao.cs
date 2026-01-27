using Microsoft.Data.SqlClient;
using MiniDARMAS.Data.DbContext;
using MiniDARMAS.Domain;
using System.Collections.Generic;

namespace MiniDARMAS.DAOs
{
    public class MeetingDAOs
    {
        private readonly DbHelper _db;

        public MeetingDAOs()
        {
            _db = new DbHelper();
        }

        // CREATE
        public void AddMeeting(Meeting meeting)
        {
            using var conn = _db.CreateConnection();

            string sql = @"INSERT INTO Meetings
                           (MeetingNo, MeetingDate, Location, Chairperson)
                           VALUES (@no, @date, @loc, @chair)";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@no", meeting.MeetingNo);
            cmd.Parameters.AddWithValue("@date", meeting.MeetingDate);
            cmd.Parameters.AddWithValue("@loc", meeting.Location);
            cmd.Parameters.AddWithValue("@chair", meeting.Chairperson);

            cmd.ExecuteNonQuery();
        }

        // READ
        public List<Meeting> GetAllMeetings()
        {
            var list = new List<Meeting>();
            using var conn = _db.CreateConnection();

            string sql = "SELECT * FROM Meetings ORDER BY MeetingDate DESC";
            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Meeting
                {
                    MeetingId = (int)reader["MeetingId"],
                    MeetingNo = reader["MeetingNo"].ToString(),
                    MeetingDate = (DateTime)reader["MeetingDate"],
                    Location = reader["Location"].ToString(),
                    Chairperson = reader["Chairperson"].ToString()
                });
            }
            return list;
        }

        // UPDATE
        public void UpdateMeeting(Meeting meeting)
        {
            using var conn = _db.CreateConnection();

            string sql = @"UPDATE Meetings SET
                           MeetingNo=@no,
                           MeetingDate=@date,
                           Location=@loc,
                           Chairperson=@chair
                           WHERE MeetingId=@id";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", meeting.MeetingId);
            cmd.Parameters.AddWithValue("@no", meeting.MeetingNo);
            cmd.Parameters.AddWithValue("@date", meeting.MeetingDate);
            cmd.Parameters.AddWithValue("@loc", meeting.Location);
            cmd.Parameters.AddWithValue("@chair", meeting.Chairperson);

            cmd.ExecuteNonQuery();
        }

        // DELETE
        public void DeleteMeeting(int meetingId)
        {
            using var conn = _db.CreateConnection();

            string sql = "DELETE FROM Meetings WHERE MeetingId=@id";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", meetingId);

            cmd.ExecuteNonQuery();
        }
    }
}
