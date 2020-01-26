using System;
using System.Collections.Generic;
using System.Text;

namespace SolcomAttendance
{
    public class SetValue
    {
        private System.Globalization.CultureInfo Coutry;


        private DateTime Day;
        //�n�Ǝ���
        public DateTime StartTime { get; set; }
        //�I�Ǝ���
        public DateTime EndTime { get; set; }
        //���v����
        public short BreakTime { get; set; }

        public SetValue(DateTime ArgDay)
        {
            Coutry = new System.Globalization.CultureInfo("ja-JP");
            Day = ArgDay;

            //�ݒ��ʂɕ\���������
            StartTime = new DateTime(ArgDay.Year, ArgDay.Month, ArgDay.Day, 9, 0, 0);
            EndTime = new DateTime(ArgDay.Year, ArgDay.Month, ArgDay.Day, 18, 0, 0);
            //BreakTime = "";
 
        }
        
        //�n�Ǝ���
        public void UpdateStartTime(int ArgHour, int ArgMin)
        {
            //�ݒ肳��Ă���l���擾
            var MyYear = this.StartTime.Year;//(��ʂ̃o�C���h���ɍ��킹��)
            var MyMonth = this.StartTime.Month;//(��ʂ̃o�C���h���ɍ��킹��)
            var MyDay = this.StartTime.Day;//(��ʂ̃o�C���h���ɍ��킹��)

            this.StartTime = new DateTime(MyYear, MyMonth, MyDay, ArgHour, ArgMin, 0);

        }

        //�I�Ǝ���
        public void UpdateEndTime(int ArgHour, int ArgMin, bool IsNextDay)
        {
            //�ݒ肳��Ă���l���擾
            var MyYear = this.EndTime.Year;//(��ʂ̃o�C���h���ɍ��킹��)
            var MyMonth = this.EndTime.Month;//(��ʂ̃o�C���h���ɍ��킹��)
            var MyDay = this.EndTime.Day;//(��ʂ̃o�C���h���ɍ��킹��)

            this.EndTime = new DateTime(MyYear, MyMonth, MyDay, ArgHour, ArgMin, 0);


            if (IsNextDay) { this.EndTime.AddDays(1); }
        }

        //�x�e����(����Ȃ��H)
        //public void BreakTime(string a)
        //{
           
        //}

    }
}
