using Client.EvalServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            EvalServiceClient esc = new EvalServiceClient("WSHttpBinding_IEvalService");
            esc.SubmitEval(new Eval() { Comments = "Coming from code behind", Submitter = "Semih", TimeSubmitted = DateTime.Now });

            Eval[] evals = esc.GetEvals();

            foreach (Eval item in evals)
            {
                Console.WriteLine(item.Comments + " - " + item.Submitter);
            }

            Console.ReadKey();
        }
    }
}
