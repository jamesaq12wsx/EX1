using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public static class MyDateTimeExtension
    {
        public static string RocDate(this DateTime dt)
        {
            //dt = DateTime.Now;

            string dty = (Int32.Parse(dt.Year.ToString()) - Int32.Parse("1911")).ToString();

            string rocDate = string.Format("民國{0}年{1}月{2}號\t 時間:{3}", dty, dt.Month, dt.Day, dt.ToString("HH:mm"));

            return rocDate;
        }
    }
}
