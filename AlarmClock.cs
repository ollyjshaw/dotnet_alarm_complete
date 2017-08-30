using System;
using Xunit;

namespace dotnet
{
    public class AlarmClock
    {
        public string readTime(String time)
        {
            var clockTime = new ParsedTime(time);
            switch (clockTime)
            {
                case ParsedTime s when s.Hours==7 && s.Mins == 0:
                    return "wake up!";
                case ParsedTime s when s.Mins == 0:
                    return "beep";
                default:
                    return "tick";
            }
        }
    }
    public class ParsedTime
    {
        public ParsedTime(String time) 
        {
            Hours = Convert.ToInt32(time.Substring(0,2));
            Mins =  Convert.ToInt32(time.Substring(3,2));
        }
        public int Mins {get;}
        public int Hours {get;}
    }
}
