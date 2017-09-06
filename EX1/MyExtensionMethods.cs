using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class MyExtensionMethods
    {
        public static string RocTime(this DateTime date)
        {
            date = DateTime.Now;

            string dty = (Int32.Parse(date.Year.ToString()) - Int32.Parse("1911")).ToString();

            string rocDate = string.Format("民國{0}年{1}月{2}號\t 時間:{3}", dty, date.Month, date.Day, date.ToString("HH:mm"));

            return rocDate;
        }
    }
}
