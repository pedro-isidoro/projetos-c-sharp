using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course5
{
    internal class TimeSpanFunction
    {
        public void Time() {
            //Ele representa uma duração em forma de Ticks
            //1.13:45:58.300 - Dia.Hora:Min:Seg.Mileseg

            /*TimeSpan t1 = new();
            TimeSpan t2 = new(900000000L);
            TimeSpan t3 = new(2, 11, 21);
            TimeSpan t4 = new(1, 2, 11, 21);
            TimeSpan t5 = new(1, 2, 11, 21, 321);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);*/

            /*TimeSpan t1 = TimeSpan.FromDays(1.5);
            TimeSpan t2 = TimeSpan.FromHours(1.5);
            TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t6 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);*/

            /*TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);*/

            /*TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);*/

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2.0);
            TimeSpan div = t2.Divide(2.0);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
            Console.WriteLine(div);
        }
    }
}
