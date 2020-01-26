using System;
using System.Collections.Generic;
using System.Text;

namespace SolcomAttendance
{
    public class SetValue
    {
        private System.Globalization.CultureInfo Coutry;


        private DateTime Day;
        //始業時間
        public DateTime StartTime { get; set; }
        //終業時間
        public DateTime EndTime { get; set; }
        //共計時間
        public short BreakTime { get; set; }

        public SetValue(DateTime ArgDay)
        {
            Coutry = new System.Globalization.CultureInfo("ja-JP");
            Day = ArgDay;

            //設定画面に表示されるやつ
            StartTime = new DateTime(ArgDay.Year, ArgDay.Month, ArgDay.Day, 9, 0, 0);
            EndTime = new DateTime(ArgDay.Year, ArgDay.Month, ArgDay.Day, 18, 0, 0);
            //BreakTime = "";
 
        }
        
        //始業時間
        public void UpdateStartTime(int ArgHour, int ArgMin)
        {
            //設定されている値を取得
            var MyYear = this.StartTime.Year;//(画面のバインド名に合わせる)
            var MyMonth = this.StartTime.Month;//(画面のバインド名に合わせる)
            var MyDay = this.StartTime.Day;//(画面のバインド名に合わせる)

            this.StartTime = new DateTime(MyYear, MyMonth, MyDay, ArgHour, ArgMin, 0);

        }

        //終業時間
        public void UpdateEndTime(int ArgHour, int ArgMin, bool IsNextDay)
        {
            //設定されている値を取得
            var MyYear = this.EndTime.Year;//(画面のバインド名に合わせる)
            var MyMonth = this.EndTime.Month;//(画面のバインド名に合わせる)
            var MyDay = this.EndTime.Day;//(画面のバインド名に合わせる)

            this.EndTime = new DateTime(MyYear, MyMonth, MyDay, ArgHour, ArgMin, 0);


            if (IsNextDay) { this.EndTime.AddDays(1); }
        }

        //休憩時間(いらない？)
        //public void BreakTime(string a)
        //{
           
        //}

    }
}
