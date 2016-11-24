using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class Territories
    {
        [Key]
        [StringLength(2147483647)]
        public string TerritoryID { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string TerritoryDescription { get; set; }

        public long RegionID { get; set; }
    }
}