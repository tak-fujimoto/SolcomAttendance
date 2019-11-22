using System;
using System.Collections.Generic;
using System.Text;

namespace SolcomAttendance
{
    public class Daily
    {
        private System.Globalization.CultureInfo Coutry;

        private DateTime Day;

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Memo { get; set; }

        public bool IsUpdated { get; set; }

        public Daily(DateTime ArgDay)
        {
            Coutry = new System.Globalization.CultureInfo("ja-JP");
            Day = ArgDay;
            StartTime = new DateTime(ArgDay.Year, ArgDay.Month, ArgDay.Day, 9, 0, 0);
            EndTime = new DateTime(ArgDay.Year, ArgDay.Month, ArgDay.Day, 18, 0, 0);
            Memo = "";
            IsUpdated = false;
        }

        public void UpdateStartTime(int ArgHour, int ArgMin)
        {
            var MyYear = this.StartTime.Year;
            var MyMonth = this.StartTime.Month;
            var MyDay = this.StartTime.Day;

            this.StartTime = new DateTime(MyYear, MyMonth, MyDay, ArgHour, ArgMin, 0);
            IsUpdated = true;
        }

        public void UpdateEndTime(int ArgHour, int ArgMin, bool IsNextDay)
        {
            var MyYear = this.EndTime.Year;
            var MyMonth = this.EndTime.Month;
            var MyDay = this.EndTime.Day;

            this.EndTime = new DateTime(MyYear, MyMonth, MyDay, ArgHour, ArgMin, 0);
            IsUpdated = true;

            if (IsNextDay) { this.EndTime.AddDays(1); }
        }

        public string GetDayStr()
        {
            return this.Day.ToString("MMŒŽdd“ú(ddd)", Coutry);
        }
    }
}
