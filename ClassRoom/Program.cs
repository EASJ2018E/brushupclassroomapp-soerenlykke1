using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum klasseA = new KlasseRum();

            klasseA.KlasseNavn = "3B";
            klasseA.SemesterStart = new DateTime(2018,9,4);
            Console.WriteLine(klasseA.SemesterStart);
            Studerende student1 = new Studerende("Søren", 7, 2);
            //Aner ikke hvad deres fødelesdag er...
            Studerende student2 = new Studerende("Zaki", 1, 2);
            Studerende student3 = new Studerende("Arlind", 3, 4);


            klasseA.Klasseliste.Add(student1);
            klasseA.Klasseliste.Add(student2);
            klasseA.Klasseliste.Add(student3);


            foreach (var studerende in klasseA.Klasseliste)
            {
                Console.WriteLine(studerende);
            }
            Console.ReadLine();



        }
    }
}
