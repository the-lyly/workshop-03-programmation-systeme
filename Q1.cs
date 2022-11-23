using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop_03_programmation_systeme
{
    delegate int DELGA(int v1, int v2);
    class Q1
    {
        static void Main1(string[] args)
        {
            DELGA d = new DELGA(work.methode);
            Console.WriteLine((d.Invoke(3, 7).ToString()));
            Console.Read();
        }
    }
    static class work
    {
        static public int methode(int v1, int v2)
        {
            return v1 + v2;
        }
    }
}



