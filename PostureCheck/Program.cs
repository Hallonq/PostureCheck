using System;

namespace PostureCheck
{
    public class Program
    {
        static void Main(string[] args)
        {
            TimeSpan startTime = DateTime.Now.TimeOfDay;

            bool running = true;
            while (running)
            {
                Console.WriteLine($"New day starting @ { DateTime.Now.ToString("yyyy-MMMM-dddd\nHH:mm") }");

                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                if (currentTime.Minutes == startTime.Minutes && currentTime.Seconds == startTime.Seconds && currentTime.Milliseconds == startTime.Milliseconds)
                {
                    Console.Beep(1000, 500);
                    Console.WriteLine("Time to take a 5 minute break! \n" +
                        "Drink some water and fix your posture. :)");
                }
            }
        }
    }
}