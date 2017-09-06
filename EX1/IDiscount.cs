using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    interface IDiscount<T>
    {
        void Discount(T t);
    }
}
