using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SolcomAttendance
{
    public class DisplayDay : INotifyPropertyChanged
    {
        private AttendanceMaster day;

        public AttendanceMaster Day
        {
            get
            {
                return this.day;
            }
            set
            {
                if (this.day != value)
                {
                    this.day = value;
                    OnPropertyChanged(nameof(Day));
                }
            }
        }

        private string daystr;

        public string DayStr
        {
            get
            {
                return this.daystr;
            }
            set
            {
                if (this.daystr != value)
                {
                    this.daystr = value;
                    OnPropertyChanged(nameof(DayStr));
                }
            }
        }

        private TimeSpan starttime;

        public TimeSpan StartTime
        {
            get
            {
                return this.starttime;
            }
            set
            {
                if (this.starttime != value)
                {
                    this.starttime = value;
                    OnPropertyChanged(nameof(StartTime));
                }
            }
        }

        private TimeSpan endtime;

        public TimeSpan EndTime
        {
            get
            {
                return this.endtime;
            }
            set
            {
                if (this.endtime != value)
                {
                    this.endtime = value;
                    OnPropertyChanged(nameof(EndTime));
                }
            }
        }

        public DisplayDay(AttendanceMaster ArgDay)
        {
            Day = ArgDay;
            DayStr = ArgDay.WorkDate.ToString("MM月dd日(ddd)", new System.Globalization.CultureInfo("ja-JP"));
            StartTime = new TimeSpan(ArgDay.StartTime.Hour, ArgDay.StartTime.Minute,0);
            EndTime = new TimeSpan(ArgDay.EndTime.Hour, ArgDay.EndTime.Minute, 0);
        }

        public void ChangeDay(AttendanceMaster ArgDay)
        {
            Day = ArgDay;
            DayStr = ArgDay.WorkDate.ToString("MM月dd日(ddd)", new System.Globalization.CultureInfo("ja-JP"));
            StartTime = new TimeSpan(ArgDay.StartTime.Hour, ArgDay.StartTime.Minute, 0);
            EndTime = new TimeSpan(ArgDay.EndTime.Hour, ArgDay.EndTime.Minute, 0);
        }

        /// <summary>
        /// INotifyPropertyChangedインターフェイスの実装
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                  new PropertyChangedEventArgs(propertyName));
            }
        }
        public void UpdateTime()
        {
            var MyYear = Day.WorkDate.Year;
            var MyMonth = Day.WorkDate.Month;
            var MyDay = Day.WorkDate.Day;

            Day.StartTime = new DateTime(MyYear, MyMonth, MyDay, this.StartTime.Hours, this.StartTime.Minutes, 0);
            Day.EndTime = new DateTime(MyYear, MyMonth, MyDay, this.EndTime.Hours, this.EndTime.Minutes, 0);
        }
    }
}
