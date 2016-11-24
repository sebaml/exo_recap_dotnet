﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataRequest
{
    [DataContract]
    public class SupplierDetail
    {
        [DataMember]
        public long SupplierId { get; set; }

        [DataMember]
        public string CompanyName { get; set; }

        [DataMember]
        public string ContactName { get; set; }

        [DataMember]
        public string ContactTitle { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Region { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string Tel { get; set; }

        [DataMember]
        public string Fax { get; set; }

        [DataMember]
        public string Website { get; set; }
    }
}
