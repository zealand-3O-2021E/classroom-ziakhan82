using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class KlasseRum
    {
        public string KlasseNavn { get; set; }

        public List<studerende> Klasseliste { get; set; }

        public DateTime SemesterStart { get; set; }

        public KlasseRum()
        {
            Klasseliste = new List<studerende>();
            SemesterStart = new DateTime();
        }

        public void HvilkenÅrstid()
        {
            var resultliste  = 
                this.Klasseliste.GroupBy(x => x.Årstid())
                .Select(aarstidGroup => new {
                    aarstid = aarstidGroup.Key,
                    countAarstid = aarstidGroup.Count()
                });

            foreach (var item in resultliste)
            {
                Console.WriteLine($"Årstid: {item.aarstid} antal: {item.countAarstid} ");

            }
        }

    }
}
