using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop_03_programmation_systeme
{
    delegate int DELG(int v);
    class Q2
    {
        static void Main2(string[] args)
        {
            DELG d = x => x * x;
            Console.WriteLine(d.Invoke(7).ToString());
            Console.Read();
        }
    }
    
        }
   



