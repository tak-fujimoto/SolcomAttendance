using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SolcomAttendance
{
    public class DisplayDay : INotifyPropertyChanged
    {
        private Daily day;

        public Daily Day
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

        public DisplayDay(Daily ArgDay)
        {
            Day = ArgDay;
            DayStr = ArgDay.GetDayStr();
            StartTime = new TimeSpan(ArgDay.StartTime.Hour, ArgDay.StartTime.Minute,0);
            EndTime = new TimeSpan(ArgDay.EndTime.Hour, ArgDay.EndTime.Minute, 0);
        }

        public void ChangeDay(Daily NewDay)
        {
            var OldDay = this.Day;
            OldDay.UpdateStartTime(this.StartTime.Hours,this.StartTime.Minutes);
            OldDay.UpdateEndTime(this.EndTime.Hours, this.EndTime.Minutes,false);

            this.Day = NewDay;
            this.DayStr = NewDay.GetDayStr();
            this.StartTime = new TimeSpan(NewDay.StartTime.Hour, NewDay.StartTime.Minute, 0);
            this.EndTime = new TimeSpan(NewDay.EndTime.Hour, NewDay.EndTime.Minute, 0);
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
    }
}
