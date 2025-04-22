using System;
using System.Threading;

// 定义闹钟类
public class AlarmClock
{
    public delegate void alarmm();
    // 定义 Tick 事件
    public event alarmm Tick;
    // 定义 Alarm 事件
    public event alarmm Alarm;

    // 闹钟的响铃时间（秒）
    public int AlarmTime { get; set; }

    // 启动闹钟
    public void Start()
    {
        for (int i = 1; i <= AlarmTime; i++)
        {
            // 触发 Tick 事件
            Tick();
            Thread.Sleep(1000);  // 模拟 1 秒钟的嘀嗒
        }

        // 触发 Alarm 事件
        Alarm();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 创建闹钟实例
        AlarmClock clock = new AlarmClock();
        clock.AlarmTime = Console.Read()-(int)'0';  // 设置闹钟响铃时间为 10 秒

        // 订阅 Tick 事件
        clock.Tick += () => Console.WriteLine("Tick...");

        // 订阅 Alarm 事件
        clock.Alarm += () => Console.WriteLine("Alarm! Wake up!");

        // 启动闹钟
        Console.WriteLine($"闹钟启动，将在 {clock.AlarmTime} 秒后响铃...");
        clock.Start();
    }
}