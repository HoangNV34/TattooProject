using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BussinessRules
{
    [Table("Category",Schema ="dbo")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(100,ErrorMessage ="Please input value {1} to {0}",MinimumLength = 1)]
        public string CategoryName { get; set; } = string.Empty;

        [MaxLength(2000)]
        public string Description { get; set; } = string.Empty;

        public ICollection<Product> Products { get; set; }
    }
}
