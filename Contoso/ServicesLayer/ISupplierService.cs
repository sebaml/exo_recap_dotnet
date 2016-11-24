using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DataModel;
using DataRequest;

namespace ServicesLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISupplierService" in both code and config file together.
    [ServiceContract]
    public interface ISupplierService
    {
        [OperationContract]
        List<SupplierType> GetSupplierByName(string name);

        [OperationContract]
        SupplierDetail GetSupplierDetail(long id);

        [OperationContract]
        bool DelSupplier(long id);

        [OperationContract]
        bool UpdateSupplier(SupplierDetail sd);
    }

}
