
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiDemo2.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        public int p_id { get; set; }
        [Required]
        public string?  p_name { get; set; }
        [Required]
        public string? company { get; set; }
        [Required]
        public int price { get; set; }


    }
}
