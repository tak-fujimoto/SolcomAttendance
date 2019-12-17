using System;
using System.Collections.Generic;
using System.Text;

namespace SolcomAttendance
{
    public class Monthly
    {
        private DateTime YearMonth;

        public Dictionary<DateTime, AttendanceMaster> Days;

        public Monthly(DateTime ArgYearMonth)
        {
            YearMonth = new DateTime(ArgYearMonth.Year, ArgYearMonth.Month, 1);
            Days = new Dictionary<DateTime, AttendanceMaster>();

            //var LastDay = YearMonth.AddMonths(1).AddDays(-1).Day;

            //for (int DayCount = 0; DayCount <= LastDay; DayCount++)
            //{
            //    Days.Add(new Daily(YearMonth.AddDays(DayCount)));
            //}
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
                Days.Add(TargetDay, a);

                a.WorkDate = TargetDay;

                return a;
            }
        }
    }
}
