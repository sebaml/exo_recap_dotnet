using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    public class Regions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long RegionID { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string RegionDescription { get; set; }
    }
}