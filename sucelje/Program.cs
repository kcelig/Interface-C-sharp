using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace suc
{
    class Ucenik : IComparable<Ucenik> {

        public string Ime { get; set; }
        public int Prosjek { get; set; }

        public Ucenik(string Ime, int Prosjek) {
            this.Ime = Ime;
            this.Prosjek = Prosjek;
        }

        public override string ToString()
        {
            return Ime + "\t" + Prosjek;
        }
        

        public int CompareTo(Ucenik ucenik)
        {
            if (this.Prosjek < ucenik.Prosjek)
            {
                return -1;
            }
            else if (this.Prosjek > ucenik.Prosjek)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Ucenik> popisUcenika = new List<Ucenik>();

            Ucenik p1 = new Ucenik("Pero", 1983);
            Ucenik p2 = new Ucenik("Ivo", 1975);
            Ucenik p3 = new Ucenik("Ana", 2000);

            popisUcenika.Add(p1);
            popisUcenika.Add(p2);
            popisUcenika.Add(p3);

            popisUcenika.Sort();

            /*
            Console.WriteLine("ISPIS");
            for (int i = 0; i < lista.Count; i++) {
                Console.WriteLine(lista[i]);
            }
             */

            foreach (Ucenik u in popisUcenika) {
                Console.WriteLine(u.ToString());
            }

            Console.ReadKey();


        }
    }
}
