using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFBiblioteka
{
    /// <summary>
    /// implementacja interfejsu IKalkulator
    /// </summary>
    public class KalkulatorService : IKalkulator
    {
        /// <summary>
        /// implementacja metody dodajacej dwie liczby
        /// </summary>
        /// <param name="wartosc1">pierwsza wartosc w dodawaniu</param>
        /// <param name="wartosc2">druga wartosc w dodawaniu</param>
        /// <returns>zwraca wartosc dodawania</returns>
        public int dodaj(int wartosc1, int wartosc2)
        {
            int wynik = wartosc1 + wartosc2;
            return wynik; 
        }
    }
}
