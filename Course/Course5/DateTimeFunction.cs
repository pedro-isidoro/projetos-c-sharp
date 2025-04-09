using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course5
{
    internal class DateTimeFunction
    {
        public void Time()
        {
            //DateTime representa um instante
            //E quanto Ticks(nanosegundos) passaram desde o ano 1

            /*DateTime d1 = new (2018, 11, 25);
            DateTime d2 = new (2018, 11, 25, 20, 45, 3);
            DateTime d3 = new (2018, 11, 25, 20, 45, 3, 500);

            DateTime d4 =  DateTime.Now;
            DateTime d5 =  DateTime.Today;
            DateTime d6 =  DateTime.UtcNow;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);*/

            /*DateTime d1 = DateTime.Parse("2000-08-15");
            DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");

            DateTime d3 = DateTime.Parse("15-08-2000");
            DateTime d4 = DateTime.Parse("15-08-2000 13:05:58");

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);*/

            /*DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d2 = DateTime.ParseExact("15-08-2000 13:05:58", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);*/

            /*DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);*/

            /*DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);*/

            /*DateTime x = new DateTime();
            DateTime y = x.Add(timeSpan);
            DateTime y = x.AddDays(double);
            DateTime y = x.AddHours(double);
            DateTime y = x.AddMilliseconds(double);
            DateTime y = x.AddMinutes(double);
            DateTime y = x.AddMonths(int);
            DateTime y = x.AddSeconds(double);
            DateTime y = x.AddTicks(long);
            DateTime y = x.AddYears(int);
            DateTime y = x.Subtract(timeSpan);
            TimeSpan t = x.Subtract(dateTime);*/
        }
    }
}
