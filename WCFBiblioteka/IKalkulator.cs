using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFBiblioteka
{
    [ServiceContract]
    public interface IKalkulator
    {
        [OperationContract]
         int dodaj(int wartosc1, int wartosc2);
    }

}
