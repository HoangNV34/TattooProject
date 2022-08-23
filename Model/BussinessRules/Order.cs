using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BussinessRules
{
    [Table("Orders",Schema ="dbo")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public DateTime DateStart { get; set; }

        [Required]
        public DateTime EstimatedDeliveryTime { get; set; }

        [Required]
        [StringLength(100,ErrorMessage ="Please input max length {1} to {0}",ErrorMessageResourceType = typeof(string),MinimumLength = 10)]
        public string AddressDelivery { get; set; } = string.Empty;

        [Required]
        [StringLength(50, ErrorMessage = "Please input max length {1} to {0}", ErrorMessageResourceType = typeof(string), MinimumLength = 1)]
        public string Status { get; set; } = string.Empty;

        [Required]
        public DateTime CreateAt { get; set; }
        [Required]
        public DateTime UpdateAt { get; set; }
        [Required]
        public DateTime DeleteAt { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
