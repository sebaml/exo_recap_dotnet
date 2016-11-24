using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace DataRequest
{
    public class SupplierRequests
    {
        public static List<SupplierType> ReqGetSupplierByName(string name)
        {
            using (var context = new ContosoContext())
            {
                var suppliers = context.Suppliers.Where(s => s.CompanyName == name).ToList();
                List<SupplierType> toReturn =  suppliers.Select(s => new SupplierType
                {
                    CompanyName = s.CompanyName, ContactName = s.ContactName, ContactTitle = s.ContactTitle, Country = s.Country
                }).ToList();

                return toReturn;
            }
        }
    }
}
