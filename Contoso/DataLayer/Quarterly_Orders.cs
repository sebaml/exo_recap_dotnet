using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    [Table("Quarterly Orders")]
    public class Quarterly_Orders
    {
        [Key]
        [StringLength(2147483647)]
        public string CustomerID { get; set; }

        [StringLength(2147483647)]
        public string CompanyName { get; set; }

        [StringLength(2147483647)]
        public string City { get; set; }

        [StringLength(2147483647)]
        public string Country { get; set; }
    }
}