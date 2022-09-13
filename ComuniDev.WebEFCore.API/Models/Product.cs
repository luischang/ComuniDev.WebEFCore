using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComuniDev.WebEFCore.API.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [Column(TypeName ="int")]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

    }
}
