using System.Collections.Generic;
using System.Net.Http.Headers;
using System.IO;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace celloveszetCLI_1
{
    public class Program
    {
        static List<cellovo> list = new List<cellovo>();
        static void Main(string[] args)
        {
            string[] osszes = File.ReadAllLines("lovesek.csv");

            foreach (var item in osszes)
            {
                list.Add(new cellovo(item));
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // 9. Feladat
            foreach (var item in list)
            {
                Console.WriteLine($"{item.nev} + {item.legnagyobb()}");
            }

            //10. Feladat

            cellovo max = list[0];

            foreach (var item in list)
            {
                if (item.legnagyobb() > max.legnagyobb())
                {
                    max = item;
                }
            }
            Console.WriteLine(max);

            //11. Feladat
            cellovo min_atlag = list[0];

            foreach (var item in list)
            {
                if (item.atlag() < min_atlag.atlag())
                {
                    min_atlag = item;
                }
            }
            Console.WriteLine(min_atlag);
        }
    }
}