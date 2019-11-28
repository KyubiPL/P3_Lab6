using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using RandomDataGenerator.Randomizers;
using RandomDataGenerator.FieldOptions;

namespace P3_Lab6
{
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public int id;

        public Osoba(string imie, string nazwisko, int id)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.id = id;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<int> lista = Enumerable.Range(150, 100).ToList();
            //lista.ForEach(x => Console.WriteLine(x));

            var randFN = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            var randLN = RandomizerFactory.GetRandomizer(new FieldOptionsLastName());

            List<Osoba> osoby = lista.Select(x => new Osoba(
                  randFN.Generate(),
                  randLN.Generate(),
                  x)).ToList();

            foreach (var item in osoby)
            {
                Console.WriteLine($"{item.id} : {item.imie} {item.nazwisko}");
            }
            //posortowac najpierw po nazwisku potem po imeieniu
            #region nowe
            /*
            //Osoba test = new Osoba()
            //{
            //    imie = "aaa",
            //    nazwisko = "ddd",
            //    id = 10
            //};

            List<Osoba> osoby =
            lista.Select(x => new Osoba()
            {
                imie = x.ToString(),
                nazwisko = "AAA",
                id = x
            }).ToList();
            //.ForEach(x=> Console.WriteLine($"{x.id}:{x.imie} {x.nazwisko}"));
            osoby[45].nazwisko = "BBB";
            //List<string> nazwiska =
            osoby.Select(x => x.nazwisko).Distinct().ToList().ForEach(Console.WriteLine);
            //.ForEach(x=>Console.WriteLine(x));

            Osoba osobab = osoby.Where(x => x.nazwisko.StartsWith("B")).FirstOrDefault();
            Console.WriteLine($"{osobab.id}:{osobab.imie} {osobab.nazwisko}");

            int iENS = 10;
            int nrStrony = 2;

            List<Osoba> strona = osoby.Skip(iENS * (nrStrony - 1))
                .Take(iENS).ToList();

            foreach (var item in strona)
            {
                Console.WriteLine($"{item.id}:{item.imie} {item.nazwisko}");
            }
            */
            #region stare
            // .Select(x=>(double)x)

            //Cast<double>() zamiast Select, ale coś nie chodzi

            /*
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            IEnumerable<int> poprze3 = lista.Where(x => x % 3 == 0);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            int suma = poprze3.Sum();
            Console.WriteLine(suma);

            double srednia = poprze3.Average();
            Console.WriteLine(srednia);
            
            
            foreach (var item in osoby)
            {
                
            }
            */
            #endregion
            #endregion

            Console.ReadLine();
        }
    }
}
