using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    [DataContract]
    public class CategoryDetail
    {
        [DataMember]
        public long CategoryId { get; set; }

        [DataMember]
        public string CategoryName { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public byte[] Picture { get; set; }
    }
}
