using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contoso.ServiceReference1;

namespace Contoso.Models
{
    public class SupplierTypeModel: ServiceReference1.SupplierType
    {

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }


        public string Tel { get; set; }

        public string Fax { get; set; }

        public string Website { get; set; }
    }
}