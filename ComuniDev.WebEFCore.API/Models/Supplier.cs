using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComuniDev.WebEFCore.API.Models
{
    [Table("Supplier")]
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Country { get; set; }


        public virtual ICollection<Product>? Products { get; set; }

    }
}
