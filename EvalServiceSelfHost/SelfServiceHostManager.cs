using EvalServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace EvalServiceSelfHost
{
    public class EvalServiceSelfHostManager : ServiceHost
    {
        public EvalServiceSelfHostManager()
            : base(typeof(EvalService), new Uri("http://localhost:8765/"))
        {

        }

        protected override void OnOpening()
        {
            base.OnOpening();

            this.AddServiceEndpoint(typeof(IEvalService), new BasicHttpBinding(), "test");

            //Birden fazla servis için burda for içerisinde dönülmeli, her bir servise aşağıdaki behaviour eklenmeli.

            ServiceMetadataBehavior meta = this.Description.Behaviors.Find<ServiceMetadataBehavior>();

            if (meta != null)
            {
                meta.HttpGetEnabled = true;
            }
            else
            {
                meta = new ServiceMetadataBehavior() { HttpGetEnabled = true };
                this.Description.Behaviors.Add(meta);
            }

            ServiceDebugBehavior debug = this.Description.Behaviors.Find<ServiceDebugBehavior>();
            debug.IncludeExceptionDetailInFaults = true;

            ServiceBehaviorAttribute behavior = this.Description.Behaviors.Find<ServiceBehaviorAttribute>();
            behavior.InstanceContextMode = InstanceContextMode.PerCall;

        }
    }
}
