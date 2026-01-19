namespace MiniDARMAS.Domain
{
    public class Meeting
    {
        public int MeetingId { get; set; }
        public string MeetingNo { get; set; }
        public DateTime MeetingDate { get; set; }
        public string Location { get; set; }
        public string Chairperson { get; set; }
    }
}
