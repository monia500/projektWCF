using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFBiblioteka
{
    /// <summary>
    /// interfejs - kontrakt uslugi
    /// </summary>
    [ServiceContract]
    public interface IKalkulator
    {
        /// <summary>
        /// metoda realizujaca dodawanie
        /// </summary>
        /// <param name="wartosc1">pierwsza wartosc podczas dodawania</param>
        /// <param name="wartosc2">druga wartosc podczas dodawania</param>
        /// <returns>zwraca wynik dodawania</returns>
        [OperationContract]
         int dodaj(int wartosc1, int wartosc2);
    }

}
