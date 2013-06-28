using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AccountServiceLibrary
{
    [ServiceContract]
    public interface IAccount
    {
        [OperationContract]
        List<DTOAccount> GetAccounts();
        [OperationContract]
        void AddAccount(DTOAccount dto);
    }
}
