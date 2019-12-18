using System;
using SQLite;

namespace SolcomAttendance
{
    public class SettingMaster
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public short BreakTime { get; set; }
        public DateTime EntryDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}