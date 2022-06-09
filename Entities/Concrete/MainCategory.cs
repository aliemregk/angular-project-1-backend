using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MainCategory : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhotoId { get; set; }
    }

    public class Order : IEntity
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsDelivered { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}
