using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz6_opp
{
    internal class ЧисловыеТипы
    {
        public double value;
        public string name;
        public string zone;
        public ЧисловыеТипы(string pName, double pValue, string pZone)
        {
            value = pValue;
            name = pName;
            zone = pZone;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine(name+" "+value);
        }
    }
}
