using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    [Table("CustomerCustomerDemo")]
    public class CustomerCustomerDemo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2147483647)]
        public string CustomerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2147483647)]
        public string CustomerTypeID { get; set; }
    }
}