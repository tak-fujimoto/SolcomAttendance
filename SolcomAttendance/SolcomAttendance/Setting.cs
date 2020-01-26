
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SolcomAttendance
{
    public class Setting : INotifyPropertyChanged
    {
        private SettingMaster value;

        public SettingMaster Value
        {
            get
            {
                return this.value;
            }
            set
            {
                if (this.value != value)
                {
                    this.value = value;
                    OnPropertyChanged(nameof(Value));
                }
            }
        }

        private string valuestr;

        public string ValueStr
        {
            get
            {
                return this.valuestr;
            }
            set
            {
                if (this.valuestr != value)
                {
                    this.valuestr = value;
                    OnPropertyChanged(nameof(ValueStr));
                }
            }
        }

        //始業時間
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

        //終業時間
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

        //休憩時間
        private string breaktime;

        public string BreakTime
        {
            get
            {
                return this.breaktime;
            }
            set
            {
                if (this.breaktime != value)
                {
                    this.breaktime = value;
                    OnPropertyChanged(nameof(BreakTime));
                }
            }
        }

        public Setting(SettingMaster ArgDay)
        {
            Value = ArgDay;
            ValueStr = ArgDay.StartTime.ToString("MM月dd日(ddd)", new System.Globalization.CultureInfo("ja-JP"));
            StartTime = new TimeSpan(ArgDay.StartTime.Hour, ArgDay.StartTime.Minute,0);
            EndTime = new TimeSpan(ArgDay.EndTime.Hour, ArgDay.EndTime.Minute, 0);
            BreakTime = "1";
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

        public void UpdateSettingValue()
        {
            //出勤
            var MyYear_S = Value.StartTime.Year;
            var MyMonth_S = Value.StartTime.Month;
            var MyDay_S = Value.StartTime.Day;

            //退勤
            var MyYear_E = Value.EndTime.Year;
            var MyMonth_E = Value.EndTime.Month;
            var MyDay_E = Value.EndTime.Day;

            Value.StartTime = new DateTime(MyYear_S, MyMonth_S, MyDay_S, this.StartTime.Hours, this.StartTime.Minutes, 0);
            Value.EndTime = new DateTime(MyYear_E, MyMonth_E, MyDay_E, this.EndTime.Hours, this.EndTime.Minutes, 0);
            //Value.BreakTime = new short();

        }
    }
}
