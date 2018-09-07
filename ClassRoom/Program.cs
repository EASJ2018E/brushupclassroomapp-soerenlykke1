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

            Console.ReadLine();



        }
    }
}
