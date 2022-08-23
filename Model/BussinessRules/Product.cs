using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BussinessRules
{
    [Table("Products",Schema ="dbo")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100,ErrorMessage ="Please input value {1} to {0}",MinimumLength = 0)]
        public string ProductName { get; set; } = String.Empty;

        [MaxLength(2000)]
        public string Description { get; set; } = string.Empty;

        public float Prices { get; set; }

        [Required]
        [StringLength(500,ErrorMessage ="Please input value {1} to {0}", MinimumLength = 0)]
        public string Image { get; set; } = string.Empty;

        [Required]
        public DateTime CreateAt { get; set; }
        [Required]
        public DateTime UpdateAt { get; set; }
        [Required]
        public DateTime DeleteAt { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
