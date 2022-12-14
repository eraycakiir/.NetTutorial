using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int OrderProductId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        [ForeignKey("OrderProductId")]
        public OrderProduct OrderProducts { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
