using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    [Table("Alphabetical list of products")]
    public class Alphabetical_list_of_products
    {
        [Key]
        [Column(Order = 0)]
        public long ProductID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2147483647)]
        public string ProductName { get; set; }

        public long? SupplierID { get; set; }

        public long? CategoryID { get; set; }

        [StringLength(2147483647)]
        public string QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public long? UnitsInStock { get; set; }

        public long? UnitsOnOrder { get; set; }

        public long? ReorderLevel { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2147483647)]
        public string Discontinued { get; set; }

        [StringLength(2147483647)]
        public string CategoryName { get; set; }
    }
}