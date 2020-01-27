using System;
using System.Collections.Generic;
using System.Text;

namespace SolcomAttendance
{
    public class Monthly
    {
        private DateTime YearMonth;
        private string UserName { get; set; }

        public Dictionary<DateTime, AttendanceMaster> Days;

        public Monthly(AttendanceRepository ArgDb,string ArgUserName,DateTime ArgYearMonth)
        {
            UserName = ArgUserName;
            YearMonth = new DateTime(ArgYearMonth.Year, ArgYearMonth.Month, 1);
            Days = new Dictionary<DateTime, AttendanceMaster>();
            
            var TempRec = ArgDb.GetMonth(UserName, YearMonth);

            foreach (var NowDay in TempRec)
            {
                Days.Add(NowDay.WorkDate, NowDay);
            }
        }

        public AttendanceMaster GetDay(DateTime TargetDay)
        {
            if(Days.ContainsKey(TargetDay))
            {
                return Days[TargetDay];
            }
            else
            {
                AttendanceMaster a = new AttendanceMaster();
                a.UserID = this.UserName;
                Days.Add(TargetDay, a);

                a.WorkDate = TargetDay;

                return a;
            }
        }
    }
}
