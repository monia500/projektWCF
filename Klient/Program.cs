using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klient.ServiceReference1;

namespace Klient
{
    /// <summary>
    /// Klasa Klienta, nawiazuje polaczenie z Hostem
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            KalkulatorClient klient = new KalkulatorClient();

            int a, b, wynik;
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());

            wynik = klient.dodaj(a, b);

            Console.WriteLine(wynik);
            Console.ReadLine();
            klient.Close();


        }
    }
}
