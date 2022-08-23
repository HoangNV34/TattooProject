using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BussinessRules
{
    [Table("OrderDetails", Schema = "dbo")]
    public class OrderDetail
    {
        public int Quantity { get; set; }
        public int TotalOrder { get; set; }
        public double Gross { get; set; }
        public double Net { get; set; }
        public int SalesOff { get; set; }

        

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductId { get;set; }
        public Product Product { get; set; }
       
    }
}
