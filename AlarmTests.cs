using System;
using Xunit;

namespace dotnet
{
    public class AlarmTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(4, 2+2);
        }
        [Fact]
        public void TestTicksEveryMin()
        {
            var alarm = new AlarmClock();
            var sound = alarm.readTime("19:01");
            Assert.Equal(sound, "tick");
        }
        [Fact]
        public void TestBeepsEveryHour()
        {
            var alarm = new AlarmClock();
            var sound = alarm.readTime("19:00");
            Assert.Equal(sound, "beep");
        }
        [Fact]
        public void TestWakesUpAt7()
        {
            var alarm = new AlarmClock();
            var sound = alarm.readTime("07:00");
            Assert.Equal(sound, "wake up!");
        }
    }
}
