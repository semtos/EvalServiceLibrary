using EvalServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace EvalServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(EvalService));
            host.Open();

            Console.WriteLine("Service is up and running");

            foreach (ServiceEndpoint se in host.Description.Endpoints)
            {
                Console.WriteLine(se.Address.ToString());
            }

            Console.ReadKey();
            host.Close();
        }
    }
}
