using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class CustomerDemographics
    {
        [Key]
        [StringLength(2147483647)]
        public string CustomerTypeID { get; set; }

        [StringLength(2147483647)]
        public string CustomerDesc { get; set; }
    }
}