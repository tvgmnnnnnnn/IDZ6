using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz6_opp
{
    class Programm
    {
        static void Main(string[] args)
        {
            НатуральныеЧисла natch = new НатуральныеЧисла("Натуральное число ", 2, " [1;+▲]");
            ДробныеЧисла drobch = new ДробныеЧисла("Дробное число ", 2.5, " [-▲;+▲]");
            Info<ДробныеЧисла>.GetFullInfo(drobch);
            Info<НатуральныеЧисла>.GetFullInfo(natch);
            Info<ЧисловыеТипы>.GetName(natch);
        }
    }
}
