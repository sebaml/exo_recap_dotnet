using System.Collections.Generic;
using DataModel;
using DataRequest;

namespace ServicesLayer
{
    public class SupplierService : ISupplierService
    {
        public List<SupplierType> GetSupplierByName(string name)
        {
            return SupplierRequests.ReqGetSupplierByName(name);
        }

        public List<SupplierType> GetSuppliers()
        {
            return SupplierRequests.ReqGetSuppliers();
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

        public bool AddSupplier(SupplierDetail sd)
        {
            return SupplierRequests.ReqAddSupplier(sd);
        }
    }
}