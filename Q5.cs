using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop_03_programmation_systeme
{
    delegate int postRadio(int v1, int v2);
    class Radio
    {
    }

        static void Main(string[] args)
    {
        Radio Nrj, Fun;
        posteRadio poste1, poste2, poste3;
        Nrj = new Radio("nrj", "musique nrj");
        Fun = new Radio("fun", "musique fun");
        poste1 = new posteRadio();
        poste2 = new posteRadio();
        poste3 = new posteRadio();
        poste1.reglerStation("nrj");
        poste2.reglerStation("nrj");
        poste3.reglerStation("fun");
        Nrj.diffuserMusique();
        Fun.diffuserMusique();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("-----------------------------");
        Console.ForegroundColor = ConsoleColor.Gray;
        poste1.reglerStation("fun");
        poste2.reglerStation("nrj");
        poste3.reglerStation("fun");
        Nrj.diffuserMusique();
        Fun.diffuserMusique();
        Console.Read();
    }
}