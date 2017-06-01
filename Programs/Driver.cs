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
            Console.WriteLine(time.toString());          
            int wait = 60 - time.getSecond();
            Thread.Sleep(wait * 1000);
        }
	}
}