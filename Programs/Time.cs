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
	
	/*
	* Updates the DateTime struct that will keep track of time.
	*/
        public void update()
        {
		time = DateTime.Now;
		
		// Converts 24 hour clock to 12 hour
		hour = (time.Hour > 12) ? time.Hour - 12 : time.Hour;
		
		// Converts 24 hour clock to 12 hour clock in the special case that it is 0 o'clock
		hour = (hour == 0) ? hour + 12 : hour;
		minute = time.Minute;
		second = time.Second;
		ms = time.Millisecond;
		period = (time.Hour >= 0 && time.Hour < 12) ? "am" : "pm";
        }

	/*
	* Returns the current hour.
	* Return: Integer that represents an hour within a 12 hour clock. (1-12)
	*/
        public int getHour()
        {
		return hour;
        }

	/*
	* Returns the current minute.
	* Return: Integer that represents a minute within an hour. (0-59)
	*/
        public int getMinute()
        {
		return minute;
        }

	/*
	* Returns the current second.
	* Return: Integer that represents a second within a minute. (0-59)
	*/
        public int getSecond()
        {
		return second;
        }

	/*
	* Returns the current milisecond.
	* Return: Integer that represents a milisecond within a second. (0-999)
	*/
        public int getMS()
        {
		return ms;
        }

	/*
	* Returns the period of day in a 12 hour clock. (am/pm)
	* Return: String that represents the period of day, am or pm.
	*/
        public string getPeriod()
        {
		return period;
        }

	/*
	* Returns a String that represents the current time of day in 12 hour clock.
	* Return: String that represents the current time of day in an easily readable 12 hour format.
	*/
        public string toString()
        {
		string min = "" + minute;
		if (minute < 10)
		min = "0" + min;
		return ("" + hour + ":" + min + period);
        }
    }
}