using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetCLI_1
{
    public class cellovo
    {

        public string nev { get; set; }
        public int elsoloves { get; set; }
        public int masodikloves { get; set; }
        public int harmadikloves { get; set; }
        public int negyedikloves { get; set; }

        public cellovo(string line)
        {
            string[] darabok = line.Split(";");

            this.nev = darabok[0];
            this.elsoloves = Convert.ToInt32(darabok[1]);
            this.masodikloves = Convert.ToInt32(darabok[2]);
            this.harmadikloves = Convert.ToInt32(darabok[3]);
            this.negyedikloves = Convert.ToInt32(darabok[4]);
        }

        public cellovo(string nev, int elsoloves, int masodikloves, int harmadikloves, int negyedikloves)
        {
            this.nev = nev;
            this.elsoloves = elsoloves;
            this.masodikloves = masodikloves;
            this.harmadikloves = harmadikloves;
            this.negyedikloves = negyedikloves;
        }

        public override string ToString()
        {
            return nev + " " + elsoloves + " " + masodikloves + " " + harmadikloves + " " + negyedikloves;
        }


        public int legnagyobb()
        {
            List<int> lovesek = new List<int>();

            lovesek.Add(elsoloves);
            lovesek.Add(masodikloves);
            lovesek.Add(harmadikloves);
            lovesek.Add(negyedikloves);

            return lovesek.Max();
        }

        public double atlag()
        {
            return (elsoloves + masodikloves + harmadikloves + negyedikloves) / 4;
        }
    }
}