using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Core.Entities
{
    public class ShoppingCartItem : BaseEntity
    {
        public int Quantity { get; set; }
        public decimal Price { get; private set; }
        public int ProductId { get; private set; }
        public virtual Product Product { get; set; }

        public ShoppingCartItem(int productId,int quantity,decimal price)
        {
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }

        public void AddQuantity(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveQuantity(int quantity)
        {
            Quantity -= quantity;
        }
    }
}
