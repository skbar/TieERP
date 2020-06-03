using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TieERP.Models
{
    public class Product : IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        //public int WarehouseId { get; set; }
        //public virtual ICollection<Review> Review{ get; set; }
    }
}