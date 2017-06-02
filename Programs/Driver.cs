using System;
using System.Threading;
using ClockLib;
public class Driver
{
	public static void Main()
	{
        Time time = new Time();
        while(true)
        {            
            time.update();
            switch(time.getMinute())
            {
                case 30:
                    half();
                    break;
                case 0:
                case 37:
                    hourly(time);
                    break;
            }          
            int wait = 60 - time.getSecond();
            Thread.Sleep(wait * 1000);
        }
	}

    static void half()
    {
        System.Media.SoundPlayer s = new System.Media.SoundPlayer();
        s.SoundLocation = "./half.wav";
        s.Load();
        s.Play();
    }

    static void hourly(Time time)
    {
        int delay = 4; // Seconds
        System.Media.SoundPlayer s = new System.Media.SoundPlayer();
        s.SoundLocation = "./hourly.wav";
        s.Load();
        for (int count = 0; count < time.getHour(); count++)
        {
            if (count != 0)
                Thread.Sleep(delay * 1000);
            s.Play();
        }
    }
}