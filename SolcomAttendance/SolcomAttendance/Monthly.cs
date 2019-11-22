using System;
using System.Collections.Generic;
using System.Text;

namespace SolcomAttendance
{
    public class Monthly
    {
        private DateTime YearMonth;

        public List<Daily> Days;

        public Monthly(DateTime ArgYearMonth)
        {
            YearMonth = new DateTime(ArgYearMonth.Year, ArgYearMonth.Month, 1);
            Days = new List<Daily>();

            var LastDay = YearMonth.AddMonths(1).AddDays(-1).Day;

            for (int DayCount = 0; DayCount <= LastDay; DayCount++)
            {
                Days.Add(new Daily(YearMonth.AddDays(DayCount)));
            }
        }

        public Daily GetDay(DateTime TargetDay)
        {
            return this.Days[TargetDay.Day - 1];
        }
    }
}
