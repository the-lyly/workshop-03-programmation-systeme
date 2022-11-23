using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WS_Memoire
{
    delegate int DELGA(int v1, int v2);
    class Q1
    {
        public delegate void delg();

    public class A
    {
        public void ma()
        {
            Console.WriteLine("ma");
        }
    }
    public class B
    {
        public void mb()
        {
            Console.WriteLine("mb");
        }
    }
    class Q4
    {
        static void Main4(string[] args)
        {
            A a;
            B b;
            delg d;
            delg[] ds;
            delg dsm;
            int i;

            a = new A();
            b = new B();
            d = new delg(a.ma);
            ds = new delg[2];

            ds[0] = a.ma;
            ds[1] = b.mb;
            dsm = new delg(a.ma);
            dsm += b.mb;

            a.ma();
            b.mb();
            d.Invoke();
            for (i = 0; i < 2; i++)
            {
                ds[i].Invoke();

            }
            dsm.Invoke();
            dsm -= b.mb;
            dsm.Invoke();

            Console.Read();
        }
    }
}

