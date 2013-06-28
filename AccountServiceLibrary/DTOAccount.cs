using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AccountServiceLibrary
{
    [DataContract]
    public class DTOAccount
    {
        [DataMember]
        public int AccountNumber { get; set; }
        [DataMember]
        public string AccountOwnerFullName { get; set; }
    }
}
