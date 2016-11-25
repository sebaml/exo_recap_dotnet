using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contoso.ServiceReference1;
using Contoso.ServiceReference2;
using Contoso.ServiceReference3;

namespace Contoso.Models
{
    public class ProductDetailModel : ProductDetail
    {
        public List<SupplierDetail> Suppliers { get; set; }
        public List<CategoryDetail> Categories { get; set; }
  
    }
}