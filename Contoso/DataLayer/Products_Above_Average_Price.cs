using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    [Table("Products Above Average Price")]
    public class Products_Above_Average_Price
    {
        [Key]
        [StringLength(2147483647)]
        public string ProductName { get; set; }

        public decimal? UnitPrice { get; set; }
    }
}