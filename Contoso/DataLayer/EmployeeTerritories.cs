using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    public class EmployeeTerritories
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EmployeeID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2147483647)]
        public string TerritoryID { get; set; }
    }
}