using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlarmConsole
{

    public class ClockArgs
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        // 构造函数
        public ClockArgs(int hour,int minute,int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
    }

    // 定义处理Tick事件的委托
    public delegate void TickHandler(object sender, ClockArgs args);

    // 定义处理Alarm事件的委托
    public delegate void AlarmHandler(object sender, ClockArgs args);

    public class AlarmClock
    {
        
        public event TickHandler Tick;
        public event AlarmHandler Alarm;
        // 闹钟当前时间
        private int hour;
        private int minute;
        private int second;
        // 闹钟设定响铃时间
        public ClockArgs alarmTime;

        public int Second
        {
            get { return second; }
            set { second = value; }
        }


        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }


        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        // 构造函数
        public AlarmClock(int hour, int minute, int second)
        {
            // 利用现在的时间初始化闹钟类
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        // 运行闹钟
        public void SetON()
        {
            // 让闹钟一直运行
            while (true)
            {
                Thread.Sleep(1000);
                // 改变时钟刻度
                if (second < 60)
                {
                    second++;
                }
                else
                {
                    // 秒数为60
                    second = 0;
                    if(minute < 60)
                    {
                        minute++;
                    }
                    else
                    {
                        // 分钟为60
                        minute = 0;
                        hour++;
                    }
                }

                // 每过一秒，就Tick一下
                Tick(this, new ClockArgs(hour, minute, second));

                // 判断是否到了响铃时间，如果到了就响铃
                if(hour == alarmTime.Hour && minute == alarmTime.Minute && second == alarmTime.Second)
                {
                    Alarm(this, alarmTime);
                }
            }
        }

        // 设置响铃时间
        public void SetAlarmTime(int hour,int minute,int second)
        {
            alarmTime = new ClockArgs(hour, minute, second);
        }
    }
}
