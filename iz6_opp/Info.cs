using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz6_opp
{
    internal class Info<T> where T : ЧисловыеТипы
    {

        public static void GetFullInfo(T geo)
        {
            geo.GetInfo();
        }

        public static void GetValue(T geo)
        {
            Console.WriteLine(geo.value);
        }

        public static void GetName(T geo)
        {
            Console.WriteLine(geo.name);
        }
    }
}
