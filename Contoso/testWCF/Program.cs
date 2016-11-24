using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataRequest;

namespace testWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var sf = new ServiceReference1.SupplierServiceClient();
            var temp = sf.GetSupplierByName("Test");
            foreach (var t in temp)
                Console.WriteLine("t");*/

            Console.WriteLine(SupplierRequests.ReqGetSupplierByName("test"));
            
        }
    }
}
