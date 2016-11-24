using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class Shippers
    {
        [Key]
        public long ShipperID { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string CompanyName { get; set; }

        [StringLength(2147483647)]
        public string Phone { get; set; }
    }
}