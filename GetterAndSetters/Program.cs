using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {

            Movies avengers = new Movies("The Avengers", "Joss Wheadon", "PG-13");
            Movies shrek = new Movies("Shrek", "Adam Adamson", "PG");



            Console.WriteLine(avengers.Rating);
            Console.ReadLine();
        }
    }
}
