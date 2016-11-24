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

        public SupplierDetail GetSupplierDetail(long id)
        {
            return SupplierRequests.ReqGetSupplierDetail(id);
        }

        public bool DelSupplier(long id)
        {
            return SupplierRequests.ReqDelSupplier(id);
        }

        public bool UpdateSupplier(SupplierDetail sd)
        {
            return SupplierRequests.ReqUpdateSupplier(sd);
        }
    }
}