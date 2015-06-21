using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFBiblioteka
{
    public class KalkulatorService : IKalkulator
    {

        public int dodaj(int wartosc1, int wartosc2)
        {
            int wynik = wartosc1 + wartosc2;
            return wynik; 
        }
    }
}
