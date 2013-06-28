using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace EvalServiceSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            EvalServiceSelfHostManager hostManager = new EvalServiceSelfHostManager();
            hostManager.Open();

            Console.WriteLine("Host is up and running");

            foreach (ServiceEndpoint se in hostManager.Description.Endpoints)
            {
                Console.WriteLine(se.Address.ToString());
            }

            Console.ReadKey();

            hostManager.Close();
        }
    }
}
