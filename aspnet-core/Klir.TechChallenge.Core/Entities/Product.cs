using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? PromotionId { get; set; }
        public virtual Promotion Promotion { get; set; }

        public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }

        public Product()
        {
            ShoppingCartItems = new List<ShoppingCartItem>();
        }
    }
}
