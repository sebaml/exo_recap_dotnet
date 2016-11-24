using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataRequest
{
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class SupplierType
    {
        [DataMember]
        public string CompanyName { get; set; }

        [DataMember]
        public string ContactName { get; set; }

        [DataMember]
        public string ContactTitle { get; set; }

        [DataMember]
        public string Country { get; set; }
    }
}
