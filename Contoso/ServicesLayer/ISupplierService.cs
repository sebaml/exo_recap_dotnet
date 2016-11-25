using System.Collections.Generic;
using System.ServiceModel;
using DataModel;

namespace ServicesLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISupplierService" in both code and config file together.
    [ServiceContract]
    public interface ISupplierService
    {
        [OperationContract]
        List<SupplierType> GetSupplierByName(string name);

        [OperationContract]
        List<SupplierType> GetSuppliers();

        [OperationContract]
        SupplierDetail GetSupplierDetail(long id);

        [OperationContract]
        bool DelSupplier(long id);

        [OperationContract]
        bool UpdateSupplier(SupplierDetail sd);

        [OperationContract]
        bool AddSupplier(SupplierDetail sd);
    }
}