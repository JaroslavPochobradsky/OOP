using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Objekt
    {
        public int objemObjektu(int strana1,int strana2,int strana3)
        {
            int objemTelesa = strana1 * strana2 * strana3;
            return objemTelesa;
        }
        public int povrchObjektu(int strana1, int strana2, int strana3)
        {
            int povrchTelesa = 2 * (strana1 * strana2 + strana2 * strana3 + strana1 * strana3);
            return povrchTelesa;
        }
        public int telesovaUhlopricka(int strana1, int strana2, int strana3)
        {
            int vysledek = (int)Math.Sqrt(strana1 * strana1 + strana2 * strana2 + strana3 * strana3);
            return vysledek;
        }
        public int stenovaUhlopricka(int strana1, int strana2)
        {
            int vysledek = (int)Math.Sqrt(strana1 * strana1 + strana2 * strana2);
            return vysledek;
        }
    }
}
