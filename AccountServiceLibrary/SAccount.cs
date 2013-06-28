using CommonServiceLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AccountServiceLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class SAccount : ServiceBase, IAccount
    {
        public static List<DTOAccount> accounts = new List<DTOAccount>();

        public List<DTOAccount> GetAccounts()
        {
            return accounts;
        }

        public void AddAccount(DTOAccount dto)
        {
            accounts.Add(dto);
        }
    }
}
