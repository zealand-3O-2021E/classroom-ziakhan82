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
            //opgave 3
            var klasserum = new KlasseRum();
            klasserum.KlasseNavn = "Zealand-3";
            klasserum.SemesterStart = new DateTime(2019, 1, 1);
            klasserum.Klasseliste.Add(new studerende("Hans", 5, 7));
            klasserum.Klasseliste.Add(new studerende("Grete", 3, 20));
            klasserum.Klasseliste.Add(new studerende("Bo", 10, 1));
            //klasserum.Klasseliste.Add(new studerende("Svend", 14, 1)); //fejl i måned
            klasserum.Klasseliste.Add(new studerende("Grete1", 3, 1));
            klasserum.Klasseliste.Add(new studerende("Grete2", 3, 2));
            klasserum.Klasseliste.Add(new studerende("Grete3", 3, 3));
            klasserum.Klasseliste.Add(new studerende("Grete4", 3, 4));
            klasserum.Klasseliste.Add(new studerende("Bo1", 10, 1));
            klasserum.Klasseliste.Add(new studerende("Bo2", 10, 2));
            klasserum.Klasseliste.Add(new studerende("Bo3", 10, 3));
            klasserum.Klasseliste.Add(new studerende("Bo4", 10, 4));
            klasserum.Klasseliste.Add(new studerende("Bo5", 10, 5));

            //opgave 4, udskriv oplysningerne
            Console.WriteLine($"Klassenavn : {klasserum.KlasseNavn}");
            Console.WriteLine($"Semesterstart : {klasserum.SemesterStart}");
            foreach (var studerende in klasserum.Klasseliste)
            {
                //Obs. jeg bruger en overide på tostring() metoden i studerende klasse
                //for at udskrive disse oplysninger
                Console.WriteLine(studerende.ToString());
            }

            klasserum.HvilkenÅrstid();

        }
    }
}
