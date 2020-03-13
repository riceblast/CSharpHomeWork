using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmConsole
{
    class TestAlarm
    {
        public static void Main(string[] args)
        {
            AlarmClock alarmClock = new AlarmClock(20,0,0); // 闹钟从晚上8点开始
            alarmClock.SetAlarmTime(20, 1, 45); // 闹钟晚上8点1分45秒响铃
            alarmClock.Tick += HandleTick; // 闹钟每秒钟Tick一次
            alarmClock.Alarm += HandleAlarm; // 闹钟在规定时刻响铃
            alarmClock.SetON();
        }

        public static void HandleTick(object sender,ClockArgs args)
        {
            Console.WriteLine($"Tick Tack, it's {args.Hour}:{args.Minute}:{args.Second} Now");
        }

        public static void HandleAlarm(object sender, ClockArgs args)
        {
            Console.WriteLine($"Boom!!!!!! It's {args.Hour}:{args.Minute}:{args.Second} Now");
        }
    }
}
