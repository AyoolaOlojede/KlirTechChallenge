
using Klir.TechChallenge.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Core.Entities
{
    public class ShoppingCart : BaseEntity, IAggregateRoot
    {
        public  List<ShoppingCartItem> ShoppingCartItems => new List<ShoppingCartItem>();
        public ShoppingCart()
        {

        }

        public void AddCartItem(int productId,decimal price,int quantity= 1)
        {
            if (!ShoppingCartItems.Any(i => i.ProductId == productId))
            {
                ShoppingCartItems.Add(new ShoppingCartItem(productId, quantity, price));
                return;
            }
            var existingItem = ShoppingCartItems.FirstOrDefault(i => i.ProductId == productId);
            existingItem.AddQuantity(quantity);
        }

        public void RemoveCartItem()
        {

        }
    }
}
