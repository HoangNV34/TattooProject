using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Model.BussinessRules
{
    [Table("Customers", Schema ="dbo")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage ="Please input value")]
        public string UserName { get; set; } = String.Empty;

        [Required(ErrorMessage = "Please input value {1}")]
        public string Password { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
        public string FirstName { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Phone]
        public string Phone { get; set; } = string.Empty;
        
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Address { get; set; } = string.Empty;


        [Required]
        public DateTime CreateAt { get; set; }
        [Required]
        public DateTime UpdateAt { get; set; }
        [Required]
        public DateTime DeleteAt { get; set; }

        public ICollection<Order> Orders { get; set;}
    }
}
