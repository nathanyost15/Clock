using System;
namespace ClockLib
{
    public class Time
    {
        private DateTime time;
        private int hour, minute, second, ms;
        private string period;
        public Time()
        {
            update();
        }

        public void update()
        {
            time = DateTime.Now;
            hour = (time.Hour > 12) ? time.Hour - 12 : time.Hour;
            hour = (hour == 0) ? hour + 12 : hour;
            minute = time.Minute;
            second = time.Second;
            ms = time.Millisecond;
            period = (time.Hour >= 0 && time.Hour < 12) ? "am" : "pm";
        }

        public int getHour()
        {
            return hour;
        }

        public int getMinute()
        {
            return minute;
        }

        public int getSecond()
        {
            return second;
        }

        public int getMS()
        {
            return ms;
        }

        public string getPeriod()
        {
            return period;
        }

        public string toString()
        {
            string min = "" + minute;
            if (minute < 10)
                min = "0" + min;
            return ("" + hour + ":" + min + period);
        }
    }
}