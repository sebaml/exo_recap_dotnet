using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    public class Suppliers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SupplierID { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string CompanyName { get; set; }

        [StringLength(2147483647)]
        public string ContactName { get; set; }

        [StringLength(2147483647)]
        public string ContactTitle { get; set; }

        [StringLength(2147483647)]
        public string Address { get; set; }

        [StringLength(2147483647)]
        public string City { get; set; }

        [StringLength(2147483647)]
        public string Region { get; set; }

        [StringLength(2147483647)]
        public string PostalCode { get; set; }

        [StringLength(2147483647)]
        public string Country { get; set; }

        [StringLength(2147483647)]
        public string Phone { get; set; }

        [StringLength(2147483647)]
        public string Fax { get; set; }

        [StringLength(2147483647)]
        public string HomePage { get; set; }
    }
}