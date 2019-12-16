using System;
using SQLite;

namespace SolcomAttendance
{
    public class AttendanceMaster
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string UserID { get; set; }
        public DateTime WorkDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public short BreakTime { get; set; }
        public DateTime EntryDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}