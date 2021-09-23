using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class studerende
    {
        public string Navn { get; set; }

        //public int FødselsMåned { get; set; }

        private int _fødselsMåned;

        public int FødselsMåned
        {
            get { return _fødselsMåned; }
            set {
                if (value >= 1 && value <= 12)
                  _fødselsMåned = value;
                else
                  throw new ArgumentException($"Værdien skal ligge i intervallet 1-12, du skrev {value}");
            }
        }

        public int FødselsDag { get; set; }

        public studerende(string navn, int måned, int dag)
        {
            Navn = navn;
            FødselsMåned = måned;
            FødselsDag = dag;
        }

        public string Årstid()
        {
            switch (FødselsMåned)
            {
                case 12:
                case 1:
                case 2:
                    return "Vinter";
                case 3:
                case 4:
                case 5:
                    return "Forår";
                case 6:
                case 7:
                case 8:
                    return "Sommer";
                case 9:
                case 10:
                case 11:
                    return "Efterår";
                default:
                    return $"Denne måned: {FødselsMåned} findes ikke skal være i 1-12";

            }

        }

        public override string ToString()
        {
            return $"Navn: {Navn} , måned: {FødselsMåned}, dag: {FødselsDag}, Årstid: {Årstid()}";
        }


    }
}
