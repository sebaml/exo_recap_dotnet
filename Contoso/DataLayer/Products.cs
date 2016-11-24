using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class Products
    {
        [Key]
        public long ProductID { get; set; }

        [Required]
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

        [Required]
        [StringLength(2147483647)]
        public string Discontinued { get; set; }
    }
}