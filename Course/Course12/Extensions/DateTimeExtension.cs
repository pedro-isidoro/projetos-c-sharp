using System;
using System.Globalization;
//namespace Course12.Extensions
//ou - assim sera puxado junto do system
namespace System
{
	public static class DateTimeExtension
	{
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if(duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture)+" hours";

            }
            else {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture)+" days";
            }

        }

    }
}

