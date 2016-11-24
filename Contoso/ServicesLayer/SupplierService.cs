using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataRequest;


namespace ServicesLayer
{
    public class SupplierService : ISupplierService
    {


        public List<SupplierType> GetSupplierByName(string name)
        {
            return SupplierRequests.ReqGetSupplierByName(name);
        }
    }
}