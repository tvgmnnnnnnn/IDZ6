using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz6_opp
{
    internal class НатуральныеЧисла: ЧисловыеТипы
    {
        public string zone;

        public НатуральныеЧисла(string pName, double pValue, string pZone) : base(pName, pValue, pZone)
        {
            zone = pZone;
        }
        override public void GetInfo()
        {
            Console.WriteLine(name + " " + value + " " + zone);
        }
    }
}
