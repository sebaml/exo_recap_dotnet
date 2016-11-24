using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class Categories
    {
        [Key]
        public long CategoryID { get; set; }

        [StringLength(2147483647)]
        public string CategoryName { get; set; }

        [StringLength(2147483647)]
        public string Description { get; set; }

        [MaxLength(2147483647)]
        public byte[] Picture { get; set; }
    }
}