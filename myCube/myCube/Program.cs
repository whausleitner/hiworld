using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCube
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("Geben Sie die Kantenlänge ein (Längeneinheiten): ");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Das Volumen beträgt" + a + "Volums-Einheiten!");

        }
    }
}
