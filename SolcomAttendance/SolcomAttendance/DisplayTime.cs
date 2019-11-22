using System;
using System.Collections.Generic;
using System.Text;

namespace SolcomAttendance
{
    public class DisplayTime
    {
        public string Hour { get; set; }

        public string Min { get; set; }

        public DisplayTime(DateTime ArgTime)
        {
            Hour = String.Format("{0:D2}", ArgTime.Hour.ToString());
            Min = String.Format("{0:D2}", ArgTime.Minute.ToString());
        }
    }
}
