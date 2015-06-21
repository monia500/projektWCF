using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using WCFBiblioteka;

namespace Host
{
    /// <summary>
    /// Klasa Hosta
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("net.tcp://192.168.0.11:8000/WCFProjekt/");
            ServiceHost selfHost = new ServiceHost(typeof(KalkulatorService), baseAddress);
            NetTcpBinding b = new NetTcpBinding();
            b.Security.Mode = SecurityMode.None;

            try
            {
                selfHost.AddServiceEndpoint(typeof(IKalkulator), b, "KalkulatorService");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                selfHost.Description.Behaviors.Add(smb);

                selfHost.Open();
                Console.WriteLine("Usługa jest gotowa");
                Console.WriteLine("Wcisnij <ENTER> zeby zamknac usluge");
                Console.WriteLine();
                Console.ReadLine();

                selfHost.Close();
            }
            catch(CommunicationException e)
            {
                Console.WriteLine("Wychwycono blad: {0}", e.Message);
                selfHost.Abort();

            }
        }
    }
}
